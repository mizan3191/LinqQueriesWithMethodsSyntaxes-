using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueries
{
    public class Project
    {
        public int Id { get; set; }
        public int EmployeId { get; set; }
        public List<Employee> Employee { get; set; }
        public string ProjectName { get; set; }

        public static List<Project> projects = new List<Project>();

        public static void ProjectInfo()
        {
            projects.Add(new Project{ Id = 1, EmployeId = 1, ProjectName = "DataImporter" });
            projects.Add(new Project{ Id = 2, EmployeId = 1, ProjectName = "DataImporter" });
            projects.Add(new Project{ Id = 3, EmployeId = 2, ProjectName = "Devteam" });
            projects.Add(new Project{ Id = 4, EmployeId = 2, ProjectName = "Devteam" });
        }
    }
}