using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static GTA_Utils.GlobalKeybinds;

namespace GTA_Utils {
	public partial class Form1 : Form {
		private static FirewallManager fwm = new FirewallManager(CONSTANTS.RULENAME);
		private static ProcessLauncher cmdPL = new ProcessLauncher("cmd.exe");
		private static ProcessLauncher suspPL = new ProcessLauncher("pssus.exe");
		private static bool isSuspended = false;
		private GlobalKeybinds.KeyboardHook hookRule;
		private GlobalKeybinds.KeyboardHook hookSuspend;
		private GlobalKeybinds.KeyboardHook hookBlockAll;

		public Form1() {
			InitializeComponent();

		}

		private void ruleButton_Click(object sender, EventArgs e) {
			if (ruleButton.Enabled) {
				toggleBlock();
			}
		}

		private void Form1_Load(object sender, EventArgs e) {
			checkLabel();
			GTALocationBox.Text = (string)Properties.Settings.Default["GTALocation"];
			if (GTALocationBox.Text != "") {
				exeCheckBox.Checked = (bool)Properties.Settings.Default["GTALocationEnabled"];
				wheelBlockButton.Enabled = true;
			}
			newBinds();

		}

		private void exeCheckBox_CheckedChanged(object sender, EventArgs e) {
			if (exeCheckBox.Checked && GTALocationBox.Text == "") {
				changeLocation();
			}
			if (fwm.RuleExists()) {
				toggleBlock();
				toggleBlock();
			}

		}
		private void toggleBlock() {
			disableControls();
			if (fwm.RuleExists()) {
				cmdPL.runProcess(CONSTANTS.DISABLE_RULE);
			} else {
				if (exeCheckBox.Checked) {
					cmdPL.runProcess(CONSTANTS.ENABLE_RULE + " program=\"" + GTALocationBox.Text + "\"");
				} else {
					cmdPL.runProcess(CONSTANTS.ENABLE_RULE);
				}
			}
			checkLabel();
			enableControls();
		}
		private void toggleBlockAll() {
			disableControls();
			if (fwm.RuleExists()) {
				toggleBlock();
				cmdPL.runProcess(CONSTANTS.ENABLE_RULE_IN_ALL + " program=\"" + GTALocationBox.Text + "\"");
				cmdPL.runProcess(CONSTANTS.ENABLE_RULE_OUT_ALL + " program=\"" + GTALocationBox.Text + "\"");
			} else {
				cmdPL.runProcess(CONSTANTS.ENABLE_RULE_IN_ALL + " program=\"" + GTALocationBox.Text + "\"");
				cmdPL.runProcess(CONSTANTS.ENABLE_RULE_OUT_ALL + " program=\"" + GTALocationBox.Text + "\"");
			}
			checkLabel();
			enableControls();
		}
		private void disableControls() {
			ruleButton.Enabled = false;
			exeCheckBox.Enabled = false;
			wheelBlockButton.Enabled = false;
		}
		private void enableControls() {
			ruleButton.Enabled = true;
			exeCheckBox.Enabled = true;
			if (GTALocationBox.Text != "") {
				wheelBlockButton.Enabled = true;
			}
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
			if (isSuspended) {
				reviveGTA();
			}
			Properties.Settings.Default["GTALocationEnabled"] = exeCheckBox.Checked;
			Properties.Settings.Default.Save();
		}

		private void changeLocationButton_Click(object sender, EventArgs e) {
			changeLocation();
		}

		void changeLocation() {
			DialogResult result = findGTA5Dialogue.ShowDialog();
			if (result == DialogResult.OK) {
				GTALocationBox.Text = findGTA5Dialogue.FileName;
				wheelBlockButton.Enabled = true;
				Properties.Settings.Default["GTALocation"] = GTALocationBox.Text;
				Properties.Settings.Default["GTALocationEnabled"] = exeCheckBox.Checked;
				Properties.Settings.Default.Save();
			} else {
				GTALocationBox.Text = "";
				wheelBlockButton.Enabled = false;
				exeCheckBox.Checked = false;
			}
		}

		void checkLabel() {
			try {
				if (fwm.RuleExists()) {
					ruleEnabledLabel.BackColor = Color.LimeGreen;
					ruleEnabledLabel.Text = "Enabled";
					ruleButton.Text = "Disable Rule";
				} else {
					ruleEnabledLabel.BackColor = Color.Yellow;
					ruleEnabledLabel.Text = "Disabled";
					ruleButton.Text = "Enable Rule";
				}
			} catch (Exception) {
				ruleEnabledLabel.BackColor = Color.Red;
				ruleEnabledLabel.Text = "Error";
			}
		}

		public void suspendGTA(int seconds) {
			string fileName = "pssus.exe";
			if (!File.Exists(fileName)) {
				try {
					byte[] fileContents = Properties.Resources.pssus;
					File.WriteAllBytes(fileName, fileContents);
				} catch (Exception e) {
					MessageBox.Show("Error! \n" + e.Message.ToString());
				}
			}
			if (File.Exists(fileName)) {
				suspendTimerLabel.Text = seconds.ToString();
				isSuspended = true;
				this.ControlBox = false;
				suspPL.runProcess("/accepteula gta5.exe");
				pssuspendTimer.Enabled = true;
				try {
					File.Delete(fileName);
				} catch (Exception e) {
					MessageBox.Show("Error! \n" + e.Message.ToString());
				}
			}
		}

