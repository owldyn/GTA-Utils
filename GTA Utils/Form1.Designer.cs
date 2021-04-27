namespace GTA_Utils {
	partial class Form1 {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.ruleButton = new System.Windows.Forms.Button();
			this.exeCheckBox = new System.Windows.Forms.CheckBox();
			this.ruleEnabledLabel = new System.Windows.Forms.Label();
			this.findGTA5Dialogue = new System.Windows.Forms.OpenFileDialog();
			this.GTALocationBox = new System.Windows.Forms.TextBox();
			this.changeLocationButton = new System.Windows.Forms.Button();
			this.suspendButton = new System.Windows.Forms.Button();
			this.pssuspendTimer = new System.Windows.Forms.Timer(this.components);
			this.suspendTimerLabel = new System.Windows.Forms.Label();
			this.unsuspendButton = new System.Windows.Forms.Button();
			this.customSuspendCheck = new System.Windows.Forms.CheckBox();
			this.customSuspendBox = new System.Windows.Forms.TextBox();
			this.wheelBlockButton = new System.Windows.Forms.Button();
			this.keybindShowButton = new System.Windows.Forms.Button();
			this.processWatch = new System.Windows.Forms.Timer(this.components);
			this.portsShowButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ruleButton
			// 
			resources.ApplyResources(this.ruleButton, "ruleButton");
			this.ruleButton.Name = "ruleButton";
			this.ruleButton.UseVisualStyleBackColor = true;
			this.ruleButton.Click += new System.EventHandler(this.ruleButton_Click);
			// 
			// exeCheckBox
			// 
			resources.ApplyResources(this.exeCheckBox, "exeCheckBox");
			this.exeCheckBox.Name = "exeCheckBox";
			this.exeCheckBox.UseVisualStyleBackColor = true;
			this.exeCheckBox.CheckedChanged += new System.EventHandler(this.exeCheckBox_CheckedChanged);
			// 
			// ruleEnabledLabel
			// 
			resources.ApplyResources(this.ruleEnabledLabel, "ruleEnabledLabel");
			this.ruleEnabledLabel.BackColor = System.Drawing.Color.Yellow;
			this.ruleEnabledLabel.Name = "ruleEnabledLabel";
			// 
			// GTALocationBox
			// 
			resources.ApplyResources(this.GTALocationBox, "GTALocationBox");
			this.GTALocationBox.Name = "GTALocationBox";
			this.GTALocationBox.ReadOnly = true;
			// 
			// changeLocationButton
			// 
			resources.ApplyResources(this.changeLocationButton, "changeLocationButton");
			this.changeLocationButton.Name = "changeLocationButton";
			this.changeLocationButton.UseVisualStyleBackColor = true;
			this.changeLocationButton.Click += new System.EventHandler(this.changeLocationButton_Click);
			// 
			// suspendButton
			// 
			resources.ApplyResources(this.suspendButton, "suspendButton");
			this.suspendButton.Name = "suspendButton";
			this.suspendButton.UseVisualStyleBackColor = true;
			this.suspendButton.Click += new System.EventHandler(this.suspendButton_Click);
			// 
			// pssuspendTimer
			// 
			this.pssuspendTimer.Interval = 1000;
			this.pssuspendTimer.Tick += new System.EventHandler(this.pssuspendTimer_Tick);
			// 
			// suspendTimerLabel
			// 
			resources.ApplyResources(this.suspendTimerLabel, "suspendTimerLabel");
			this.suspendTimerLabel.Name = "suspendTimerLabel";
			// 
			// unsuspendButton
			// 
			resources.ApplyResources(this.unsuspendButton, "unsuspendButton");
			this.unsuspendButton.Name = "unsuspendButton";
			this.unsuspendButton.UseVisualStyleBackColor = true;
			this.unsuspendButton.Click += new System.EventHandler(this.unsuspendButton_Click);
			// 
			// customSuspendCheck
			// 
			resources.ApplyResources(this.customSuspendCheck, "customSuspendCheck");
			this.customSuspendCheck.Name = "customSuspendCheck";
			this.customSuspendCheck.UseVisualStyleBackColor = true;
			this.customSuspendCheck.CheckedChanged += new System.EventHandler(this.customSuspendCheck_CheckedChanged);
			// 
			// customSuspendBox
			// 
			resources.ApplyResources(this.customSuspendBox, "customSuspendBox");
			this.customSuspendBox.Name = "customSuspendBox";
			this.customSuspendBox.ReadOnly = true;
			// 
			// wheelBlockButton
			// 
			resources.ApplyResources(this.wheelBlockButton, "wheelBlockButton");
			this.wheelBlockButton.Name = "wheelBlockButton";
			this.wheelBlockButton.UseVisualStyleBackColor = true;
			this.wheelBlockButton.Click += new System.EventHandler(this.wheelBlockButton_Click);
			// 
			// keybindShowButton
			// 
			resources.ApplyResources(this.keybindShowButton, "keybindShowButton");
			this.keybindShowButton.Name = "keybindShowButton";
			this.keybindShowButton.UseVisualStyleBackColor = true;
			this.keybindShowButton.Click += new System.EventHandler(this.keybindShowButton_Click);
			// 
			// processWatch
			// 
			this.processWatch.Enabled = true;
			this.processWatch.Interval = 30000;
			this.processWatch.Tick += new System.EventHandler(this.processWatch_Tick);
			// 
			// portsShowButton
			// 
			resources.ApplyResources(this.portsShowButton, "portsShowButton");
			this.portsShowButton.Name = "portsShowButton";
			this.portsShowButton.UseVisualStyleBackColor = true;
			this.portsShowButton.Click += new System.EventHandler(this.portsShowButton_Click);
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.portsShowButton);
			this.Controls.Add(this.keybindShowButton);
			this.Controls.Add(this.wheelBlockButton);
			this.Controls.Add(this.customSuspendBox);
			this.Controls.Add(this.customSuspendCheck);
			this.Controls.Add(this.unsuspendButton);
			this.Controls.Add(this.suspendTimerLabel);
			this.Controls.Add(this.suspendButton);
			this.Controls.Add(this.changeLocationButton);
			this.Controls.Add(this.GTALocationBox);
			this.Controls.Add(this.ruleEnabledLabel);
			this.Controls.Add(this.exeCheckBox);
			this.Controls.Add(this.ruleButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ruleButton;
		private System.Windows.Forms.CheckBox exeCheckBox;
		private System.Windows.Forms.Label ruleEnabledLabel;
		private System.Windows.Forms.OpenFileDialog findGTA5Dialogue;
		private System.Windows.Forms.TextBox GTALocationBox;
		private System.Windows.Forms.Button changeLocationButton;
		private System.Windows.Forms.Button suspendButton;
		private System.Windows.Forms.Timer pssuspendTimer;
		private System.Windows.Forms.Label suspendTimerLabel;
		private System.Windows.Forms.Button unsuspendButton;
		private System.Windows.Forms.CheckBox customSuspendCheck;
		private System.Windows.Forms.TextBox customSuspendBox;
		private System.Windows.Forms.Button wheelBlockButton;
		private System.Windows.Forms.Button keybindShowButton;
		private System.Windows.Forms.Timer processWatch;
		private System.Windows.Forms.Button portsShowButton;
	}
}

