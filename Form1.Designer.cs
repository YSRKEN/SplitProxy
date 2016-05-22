namespace SplitProxy {
	partial class Form1 {
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			this.StartButton = new System.Windows.Forms.Button();
			this.StopButton = new System.Windows.Forms.Button();
			this.OutPort0TextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.OutPort1TextBox = new System.Windows.Forms.TextBox();
			this.OutBranch1CheckBox = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.InHostTextBox = new System.Windows.Forms.TextBox();
			this.InProxyCheckBox = new System.Windows.Forms.CheckBox();
			this.LoggingTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.InPortTextBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.DummyPort2TextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.DummyPort1TextBox = new System.Windows.Forms.TextBox();
			this.DummyPort1CheckBox = new System.Windows.Forms.CheckBox();
			this.DummyPort2CheckBox = new System.Windows.Forms.CheckBox();
			this.OutBranch2CheckBox = new System.Windows.Forms.CheckBox();
			this.OutPort2TextBox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// StartButton
			// 
			this.StartButton.Location = new System.Drawing.Point(12, 12);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(75, 23);
			this.StartButton.TabIndex = 0;
			this.StartButton.Text = "Start";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// StopButton
			// 
			this.StopButton.Enabled = false;
			this.StopButton.Location = new System.Drawing.Point(93, 12);
			this.StopButton.Name = "StopButton";
			this.StopButton.Size = new System.Drawing.Size(75, 23);
			this.StopButton.TabIndex = 1;
			this.StopButton.Text = "Stop";
			this.StopButton.UseVisualStyleBackColor = true;
			this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
			// 
			// OutPort0TextBox
			// 
			this.OutPort0TextBox.Location = new System.Drawing.Point(148, 49);
			this.OutPort0TextBox.Name = "OutPort0TextBox";
			this.OutPort0TextBox.Size = new System.Drawing.Size(47, 19);
			this.OutPort0TextBox.TabIndex = 2;
			this.OutPort0TextBox.Text = "10000";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(12, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "○出力";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(87, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "Port0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(201, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 19);
			this.label3.TabIndex = 5;
			this.label3.Text = "Port1";
			// 
			// OutPort1TextBox
			// 
			this.OutPort1TextBox.Enabled = false;
			this.OutPort1TextBox.Location = new System.Drawing.Point(262, 49);
			this.OutPort1TextBox.Name = "OutPort1TextBox";
			this.OutPort1TextBox.Size = new System.Drawing.Size(47, 19);
			this.OutPort1TextBox.TabIndex = 6;
			this.OutPort1TextBox.Text = "9100";
			// 
			// OutBranch1CheckBox
			// 
			this.OutBranch1CheckBox.AutoSize = true;
			this.OutBranch1CheckBox.Location = new System.Drawing.Point(315, 51);
			this.OutBranch1CheckBox.Name = "OutBranch1CheckBox";
			this.OutBranch1CheckBox.Size = new System.Drawing.Size(67, 16);
			this.OutBranch1CheckBox.TabIndex = 7;
			this.OutBranch1CheckBox.Text = "使用する";
			this.OutBranch1CheckBox.UseVisualStyleBackColor = true;
			this.OutBranch1CheckBox.CheckedChanged += new System.EventHandler(this.OutBranch1CheckBox_CheckedChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(12, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 19);
			this.label4.TabIndex = 8;
			this.label4.Text = "○入力";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label5.Location = new System.Drawing.Point(83, 109);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 19);
			this.label5.TabIndex = 9;
			this.label5.Text = "Host";
			// 
			// InHostTextBox
			// 
			this.InHostTextBox.Enabled = false;
			this.InHostTextBox.Location = new System.Drawing.Point(136, 109);
			this.InHostTextBox.Name = "InHostTextBox";
			this.InHostTextBox.Size = new System.Drawing.Size(100, 19);
			this.InHostTextBox.TabIndex = 12;
			this.InHostTextBox.Text = "localhost";
			// 
			// InProxyCheckBox
			// 
			this.InProxyCheckBox.AutoSize = true;
			this.InProxyCheckBox.Location = new System.Drawing.Point(189, 140);
			this.InProxyCheckBox.Name = "InProxyCheckBox";
			this.InProxyCheckBox.Size = new System.Drawing.Size(67, 16);
			this.InProxyCheckBox.TabIndex = 13;
			this.InProxyCheckBox.Text = "使用する";
			this.InProxyCheckBox.UseVisualStyleBackColor = true;
			// 
			// LoggingTextBox
			// 
			this.LoggingTextBox.Location = new System.Drawing.Point(12, 233);
			this.LoggingTextBox.Multiline = true;
			this.LoggingTextBox.Name = "LoggingTextBox";
			this.LoggingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.LoggingTextBox.Size = new System.Drawing.Size(410, 116);
			this.LoggingTextBox.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label6.Location = new System.Drawing.Point(12, 166);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(113, 19);
			this.label6.TabIndex = 15;
			this.label6.Text = "○ダミー入力";
			// 
			// InPortTextBox
			// 
			this.InPortTextBox.Enabled = false;
			this.InPortTextBox.Location = new System.Drawing.Point(136, 138);
			this.InPortTextBox.Name = "InPortTextBox";
			this.InPortTextBox.Size = new System.Drawing.Size(47, 19);
			this.InPortTextBox.TabIndex = 22;
			this.InPortTextBox.Text = "8080";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label9.Location = new System.Drawing.Point(83, 138);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(45, 19);
			this.label9.TabIndex = 23;
			this.label9.Text = "Port";
			// 
			// DummyPort2TextBox
			// 
			this.DummyPort2TextBox.Enabled = false;
			this.DummyPort2TextBox.Location = new System.Drawing.Point(192, 195);
			this.DummyPort2TextBox.Name = "DummyPort2TextBox";
			this.DummyPort2TextBox.Size = new System.Drawing.Size(47, 19);
			this.DummyPort2TextBox.TabIndex = 27;
			this.DummyPort2TextBox.Text = "9400";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label7.Location = new System.Drawing.Point(131, 195);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 19);
			this.label7.TabIndex = 26;
			this.label7.Text = "Port2";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label8.Location = new System.Drawing.Point(131, 166);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 19);
			this.label8.TabIndex = 25;
			this.label8.Text = "Port1";
			// 
			// DummyPort1TextBox
			// 
			this.DummyPort1TextBox.Enabled = false;
			this.DummyPort1TextBox.Location = new System.Drawing.Point(192, 166);
			this.DummyPort1TextBox.Name = "DummyPort1TextBox";
			this.DummyPort1TextBox.Size = new System.Drawing.Size(47, 19);
			this.DummyPort1TextBox.TabIndex = 24;
			this.DummyPort1TextBox.Text = "9300";
			// 
			// DummyPort1CheckBox
			// 
			this.DummyPort1CheckBox.AutoSize = true;
			this.DummyPort1CheckBox.Enabled = false;
			this.DummyPort1CheckBox.Location = new System.Drawing.Point(245, 168);
			this.DummyPort1CheckBox.Name = "DummyPort1CheckBox";
			this.DummyPort1CheckBox.Size = new System.Drawing.Size(67, 16);
			this.DummyPort1CheckBox.TabIndex = 28;
			this.DummyPort1CheckBox.Text = "使用する";
			this.DummyPort1CheckBox.UseVisualStyleBackColor = true;
			this.DummyPort1CheckBox.CheckedChanged += new System.EventHandler(this.DummyPort1CheckBox_CheckedChanged);
			// 
			// DummyPort2CheckBox
			// 
			this.DummyPort2CheckBox.AutoSize = true;
			this.DummyPort2CheckBox.Enabled = false;
			this.DummyPort2CheckBox.Location = new System.Drawing.Point(245, 197);
			this.DummyPort2CheckBox.Name = "DummyPort2CheckBox";
			this.DummyPort2CheckBox.Size = new System.Drawing.Size(67, 16);
			this.DummyPort2CheckBox.TabIndex = 29;
			this.DummyPort2CheckBox.Text = "使用する";
			this.DummyPort2CheckBox.UseVisualStyleBackColor = true;
			this.DummyPort2CheckBox.CheckedChanged += new System.EventHandler(this.DummyPort2CheckBox_CheckedChanged);
			// 
			// OutBranch2CheckBox
			// 
			this.OutBranch2CheckBox.AutoSize = true;
			this.OutBranch2CheckBox.Location = new System.Drawing.Point(315, 79);
			this.OutBranch2CheckBox.Name = "OutBranch2CheckBox";
			this.OutBranch2CheckBox.Size = new System.Drawing.Size(67, 16);
			this.OutBranch2CheckBox.TabIndex = 32;
			this.OutBranch2CheckBox.Text = "使用する";
			this.OutBranch2CheckBox.UseVisualStyleBackColor = true;
			this.OutBranch2CheckBox.CheckedChanged += new System.EventHandler(this.OutBranch2CheckBox_CheckedChanged);
			// 
			// OutPort2TextBox
			// 
			this.OutPort2TextBox.Enabled = false;
			this.OutPort2TextBox.Location = new System.Drawing.Point(262, 77);
			this.OutPort2TextBox.Name = "OutPort2TextBox";
			this.OutPort2TextBox.Size = new System.Drawing.Size(47, 19);
			this.OutPort2TextBox.TabIndex = 31;
			this.OutPort2TextBox.Text = "9200";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label10.Location = new System.Drawing.Point(201, 77);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(55, 19);
			this.label10.TabIndex = 30;
			this.label10.Text = "Port2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 361);
			this.Controls.Add(this.OutBranch2CheckBox);
			this.Controls.Add(this.OutPort2TextBox);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.DummyPort2CheckBox);
			this.Controls.Add(this.DummyPort1CheckBox);
			this.Controls.Add(this.DummyPort2TextBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.DummyPort1TextBox);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.InPortTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.LoggingTextBox);
			this.Controls.Add(this.InProxyCheckBox);
			this.Controls.Add(this.InHostTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.OutBranch1CheckBox);
			this.Controls.Add(this.OutPort1TextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.OutPort0TextBox);
			this.Controls.Add(this.StopButton);
			this.Controls.Add(this.StartButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "分配器";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.Button StopButton;
		private System.Windows.Forms.TextBox OutPort0TextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox OutPort1TextBox;
		private System.Windows.Forms.CheckBox OutBranch1CheckBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox InHostTextBox;
		private System.Windows.Forms.CheckBox InProxyCheckBox;
		private System.Windows.Forms.TextBox LoggingTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox InPortTextBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox DummyPort2TextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox DummyPort1TextBox;
		private System.Windows.Forms.CheckBox DummyPort1CheckBox;
		private System.Windows.Forms.CheckBox DummyPort2CheckBox;
		private System.Windows.Forms.CheckBox OutBranch2CheckBox;
		private System.Windows.Forms.TextBox OutPort2TextBox;
		private System.Windows.Forms.Label label10;
	}
}