		public void reviveGTA() {
			string fileName = "pssus.exe";
			if (!File.Exists(fileName)) {
				try {
					byte[] fileContents = Properties.Resources.pssus;
					File.WriteAllBytes(fileName, fileContents);
				} catch (Exception e) {
					MessageBox.Show("Error! \n" + e.Message.ToString());
				}
			}
			if (File.Exists(fileName)) {
				suspPL.runProcess("-r gta5.exe");
				this.ControlBox = true;
				isSuspended = false;
				pssuspendTimer.Enabled = false;
				suspendTimerLabel.Text = "";
				suspendButton.Enabled = true;
				unsuspendButton.Enabled = false;
				try {
					File.Delete(fileName);
				} catch(Exception e) {
					MessageBox.Show("Error! \n" + e.Message.ToString());
				}
			}
		}

		private void suspendButton_Click(object sender, EventArgs e) {
			if (suspendButton.Enabled) {
				suspendButton.Enabled = false;
				if (customSuspendCheck.Checked) {
					int length;
					if (int.TryParse(customSuspendBox.Text, out length)) {
						suspendGTA(length);
					} else {
						suspendGTA(10);
					}
				} else {
					suspendGTA(10);
				}
				unsuspendButton.Enabled = true;
			}
		}

		private void pssuspendTimer_Tick(object sender, EventArgs e) {
			int tmpcountdown = int.Parse(suspendTimerLabel.Text);
			if (tmpcountdown > 0) {
				tmpcountdown--;
				suspendTimerLabel.Text = tmpcountdown.ToString();
			} else {
				reviveGTA();
			}
		}

		private void unsuspendButton_Click(object sender, EventArgs e) {
			reviveGTA();
		}

		private void customSuspendCheck_CheckedChanged(object sender, EventArgs e) {
			if (customSuspendCheck.Checked) {
				customSuspendBox.ReadOnly = false;
			} else {
				customSuspendBox.ReadOnly = true;
			}
		}

		private void wheelBlockButton_Click(object sender, EventArgs e) {
			if (wheelBlockButton.Enabled) {
				toggleBlockAll();
			}
		}

		private void keybindShowButton_Click(object sender, EventArgs e) {
			disposeBinds();
			Form2 f = new Form2();
			f.ShowDialog();
			newBinds();
			GC.Collect();
		}
		private void disposeBinds() {
			hookRule.Dispose();
			hookSuspend.Dispose();
			hookBlockAll.Dispose();
		}
		private void newBinds() {
			hookRule = new GlobalKeybinds.KeyboardHook();
			hookSuspend = new GlobalKeybinds.KeyboardHook();
			hookBlockAll = new GlobalKeybinds.KeyboardHook();
			hookRule.KeyPressed += new EventHandler<GlobalKeybinds.KeyPressedEventArgs>(ruleButton_Click);
			hookSuspend.KeyPressed += new EventHandler<GlobalKeybinds.KeyPressedEventArgs>(suspendButton_Click);
			hookBlockAll.KeyPressed += new EventHandler<GlobalKeybinds.KeyPressedEventArgs>(wheelBlockButton_Click);
			try {
				setKeybind("RuleBind", "RuleModifier", ref hookRule);
				setKeybind("SuspendBind", "SuspendModifier", ref hookSuspend);
				setKeybind("BlockBind", "BlockModifier", ref hookBlockAll);
			} catch (Exception e) {
				MessageBox.Show("There was an error setting your keybinds. Make sure you're not trying to assign the same key to two functions, or that another program isn't using that key as a global keybind.\n" +
					"Full error: " + e.Message);
			}

		}
		private int getModifierFromSettings(string s) {
			if (Properties.Settings.Default[s] == null || Properties.Settings.Default[s].Equals("None")) {
				return 0;
			} else {
				Dictionary<string, int> modifierReturn = new Dictionary<string, int> {
					{ "Alt", 1 },
					{ "Control", 2 },
					{ "Shift", 4 },
					{ "Win", 8 }
				};
				return modifierReturn[Properties.Settings.Default[s].ToString()];
			}
		}
		private string getKeyFromSettings(string s) {
			if (Properties.Settings.Default[s] == null || Properties.Settings.Default[s].Equals("")) {
				return null;
			} else {
				return Properties.Settings.Default[s].ToString();
			}
		}
		private void setKeybind(string bindSeting, string bindModifier, ref KeyboardHook kh) {
			KeysConverter kconv = new KeysConverter();
			if (getKeyFromSettings(bindSeting) != null) {
				if (getModifierFromSettings(bindModifier) != 0) {
					ModifierKeys modifier = (ModifierKeys)getModifierFromSettings(bindModifier);
					Keys bind = (Keys)kconv.ConvertFromString(getKeyFromSettings(bindSeting));
					kh.RegisterHotKey(modifier, bind);
				} else {
					Keys bind = (Keys)kconv.ConvertFromString(getKeyFromSettings(bindSeting));
					kh.RegisterHotKey(0, bind);
				}
			}
		}
		
		private void processWatch_Tick(object sender, EventArgs e) {

		}

		private void portsShowButton_Click(object sender, EventArgs e) {

		}
	}
}
