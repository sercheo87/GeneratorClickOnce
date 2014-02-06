using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilVersioningCO;

namespace UtilVersion
{
    public class UtilFiles
    {
        public UtilFiles()
        {
        }

        public List<DtoFiles> GetProjectsByPath(String path)
        {
            List<DtoFiles> collectionProjects = new List<DtoFiles>();
            string[] filePaths = Directory.GetFiles(path, "*.vbproj",SearchOption.AllDirectories);

            foreach (string file in filePaths)
            {
                DtoFiles project = new DtoFiles();
                project.PathFull = file.ToString().Trim();
                project.Path = Directory.GetParent(file).ToString();
                project.Name = Path.GetFileNameWithoutExtension(file);
                project.Type = Path.GetExtension(file).Replace(".","");

                collectionProjects.Add(project);
            }

            return collectionProjects;
        }
    }
}
