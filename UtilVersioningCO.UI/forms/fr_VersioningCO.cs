using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilVersion;
using UtilVersioningCO.UI.forms;

namespace UtilVersioningCO.UI
{
    public partial class frm_VersioningCO : Form
    {
        public string FILE_CONFIG = string.Empty;
        UtilFiles utilFiles = new UtilFiles();
        UtilProject utilProjects = new UtilProject();

        public frm_VersioningCO()
        {
            InitializeComponent();
            LoadProjectsConfig();
            ClearElements();
        }

        #region "Actions"
        private void LoadProjectsConfig()
        {
            btPreferences.Enabled = false;
            btClean.Enabled = false;
            foreach (string file in Directory.GetFiles(@"config/", "*.xml"))
            {
                cbListFilePrj.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }

        private void LoadProject()
        {

            if (cbListFilePrj.SelectedItem != null)
            {
                FILE_CONFIG = Path.Combine("config", string.Concat(cbListFilePrj.Text, ".xml"));
                btPreferences.Enabled = true;
                btClean.Enabled = true;
                ClearElements();
                ConfigureGrid();
            }
            else
            {
                btPreferences.Enabled = false;
                btClean.Enabled = false;
                MessageBox.Show("File Not Found");
            }
        }

        private void ClearElements()
        {
            tsProjectsCount.Text = string.Empty;
            tvProjects.Nodes.Clear();
            projectsDs.tbDtoFiles.Clear();
            projectsDs.tbProjects.Clear();
            pbProgress.Visible = false;
        }

        private void CollectionProjectToTreeView(List<DtoFiles> collectionPrj)
        {
            int id = 0;
            ClearElements();
            foreach (DtoFiles item in collectionPrj)
            {
                id++;
                TreeNode newNode = tvProjects.Nodes.Add(item.Name, item.Name, 0);
                newNode.Nodes.Add("id", string.Concat("ID:", id));
                newNode.Nodes.Add("Path", string.Concat("Path Parent:", item.Path));
                newNode.Nodes.Add("PathFull", string.Concat("Full Path:", item.PathFull));
                newNode.Nodes.Add("Type", string.Concat("Type Project:", item.Type));

                DataTable dt = projectsDs.tbDtoFiles;
                DataRow dtRow = dt.NewRow();
                dtRow["Id"] = id;
                dtRow["Name"] = item.Name;
                dtRow["Path"] = item.Path;
                dtRow["PathFull"] = item.PathFull;
                dtRow["Type"] = item.Type;
                projectsDs.tbDtoFiles.Rows.Add(dtRow);
            }

            tsProjectsCount.Text = string.Concat("Projects Found : ", collectionPrj.Count());
        }

        private List<DtoFiles> GetDtoNodeSelected()
        {
            string pattern = @":[\w]*";
            List<DtoFiles> ret = new List<DtoFiles>();
            foreach (TreeNode item in tvProjects.Nodes)
            {
                if (item.Checked)
                {
                    Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
                    MatchCollection matches = rgx.Matches(item.Nodes["id"].ToString());
                    int _id = int.Parse(matches[1].Value.Replace(":", ""));

                    ret.Add(GetInformationNode(_id));

                }
            }
            return ret;
        }

        private DtoFiles GetDtoNodeSelected(TreeNode treeNode)
        {
            string pattern = @":[\w]*";
            List<DtoFiles> ret = new List<DtoFiles>();

            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(treeNode.Nodes["id"].ToString());
            int _id = int.Parse(matches[1].Value.Replace(":", ""));

            return GetInformationNode(_id);

        }

        private DtoFiles GetInformationNode(int idProject)
        {
            DataRow drow = projectsDs.tbDtoFiles.AsEnumerable().Where(x => x.Id == idProject).SingleOrDefault();
            return new DtoFiles() { Id = int.Parse(drow["Id"].ToString()), Name = drow["Name"].ToString(), Path = drow["Path"].ToString(), PathFull = drow["PathFull"].ToString(), Type = drow["Type"].ToString() };
        }

        private bool ExistsProjectsToGenerate(int idProject)
        {
            DataRow drow = projectsDs.tbProjects.AsEnumerable().Where(x => x.Id == idProject).SingleOrDefault();
            return drow == null;
        }

        private void ConfigureGrid()
        {
            bnProjectsGenerate.BindingSource = tbProjectsBindingSource;
            dgProjectsGen.DataSource = tbProjectsBindingSource;

            dgProjectsGen.Columns[1].HeaderText = "Project";
            dgProjectsGen.Columns[2].HeaderText = "Version New Click Once";
            dgProjectsGen.Columns[3].HeaderText = "Version Now Click Once";
            dgProjectsGen.Columns[4].HeaderText = "Version New Dll";
            dgProjectsGen.Columns[5].HeaderText = "Version Now Dll";

            dgProjectsGen.Columns[0].Visible = false;

            dgProjectsGen.Columns[0].ReadOnly = true;
            dgProjectsGen.Columns[1].ReadOnly = true;
            dgProjectsGen.Columns[2].ReadOnly = false;
            dgProjectsGen.Columns[3].ReadOnly = true;
            dgProjectsGen.Columns[4].ReadOnly = true;
            dgProjectsGen.Columns[5].ReadOnly = true;
            dgProjectsGen.Columns[6].ReadOnly = true;

            if (utilProjects.SaveVersionDll(FILE_CONFIG))
            {
                dgProjectsGen.Columns[4].ReadOnly = false;
                dgProjectsGen.Columns[4].CellTemplate.Style.BackColor = Color.SkyBlue;
            }
            dgProjectsGen.Columns[1].Width = 200;
            dgProjectsGen.Columns[2].CellTemplate.Style.BackColor = Color.SkyBlue;
        }

        private void AddProjectToGenerate()
        {
            bool autoIncrementVersion = utilProjects.GetIncrementAutomatic(FILE_CONFIG);
            foreach (DtoFiles Item in GetDtoNodeSelected())
            {
                if (ExistsProjectsToGenerate(Item.Id))
                {
                    DataTable dt = projectsDs.tbProjects;
                    DataRow dtRow = dt.NewRow();
                    string ProjectInstaller = utilProjects.GetPathProjectInstaller(Item.Name, FILE_CONFIG);
                    if (string.IsNullOrEmpty(ProjectInstaller))
                    {
                        MessageBox.Show("Project Installer not found: " + Item.Name, "Admin Projets", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string version_dll = utilProjects.GetVersion(Item.PathFull, autoIncrementVersion);
                        string version_Co = utilProjects.GetVersion(ProjectInstaller, autoIncrementVersion);
                        string version_dll_ori = utilProjects.GetVersion(Item.PathFull);
                        string version_Co_ori = utilProjects.GetVersion(ProjectInstaller);
                        string AssemblyName = utilProjects.GetAssemblyName(ProjectInstaller);
                        if (string.IsNullOrEmpty(AssemblyName))
                        {
                            MessageBox.Show("Not load Configuration", "Projects Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        dtRow["Id"] = Item.Id;
                        dtRow["Name"] = Item.Name;
                        dtRow["VersionNew"] = version_Co;
                        dtRow["VersionNow"] = version_Co_ori;
                        dtRow["VersionDll"] = version_dll;
                        dtRow["VersionDllNow"] = version_dll_ori;
                        dtRow["AssemblyName"] = AssemblyName;
                        projectsDs.tbProjects.Rows.Add(dtRow);
                    }
                }
            }
            ConfigureGrid();
        }

        private void AddProjectToGenerate(TreeNode treeNode)
        {
            DtoFiles Item = GetDtoNodeSelected(treeNode);
            if (ExistsProjectsToGenerate(Item.Id))
            {
                DataTable dt = projectsDs.tbProjects;
                DataRow dtRow = dt.NewRow();
                string ProjectInstaller = utilProjects.GetPathProjectInstaller(Item.Name, FILE_CONFIG);
                if (string.IsNullOrEmpty(ProjectInstaller))
                {
                    MessageBox.Show("Project Installer not found: " + Item.Name, "Admin Projets", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool autoIncrementVersion = utilProjects.GetIncrementAutomatic(FILE_CONFIG);
                    string version_dll = utilProjects.GetVersion(Item.PathFull, autoIncrementVersion);
                    string version_Co = utilProjects.GetVersion(ProjectInstaller, autoIncrementVersion);
                    string version_dll_ori = utilProjects.GetVersion(Item.PathFull);
                    string version_Co_ori = utilProjects.GetVersion(ProjectInstaller);

                    string AssemblyName = utilProjects.GetAssemblyName(ProjectInstaller);
                    if (string.IsNullOrEmpty(AssemblyName))
                    {
                        MessageBox.Show("Not load Configuration", "Projects Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dtRow["Id"] = Item.Id;
                        dtRow["Name"] = Item.Name;
                        dtRow["VersionNew"] = version_Co;
                        dtRow["VersionNow"] = version_Co_ori;
                        dtRow["VersionDll"] = version_dll;
                        dtRow["VersionDllNow"] = version_dll_ori;
                        dtRow["AssemblyName"] = AssemblyName;
                        projectsDs.tbProjects.Rows.Add(dtRow);
                    }
                }
            }
            ConfigureGrid();
        }

        private void RemoveProjectToGenerate(TreeNode treeNode)
        {
            DtoFiles Item = GetDtoNodeSelected(treeNode);

            DataRow dataRow = (from t in projectsDs.tbProjects.AsEnumerable()
                               where t.Field<int>("Id") == Item.Id
                               select t).SingleOrDefault();

            if (dataRow != null)
            {
                projectsDs.tbProjects.Rows.Remove(dataRow);
                ConfigureGrid();
            }
        }
        #endregion

        private void dgProjectsGen_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string pattern = @"([\d]{1,3})\.([\d]{1,3})\.([\d]{1,3})\.([\d]{1,3})";
            string value = dgProjectsGen.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(value);

            if (matches.Count == 0)
            {
                dgProjectsGen.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Empty;
                MessageBox.Show("Valores Permitidos \n Ejm: \n 1.0.0.1 \n 100.255.255.001", "Control de Verision", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tvProjects_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvProjects.BeginUpdate();
            this.tvProjects.SelectedNode = e.Node;
            try
            {
                if (e.Node.Level == 0)
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        msNodeChild.Show(MousePosition);
                    }
                    else
                    {
                        if (e.Node.Checked)
                        {
                            AddProjectToGenerate(e.Node);
                        }
                        else
                        {
                            RemoveProjectToGenerate(e.Node);
                        }
                    }
                }
            }
            finally
            {
                this.tvProjects.EndUpdate();
            }
        }

        #region "Strip Menu Child"
        private void openFolderContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sPathShow = string.Empty;

            if (tvProjects.SelectedNode.Level == 1)
            {
                sPathShow = tvProjects.SelectedNode.Parent.Nodes["Id"].ToString();
            }
            else
            {
                sPathShow = tvProjects.SelectedNode.Nodes["Id"].ToString();
            }
            string pattern = @":[\w]*";

            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(sPathShow);
            int _id = int.Parse(matches[1].Value.Replace(":", ""));

            GetInformationNode(_id);
            Process.Start(GetInformationNode(_id).Path);
        }

        private void selectAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (TreeNode item in tvProjects.Nodes)
            {
                item.Checked = true;
            }
            AddProjectToGenerate();
        }
        #endregion

        private void btPreferences_Click(object sender, EventArgs e)
        {
            fr_preferences pref = new fr_preferences();
            pref.ShowDialog();
        }

        private void btExecute_Click_1(object sender, EventArgs e)
        {
            ShowNotify(1000, "Starting published");
            this.Cursor = Cursors.WaitCursor;
            Process Proc = new Process();
            Regex rgx;
            MatchCollection matches;
            tbProjectsBindingSource.EndEdit();
            string FullPathOutClickOnce = utilProjects.GetPathDestination(FILE_CONFIG);
            string FullPathInstallers = utilProjects.GetPathInstallers(FILE_CONFIG);
            pbProgress.Visible = true;

            string TEMPLATE = utilProjects.GetTemplateScripts(FILE_CONFIG);
            string NAME_BUILD = string.Concat("BUILD_CLICK_ONCE_", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute);
            string fileScript = string.Concat(utilProjects.GetPathDestinationSQL(FILE_CONFIG), "\\", NAME_BUILD, ".sql");
            Directory.CreateDirectory(utilProjects.GetPathDestinationSQL(FILE_CONFIG));
            Directory.CreateDirectory(FullPathOutClickOnce);
            StreamWriter FILE_SCRIPTS = new StreamWriter(fileScript, false);

            //PRE PROCESS PUBLISH
            Proc = new Process();
            Proc.StartInfo.FileName = @"PrePublish.bat";
            Proc.StartInfo.WorkingDirectory = FullPathInstallers;
            Proc.StartInfo.Arguments = string.Concat(FullPathOutClickOnce);
            Proc.StartInfo.UseShellExecute = true;

            Proc.Start();
            Proc.WaitForExit();
            if (Proc.ExitCode == 0)
            {
                Proc.Close();
                foreach (DataRow row in projectsDs.tbProjects.Rows)
                {
                    string Version_New = row["VersionNew"].ToString();
                    if (!string.IsNullOrEmpty(Version_New))
                    {

                        string Version_New_DLL = row["VersionDll"].ToString();
                        if (!string.IsNullOrEmpty(Version_New_DLL))
                        {
                            if (utilProjects.SaveVersionDll(FILE_CONFIG))
                            {
                                DtoFiles projDto = GetInformationNode(int.Parse(row["Id"].ToString()));
                                utilProjects.UpdateVersion(Version_New_DLL, projDto.PathFull);
                            }
                        }

                        string FullPathSolution = utilProjects.GetPathProjectInstaller(row["Name"].ToString(), FILE_CONFIG);

                        string Version = string.Empty;
                        string Version_Revision = string.Empty;

                        rgx = new Regex(@"(\w*)\.(\w*)\.(\w*)\.", RegexOptions.IgnoreCase);
                        matches = rgx.Matches(Version_New);
                        Version = string.Concat(matches[0].ToString(), "%2a");

                        rgx = new Regex(@"(\w*)\.(\w*)\.(\w*)\.", RegexOptions.IgnoreCase);
                        Version_Revision = rgx.Replace(Version_New, "");

                        //PROCESS PUBLISH
                        Proc = new Process();
                        Proc.StartInfo.FileName = @"Publish.bat";
                        Proc.StartInfo.WorkingDirectory = FullPathInstallers;
                        Proc.StartInfo.Arguments = string.Concat(FullPathSolution, " ", FullPathOutClickOnce, " ", Version, " ", Version_Revision);
                        Proc.StartInfo.UseShellExecute = true;
                        try
                        {
                            Proc.Start();
                            Proc.WaitForExit();

                            if (Proc.ExitCode != 0)
                            {
                                ShowNotify(500, string.Concat("Error on published project:", row["Name"].ToString()), ToolTipIcon.Error);
                                foreach (DataGridViewRow itemRow in dgProjectsGen.Rows)
                                {
                                    if (itemRow.Cells["Name"].Value.Equals(row["Name"].ToString()))
                                    {
                                        itemRow.DefaultCellStyle.BackColor = Color.Red;
                                    }
                                }
                            }
                            else
                            {
                                foreach (DataGridViewRow itemRow in dgProjectsGen.Rows)
                                {
                                    if (itemRow.Cells["Name"].Value.Equals(row["Name"].ToString()))
                                    {
                                        itemRow.DefaultCellStyle.BackColor = Color.PaleGreen;
                                        FILE_SCRIPTS.WriteLine(string.Format(TEMPLATE, Version_New, row["AssemblyName"].ToString()));
                                    }
                                }
                            }
                            Proc.Close();
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine("Exception: " + exception.Message);
                        }
                        Proc.Close();
                    }
                }

                //POST PROCESS PUBLISH
                Proc = new Process();
                Proc.StartInfo.FileName = @"PostPublish.bat";
                Proc.StartInfo.WorkingDirectory = FullPathInstallers;
                Proc.StartInfo.Arguments = string.Concat(string.Concat(utilProjects.GetPathDestinationSQL(FILE_CONFIG), "\\", NAME_BUILD, ".zip"), " ", (utilProjects.GetValueCompress(FILE_CONFIG) ? "1" : "0"), " ", FullPathOutClickOnce);
                Proc.StartInfo.UseShellExecute = true;

                Proc.Start();
                Proc.WaitForExit();
                if (Proc.ExitCode != 0)
                {
                    ShowNotify(1000, "Error on published project:PostPublish", ToolTipIcon.Error);
                }
                else
                {
                    ShowNotify(1000, "Published completed");
                }
                Proc.Close();
            }
            else
            {
                ShowNotify(1500, "Error on published", ToolTipIcon.Error);
            }
            pbProgress.Visible = false;
            FILE_SCRIPTS.Close();
            this.Cursor = Cursors.Default;
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            ClearElements();
            ConfigureGrid();
        }

        private void ShowNotify(int time, string msg, ToolTipIcon ico = ToolTipIcon.Info)
        {
            niNotify.ShowBalloonTip(time, "Generator ClickOnce", msg, ico);
            niNotify.Visible = true;
        }

        private void btLoadPrjConf_Click(object sender, EventArgs e)
        {
            LoadProject();
            if (!string.IsNullOrEmpty (FILE_CONFIG))
            {
            List<DtoFiles> collectionPrj = utilFiles.GetProjectsByPath(utilProjects.GetPathProjects(FILE_CONFIG));
            CollectionProjectToTreeView(collectionPrj);
            }
        }
    }
}