using Project_DAL.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DAL.Repos
{
    internal class DBObj
    {
        protected ProjectManagementEntities DB;

        protected DBObj()
        {
            DB = new ProjectManagementEntities();
        }
    }
}
