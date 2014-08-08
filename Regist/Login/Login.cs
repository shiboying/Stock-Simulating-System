using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Login
{   
    public class Login
    {
        static string Lname,Lpwd;
        public static int UserLogin(string name,string pwd)
        {
            int  count = 0;
            FileStream fs = new FileStream("name.txt", FileMode.Open);
            //StreamReader fss = new StreamReader(fs);
            FileStream sf = new FileStream("pwd.txt", FileMode.Open);
            //StreamReader ssf = new StreamReader(sf);

            using (StreamReader fss = new StreamReader(fs))
            {
               Lname = fss.ReadToEnd();
            }
            using (StreamReader ssf = new StreamReader(sf))
            {
                Lpwd = ssf.ReadToEnd();
            }
            if (Lname.Contains(name) && Lpwd.Contains(pwd))
            {
                return -1;
            }
            else
            {
                return count;
            }
                
        }
    }
}
