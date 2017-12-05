using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qiniu_upload_csharp
{
	class HotKey
	{
		[DllImport("user32.dll")]
		public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint control, Keys vk);
		[DllImport("user32.dll")]
		public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		private IntPtr hWnd;

		public enum ControlKey
		{
			none = 0,
			MOD_ALT = 1,
			MOD_CONTROL = 2,
			MOD_SHIFT = 4,
			MOD_WIN = 8
		}

		public HotKey(IntPtr InhWnd)
		{
			hWnd = InhWnd;
		}

		public void RegHotKey()
		{
			
			UnregisterHotKey(hWnd, 233);
			RegisterHotKey(hWnd, 233, ProgramConfig.OutConfig.HKStruct.ControlKey1| ProgramConfig.OutConfig.HKStruct.ControlKey2, ProgramConfig.OutConfig.HKStruct.KeyCode);
		}

		public void UnRegHotKey()
		{
			UnregisterHotKey(hWnd, 233);
		}
	}
}
