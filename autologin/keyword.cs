using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
namespace autologin
{
    public class keyword
    {
        private StreamReader readersave;

        public StreamReader ReaderSave
        {
            get
            {
                return readersave;
            }
            set
            {
                readersave = value;
            }
        }
        public string findkeyword(int len)
        {
            string keywords;
            while ((keywords = readersave.ReadLine()) != null)
            {
                if (keywords.Contains("__VIEWSTATE"))
                    break;
            }
            
            keywords = keywords.Substring(47);
            keywords = keywords.Substring(0, keywords.Length - 5);



            return keywords;

        }
    }
}
