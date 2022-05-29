using System;
using System.IO;
using System.Collections.Generic;

namespace Criptografia
{
    internal class Database
    {
        public static void SaveData(string[] users, string[] passwords)
        {
            if (users != null || passwords != null)
            {
                try
                {
                    string folderPath = @"C:\Backup";
                    if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);
                    StreamWriter writer = new StreamWriter(@"C:\Backup\database_scs.txt");

                    for (int count = 0; count < users.Length; count++)
                    {
                        writer.WriteLine(users[count].ToString() + '|' + passwords[count].ToString());
                    }

                    writer.Close();
                }
                catch { }
            }
        }

        public static void LoadData(string[] users, string[] passwords)
        {
            if (users == null || passwords == null)
            {
                try
                {
                    List<string> usuarios = new List<string>();
                    List<string> senhas = new List<string>();

                    StreamReader reader = new StreamReader(@"C:\Backup\database_scs.txt");
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        string[] content = line.Split('|');
                        usuarios.Add(content[0]);
                        senhas.Add(content[1]);
                        line = reader.ReadLine();
                    }

                    MainMenu.users = usuarios.ToArray();
                    MainMenu.passwords = senhas.ToArray();
                    reader.Close();
                }
                catch { }
            }
        }
    }
}
