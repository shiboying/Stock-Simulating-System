using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Regist
{
    public class Regist
    {
            public static void WriteName(string name)
            {
                FileStream fs = new FileStream("name.txt", FileMode.Append);
                StreamWriter fss = new StreamWriter(fs);
               // byte[] data = new UTF8Encoding().GetBytes(name);
                //fs.Write(data, 0, data.Length);
                fss.WriteLine(name);
                fss.Close();
                fs.Close();
            }


            public static void WritePwd(string pwd)
            {
                FileStream sf = new FileStream("pwd.txt", FileMode.Append);
                StreamWriter ssf = new StreamWriter(sf);
                //byte[] data = new UTF8Encoding().GetBytes(pwd);
                //sf.Write(data, 0, data.Length);
                ssf.WriteLine(pwd);
                ssf.Close();
                sf.Close();
            }
    }
    
}
