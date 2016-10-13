using System.Runtime.InteropServices;

namespace LetsMove
{
	static class CFunctions
	{
		[DllImport ("~/LetsMove.framework")]
		static extern void PFMoveToApplicationsFolderIfNecessary ();
	}
}
