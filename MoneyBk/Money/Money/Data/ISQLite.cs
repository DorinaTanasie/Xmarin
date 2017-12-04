using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Money.Data
{
   public interface ISQLite  //u use interface because we can make 3 methods of connections for IOS,Android and Windows 
    {
      SQLiteConnection  GetConnection();

       
    }
}
