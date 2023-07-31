using Project_DAL.DataBase;
using Project_DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DAL.Repos
{
    internal class ProjectRepo :DBObj, DatabaseInterface<Project, int, bool>
    {
        public bool Create(Project obj)
        {
            DB.Projects.Add(obj);
            return DB.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var data = Get(id);
            DB.Projects.Remove(data);
            return DB.SaveChanges() > 0;
        }

        public List<Project> Get()
        {
            return DB.Projects.ToList();
        }

        public Project Get(int id)
        {
            var data = DB.Projects.Find(id);
            return data;
        }
    }
}
