using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using UtilVersion;

namespace UtilVersioningCO.UI.forms
{
    public partial class fr_preferences : Form
    {
        XmlDocument xmlDoc = new XmlDocument();
        UtilFiles utilFiles = new UtilFiles();

        public fr_preferences()
        {
            InitializeComponent();
            LoadPreferences();
        }

        private void LoadPreferences()
        {
            xmlDoc.Load(@"config/configuration.xml");
            XmlNodeList xNodeProjectsInstallers = xmlDoc.SelectNodes("/config/coprojects");
            setDbProjects(xNodeProjectsInstallers);

            XmlNode xNode;
            xNode = xmlDoc.SelectSingleNode("/config/general/folder_projects");
            txFolderProjects.Text = xNode.InnerText;

            xNode = xmlDoc.SelectSingleNode("/config/general/folder_installers");
            txFolderInstaller.Text = xNode.InnerText;

            xNode = xmlDoc.SelectSingleNode("/config/general/folder_out");
            txFolderOut.Text = xNode.InnerText;

            xNode = xmlDoc.SelectSingleNode("/config/general/folder_click_once");
            txFolderClickOnce.Text = xNode.InnerText;

            xNode = xmlDoc.SelectSingleNode("/config/general/folder_sql");
            txFolderSql.Text = xNode.InnerText;

            xNode = xmlDoc.SelectSingleNode("/config/general/zip");
            cbZip.Checked = bool.Parse(xNode.InnerText);

            xNode = xmlDoc.SelectSingleNode("/config/general/updateversiondll");
            cbVersionDll.Checked = bool.Parse(xNode.InnerText);

            xNode = xmlDoc.SelectSingleNode("/config/templates/sql");
            txTemplateSql.Text = xNode.InnerText;

            xNode = xmlDoc.SelectSingleNode("/config/general/auto_increment_version");
            cbVersionIncrement.Checked = bool.Parse(xNode.InnerText);

            List<DtoFiles> collectionPrj = utilFiles.GetProjectsByPath(txFolderProjects.Text);
            cbProjectName.DataSource = collectionPrj.AsEnumerable().Select(x => x.Name).ToList();
        }

        private void SavePreferences()
        {
            xmlDoc.Load(@"config/configuration.xml");
            XmlNodeList xNodeProjectsInstallers = xmlDoc.SelectNodes("/config/coprojects");

            foreach (XmlNode item in xNodeProjectsInstallers)
            {
                item.RemoveAll();
            }

            XmlNode parentElement = (XmlElement)xmlDoc.SelectNodes("/config/coprojects")[0];

            foreach (DataRow row in projectsDs.tbProjInstaller.Rows)
            {
                string prjName = row["ProjectName"].ToString();
                string prjInstaller = row["PathInstaller"].ToString();

                XmlNode project = xmlDoc.CreateNode(XmlNodeType.Element, "project", null);
                XmlAttribute atr = xmlDoc.CreateAttribute("id");
                atr.Value = prjName;
                project.Attributes.Append(atr);
                project.InnerText = prjInstaller;

                parentElement.AppendChild(project);
            }

            XmlNode xNode;
            xNode = xmlDoc.SelectSingleNode("/config/general/folder_projects");
            xNode.InnerText = txFolderProjects.Text.Trim();

            xNode = xmlDoc.SelectSingleNode("/config/general/folder_installers");
            xNode.InnerText = txFolderInstaller.Text.Trim();

            xNode = xmlDoc.SelectSingleNode("/config/general/folder_out");
            xNode.InnerText = txFolderOut.Text.Trim();

            xNode = xmlDoc.SelectSingleNode("/config/general/folder_click_once");
            xNode.InnerText = txFolderClickOnce.Text.Trim();

            xNode = xmlDoc.SelectSingleNode("/config/general/folder_sql");
            xNode.InnerText = txFolderSql.Text.Trim();

            xNode = xmlDoc.SelectSingleNode("/config/general/zip");
            xNode.InnerText = cbZip.Checked.ToString();

            xNode = xmlDoc.SelectSingleNode("/config/general/updateversiondll");
            xNode.InnerText = cbVersionDll.Checked.ToString();

            xNode = xmlDoc.SelectSingleNode("/config/templates/sql");
            xNode.InnerText = txTemplateSql.Text.Trim();

            xNode = xmlDoc.SelectSingleNode("/config/general/auto_increment_version");
            xNode.InnerText = cbVersionIncrement.Checked.ToString();

            xmlDoc.Save(@"config/configuration.xml");
        }

        private void txFolderOut_DoubleClick(object sender, EventArgs e)
        {
            if (fbdGetFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txFolderOut.Text = fbdGetFolder.SelectedPath;
            }
        }

        private void setDbProjects(XmlNodeList nodes)
        {
            projectsDs.tbProjInstaller.Clear();
            foreach (XmlNode item in nodes.Item(0).ChildNodes)
            {
                string attr = item.Attributes["id"].Value;
                string installer = item.InnerText.ToString();

                DataTable dt = projectsDs.tbProjInstaller;

                DataRow dtRow = dt.NewRow();
                dtRow["ProjectName"] = attr;
                dtRow["PathInstaller"] = installer;

                projectsDs.tbProjInstaller.Rows.Add(dtRow);
            }
            tbProjInstallerDataGridView.AutoResizeColumns();
            tbProjInstallerDataGridView.Columns[1].Width = 200;
        }

        private void gvProjectInstaller_Click(object sender, EventArgs e)
        {
            cbProjectName.SelectedIndex = cbProjectName.FindString(tbProjInstallerDataGridView.CurrentRow.Cells[1].Value.ToString());
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            SavePreferences();
            LoadPreferences();
        }

        private void tbProjInstallerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            tbProjInstallerBindingSource.EndEdit();
            SavePreferences();
            LoadPreferences();
        }

        private void pathInstallerTextBox_DoubleClick(object sender, EventArgs e)
        {
            fdFindProjectsInstallers.Filter = "Projects C#|*.csproj|Projects VB|*.vbproj";
            if (fdFindProjectsInstallers.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pathInstallerTextBox.Text = fdFindProjectsInstallers.FileName.Substring(txFolderInstaller.Text.Length + 1).ToString();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SavePreferences();
            LoadPreferences();
        }
    }
}
