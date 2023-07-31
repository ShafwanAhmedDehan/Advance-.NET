using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatagoryDataAL
{
    public interface DALInterface<CLASS, ID, RET>
    {
        List<CLASS> Get();
        CLASS Get(ID id);
        RET Create(CLASS obj);
        RET Delete(ID id);
        RET Update(CLASS obj, ID id);
    }
}
