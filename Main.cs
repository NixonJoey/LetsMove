using AppKit;

namespace MoveTester
{
	static class MainClass
	{
		static void Main(string[] args)
		{
			NSApplication.Init();
			LetsMove.LetsMove.PFMoveToApplicationsFolderIfNecessary ();
			NSApplication.Main(args);
		}
	}
}
