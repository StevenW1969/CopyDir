using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace CopyDir
{
    public partial class FrmMain_Treeview : Form
    {
        #region ========== Declare Variables ===============

        public string sDir;
        public string dDir;

        public long dirSize;
        public long fileSize;
        public long driveFreeSpace;
        public string myDriveFreeSpaceTotal;

        public int dlLength;
        public string dl;

        public long total;
        public long total_m;
        public long total_tv;

        public List<long> fsList_m;
        public List<long> fsList_tv;

        public string wcl_dir;
        public string wcl_file;

        public string movList;
        public string tvsList;

        public string mdDir;
        public string tvdDir;
        public List<string> mFList = new List<string>();
        public static List<string> mCList = new List<string>();
        public BindingSource bs = new BindingSource();
        public string displaytext;

        public List<string> srcFilePaths = new List<string>();
        public List<string> dstFilePaths = new List<string>();

        public List<string> list1;
        public List<string> list2;

        #endregion

        #region ========== FrmMain_TreeView ================

        public FrmMain_Treeview()
        {
            InitializeComponent();
            this.BringToFront();
            this.DoubleBuffered = true;
           
        }
        private void frmMain_Treeview_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            var assemblyLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var fileVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(assemblyLocation).FileVersion;
            this.Text = "Compare-and-Copy Movies & TV Shows Library  |     Version: " + fileVersion;

            sDir = Properties.Settings.Default.sDir;
            dDir = Properties.Settings.Default.dDir;
            txt_sDir.Text = sDir;
            txt_dDir.Text = dDir;

            //Display the current file being copied on the form
            displaytext = "Current file being copied: Waiting to start!";
            lblCurFN.Text = displaytext;
            lblCurFN.ForeColor = Color.CornflowerBlue;
            lblCurFN.Update();

            mdDir = Path.Combine(dDir, "Movies");
            tvdDir = Path.Combine(dDir, "TV Shows");

            //The tvMovies base TreeView
            TreeNode mainNode_mov = new TreeNode();
            mainNode_mov.Name = "mainNode_mov";
            mainNode_mov.Text = "Movies";
            this.tvMovies.Nodes.Add(mainNode_mov);

            // The tvTVShows base TreeView
            TreeNode mainNode_tvs = new TreeNode();
            mainNode_tvs.Name = "mainNode_tvs";
            mainNode_tvs.Text = "TV Shows";
            this.tvTVShows.Nodes.Add(mainNode_tvs);

            ChangeLabelText("Waiting for copy Process to Start!", Color.Red);

            dlLength = dDir.Length;
            dl = dDir.Remove(3, dlLength - 3);
            driveFreeSpace = GetTotalFreeSpace(dl);
            myDriveFreeSpaceTotal = Sized.ToPrettySize(driveFreeSpace, 2);

            lblDDFS.Text = myDriveFreeSpaceTotal;
        }

        #endregion

        #region ========== Subroutines & Functions =========

        static void ChangeLabelText(string text, Color? color = null)
        {
            //Display the current file being copied on the form
            string displaytext = "Current file being copied: " + text;
            Program.frmMain_Treeview.lblCurFN.Text = displaytext;
            Program.frmMain_Treeview.lblCurFN.ForeColor = color ?? Color.Black;
            Program.frmMain_Treeview.lblCurFN.Update();
        }
        public List<string> Get_Mov_Paths(string tDir)
        {
            List<string> dnList = new List<string>();
            if (Directory.Exists(tDir))
            {
                foreach (var dir in Directory.GetDirectories(tDir, "*", System.IO.SearchOption.AllDirectories))
                {
                    var di = new DirectoryInfo(dir);
                    var both_halves = di.FullName;
                    int fileCount = Directory.GetFiles(both_halves, "*", System.IO.SearchOption.AllDirectories).Length;
                    if (fileCount > 0)
                    {
                        if (dir.Contains("Movies"))
                        {
                            Regex regx_mov = new Regex(@"\bMovies\b");

                            string[] part_two = regx_mov.Split(both_halves);

                            foreach (string match in part_two)
                            {
                                if (match.Length > 0)
                                {
                                    if (!match.Contains(sDir))
                                    {
                                        dnList.Add(match);
                                    }
                                }
                            }
                        }
                    }

                }

            }
            return dnList;
        }
        public List<string> Get_TvS_Paths(string tDir)
        {
            List<string> dnList = new List<string>();
            if (Directory.Exists(tDir))
            {
                foreach (var dir in Directory.GetDirectories(tDir, "*", System.IO.SearchOption.AllDirectories))
                {
                    var di = new DirectoryInfo(dir);
                    var both_halves = di.FullName;
                    int fileCount = Directory.GetFiles(both_halves, "*", System.IO.SearchOption.AllDirectories).Length;
                    if (fileCount > 0)
                    {
                        if (dir.Contains("TV Shows"))
                        {
                            Regex regx_mov = new Regex(@"\bTV Shows\b");

                            string[] part_two = regx_mov.Split(both_halves);

                            foreach (string match in part_two)
                            {
                                if (match.Length > 0)
                                {
                                    if (!match.Contains(sDir))
                                    {
                                        dnList.Add(match);
                                    }
                                }
                            }
                        }
                    }

                }

            }
            return dnList;
        }
        public void CompareLists(string cType)
        {

            dDir = txt_dDir.Text;
            sDir = txt_sDir.Text;

            string m = "Movies";
            string t = "TV Shows";

            if (cType == m)
            {
                list1 = Get_Mov_Paths(sDir);
                list2 = Get_Mov_Paths(dDir);
            }
            if (cType == t)
            {
                list1 = Get_TvS_Paths(sDir);
                list2 = Get_TvS_Paths(dDir);
            }

            List<string> list = new List<string>();
            list.Clear();

            IEnumerable<string> iesList = list1.Except(list2);
            fsList_m = new List<long>();
            fsList_tv = new List<long>();

            foreach (string dir in iesList)
            {
                if (cType == m)
                {
                    string d = sDir + "\\Movies" + dir;
                    DirectoryInfo di = new DirectoryInfo(d);
                    dirSize = di.EnumerateFiles("*", System.IO.SearchOption.AllDirectories).Sum(fi => fi.Length);
                    fsList_m.Add(dirSize);
                    list.Add(dir);
                }

                if (cType == t)
                {
                    string d = sDir + "\\TV Shows" + dir;

                    //regex
                    string pattern = @"([a-zA-Z]+) (\d+)";
                    Match match = Regex.Match(d, pattern);

                    DirectoryInfo di = new DirectoryInfo(d);
                    if (match.Success)
                    {
                        dirSize = di.EnumerateFiles("*", System.IO.SearchOption.AllDirectories).Sum(fi => fi.Length);
                        fsList_tv.Add(dirSize);
                        list.Add(dir);
                    }
                }
            }
            list.Sort();

            if (cType == m)
            {
                gbFoundMov.Text = "Found " + list.Count + " " + m;
                this.tvMovies.BeginUpdate();
            }

            if (cType == t)
            {
                gbFoundTVS.Text = "Found " + list.Count + " " + t;
                this.tvTVShows.BeginUpdate();
            }

            TreeNode lastNode = null;
            string subPathAgg;
            foreach (string path in list)
            {
                subPathAgg = string.Empty;
                foreach (string subPath in path.Split('\\'))
                {
                    subPathAgg += subPath + '\\';

                    TreeNode[] nodes;

                    if (cType == m)
                    {
                        nodes = tvMovies.Nodes.Find(subPathAgg, true);
                        if (nodes.Length == 0)
                            if (lastNode == null)
                                lastNode = tvMovies.Nodes.Add(subPathAgg, subPath);
                            else
                                lastNode = lastNode.Nodes.Add(subPathAgg, subPath);
                        else lastNode = nodes[0];
                    }

                    else if (cType == t)
                    {
                        nodes = tvTVShows.Nodes.Find(subPathAgg, true);
                        if (nodes.Length == 0)
                            if (lastNode == null)
                                lastNode = tvTVShows.Nodes.Add(subPathAgg, subPath);
                            else
                                lastNode = lastNode.Nodes.Add(subPathAgg, subPath);
                        else lastNode = nodes[0];
                    }
                }
            }

            if (cType == m)
            {
                ExpandToLevel(tvMovies.Nodes, 1);
                this.tvMovies.EndUpdate();

                movList = Path.Combine(dDir, "mlist.txt");
                File.WriteAllLines(movList, list);

                foreach (var line in list)
                {
                    if (!line.Contains("_sub"))
                    {
                        string s_path = sDir + "\\Movies" + line;
                        string d_path = dDir + "\\Movies" + line;
                        srcFilePaths.Add(s_path);
                        dstFilePaths.Add(d_path);
                    }
                }
            }

            if (cType == t)
            {
                ExpandToLevel(tvTVShows.Nodes, 2);
                this.tvTVShows.EndUpdate();

                tvsList = Path.Combine(dDir, "tvlist.txt");
                File.WriteAllLines(tvsList, list);

                foreach (var line in list)
                {
                    if (!line.Contains("_sub"))
                    {
                        string s_path = sDir + "\\TV Shows" + line;
                        string d_path = dDir + "\\TV Shows" + line;
                        srcFilePaths.Add(s_path);
                        dstFilePaths.Add(d_path);
                    }
                }
            }

            srcFilePaths.Sort();
            dstFilePaths.Sort();
        }
        private void CompareSpace(long rSpace, long dSpace)
        {
            if (rSpace > dSpace)
            {
                lblDDFS.ForeColor = Color.Red;
                lblTSN.ForeColor = Color.Red;

                string myTotal = Sized.ToPrettySize(rSpace, 2);
                lblTSN.Text = myTotal;
            }
            else
            {
                lblDDFS.ForeColor = Color.LimeGreen;
                lblTSN.ForeColor = Color.LimeGreen;

                string myTotal = Sized.ToPrettySize(rSpace, 2);
                lblTSN.Text = myTotal;
            }
        }
        void ExpandToLevel(TreeNodeCollection nodes, int level)
        {
            if (level > 0)
            {
                foreach (TreeNode node in nodes)
                {
                    node.Expand();
                    ExpandToLevel(node.Nodes, level - 1);
                }
            }
        }
        private void CopyDirContents(string src)
        {
            string dPath = src.Replace(sDir, dDir);

            DirectoryInfo di = new DirectoryInfo(src);
            FileInfo[] files = di.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            foreach (FileInfo file in files)
            {
                string sFile = file.FullName.ToString();
                string dFile = sFile.Replace(sDir, dDir);
                ChangeLabelText(file.Name, Color.Orange);

                fileSize = file.Length;
                string myFileSize = Sized.ToPrettySize(fileSize, 1);
                lblCFS.Text = myFileSize;

                if (!File.Exists(dFile))
                {
                    FileSystem.CopyFile(sFile.ToString(), dFile, UIOption.AllDialogs, UICancelOption.DoNothing);

                    //Log the file that was copied after it finishes.
                    string logtext = "Copied file from: " + sFile + " to: " + dFile + " | " + DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss tt" + Environment.NewLine);
                    string logFileName = "log.txt";
                    Log.Message(logtext, Program.frmMain_Treeview.txt_dDir.Text, logFileName);
                }
            }
        }
        private long GetTotalFreeSpace(string driveName)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady && drive.Name == driveName)
                {
                    return drive.TotalFreeSpace;
                }
            }
            return -1;
        }

        #endregion

        #region ========== Events ==========================

        // Click Events
        private void btn_sDir_Click(object sender, EventArgs e)
        {
            if (fbd_sDir.ShowDialog() == DialogResult.OK)
            {
                txt_sDir.Text = fbd_sDir.SelectedPath;
            }
        }
        private void btn_dDir_Click(object sender, EventArgs e)
        {
            if (fbd_dDir.ShowDialog() == DialogResult.OK)
            {
                txt_dDir.Text = fbd_dDir.SelectedPath;
            }
        }
        private void BtnStartCopy_Click(object sender, EventArgs e)
        {
            if (srcFilePaths.Count > 0)
            {
                srcFilePaths.Sort();

                //int x = 0;
                foreach (var path in srcFilePaths)
                {
                    CopyDirContents(path);
                }
                ChangeLabelText("All Files have been copied Successfully,All Done!", Color.Green);
            }
            else
            {
                MessageBox.Show("Either the Compare did not yeild any results or you have not yet performed a Compare", "NO FILES FOUND TO COPY!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void RbTV_Mov_Click(object sender, EventArgs e)
        {
            gbFoundMov.Text = "Movies";
            gbFoundTVS.Text = "TV Shows";

            tvTVShows.Nodes.Clear();
            tvMovies.Nodes.Clear();

            rbTV_Mov.ForeColor = Color.LimeGreen;
            rbTV.ForeColor = Color.Silver;
            rbMov.ForeColor = Color.Silver;

            total_m = 0;
            CompareLists("Movies");
            if (fsList_m == null)
            {
                total_m = 0;
            }
            else
            {
                total_m = fsList_m.Sum(x => Convert.ToInt64(x));
            }

            total_tv = 0;
            CompareLists("TV Shows");
            if (fsList_tv == null)
            {
                total_tv = 0;
            }
            else
            {
                total_tv = fsList_tv.Sum(x => Convert.ToInt64(x));
            }

            total = total_m + total_tv;
            CompareSpace(total, driveFreeSpace);
        }
        private void RbTV_Click(object sender, EventArgs e)
        {
            gbFoundMov.Text = "Movies";
            gbFoundTVS.Text = "TV Shows";

            tvTVShows.Nodes.Clear();
            tvMovies.Nodes.Clear();

            rbTV_Mov.ForeColor = Color.Silver;
            rbTV.ForeColor = Color.LimeGreen;
            rbMov.ForeColor = Color.Silver;

            total_tv = 0;
            CompareLists("TV Shows");
            if (fsList_tv == null)
            {
                total_tv = 0;
            }
            else
            {
                total_tv = fsList_tv.Sum(x => Convert.ToInt64(x));
            }

            CompareSpace(total_tv, driveFreeSpace);
        }
        private void RbMov_Click(object sender, EventArgs e)
        {
            gbFoundMov.Text = "Movies";
            gbFoundTVS.Text = "TV Shows";

            tvTVShows.Nodes.Clear();
            tvMovies.Nodes.Clear();

            rbTV_Mov.ForeColor = Color.Silver;
            rbTV.ForeColor = Color.Silver;
            rbMov.ForeColor = Color.LimeGreen;

            total_m = 0;
            CompareLists("Movies");
            if (fsList_m == null)
            {
                total_m = 0;
            }
            else
            {

                total_m = fsList_m.Sum(x => Convert.ToInt64(x));
            }

            CompareSpace(total_m, driveFreeSpace);
        }


        // Misc Events
        private void Txt_sDir_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.sDir = txt_sDir.Text;
            Properties.Settings.Default.Save();
        }
        private void Txt_dDir_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.dDir = txt_dDir.Text;
            Properties.Settings.Default.Save();
        }

        #endregion
    }
}