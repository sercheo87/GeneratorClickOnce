using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace UtilVersion
{
    public class UtilProject
    {
        public UtilProject()
        {
        }

        public void UpdateVersion(string version, string pathXml)
        {
            try
            {
                if (!string.IsNullOrEmpty(version))
                {
                    string valueNew, valueOld, value;
                    Regex rgx;
                    MatchCollection matches;
                    XmlNode node;
                    var xmlDoc = new XmlDocument();
                    xmlDoc.Load(pathXml);

                    System.Xml.XmlNamespaceManager xmlmanager = new XmlNamespaceManager(xmlDoc.NameTable);
                    xmlmanager.AddNamespace("def", "http://schemas.microsoft.com/developer/msbuild/2003");

                    node = xmlDoc.SelectSingleNode("//def:PropertyGroup/def:ApplicationVersion", xmlmanager);
                    rgx = new Regex(@"(\w*)\.(\w*)\.(\w*)\.", RegexOptions.IgnoreCase);
                    matches = rgx.Matches(version);
                    valueNew = matches[0].ToString();
                    valueOld = node.InnerText;
                    value = rgx.Replace(valueOld, valueNew);
                    node.InnerText = value;

                    node = xmlDoc.SelectSingleNode("//def:PropertyGroup/def:ApplicationRevision", xmlmanager);
                    rgx = new Regex(@"(\w*)\.(\w*)\.(\w*)\.", RegexOptions.IgnoreCase);
                    value = rgx.Replace(version, "");
                    node.InnerText = value;

                    xmlDoc.Save(pathXml);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public String GetVersion(string pathXml, bool autoIncrement = false)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(pathXml);

            System.Xml.XmlNamespaceManager xmlmanager = new XmlNamespaceManager(xmlDoc.NameTable);
            xmlmanager.AddNamespace("def", "http://schemas.microsoft.com/developer/msbuild/2003");

            XmlNodeList xNodeRevision = xmlDoc.SelectNodes("//def:PropertyGroup/def:ApplicationRevision", xmlmanager);
            string vrRevision = xNodeRevision[0].InnerText.ToString();

            XmlNodeList xNodeVersion = xmlDoc.SelectNodes("//def:PropertyGroup/def:ApplicationVersion", xmlmanager);
            string vrVersion = xNodeVersion[0].InnerText.ToString();

            Regex rgx = new Regex(@".\%(.\w)", RegexOptions.IgnoreCase);
            string matches = rgx.Replace(vrVersion, "");

            //incremento automatico de la revision en 1
            if (autoIncrement)
            {
                if (string.IsNullOrEmpty(vrRevision))
                {
                    vrRevision = "0";
                }
                else
                {
                    vrRevision = (int.Parse(vrRevision) + 1).ToString();
                }
            }

            return string.Concat(matches, ".", vrRevision);
        }

        public string GetPathInstallers(string fileXml)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode xNode;
            string path_folder = string.Empty;
            string solution = string.Empty;

            xmlDoc.Load(fileXml);
            xNode = xmlDoc.SelectSingleNode("/config/general/folder_installers");
            if (xNode == null)
            {
                return null;
            }
            return xNode.InnerText;
        }

        public string GetPathProjects(string fileXml)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode xNode;
            string path_folder = string.Empty;
            string solution = string.Empty;

            xmlDoc.Load(fileXml);
            xNode = xmlDoc.SelectSingleNode("/config/general/folder_projects");
            if (xNode == null)
            {
                return null;
            }
            return xNode.InnerText;
        }

        public string GetPathProjectInstaller(string projectName, string fileXml)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode xNode;
            string path_folder = string.Empty;
            string solution = string.Empty;

            xmlDoc.Load(fileXml);
            xNode = xmlDoc.SelectSingleNode("/config/general/folder_installers");
            if (xNode == null)
            {
                return null;
            }
            path_folder = xNode.InnerText;


            xNode = xmlDoc.SelectSingleNode("/config/coprojects/project[@id='" + projectName + "']");
            if (xNode == null)
            {
                return null;
            }
            solution = xNode.InnerText;

            return Path.Combine(path_folder, solution);
        }

        public string GetPathDestination(string fileXml)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode xNode;
            string out_folder = string.Empty;
            string folderCO = string.Empty;

            xmlDoc.Load(fileXml);
            xNode = xmlDoc.SelectSingleNode("/config/general/folder_out");
            out_folder = xNode.InnerText;



            xNode = xmlDoc.SelectSingleNode("/config/general/folder_click_once");
            folderCO = xNode.InnerText;

            return Path.Combine(out_folder, folderCO);
        }

        public string GetPathDestinationSQL(string fileXml)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode xNode;
            string out_folder = string.Empty;
            string folderCO = string.Empty;

            xmlDoc.Load(fileXml);
            xNode = xmlDoc.SelectSingleNode("/config/general/folder_out");
            out_folder = xNode.InnerText;



            xNode = xmlDoc.SelectSingleNode("/config/general/folder_sql");
            folderCO = xNode.InnerText;

            return Path.Combine(out_folder, folderCO);
        }

        public bool SaveVersionDll(string fileXml)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode xNode;

            xmlDoc.Load(fileXml);
            xNode = xmlDoc.SelectSingleNode("/config/general/updateversiondll");

            return bool.Parse(xNode.InnerText.ToString());
        }

        public string GetTemplateScripts(string fileXml)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode xNode;

            xmlDoc.Load(fileXml);
            xNode = xmlDoc.SelectSingleNode("/config/templates/sql");

            if (xNode == null)
            {
                return null;
            }
            else
            {
                return xNode.InnerText.Trim();
            }
        }

        public string GetAssemblyName(string ProjectInstallerPath)
        {
            string fileAppConfig = Path.Combine(Directory.GetParent(ProjectInstallerPath).ToString(), "App.config");
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(fileAppConfig);

            XmlNode xNodeRevision = xmlDoc.SelectSingleNode("/configuration/appSettings/add[@key='mainAssemblyName']");
            if (xNodeRevision != null)
            {
                return xNodeRevision.Attributes["value"].Value.ToString();
            }
            else
            {
                return null;
            }
        }

        public bool GetValueCompress(string fileXml)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(fileXml);

            XmlNode xNodeRevision = xmlDoc.SelectSingleNode("/config/general/zip");
            if (xNodeRevision != null)
            {
                return bool.Parse(xNodeRevision.InnerText.ToString());
            }
            else
            {
                return false;
            }
        }

        public bool GetIncrementAutomatic(string fileXml)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(fileXml);

            XmlNode xNodeRevision = xmlDoc.SelectSingleNode("/config/general/auto_increment_version");
            if (xNodeRevision != null)
            {
                return bool.Parse(xNodeRevision.InnerText.ToString());
            }
            else
            {
                return false;
            }
        }
    }
}
