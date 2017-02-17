using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob
{
    public class Bob
    {
        public static String Hey(String msg)
        {
            if (msg.Trim().Length ==0) {
                return "Fine. Be that way!";
            }
            else if (msg.Equals(msg.ToUpper()) && msg.Equals(msg.ToLower()))
            {
                return "Whoa, chill out!";
            } else if (msg[msg.Trim().Length - 1] == '?') {
                return "Sure.";
            }
            else
                return "Whatever.";
        }

        public static void Main(string[] args)
        {

        }
    }
}
