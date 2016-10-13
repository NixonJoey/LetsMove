using System.Runtime.InteropServices;

namespace LetsMove
{
	public static class LetsMove
	{
		[DllImport ("LetsMove.framework/LetsMove")]
		public static extern void PFMoveToApplicationsFolderIfNecessary ();
	}
}
