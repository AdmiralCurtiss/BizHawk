static class VersionInfo
{
	public const string MAINVERSION = "1.11.7"; // Use numbers only or the new version notification won't work
	public static readonly string RELEASEDATE = "2016-09-10";
	public static readonly bool DeveloperBuild = false;
	public static readonly string HomePage = "http://tasvideos.org/BizHawk.html";

	private static string _CustomBuildString = null;
	public static string CustomBuildString {
		get {
			if ( _CustomBuildString == null ) {
				try {
					_CustomBuildString = System.IO.File.ReadAllLines( "gamedb/apversion.txt" )[0].Trim();
				} catch ( System.Exception ) {
					_CustomBuildString = "ArcadePit " + RELEASEDATE;
				}
			}

			return _CustomBuildString;
		}
	}

	public static string GetEmuVersion()
	{
		return DeveloperBuild ? ("GIT " + SubWCRev.GIT_BRANCH + "#" + SubWCRev.GIT_SHORTHASH) : ("Version " + MAINVERSION);
	}
}
