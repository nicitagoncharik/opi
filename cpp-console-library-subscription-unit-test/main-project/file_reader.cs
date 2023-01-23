using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_project
{
    public class file_reader
    {
        public static int SizeMas(string filename)
        {
            try
            {
                int count = System.IO.File.ReadAllLines(filename).Length;
                return count;
            }
            catch
            {
                return 0;
            }
        }

        public static void Read(string filename, object[,] arr)
        {
            try
            {
                string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

                using (StreamReader stream = new StreamReader(filename))
                {
                    int i = 0;
                    int count = SizeMas(filename);

                    marafon.info[] information = new marafon.info[count];
                    marafon.time[] time = new marafon.time[count];


                    while (stream.Peek() >= 0)
                    {
                        string str = stream.ReadLine(); // читаем строку из файла 
                        string[] words = str.Split(' '); // разбиваем строку по словами 

                        information[i].num = Convert.ToInt32(words[0]);
                        information[i].fname = words[1];
                        information[i].lname = words[2];
                        information[i].mname = words[3];
                        time[i].start = words[4];
                        time[i].finish = words[5];
                        information[i].club = words[6];
                        
                        arr[i, 0] = information[i].num;
                        arr[i, 1] = information[i].fname;
                        arr[i, 2] = information[i].lname;
                        arr[i, 3] = information[i].mname;
                        arr[i, 4] = time[i].start;
                        arr[i, 5] = time[i].finish;
                        arr[i, 6] = information[i].club;

                        i++;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Файл не найден");
            }
        }
    }
}