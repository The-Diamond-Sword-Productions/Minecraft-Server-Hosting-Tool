using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Server_Hosting_Tool
{
    class CraftBukkitVersions
    {
        public string URL;
        public string Version;

        public CraftBukkitVersions(string version, string url)
        {
            Version = version;
            URL = url;
        }

        public static CraftBukkitVersions oneSixteenFive = new CraftBukkitVersions("1.16.5", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.16.5.jar");
        public static CraftBukkitVersions oneSixteenFour = new CraftBukkitVersions("1.16.4", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.16.4.jar");
        public static CraftBukkitVersions oneSixteenThree = new CraftBukkitVersions("1.16.3", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.16.3.jar");
        public static CraftBukkitVersions oneSixteenTwo = new CraftBukkitVersions("1.16.2", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.16.2.jar");
        public static CraftBukkitVersions oneSixteenOne = new CraftBukkitVersions("1.16.1", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.16.1.jar");

        public static CraftBukkitVersions oneFifteenTwo = new CraftBukkitVersions("1.15.2", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.15.2.jar");
        public static CraftBukkitVersions oneFifteenOne = new CraftBukkitVersions("1.15.1", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.15.1-R0.1-SNAPSHOT.jar");
        public static CraftBukkitVersions oneFifteen = new CraftBukkitVersions("1.15", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.15-R0.1-SNAPSHOT.jar");

        public static CraftBukkitVersions oneFourteenFour = new CraftBukkitVersions("1.14.4", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.14.4-R0.1-SNAPSHOT.jar");
        public static CraftBukkitVersions oneFourteenThree = new CraftBukkitVersions("1.14.3", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.14.3-R0.1-SNAPSHOT.jar");
        public static CraftBukkitVersions oneFourteenTwo = new CraftBukkitVersions("1.14.2", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.14.2-R0.1-SNAPSHOT.jar");
        public static CraftBukkitVersions oneFourteenOne = new CraftBukkitVersions("1.14.1", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.14.1-R0.1-SNAPSHOT.jar");
        public static CraftBukkitVersions oneFourteen = new CraftBukkitVersions("1.14", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.14-R0.1-SNAPSHOT.jar");

        public static CraftBukkitVersions oneThirteenTwo = new CraftBukkitVersions("1.13.2", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.13.2.jar");
        public static CraftBukkitVersions oneThirteenOne = new CraftBukkitVersions("1.13.1", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.13.1.jar");
        public static CraftBukkitVersions oneThirteen = new CraftBukkitVersions("1.13", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.13.jar");

        public static CraftBukkitVersions oneTwelveTwo = new CraftBukkitVersions("1.12.2", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.12.2.jar");
        public static CraftBukkitVersions oneTwelveOne = new CraftBukkitVersions("1.12.1", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.12.1.jar");
        public static CraftBukkitVersions oneTwelve = new CraftBukkitVersions("1.12", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.12.jar");

        public static CraftBukkitVersions oneElevenTwo = new CraftBukkitVersions("1.11.2", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.11.2.jar");
        public static CraftBukkitVersions oneElevenOne = new CraftBukkitVersions("1.11.1", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.11.1.jar");
        public static CraftBukkitVersions oneEleven = new CraftBukkitVersions("1.11", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.11.jar");

        public static CraftBukkitVersions oneTenTwo = new CraftBukkitVersions("1.10.2", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.10.2-R0.1-SNAPSHOT-latest.jar");
        public static CraftBukkitVersions oneTen = new CraftBukkitVersions("1.10", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.10-R0.1-SNAPSHOT-latest.jar");

        public static CraftBukkitVersions oneNineFour = new CraftBukkitVersions("1.9.4", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.9.4-R0.1-SNAPSHOT-latest.jar");
        public static CraftBukkitVersions oneNineTwo = new CraftBukkitVersions("1.9.2", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.9.2-R0.1-SNAPSHOT-latest.jar");
        public static CraftBukkitVersions oneNine = new CraftBukkitVersions("1.9", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.9-R0.1-SNAPSHOT-latest.jar");

        public static CraftBukkitVersions oneEightEight = new CraftBukkitVersions("1.8.8", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.8.8-R0.1-SNAPSHOT-latest.jar");
        public static CraftBukkitVersions oneEightSeven = new CraftBukkitVersions("1.8.7", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.8.7-R0.1-SNAPSHOT-latest.jar");
        public static CraftBukkitVersions oneEightSix = new CraftBukkitVersions("1.8.6", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.8.6-R0.1-SNAPSHOT-latest.jar");
        public static CraftBukkitVersions oneEightFive = new CraftBukkitVersions("1.8.5", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.8.5-R0.1-SNAPSHOT-latest.jar");
        public static CraftBukkitVersions oneEightFour = new CraftBukkitVersions("1.8.4", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.8.4-R0.1-SNAPSHOT-latest.jar");
        public static CraftBukkitVersions oneEightThree = new CraftBukkitVersions("1.8.3", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.8.3-R0.1-SNAPSHOT-latest.jar");
        public static CraftBukkitVersions oneEight = new CraftBukkitVersions("1.8", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.8-R0.1-SNAPSHOT-latest.jar");

        public static CraftBukkitVersions oneSevenTen = new CraftBukkitVersions("1.7.10", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.7.10-R0.1-20140808.005431-8.jar");
        public static CraftBukkitVersions oneSevenNine = new CraftBukkitVersions("1.7.9", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.7.9-R0.2-SNAPSHOT.jar");
        public static CraftBukkitVersions oneSevenEight = new CraftBukkitVersions("1.7.8", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.7.8-R0.1-SNAPSHOT.jar");
        public static CraftBukkitVersions oneSevenFive = new CraftBukkitVersions("1.7.5", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.7.5-R0.1-20140402.020013-12.jar");
        public static CraftBukkitVersions oneSevenTwo = new CraftBukkitVersions("1.7.2", "https://cdn.getbukkit.org/craftbukkit/craftbukkit-1.7.2-R0.4-20140216.012104-3.jar");
    }
}
