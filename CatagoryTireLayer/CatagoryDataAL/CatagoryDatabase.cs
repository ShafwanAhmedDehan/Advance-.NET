using CatagoryDataAL.DataBase;
using CatagoryDataAL.DatabaseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatagoryDataAL
{
    public class CatagoryDatabase : DALInterface<Catagory, int, bool>
    {
        public bool Create(Catagory obj)
        {
            var db = new NewsCatagoryEntities();
            db.Catagories.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var db = new NewsCatagoryEntities();
            var data = Get(id);
            db.Catagories.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<Catagory> Get()
        {
            var db = new NewsCatagoryEntities();
            return db.Catagories.ToList();
        }

        public Catagory Get(int id)
        {
            var db = new NewsCatagoryEntities();
            var data = db.Catagories.Find(id);
            return data;
        }

        public bool Update(Catagory obj, int id)
        {
            throw new NotImplementedException();
        }
    }
}
