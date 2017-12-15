using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    class BO
    {
        
        public static void Delete(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
        }
        public static void WriterPlayers(string filename, params object[] par)
        {
            FileStream file;
            if (File.Exists(filename))
            {
                file = new FileStream(filename, FileMode.Append, FileAccess.Write);
            }
            else
            {
                file = new FileStream(filename, FileMode.Create, FileAccess.Write);
            }
            StreamWriter sWriter = new StreamWriter(file, Encoding.UTF8);
            for (int i = 0; i < par.Length; i++)
            {
                sWriter.WriteLine(par[i]);

            }

            sWriter.Flush();
            sWriter.Close();
            file.Close();

        }
        public static void Ghimang(string filename, int[,] M)
        {
            FileStream file;
            if (File.Exists(filename))
            {
                file = new FileStream(filename, FileMode.Truncate, FileAccess.Write);
            }
            else
            {
                file = new FileStream(filename, FileMode.Create, FileAccess.Write);
            }
            StreamWriter sWriter = new StreamWriter(file, Encoding.UTF8);
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    sWriter.Write(M[i, j]);
                }
                sWriter.WriteLine();
            }
            sWriter.Write(M[9, 0]);
            sWriter.Write(M[9, 1]);
            sWriter.Flush();
            sWriter.Close();
            file.Close();

        }
        public static int DocMang(string filename, int[,] M)
        {
            int i = 0, j = 0;
            string s;
            if (!File.Exists(filename))
            {
                return 0;
            }
            else
            {
                FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read);
                StreamReader read = new StreamReader(file, Encoding.UTF8);
                while (read.Peek() != -1)
                {
                    if (j == 18 && i < 9)
                    {
                        i++;
                        j = 0;
                        s = read.Read().ToString();
                        s = read.Read().ToString();
                    }
                    if (i < 9) M[i, j++] = Int32.Parse(read.Read().ToString()) - 48;
                    if (i == 9)
                    {
                        M[i, j++] = Int32.Parse(read.Read().ToString()) - 48;
                    }
                }
                read.Close();
                file.Close();
            }
            return 1;
        }

        public static void ReadPlayers(string filename, List<player> pl)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File khong ton tai");
            }
            else
            {
                FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read);
                StreamReader read = new StreamReader(file, Encoding.UTF8);
                while (read.Peek() != -1)
                {

                    player a = new player();
                    a.Name = read.ReadLine();
                    a.Time = int.Parse(read.ReadLine());

                    pl.Add(a);
                }
                read.Close();
                file.Close();
                pl.Reverse();
            }
        }


    }
}
