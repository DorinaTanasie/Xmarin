using Money.Modules;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Money.Data
{
   public class UserDatabaseControler
    {
        //in this class we will made the conection from the database and add tables for objects
        // we will gat a platform specific code usin independence server
        // then we will use create table with user object as type, this will create the table in DB if table already exists nothing will happem 
        static object locker = new object();
        SQLiteConnection database;
        public UserDatabaseControler()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Users>();
        }
        public Users GetUser()
        {
            lock (locker)
            {
                if (database.Table<Users>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<Users>().First();

                }

            }


        }
        public int SaveUser(Users user)
        {
            lock (locker)
            {
                if (user.ID != 0)
                {
                    database.Update(user);
                    return user.ID;


                }
                else
                {
                    return database.Insert(user);

                }

            }

        }
        public int DeleteUser(int id)
        {
            lock (locker)
            {
                return database.Delete<Users>(id);

            }


        }

    }
}
