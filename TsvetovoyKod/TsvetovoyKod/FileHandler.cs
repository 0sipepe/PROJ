using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TsvetovoyKod.Properties;
using System.Diagnostics;
using System.Resources;

namespace TsvetovoyKod
{
    public static class FileHandler
    {
        
        static FileHandler()
        {
            FromFile();
        }

        internal static void ToFile()
        {
            string toFile = "";
            for (int i = 0; i < User.users.Count - 1; i++)
            {               
                toFile += User.users[i].Name + ":" + User.users[i].Score + "\n";
            }
            toFile += User.users[User.users.Count - 1].Name + ":" + User.users[User.users.Count - 1].Score;
            //Console.WriteLine(toFile + "uuu");
            
            File.WriteAllText("Пользователи.txt", toFile);

        }
        internal static void Start() => Console.WriteLine("static class has been initialized");


        internal static void FromFile()
        {
            string a = File.ReadAllText("Пользователи.txt");
            string[] aa = a.Split('\n');
            for (int i = 0; i < aa.Length; i++)
            {
                string[] aaa = aa[i].Split(':');
                User user = new User(aaa[0], Convert.ToInt32(aaa[1]));
                User.users.Add(user);
            }
        }

}
}