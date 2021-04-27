using System;
using System.Windows.Forms;

namespace GTA_Utils {
	public partial class Form2 : Form {
		string input = "";
        public Form2() {
			InitializeComponent();
		}

		private void captureKeyButton_Click(object sender, EventArgs e) {
            
		}

		private void inputBox_KeyDown(object sender, KeyEventArgs e) {
            KeysConverter kconv = new KeysConverter();
            foreach (Keys k in Enum.GetValues(typeof(Keys))) {
                if (e.KeyCode == k) {
                    input = e.KeyCode.ToString();
                }
            }
        }

		private void Form2_FormClosed(object sender, FormClosedEventArgs e) {
            
        }

		private void inputBox_TextChanged(object sender, EventArgs e) {

		}

		private void Form2_Load(object sender, EventArgs e) {
			modifierCombo.SelectedItem = "None";
			string ruleModifier = "RuleModifier", ruleButton = "RuleBind"; ;
			string suspendModifier = "SuspendModifier", suspendButton = "SuspendBind";
			string blockModifier = "BlockModifier", blockButton = "BlockBind"; ;


			ruleBox.Text = getBindBoxText(ruleButton, ruleModifier);
			suspendBox.Text = getBindBoxText(suspendButton, suspendModifier);
			blockAllBox.Text = getBindBoxText(blockButton, blockModifier);
		}
		public string getModifierFromSettings(string s) {
			if (Properties.Settings.Default[s] == null || Properties.Settings.Default[s].Equals("None")) {
				return null;
			} else {
				return Properties.Settings.Default[s].ToString();
			}
		}
		public string getKeyFromSettings(string s) {
			if (Properties.Settings.Default[s] == null || Properties.Settings.Default[s].Equals("")) {
				return null;
			} else {
				return Properties.Settings.Default[s].ToString();
			}
		}

		private void inputBox_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e) {
			inputBox.Text = input;
		}

		private void ruleButton_Click(object sender, EventArgs e) {
			string bindSetting = "RuleBind", modifierSetting = "RuleModifier";
			modifySettings(bindSetting, modifierSetting);
			ruleBox.Text = getBindBoxText(bindSetting, modifierSetting);
		}

		private void suspendButton_Click(object sender, EventArgs e) {
			string bindSetting = "SuspendBind", modifierSetting = "SuspendModifier";
			modifySettings(bindSetting, modifierSetting);
			suspendBox.Text = getBindBoxText(bindSetting, modifierSetting);
		}

		private void blockAllBox_TextChanged(object sender, EventArgs e) {

		}

		private void blockAllButton_Click(object sender, EventArgs e) {
			string bindSetting = "BlockBind", modifierSetting = "BlockModifier";
			modifySettings(bindSetting, modifierSetting);
			blockAllBox.Text = getBindBoxText(bindSetting, modifierSetting);
		}

		private void modifySettings(string bindSetting, string modifierSetting) {
			if (!inputBox.Text.Equals("")) {
				Properties.Settings.Default[bindSetting] = inputBox.Text;
				Properties.Settings.Default[modifierSetting] = modifierCombo.SelectedItem;
				Properties.Settings.Default.Save();
			} else {
				Properties.Settings.Default[bindSetting] = null;
				Properties.Settings.Default[modifierSetting] = null;
				Properties.Settings.Default.Save();
			}
		}
		private string getBindBoxText(string bindSetting, string modifierSetting) {
			string bind = getKeyFromSettings(bindSetting), modifier = getModifierFromSettings(modifierSetting);
			return modifier == null ? bind : modifier + " " + bind;
		}
	}   

}

