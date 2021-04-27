namespace GTA_Utils {
	partial class Form2 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.inputBox = new System.Windows.Forms.TextBox();
			this.suspendButton = new System.Windows.Forms.Button();
			this.ruleButton = new System.Windows.Forms.Button();
			this.modifierCombo = new System.Windows.Forms.ComboBox();
			this.ruleBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.suspendBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.blockAllBox = new System.Windows.Forms.TextBox();
			this.blockAllButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// inputBox
			// 
			this.inputBox.Location = new System.Drawing.Point(12, 37);
			this.inputBox.Name = "inputBox";
			this.inputBox.Size = new System.Drawing.Size(117, 20);
			this.inputBox.TabIndex = 1;
			this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
			this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
			this.inputBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyUp);
			// 
			// suspendButton
			// 
			this.suspendButton.Location = new System.Drawing.Point(12, 92);
			this.suspendButton.Name = "suspendButton";
			this.suspendButton.Size = new System.Drawing.Size(117, 23);
			this.suspendButton.TabIndex = 2;
			this.suspendButton.Text = "Save As Suspend";
			this.suspendButton.UseVisualStyleBackColor = true;
			this.suspendButton.Click += new System.EventHandler(this.suspendButton_Click);
			// 
			// ruleButton
			// 
			this.ruleButton.Location = new System.Drawing.Point(12, 63);
			this.ruleButton.Name = "ruleButton";
			this.ruleButton.Size = new System.Drawing.Size(117, 23);
			this.ruleButton.TabIndex = 3;
			this.ruleButton.Text = "Save As Toggle Rule";
			this.ruleButton.UseVisualStyleBackColor = true;
			this.ruleButton.Click += new System.EventHandler(this.ruleButton_Click);
			// 
			// modifierCombo
			// 
			this.modifierCombo.FormattingEnabled = true;
			this.modifierCombo.Items.AddRange(new object[] {
            "Control",
            "Shift",
            "Alt",
            "None"});
			this.modifierCombo.Location = new System.Drawing.Point(12, 10);
			this.modifierCombo.Name = "modifierCombo";
			this.modifierCombo.Size = new System.Drawing.Size(117, 21);
			this.modifierCombo.TabIndex = 4;
			// 
			// ruleBox
			// 
			this.ruleBox.Location = new System.Drawing.Point(190, 10);
			this.ruleBox.Name = "ruleBox";
			this.ruleBox.ReadOnly = true;
			this.ruleBox.Size = new System.Drawing.Size(117, 20);
			this.ruleBox.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(155, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Rule";
			// 
			// suspendBox
			// 
			this.suspendBox.Location = new System.Drawing.Point(190, 36);
			this.suspendBox.Name = "suspendBox";
			this.suspendBox.ReadOnly = true;
			this.suspendBox.Size = new System.Drawing.Size(117, 20);
			this.suspendBox.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(135, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Suspend";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(135, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "BlockAll";
			// 
			// blockAllBox
			// 
			this.blockAllBox.Location = new System.Drawing.Point(190, 62);
			this.blockAllBox.Name = "blockAllBox";
			this.blockAllBox.ReadOnly = true;
			this.blockAllBox.Size = new System.Drawing.Size(117, 20);
			this.blockAllBox.TabIndex = 9;
			this.blockAllBox.TextChanged += new System.EventHandler(this.blockAllBox_TextChanged);
			// 
			// blockAllButton
			// 
			this.blockAllButton.Location = new System.Drawing.Point(12, 121);
			this.blockAllButton.Name = "blockAllButton";
			this.blockAllButton.Size = new System.Drawing.Size(117, 23);
			this.blockAllButton.TabIndex = 11;
			this.blockAllButton.Text = "Save As Block All";
			this.blockAllButton.UseVisualStyleBackColor = true;
			this.blockAllButton.Click += new System.EventHandler(this.blockAllButton_Click);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Location = new System.Drawing.Point(135, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(167, 52);
			this.label4.TabIndex = 12;
			this.label4.Text = "You must close this window for changes to take effect";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 149);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.blockAllButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.blockAllBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.suspendBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ruleBox);
			this.Controls.Add(this.modifierCombo);
			this.Controls.Add(this.ruleButton);
			this.Controls.Add(this.suspendButton);
			this.Controls.Add(this.inputBox);
			this.Name = "Form2";
			this.Text = "Keybinds";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox inputBox;
		private System.Windows.Forms.Button suspendButton;
		private System.Windows.Forms.Button ruleButton;
		private System.Windows.Forms.ComboBox modifierCombo;
		private System.Windows.Forms.TextBox ruleBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox suspendBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox blockAllBox;
		private System.Windows.Forms.Button blockAllButton;
		private System.Windows.Forms.Label label4;
	}
}