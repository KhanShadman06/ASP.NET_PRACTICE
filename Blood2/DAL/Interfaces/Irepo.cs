using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface Irepo<CLASS,ID,RESULT>
    {
        List<CLASS> Get();
        CLASS Get(ID id);
        RESULT Add(CLASS obj);

        bool Update (CLASS obj);
        bool Delete(ID id);




    }
}
