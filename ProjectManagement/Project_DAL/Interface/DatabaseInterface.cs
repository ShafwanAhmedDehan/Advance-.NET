using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DAL.Interface
{
    public interface DatabaseInterface <CLASS, ID, RET>
    {
        List<CLASS> Get();
        RET Create(CLASS obj);
        CLASS Get(ID id);
        RET Delete(ID id);
    }
}
