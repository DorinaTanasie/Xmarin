using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.Modules
{
  public class Users
    {
         
        /// <summary>
        /// nu uita sa le faci private deoarece am facut o metoda care le seteaza si returneaza
        /// </summary>
        [PrimaryKey, AutoIncrement] // we will add a key to the clases that we want to save
        public int ID { get; set; }
        public string username { get; set; }
        public string pasword { get; set; }
        public string email { get; set; }
        public string ConfirmPassword { get; set; }
        public Users() { } //for database control later
        public Users(string username, string pasword) {
            this.username = username;
            this.pasword = pasword;
            

        }
        public Users(string username, string pasword, string email, string confirmPass)
        {
            this.username = username;
            this.pasword = pasword;
            this.email = email;
            this.ConfirmPassword = confirmPass;
            

        }
        public bool CheckInformation() //check if values are corectly set 
        {
            if (!this.username.Equals("") && !this.pasword.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
      
        public bool ConfirmPass(string confPass)
        {
            if (pasword == confPass)
            {
                return true;
            }
            else return false;
        }
       
    }
}
