using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitProxy {
	//! Sample.HTTProxyからロギングを可能にするためのdelegate
	public delegate void AddTextLog(string str);
	public partial class Form1 : Form {
		/** クラス変数
		 */
		//! Sample.HTTProxyからロギングを可能にするためのdelegate
		public static AddTextLog addTextLog;
		//! 使用するプロキシサーバ
		Sample.HTTProxy proxy;
		//! ダミーとなるHTTPサーバ
		HttpListener listener1, listener2;
		//! サーバ群がONになっているとtrue
		bool on_flg = false;

		/** クラスメソッド
		 */
		//! コンストラクタ
		public Form1() {
			InitializeComponent();
			//! ロギング用にdelegateを登録する
			addTextLog = new AddTextLog(AddText);
		}
		//! データをLoggingTextBoxにロギング
		public void AddText(string text) {
			if(LoggingTextBox.InvokeRequired) {
				Invoke(new AddTextLog(AddText), new object[] { text });
				return;
			}
			LoggingTextBox.AppendText(text + "\n");
		}
		//! チェックボックス関係
		private void OutBranch1CheckBox_CheckedChanged(object sender, EventArgs e) {
			var flg = OutBranch1CheckBox.Checked;
			OutPort1TextBox.Enabled = flg;
			DummyPort1CheckBox.Enabled = flg;
		}
		private void OutBranch2CheckBox_CheckedChanged(object sender, EventArgs e) {
			var flg = OutBranch2CheckBox.Checked;
			OutPort2TextBox.Enabled = flg;
			DummyPort2CheckBox.Enabled = flg;
		}
		private void DummyPort1CheckBox_CheckedChanged(object sender, EventArgs e) {
			var flg = DummyPort1CheckBox.Checked;
			DummyPort1TextBox.Enabled = flg;
		}
		private void DummyPort2CheckBox_CheckedChanged(object sender, EventArgs e) {
			var flg = DummyPort2CheckBox.Checked;
			DummyPort2TextBox.Enabled = flg;
		}
		//! サーバ群をONにする
		private void StartButton_Click(object sender, EventArgs e) {
			if(on_flg)
				return;
			//! ログをクリアする
			LoggingTextBox.Text = "";
			LoggingTextBox.Refresh();

			//! プロキシサーバを起動させる
			proxy = new Sample.HTTProxy();
			{
				//! 入力にプロキシを使用する場合の処理
				if(InProxyCheckBox.Checked) {
					proxy.SetUpProxy(InHostTextBox.Text, int.Parse(InPortTextBox.Text));
				}
			}
			{
				//! 出力の状態によって初期化方法を変える
				var port0 = int.Parse(OutPort0TextBox.Text);
				var port1 = int.Parse(OutPort1TextBox.Text);
				var port2 = int.Parse(OutPort2TextBox.Text);
				var branch1Flg = (OutBranch1CheckBox.Enabled && OutBranch1CheckBox.Checked);
				var branch2Flg = (OutBranch2CheckBox.Enabled && OutBranch2CheckBox.Checked);
				if(branch1Flg) {
					if(branch2Flg) {
						proxy.Start(port0, port1, port2);
					} else {
						proxy.Start(port0, port1);
					}
				} else {
					if(branch2Flg) {
						proxy.Start(port0, port2);
					} else {
						proxy.Start(port0);
					}
				}
			}
			{
				//! ダミーとなるサーバも起動させる
				var dummyPort1 = int.Parse(DummyPort1TextBox.Text);
				var dummyPort2 = int.Parse(DummyPort2TextBox.Text);
				var dummy1Flg = (DummyPort1CheckBox.Enabled && DummyPort1CheckBox.Checked);
				var dummy2Flg = (DummyPort2CheckBox.Enabled && DummyPort2CheckBox.Checked);
				if(dummy1Flg) {
					listener1 = new HttpListener();
					string prefix = string.Format("http://{0}:{1}/", IPAddress.Loopback, dummyPort1);
					listener1.Prefixes.Add(prefix);
					try {
						listener1.Start();
						AddText(string.Format("DummyPort1({0}) : Started.", dummyPort1));
					} catch(HttpListenerException ex) {
						AddText(string.Format("Exception at starting HttpListener\n{0}", ex.ToString()));
					}
				}
				if(dummy2Flg) {
					listener2 = new HttpListener();
					string prefix = string.Format("http://{0}:{1}/", IPAddress.Loopback, dummyPort2);
					listener2.Prefixes.Add(prefix);
					try {
						listener2.Start();
						AddText(string.Format("DummyPort2({0}) : Started.", dummyPort2));
					} catch(HttpListenerException ex) {
						AddText(string.Format("Exception at starting HttpListener\n{0}", ex.ToString()));
					}
				}
			}
			{
				//! on_flgおよびボタンの状態を変更する
				on_flg = true;
				StartButton.Enabled = false;
				StopButton.Enabled = true;
			}
		}
		//! サーバ群をOFFにする
		private void StopButton_Click(object sender, EventArgs e) {
			if(!on_flg)
				return;
			//! プロキシサーバを停止させる
			proxy.Stop();
			//! ダミーサーバも停止させる
			if(listener1 != null) {
				if(listener1.IsListening)
					listener1.Stop();
				listener1.Close();
				listener1 = null;
			}
			if(listener2 != null) {
				if(listener2.IsListening)
					listener2.Stop();
				listener2.Close();
				listener2 = null;
			}
			//! on_flgおよびボタンの状態を変更する
			on_flg = false;
			StartButton.Enabled = true;
			StopButton.Enabled = false;
		}
	}
}
