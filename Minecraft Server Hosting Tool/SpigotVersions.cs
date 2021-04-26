using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Server_Hosting_Tool
{
    class SpigotVersions
    {
        public string URL;
        public string Version;

        public SpigotVersions(string version, string url)
        {
            Version = version;
            URL = url;
        }

        public static SpigotVersions oneSixteenFive = new SpigotVersions("1.16.5", "https://cdn.getbukkit.org/spigot/spigot-1.16.5.jar");
        public static SpigotVersions oneSixteenFour = new SpigotVersions("1.16.4", "https://cdn.getbukkit.org/spigot/spigot-1.16.4.jar");
        public static SpigotVersions oneSixteenThree = new SpigotVersions("1.16.3", "https://cdn.getbukkit.org/spigot/spigot-1.16.3.jar");
        public static SpigotVersions oneSixteenTwo = new SpigotVersions("1.16.2", "https://cdn.getbukkit.org/spigot/spigot-1.16.2.jar");
        public static SpigotVersions oneSixteenOne = new SpigotVersions("1.16.1", "https://cdn.getbukkit.org/spigot/spigot-1.16.1.jar");

        public static SpigotVersions oneFifteenTwo = new SpigotVersions("1.15.2", "https://cdn.getbukkit.org/spigot/spigot-1.15.2.jar");
        public static SpigotVersions oneFifteenOne = new SpigotVersions("1.15.1", "https://cdn.getbukkit.org/spigot/spigot-1.15.1.jar");
        public static SpigotVersions oneFifteen = new SpigotVersions("1.15", "https://cdn.getbukkit.org/spigot/spigot-1.15.jar");

        public static SpigotVersions oneFourteenFour = new SpigotVersions("1.14.4", "https://cdn.getbukkit.org/spigot/spigot-1.14.4.jar");
        public static SpigotVersions oneFourteenThree = new SpigotVersions("1.14.3", "https://cdn.getbukkit.org/spigot/spigot-1.14.3.jar");
        public static SpigotVersions oneFourteenTwo = new SpigotVersions("1.14.2", "https://cdn.getbukkit.org/spigot/spigot-1.14.2.jar");
        public static SpigotVersions oneFourteenOne = new SpigotVersions("1.14.1", "https://cdn.getbukkit.org/spigot/spigot-1.14.1.jar");
        public static SpigotVersions oneFourteen = new SpigotVersions("1.14", "https://cdn.getbukkit.org/spigot/spigot-1.14.jar");

        public static SpigotVersions oneThirteenTwo = new SpigotVersions("1.13.2", "https://cdn.getbukkit.org/spigot/spigot-1.13.2.jar");
        public static SpigotVersions oneThirteenOne = new SpigotVersions("1.13.1", "https://cdn.getbukkit.org/spigot/spigot-1.13.1.jar");
        public static SpigotVersions oneThirteen = new SpigotVersions("1.13", "https://cdn.getbukkit.org/spigot/spigot-1.13.jar");

        public static SpigotVersions oneTwelveTwo = new SpigotVersions("1.12.2", "https://cdn.getbukkit.org/spigot/spigot-1.12.2.jar");
        public static SpigotVersions oneTwelveOne = new SpigotVersions("1.12.1", "https://cdn.getbukkit.org/spigot/spigot-1.12.1.jar");
        public static SpigotVersions oneTwelve = new SpigotVersions("1.12", "https://cdn.getbukkit.org/spigot/spigot-1.12.jar");

        public static SpigotVersions oneElevenTwo = new SpigotVersions("1.11.2", "https://cdn.getbukkit.org/spigot/spigot-1.11.2.jar");
        public static SpigotVersions oneElevenOne = new SpigotVersions("1.11.1", "https://cdn.getbukkit.org/spigot/spigot-1.11.1.jar");
        public static SpigotVersions oneEleven = new SpigotVersions("1.11", "https://cdn.getbukkit.org/spigot/spigot-1.11.jar");

        public static SpigotVersions oneTenTwo = new SpigotVersions("1.10.2", "https://cdn.getbukkit.org/spigot/spigot-1.10.2-R0.1-SNAPSHOT-latest.jar");
        public static SpigotVersions oneTen = new SpigotVersions("1.10", "https://cdn.getbukkit.org/spigot/spigot-1.10-R0.1-SNAPSHOT-latest.jar");

        public static SpigotVersions oneNineFour = new SpigotVersions("1.9.4", "https://cdn.getbukkit.org/spigot/spigot-1.9.4-R0.1-SNAPSHOT-latest.jar");
        public static SpigotVersions oneNineTwo = new SpigotVersions("1.9.2", "https://cdn.getbukkit.org/spigot/spigot-1.9.2-R0.1-SNAPSHOT-latest.jar");
        public static SpigotVersions oneNine = new SpigotVersions("1.9", "https://cdn.getbukkit.org/spigot/spigot-1.9-R0.1-SNAPSHOT-latest.jar");

        public static SpigotVersions oneEightEight = new SpigotVersions("1.8.8", "https://cdn.getbukkit.org/spigot/spigot-1.8.8-R0.1-SNAPSHOT-latest.jar");
        public static SpigotVersions oneEightSeven = new SpigotVersions("1.8.7", "https://cdn.getbukkit.org/spigot/spigot-1.8.7-R0.1-SNAPSHOT-latest.jar");
        public static SpigotVersions oneEightSix = new SpigotVersions("1.8.6", "https://cdn.getbukkit.org/spigot/spigot-1.8.6-R0.1-SNAPSHOT-latest.jar");
        public static SpigotVersions oneEightFive = new SpigotVersions("1.8.5", "https://cdn.getbukkit.org/spigot/spigot-1.8.5-R0.1-SNAPSHOT-latest.jar");
        public static SpigotVersions oneEightFour = new SpigotVersions("1.8.4", "https://cdn.getbukkit.org/spigot/spigot-1.8.4-R0.1-SNAPSHOT-latest.jar");
        public static SpigotVersions oneEightThree = new SpigotVersions("1.8.3", "https://cdn.getbukkit.org/spigot/spigot-1.8.3-R0.1-SNAPSHOT-latest.jar");
        public static SpigotVersions oneEight = new SpigotVersions("1.8", "https://cdn.getbukkit.org/spigot/spigot-1.8-R0.1-SNAPSHOT-latest.jar");

        public static SpigotVersions oneSevenTen = new SpigotVersions("1.7.10", "https://cdn.getbukkit.org/spigot/spigot-1.7.10-SNAPSHOT-b1657.jar");
        public static SpigotVersions oneSevenNine = new SpigotVersions("1.7.9", "https://cdn.getbukkit.org/spigot/spigot-1.7.9-R0.2-SNAPSHOT.jar");
        public static SpigotVersions oneSevenEight = new SpigotVersions("1.7.8", "https://cdn.getbukkit.org/spigot/spigot-1.7.8-R0.1-SNAPSHOT.jar");
        public static SpigotVersions oneSevenFive = new SpigotVersions("1.7.5", "https://cdn.getbukkit.org/spigot/spigot-1.7.5-R0.1-SNAPSHOT-1387.jar");
        public static SpigotVersions oneSevenTwo = new SpigotVersions("1.7.2", "https://cdn.getbukkit.org/spigot/spigot-1.7.2-R0.4-SNAPSHOT-1339.jar");
    }
}
