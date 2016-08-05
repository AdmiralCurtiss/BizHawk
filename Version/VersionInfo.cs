static class VersionInfo
{
	public const string MAINVERSION = "1.11.4"; // Use numbers only or the new version notification won't work
	public static readonly string RELEASEDATE = "July 05, 2016";
	public static readonly bool DeveloperBuild = false;
	public static readonly string HomePage = "http://tasvideos.org/BizHawk.html";

	public static string GetEmuVersion()
	{
		return DeveloperBuild ? ("GIT " + SubWCRev.GIT_BRANCH + "#" + SubWCRev.GIT_SHORTHASH) : ("Version " + MAINVERSION);
	}
}
