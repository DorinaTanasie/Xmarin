using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using Money.Data;
using System.IO;
using Xamarin.Forms;
using Money.Droid.Data;
//this will let compiler to know to use this platform specific for interface
[assembly: Dependency(typeof(SQLite_Android))]

namespace Money.Droid.Data
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFullName= "User.db3"; //the place where we will save user data
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // here is made the connection
            var path = Path.Combine(documentPath, sqliteFullName);
            var connection = new SQLite.SQLiteConnection(path);
            return connection;
            
        }
       
    }
}