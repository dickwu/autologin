using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autologin
{
    public class IsRight
    {
        string username;
        string passwd;

        public string UserName
        {
            set
            {
                username = value;
            }
        }
        public string PassWord
        {
            set
            {
                passwd = value;
            }
        }
        public bool isright()
        {
            if (username.Length == 10)
            {
                if (passwd == null || passwd.Length < 5)
                    return false;
                else
                    return true;
            }
            else
                return false;


        }
    }
}
