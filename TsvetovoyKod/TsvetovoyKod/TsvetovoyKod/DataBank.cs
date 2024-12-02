using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TsvetovoyKod.Properties;
using System.Diagnostics;

namespace TsvetovoyKod
{
    public static class DataBank
    {
        internal static int ExactUser;
        internal static List<Users> users = new List<Users>();
        internal static string a;
        static DataBank()
        {
            //a = Resources.Пользователи;
            a = File.ReadAllText("E:\\TsvetovoyKod\\TsvetovoyKod\bin\\Debug\\Пользователи.txt");
            string[] aa = a.Split('\n');
            for (int i = 0; i < aa.Length; i++)
            {
                //Console.WriteLine(aa[i]);
                users.Add(MakeUser(aa[i]));
            }
            Console.WriteLine(users.Count);
        }

        internal static void ToFile()
        {
            for (int i = 0; i < users.Count; i++)
            {
                string toFile = users[i].Name + ":" + users[i].Score + "\n";
                File.WriteAllText("E:\\TsvetovoyKod\\TsvetovoyKod\bin\\Debug\\Пользователи.txt", toFile);
            }
        }



        public static int IsNew(string userName)
        {
            int mem = 0;
            for (int i = 0; i < users.Count; i++)
            {
                if (userName == "")
                {
                    mem = 3;
                    ExactUser = users.Count;
                }
                else
                {
                    if (users[i].Name == userName)
                    {
                        if (users[i].Score == 0)
                        {
                            ExactUser = i;
                            mem = 1;
                        }
                        else { mem = 0; }
                    }
                    else
                    {
                        ExactUser = users.Count;
                        mem = 2;
                    }
                }
            }
            return mem;
        }
        internal static Users MakeUser(string aa)
        {

            string[] aaa = aa.Split(':');
            Users user = new Users(aaa[0], Convert.ToInt32(aaa[1]));
            return user;

        }

        
    }
}