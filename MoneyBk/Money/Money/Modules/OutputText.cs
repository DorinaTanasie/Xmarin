using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.Modules
{
    class OutputText
    {
     public static  string NotMember = "No account yet? Create one";
     public static  string AlreadyMember = "Already a member? Login";
     public static  string EmailExists = "Email Already Exists";
     public static string error_pasMatch = "Password Does Not Matches";
     public static  string error_valid_email_password = "Wrong Email or Password";
        public static string SuccesLogin = "Succes login";
        public static string error_PwOrUsr_empty ="Not Succes login, username or pasword are empty";
    }
}
