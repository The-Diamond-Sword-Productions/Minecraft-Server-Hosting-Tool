using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Server_Hosting_Tool
{
    class PaperVersions
    {
        public string URL;
        public string Version;

        public PaperVersions(string version, string url)
        {
            Version = version;
            URL = url;
        }

        public static PaperVersions oneSixteenFive = new PaperVersions("1.16.5", "https://papermc.io/api/v2/projects/paper/versions/1.16.5/builds/626/downloads/paper-1.16.5-626.jar");
        public static PaperVersions oneSixteenFour = new PaperVersions("1.16.4", "https://papermc.io/api/v2/projects/paper/versions/1.16.4/builds/416/downloads/paper-1.16.4-416.jar");
        public static PaperVersions oneSixteenThree = new PaperVersions("1.16.3", "https://papermc.io/api/v2/projects/paper/versions/1.16.3/builds/253/downloads/paper-1.16.3-253.jar");
        public static PaperVersions oneSixteenTwo = new PaperVersions("1.16.2", "https://papermc.io/api/v2/projects/paper/versions/1.16.2/builds/189/downloads/paper-1.16.2-189.jar");
        public static PaperVersions oneSixteenOne = new PaperVersions("1.16.1", "https://papermc.io/api/v2/projects/paper/versions/1.16.1/builds/138/downloads/paper-1.16.1-138.jar");

        public static PaperVersions oneFifteenTwo = new PaperVersions("1.15.2", "https://papermc.io/api/v2/projects/paper/versions/1.15.2/builds/391/downloads/paper-1.15.2-391.jar");

        public static PaperVersions oneFourteenFour = new PaperVersions("1.14.4", "https://papermc.io/api/v2/projects/paper/versions/1.14.4/builds/243/downloads/paper-1.14.4-243.jar");

        public static PaperVersions oneThirteenTwo = new PaperVersions("1.13.2", "https://papermc.io/api/v2/projects/paper/versions/1.13.2/builds/655/downloads/paper-1.13.2-655.jar");

        public static PaperVersions oneTwelveTwo = new PaperVersions("1.12.2", "https://papermc.io/api/v2/projects/paper/versions/1.12.2/builds/1618/downloads/paper-1.12.2-1618.jar");

        public static PaperVersions oneElevenTwo = new PaperVersions("1.11.2", "https://papermc.io/api/v2/projects/paper/versions/1.11.2/builds/1104/downloads/paper-1.11.2-1104.jar");

        public static PaperVersions oneTenTwo = new PaperVersions("1.10.2", "https://papermc.io/api/v2/projects/paper/versions/1.10.2/builds/916/downloads/paper-1.10.2-916.jar");

        public static PaperVersions oneNineFour = new PaperVersions("1.9.4", "https://papermc.io/api/v2/projects/paper/versions/1.9.4/builds/773/downloads/paper-1.9.4-773.jar");

        public static PaperVersions oneEightEight = new PaperVersions("1.8.8", "https://papermc.io/api/v2/projects/paper/versions/1.8.8/builds/443/downloads/paper-1.8.8-443.jar");
    }
}
