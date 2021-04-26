﻿using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Minecraft_Server_Hosting_Tool
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Timer t1 = new Timer(); //timer for animations for sidebar
        public string openedPan = "welcomePan"; //string to know which panel is visible
        public bool installing = false; //just to know if server is installing when application exit

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainTabControl.Appearance = TabAppearance.FlatButtons;
            MainTabControl.ItemSize = new Size(0, 1);
            MainTabControl.SizeMode = TabSizeMode.Fixed;
            MainTabControl.SelectedTab = welcomeTab;
        }

        //---------------Code for dragable form----------------
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void bar_mouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //---------------End of code for dragable form----------------
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (installing == true)
            {
                DialogResult confirmAnnulation = MessageBox.Show("You are currently installing a minecraft server. Do you want to cancel the installation? You might have some corrupted files in your server installation path, but that's ok you can delete them.", "Cancel Installation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmAnnulation == DialogResult.No)
                    return;
            }    
            System.Windows.Forms.Application.Exit();
        }
        public int animcount = 0; //integer for animations sidebar
        private void openSideBarBtn_Click(object sender, EventArgs e)
        {
            animcount = 0;
            t1.Interval = 10;
            openSideBarBtn.Enabled = false;
            if (openSideBarBtn.Text == "<")
            {
                t1.Tick += new EventHandler(hideBar);
            }
            else
            {
                MainTabControl.Location = new Point(206, 25);
                MainTabControl.Size = new Size(600, 436);
                hideBorderPan1.Location = new Point(206, 34);
                t1.Tick += new EventHandler(showBar);
            }
            t1.Start();
        }
        private void hideBar(object sender, EventArgs e)
        {
            if (animcount <= 60)
            {
                openSideBarBtn.Location = new Point(openSideBarBtn.Location.X - 3, 34);
                sideBar.Location = new Point(sideBar.Location.X - 3, 34);
            }
            else
            {
                t1.Stop();
                openSideBarBtn.Location = new Point(0, 34);
                sideBar.Location = new Point(-184, 34);
                MainTabControl.Location = new Point(23, 25);
                MainTabControl.Size = new Size(783, 436);
                hideBorderPan1.Location = new Point(23, 34);
                t1.Tick -= new EventHandler(hideBar);
                openSideBarBtn.Text = ">";
                openSideBarBtn.Enabled = true;
            }
            animcount += 1;
        }
        private void showBar(object sender, EventArgs e)
        {
            if (animcount <= 60)
            {
                openSideBarBtn.Location = new Point(openSideBarBtn.Location.X + 3, 34);
                sideBar.Location = new Point(sideBar.Location.X + 3, 34);
            }
            else
            {
                t1.Stop();
                openSideBarBtn.Location = new Point(183, 34);
                sideBar.Location = new Point(0, 34);
                t1.Tick -= new EventHandler(showBar);
                openSideBarBtn.Text = "<";
                openSideBarBtn.Enabled = true;
            }
            animcount += 1;
        }

        private void installServBtn_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedTab = installServTab;
            serverInstallType.SelectedItem = "Vanilla (normal minecraft)";
            serverInstallVersion.SelectedItem = "1.16.5";
        }

        private void MBradioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (MBradioBtn.Checked == true)
            {
                if (Double.TryParse(allocatedRam.Text, out double parsedValue))
                {
                    double ram = Convert.ToDouble(allocatedRam.Text);
                    ram = ram * 1024;
                    allocatedRam.Text = Convert.ToString(ram);
                }
                allocatedRam.Items.Clear();
                allocatedRam.Items.Add("512");
                allocatedRam.Items.Add("1024");
                allocatedRam.Items.Add("2048");
                allocatedRam.Items.Add("3072");
                allocatedRam.Items.Add("4096");
                allocatedRam.Items.Add("5120");
                allocatedRam.Items.Add("6144");
                allocatedRam.Items.Add("7168");
                allocatedRam.Items.Add("8192");
                allocatedRam.Items.Add("9216");
                allocatedRam.Items.Add("10240");
                allocatedRam.Items.Add("11264");
                allocatedRam.Items.Add("12288");
                allocatedRam.Items.Add("13312");
                allocatedRam.Items.Add("14336");
                allocatedRam.Items.Add("15360");
                allocatedRam.Items.Add("16384");
                allocatedRam.Items.Add("17408");
                allocatedRam.Items.Add("18432");
                allocatedRam.Items.Add("19456");
                allocatedRam.Items.Add("20480");
            }
            else
            {
                if (Double.TryParse(allocatedRam.Text, out double parsedValue))
                {
                    double ram = Convert.ToDouble(allocatedRam.Text);
                    ram = ram / 1024;
                    allocatedRam.Text = Convert.ToString(ram);
                }
                allocatedRam.Items.Clear();
                allocatedRam.Items.Add("0.5");
                allocatedRam.Items.Add("1");
                allocatedRam.Items.Add("2");
                allocatedRam.Items.Add("3");
                allocatedRam.Items.Add("4");
                allocatedRam.Items.Add("5");
                allocatedRam.Items.Add("6");
                allocatedRam.Items.Add("7");
                allocatedRam.Items.Add("8");
                allocatedRam.Items.Add("9");
                allocatedRam.Items.Add("10");
                allocatedRam.Items.Add("11");
                allocatedRam.Items.Add("12");
                allocatedRam.Items.Add("13");
                allocatedRam.Items.Add("14");
                allocatedRam.Items.Add("15");
                allocatedRam.Items.Add("16");
                allocatedRam.Items.Add("17");
                allocatedRam.Items.Add("18");
                allocatedRam.Items.Add("19");
                allocatedRam.Items.Add("20");
            }
        }

        private void browseServerInstallPathBtn_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog() { IsFolderPicker = true };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                serverInstallPath.Text = dialog.FileName;
            }
        }
        static ulong GetTotalMemoryInBytes()
        {
            return new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
        }
        private async void installNewServerBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(serverInstallPath.Text))
            {
                MessageBox.Show("Please enter a directory to install your server.", "No Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(serverInstallPath.Text))
            {
                MessageBox.Show("The directory you have entered does not exist.", "Wrong Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Double.TryParse(allocatedRam.Text, out double parsedValue))
            {
                MessageBox.Show("The ram amount is invalid! (" + allocatedRam.Text + ")\n\nPlease put the number of MB / GB you want for your server!\n\nDefault: 2048 MB", "Invalid Ram", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double ram = Convert.ToDouble(allocatedRam.Text);
            if (ram < 1.0 && GBradioBtn.Checked || ram < 1000.0 && MBradioBtn.Checked)
            {
                DialogResult notMuchRam = MessageBox.Show("You have allocated less than 1 GB / 1000 MB of ram to your server.\n\nThat's not very much. We recommend at least 1 GB / 1000 MB per server.\n\nAre you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (notMuchRam == DialogResult.No)
                    return;
            }
            double installedRam = GetTotalMemoryInBytes() / 1000000000; //= ram in GB
            double ramToCheck = ram;
            if (MBradioBtn.Checked) { ramToCheck = ram / 1024; }
            string MGB = "MB";
            if (GBradioBtn.Checked) { MGB = "GB"; }
            if (installedRam / 2 < ramToCheck && installedRam > ramToCheck)
            {
                DialogResult moreThanHalfRam = MessageBox.Show("You have allocated more than half of your computer's ram to your server.\n\nIf you want the computer only to host the server and not anything else, this is ok. Else, you should consider lowering the amount of allocated ram to your server.\n\nWe are detecting " + Convert.ToString(installedRam) + " GB of ram on your computer.\nYou have allocated " + Convert.ToString(ram) + " " + MGB + " of ram to your server.\n\nAre you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (moreThanHalfRam == DialogResult.No)
                    return;
            }
            if (installedRam < ramToCheck)
            {
                DialogResult moreThanPCRam = MessageBox.Show("You have allocated more ram than what your computer currently has.\n\nThis might cause the server to crash, you should consider lowering the amount of allocated ram to your server.\n\nWe are detecting " + Convert.ToString(installedRam) + " GB of ram on your computer.\nYou have allocated " + Convert.ToString(ram) + " " + MGB + " of ram to your server.\n\nDo you still want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (moreThanPCRam == DialogResult.No)
                    return;
            }
            if (Directory.EnumerateFileSystemEntries(serverInstallPath.Text).Any())
            {
                DialogResult folderNotEmpty = MessageBox.Show("The folder you have selected (" + serverInstallPath.Text + ") is not empty.\n\nAre you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (folderNotEmpty == DialogResult.No)
                    return;
            }

            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                MessageBox.Show("You are not connected to the internet. Please check you connection and try again.", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            installing = true;

            string JarFileName = serverInstallPath.Text + @"\server.jar";
            string errorMessage = "Error : Minecraft version is unavailable.";

            noEditWhileInstallPan.Enabled = false;
            sideBar.Enabled = false;


            WebClient client = new WebClient();
            client.DownloadProgressChanged += (o, args) =>
            {
                double installProgress = args.ProgressPercentage * 0.9; //.jar download stops at 90% because 10 last % for generating files such as eula, server.properties...
                installStatusLbl.Text = "Downloading: "  + serverInstallType.Text + " " + serverInstallVersion.Text + " server file , please wait..." + Convert.ToString(installProgress) + "%";
                installProgressBar.Value = Convert.ToInt32(installProgress);
            };
            if (serverInstallType.Text == "Vanilla (normal minecraft)")
            {
                using (StreamWriter sw = File.CreateText(serverInstallPath.Text + @"\" + "data.msht"))
                {
                    await sw.WriteLineAsync("#Please do not edit this file, or MSHT could give you an error.");
                    await sw.WriteLineAsync("Vanilla");
                    await sw.WriteLineAsync(serverInstallVersion.Text);
                }
                switch (serverInstallVersion.Text)
                {
                    case "1.16.5":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneSixteenFive.URL, JarFileName);
                        break;
                    case "1.16.4":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneSixteenFour.URL, JarFileName);
                        break;
                    case "1.16.3":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneSixteenThree.URL, JarFileName);
                        break;
                    case "1.16.2":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneSixteenTwo.URL, JarFileName);
                        break;
                    case "1.16.1":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneSixteenOne.URL, JarFileName);
                        break;
                    case "1.16":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneSixteen.URL, JarFileName);
                        break;

                    case "1.15.2":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneFifteenTwo.URL, JarFileName);
                        break;
                    case "1.15.1":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneFifteenOne.URL, JarFileName);
                        break;
                    case "1.15":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneFifteen.URL, JarFileName);
                        break;

                    case "1.14.4":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneFourteenFour.URL, JarFileName);
                        break;
                    case "1.14.3":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneFourteenThree.URL, JarFileName);
                        break;
                    case "1.14.2":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneFourteenTwo.URL, JarFileName);
                        break;
                    case "1.14.1":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneFourteenOne.URL, JarFileName);
                        break;
                    case "1.14":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneFourteen.URL, JarFileName);
                        break;

                    case "1.13.2":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneThirteenTwo.URL, JarFileName);
                        break;
                    case "1.13.1":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneThirteenOne.URL, JarFileName);
                        break;
                    case "1.13":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneThirteen.URL, JarFileName);
                        break;

                    case "1.12.2":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneTwelveTwo.URL, JarFileName);
                        break;
                    case "1.12.1":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneTwelveOne.URL, JarFileName);
                        break;
                    case "1.12":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneTwelve.URL, JarFileName);
                        break;

                    case "1.11.2":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneElevenTwo.URL, JarFileName);
                        break;
                    case "1.11.1":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneElevenOne.URL, JarFileName);
                        break;
                    case "1.11":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneEleven.URL, JarFileName);
                        break;

                    case "1.10.2":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneTenTwo.URL, JarFileName);
                        break;
                    case "1.10.1":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneTenOne.URL, JarFileName);
                        break;
                    case "1.10":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneTen.URL, JarFileName);
                        break;

                    case "1.9.4":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneNineFour.URL, JarFileName);
                        break;
                    case "1.9.3":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneNineThree.URL, JarFileName);
                        break;
                    case "1.9.2":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneNineTwo.URL, JarFileName);
                        break;
                    case "1.9.1":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneNineOne.URL, JarFileName);
                        break;
                    case "1.9":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneNine.URL, JarFileName);
                        break;

                    case "1.8.9":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneEightNine.URL, JarFileName);
                        break;
                    case "1.8.8":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneEightEight.URL, JarFileName);
                        break;
                    case "1.8.7":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneEightSeven.URL, JarFileName);
                        break;
                    case "1.8.6":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneEightSix.URL, JarFileName);
                        break;
                    case "1.8.5":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneEightFive.URL, JarFileName);
                        break;
                    case "1.8.4":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneEightFour.URL, JarFileName);
                        break;
                    case "1.8.3":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneEightThree.URL, JarFileName);
                        break;
                    case "1.8.2":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneEightTwo.URL, JarFileName);
                        break;
                    case "1.8.1":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneEightOne.URL, JarFileName);
                        break;
                    case "1.8":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneEight.URL, JarFileName);
                        break;

                    case "1.7.10":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneSevenTen.URL, JarFileName);
                        break;
                    case "1.7.9":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneSevenNine.URL, JarFileName);
                        break;
                    case "1.7.8":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneSevenEight.URL, JarFileName);
                        break;
                    case "1.7.7":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneSevenSeven.URL, JarFileName);
                        break;
                    case "1.7.6":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneSevenSix.URL, JarFileName);
                        break;
                    case "1.7.5":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneSevenFive.URL, JarFileName);
                        break;
                    case "1.7.4":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneSevenFour.URL, JarFileName);
                        break;
                    case "1.7.3":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneSevenThree.URL, JarFileName);
                        break;
                    case "1.7.2":
                        await client.DownloadFileTaskAsync(VanillaVersions.oneSevenTwo.URL, JarFileName);
                        break;

                    default:
                        installStatusLbl.Text = errorMessage;
                        break;
                }
            }
            else if (serverInstallType.Text == "Spigot (for plugins)")
            {
                using (StreamWriter sw = File.CreateText(serverInstallPath.Text + @"\" + "data.msht"))
                {
                    await sw.WriteLineAsync("#Please do not edit this file, or MSHT could give you an error.");
                    await sw.WriteLineAsync("Spigot");
                    await sw.WriteLineAsync(serverInstallVersion.Text);
                }
                switch (serverInstallVersion.Text)
                {
                    case "1.16.5":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneSixteenFive.URL, JarFileName);
                        break;
                    case "1.16.4":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneSixteenFour.URL, JarFileName);
                        break;
                    case "1.16.3":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneSixteenThree.URL, JarFileName);
                        break;
                    case "1.16.2":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneSixteenTwo.URL, JarFileName);
                        break;
                    case "1.16.1":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneSixteenOne.URL, JarFileName);
                        break;

                    case "1.15.2":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneFifteenTwo.URL, JarFileName);
                        break;
                    case "1.15.1":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneFifteenOne.URL, JarFileName);
                        break;
                    case "1.15":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneFifteen.URL, JarFileName);
                        break;

                    case "1.14.4":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneFourteenFour.URL, JarFileName);
                        break;
                    case "1.14.3":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneFourteenThree.URL, JarFileName);
                        break;
                    case "1.14.2":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneFourteenTwo.URL, JarFileName);
                        break;
                    case "1.14.1":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneFourteenOne.URL, JarFileName);
                        break;
                    case "1.14":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneFourteen.URL, JarFileName);
                        break;

                    case "1.13.2":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneThirteenTwo.URL, JarFileName);
                        break;
                    case "1.13.1":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneThirteenOne.URL, JarFileName);
                        break;
                    case "1.13":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneThirteen.URL, JarFileName);
                        break;

                    case "1.12.2":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneTwelveTwo.URL, JarFileName);
                        break;
                    case "1.12.1":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneTwelveOne.URL, JarFileName);
                        break;
                    case "1.12":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneTwelve.URL, JarFileName);
                        break;

                    case "1.11.2":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneElevenTwo.URL, JarFileName);
                        break;
                    case "1.11.1":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneElevenOne.URL, JarFileName);
                        break;
                    case "1.11":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneEleven.URL, JarFileName);
                        break;

                    case "1.10.2":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneTenTwo.URL, JarFileName);
                        break;
                    case "1.10":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneTen.URL, JarFileName);
                        break;

                    case "1.9.4":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneNineFour.URL, JarFileName);
                        break;
                    case "1.9.2":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneNineTwo.URL, JarFileName);
                        break;
                    case "1.9":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneNine.URL, JarFileName);
                        break;

                    case "1.8.8":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneEightEight.URL, JarFileName);
                        break;
                    case "1.8.7":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneEightSeven.URL, JarFileName);
                        break;
                    case "1.8.6":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneEightSix.URL, JarFileName);
                        break;
                    case "1.8.5":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneEightFive.URL, JarFileName);
                        break;
                    case "1.8.4":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneEightFour.URL, JarFileName);
                        break;
                    case "1.8.3":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneEightThree.URL, JarFileName);
                        break;
                    case "1.8":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneEight.URL, JarFileName);
                        break;

                    case "1.7.10":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneSevenTen.URL, JarFileName);
                        break;
                    case "1.7.9":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneSevenNine.URL, JarFileName);
                        break;
                    case "1.7.8":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneSevenEight.URL, JarFileName);
                        break;
                    case "1.7.5":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneSevenFive.URL, JarFileName);
                        break;
                    case "1.7.2":
                        await client.DownloadFileTaskAsync(SpigotVersions.oneSevenTwo.URL, JarFileName);
                        break;

                    default:
                        installStatusLbl.Text = errorMessage;
                        break;
                }
            }
            else if (serverInstallType.Text == "Paper (for plugins & performance)")
            {
                using (StreamWriter sw = File.CreateText(serverInstallPath.Text + @"\" + "data.msht"))
                {
                    await sw.WriteLineAsync("#Please do not edit this file, or MSHT could give you an error.");
                    await sw.WriteLineAsync("Paper");
                    await sw.WriteLineAsync(serverInstallVersion.Text);
                }
                switch (serverInstallVersion.Text)
                {
                    case "1.16.5":
                        await client.DownloadFileTaskAsync(PaperVersions.oneSixteenFive.URL, JarFileName);
                        break;
                    case "1.16.4":
                        await client.DownloadFileTaskAsync(PaperVersions.oneSixteenFour.URL, JarFileName);
                        break;
                    case "1.16.3":
                        await client.DownloadFileTaskAsync(PaperVersions.oneSixteenThree.URL, JarFileName);
                        break;
                    case "1.16.2":
                        await client.DownloadFileTaskAsync(PaperVersions.oneSixteenTwo.URL, JarFileName);
                        break;
                    case "1.16.1":
                        await client.DownloadFileTaskAsync(PaperVersions.oneSixteenOne.URL, JarFileName);
                        break;

                    case "1.15.2":
                        await client.DownloadFileTaskAsync(PaperVersions.oneFifteenTwo.URL, JarFileName);
                        break;

                    case "1.14.4":
                        await client.DownloadFileTaskAsync(PaperVersions.oneFourteenFour.URL, JarFileName);
                        break;

                    case "1.13.2":
                        await client.DownloadFileTaskAsync(PaperVersions.oneThirteenTwo.URL, JarFileName);
                        break;

                    case "1.12.2":
                        await client.DownloadFileTaskAsync(PaperVersions.oneTwelveTwo.URL, JarFileName);
                        break;

                    case "1.11.2":
                        await client.DownloadFileTaskAsync(PaperVersions.oneElevenTwo.URL, JarFileName);
                        break;

                    case "1.10.2":
                        await client.DownloadFileTaskAsync(PaperVersions.oneTenTwo.URL, JarFileName);
                        break;

                    case "1.9.4":
                        await client.DownloadFileTaskAsync(PaperVersions.oneNineFour.URL, JarFileName);
                        break;

                    case "1.8.8":
                        await client.DownloadFileTaskAsync(PaperVersions.oneEightEight.URL, JarFileName);
                        break;

                    default:
                        installStatusLbl.Text = errorMessage;
                        break;
                }
            }
            //add craftbukkit here
            //add forge here


            installStatusLbl.Text = "Generating server.properties for version " + serverInstallVersion.Text + "...";

            var count = serverInstallVersion.Text.Count(x => x == '.');
            string tester = serverInstallVersion.Text;
            int add = 0;

            if (serverInstallVersion.Text[3] != Convert.ToChar("."))
            {
                int one = int.Parse(serverInstallVersion.Text[0].ToString());
                int two = int.Parse(serverInstallVersion.Text[2].ToString());
                add = one + two;
                tester = Convert.ToString(add) + "." + serverInstallVersion.Text[3] + serverInstallVersion.Text[5];
            }



            if (count == 2 && serverInstallVersion.Text[3] == Convert.ToChar(".")) //just removing the second dot if there is one -> read below to know why
            {
                tester = tester.Remove(3, 1);
            }

            MessageBox.Show(tester);

            double version = Convert.ToDouble(tester, System.Globalization.CultureInfo.InvariantCulture);

            using (StreamWriter sw = File.CreateText(serverInstallPath.Text + @"\" + "server.properties")) //to check for a version just remove the second dot if there is one, example : if I want to check for 1.16.5 I say 2.65, for 1.14 I say 2.44, for 1.9.4 I say 1.94. IF there are two numbers after the first dot you add the first and second numbers together.
            {
                await sw.WriteLineAsync("spawn-protection=16");
                await sw.WriteLineAsync("max-tick-time=60000");
                await sw.WriteLineAsync("query.port=25565");
                if (version >= 1.8)
                    await sw.WriteLineAsync("generator-settings=");
                if (version >= 2.6)
                    await sw.WriteLineAsync("sync-chunk-writes=true");
                await sw.WriteLineAsync("force-gamemode=false");
                await sw.WriteLineAsync("allow-nether=true");
                await sw.WriteLineAsync("enforce-whitelist=false");
                await sw.WriteLineAsync("gamemode=survival");
                await sw.WriteLineAsync("broadcast-console-to-ops=true");
                await sw.WriteLineAsync("enable-query=false");
                await sw.WriteLineAsync("player-idle-timeout=0");
                if (version >= 2.64)
                    await sw.WriteLineAsync("text-filtering-config=");
                await sw.WriteLineAsync("difficulty=easy");
                await sw.WriteLineAsync("broadcast-rcon-to-ops=true");
                await sw.WriteLineAsync("spawn-monsters=true");
                await sw.WriteLineAsync("op-permission-level=4");
                await sw.WriteLineAsync("pvp=true");
                if (version >= 2.6)
                    await sw.WriteLineAsync("entity-broadcast-range-percentage=100");
                await sw.WriteLineAsync("snooper-enabled=true");
                await sw.WriteLineAsync("level-type=default");
                if (version >= 2.6)
                    await sw.WriteLineAsync("enable-status=true");
                await sw.WriteLineAsync("resource-pack-prompt=");
                await sw.WriteLineAsync("hardcore=false");
                await sw.WriteLineAsync("enable-command-block=false");
                if (version >= 1.8)
                    await sw.WriteLineAsync("network-compression-threshold=256");
                await sw.WriteLineAsync("max-players=20");
                await sw.WriteLineAsync("max-world-size=29999984");
                await sw.WriteLineAsync("resource-pack-sha1=");
                if (version >= 2.44)
                    await sw.WriteLineAsync("function-permission-level=2");
                await sw.WriteLineAsync("rcon.port=25575");
                await sw.WriteLineAsync("server-port=25565");
                await sw.WriteLineAsync("server-ip=");
                await sw.WriteLineAsync("spawn-npcs=true");
                await sw.WriteLineAsync("require-resource-pack=false");
                await sw.WriteLineAsync("allow-flight=false");
                await sw.WriteLineAsync("level-name=world");
                await sw.WriteLineAsync("view-distance=10");
                await sw.WriteLineAsync("resource-pack=");
                await sw.WriteLineAsync("spawn-animals=true");
                await sw.WriteLineAsync("white-list=false");
                await sw.WriteLineAsync("rcon.password=");
                await sw.WriteLineAsync("generate-structures=true");
                await sw.WriteLineAsync("online-mode=true");
                await sw.WriteLineAsync("level-seed=");
                if (version >= 2.1)
                    await sw.WriteLineAsync("prevent-proxy-connections=false");
                await sw.WriteLineAsync("use-native-transport=true");
                if (version >= 2.6)
                    await sw.WriteLineAsync("enable-jmx-monitoring=false");
                await sw.WriteLineAsync("motd=A Minecraft Server");
                if (version >= 2.62)
                    await sw.WriteLineAsync("rate-limit=0");
                await sw.WriteLineAsync("enable-rcon=false");
                if (version < 2.2)
                    await sw.WriteLineAsync("announce-player-achievements=true");
            }

            installStatusLbl.Text = "Generating eula file...";

            using (StreamWriter sw = File.CreateText(serverInstallPath.Text + @"\" + "eula.txt"))
            {
                await sw.WriteLineAsync("eula=true");
            }

            noEditWhileInstallPan.Enabled = true;
            sideBar.Enabled = true;
            installing = false;
            installStatusLbl.Text = "idle";
        }

        private void serverInstallType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serverInstallType.Text == "Vanilla (normal minecraft)")
            {
                serverInstallVersion.Items.Clear();
                serverInstallVersion.Items.AddRange(new string[] { "1.16.5", "1.16.4", "1.16.3", "1.16.2", "1.16.1", "1.16", "1.15.2", "1.15.1", "1.15", "1.14.4", "1.14.3", "1.14.2", "1.14.1", "1.14", "1.13.2", "1.13.1", "1.13", "1.12.2", "1.12.1", "1.12", "1.11.2", "1.11.1", "1.11", "1.10.2", "1.10.1", "1.10", "1.9.4", "1.9.3", "1.9.2", "1.9.1", "1.9", "1.8.9", "1.8.8", "1.8.7", "1.8.6", "1.8.5", "1.8.4", "1.8.3", "1.8.2", "1.8.1", "1.8", "1.7.10", "1.7.9", "1.7.8", "1.7.7", "1.7.6", "1.7.5", "1.7.4", "1.7.3", "1.7.2" });
                serverInstallVersion.SelectedItem = "1.16.5";
            }
            else if (serverInstallType.Text == "Spigot (for plugins)")
            {
                serverInstallVersion.Items.Clear();
                serverInstallVersion.Items.AddRange(new string[] { "1.16.5", "1.16.4", "1.16.3", "1.16.2", "1.16.1", "1.15.2", "1.15.1", "1.15", "1.14.4", "1.14.3", "1.14.2", "1.14.1", "1.14", "1.13.2", "1.13.1", "1.13", "1.12.2", "1.12.1", "1.12", "1.11.2", "1.11.1", "1.11", "1.10.2", "1.10", "1.9.4", "1.9.2", "1.9", "1.8.8", "1.8.7", "1.8.6", "1.8.5", "1.8.4", "1.8.3", "1.8", "1.7.10", "1.7.9", "1.7.8", "1.7.5", "1.7.2" });
                serverInstallVersion.SelectedItem = "1.16.5";
            }
            else if (serverInstallType.Text == "Paper (for plugins & performance)")
            {
                serverInstallVersion.Items.Clear();
                serverInstallVersion.Items.AddRange(new string[] { "1.16.5", "1.16.4", "1.16.3", "1.16.2", "1.16.1", "1.15.2", "1.14.4", "1.13.2", "1.12.2", "1.11.2", "1.10.2", "1.9.4", "1.8.8" });
                serverInstallVersion.SelectedItem = "1.16.5";
            }
            else if (serverInstallType.Text == "CraftBukkit (for plugins & performance)")
            {
                serverInstallVersion.Items.Clear();
                serverInstallVersion.Items.AddRange(new string[] { "1.16.5", "1.16.4", "1.16.3", "1.16.2", "1.16.1", "1.15.2", "1.15.1", "1.15", "1.14.4", "1.14.3", "1.14.2", "1.14.1", "1.14", "1.13.2", "1.13.1", "1.13", "1.12.2", "1.12.1", "1.12", "1.11.2", "1.11.1", "1.11", "1.10.2", "1.10", "1.9.4", "1.9.2", "1.9", "1.8.8", "1.8.7", "1.8.6", "1.8.5", "1.8.4", "1.8.3", "1.8", "1.7.10", "1.7.9", "1.7.8", "1.7.5", "1.7.2" });
                serverInstallVersion.SelectedItem = "1.16.5";
            }
            else if (serverInstallType.Text == "Forge (for mods)")
            {
                serverInstallVersion.Items.Clear();
                serverInstallVersion.Items.AddRange(new string[] { "1.16.5", "1.16.4", "1.16.3", "1.16.2", "1.16.1", "1.15.2", "1.15.1", "1.15", "1.14.4", "1.14.3", "1.14.2", "1.13.2", "1.12.2", "1.12.1", "1.12", "1.11.2", "1.11", "1.10.2", "1.10", "1.9.4", "1.9", "1.8.9", "1.8.8", "1.8", "1.7.10", "1.7.2" });
                serverInstallVersion.SelectedItem = "1.16.5";
            }
        }
    }
}