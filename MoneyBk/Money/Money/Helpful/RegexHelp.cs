using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Money.Helpful
{
    class RegexHelp
    {
        public bool IsValidEmail(string email)
        {
            Regex expresion = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
          //  var expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            Match match = expresion.Match(email);
            if (match.Success)
                return true;
            else
                return false;

        }
        /// <summary>
        /// ([\w\.\-]+) - this is for the first-level domain (many letters and numbers, also point and hyphen)
        /// ([\w\-]+) - this is for second-level domain
        ///   ((\.(\w) { 2,3})+) - and this is for other level domains(from 3 to infinity) which includes a point and 2 or 3 literals
        /// </summary>
    }
}
