using System;
using System.Windows.Forms;
using NetFwTypeLib;

namespace GTA_Utils {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
		

	}

	class FirewallManager {
		INetFwRule firewallRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
		INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
		public FirewallManager(string name) {
			firewallRule.Name = name;
		}
		public bool RuleExists() {
			//GC.Collect();
			foreach (INetFwRule rule in firewallPolicy.Rules) {
				if (rule.Name.IndexOf(firewallRule.Name) != -1) {
					return true;
				}
			}
			return false;
		}
	}
	class ProcessLauncher {
		System.Diagnostics.Process process = new System.Diagnostics.Process();
		System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
		public ProcessLauncher (string filename) {
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = filename;
			process.StartInfo = startInfo;
		}
		public void runProcess(string arguments) {
			startInfo.Arguments = arguments;
			process.Start();
			process.WaitForExit();
		}
	}

	class HotKey {
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		enum KeyModifier {
			None = 0,
			Alt = 1,
			Control = 2,
			Shift = 4,
			WinKey = 8
		}

	}
	public static class CONSTANTS {
		public static readonly string RULENAME = "GTA V Block";
		public static readonly string ENABLE_RULE = "/C netsh advfirewall firewall add rule name=\"" + RULENAME + "\" protocol=UDP dir=out remoteport=6672,61455,61457,61456,61458 action=block enable=yes";
		public static readonly string ENABLE_RULE_IN_ALL = "/C netsh advfirewall firewall add rule name=\"" + RULENAME + "\" protocol=UDP dir=in action=block enable=yes";
		public static readonly string ENABLE_RULE_OUT_ALL = "/C netsh advfirewall firewall add rule name=\"" + RULENAME + "\" protocol=UDP dir=out action=block enable=yes";
		public static readonly string DISABLE_RULE = "/C netsh advfirewall firewall delete rule name=\"" + RULENAME + "\"";

	}
}


