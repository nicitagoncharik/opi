using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace main_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №1,2");
            Console.WriteLine("Вариант №1");
            Console.WriteLine("Автор: Никита Гончарик");
            

            Console.WriteLine("");

            string filename = "TextFile1.txt";
            int size = file_reader.SizeMas(filename);
            object[,] mas = new object[size, 7];

            //чтение информации из файла и запись в массив
            file_reader.Read(filename, mas);


            for (int i = 0; i < size; i++)
            {
                string num = mas[i, 0].ToString();
                string fname = mas[i, 1].ToString();
                string lname = mas[i, 2].ToString();
                string mname = mas[i, 3].ToString();
                string start = mas[i, 4].ToString();
                string finish = mas[i, 5].ToString();
                string club = mas[i, 6].ToString();

                Console.WriteLine("|" + num + " " + "|" + " " + fname + " " + "|" + " " + lname + " " + "|" + " " + mname + " " + "|" + " " + start + " " + "|" + " " + finish + " " + "|" + " " + club);

            }

            string filters;
            do
            {
                Console.Write("Выполнить фильтрацию данных? (yes/no): ");
                filters = Console.ReadLine();
                if (filters == "yes")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Какую фильтрацию выполнить?");
                    Console.WriteLine("1) По клубу");
                    Console.WriteLine("2) По времени");
                    Console.Write("Введите 1 или 2: ");
                    string n_filter = Console.ReadLine();

                    if (n_filter == "1")
                    {

                        for (int i = 0; i < size; i++)
                        {
                            if (Convert.ToString(mas[i, 6]) == "Спартак")
                            {
                                string num = mas[i, 0].ToString();
                                string fname = mas[i, 1].ToString();
                                string lname = mas[i, 2].ToString();
                                string mname = mas[i, 3].ToString();
                                string start = mas[i, 4].ToString();
                                string finish = mas[i, 5].ToString();
                                string club = mas[i, 6].ToString();

                                Console.WriteLine("|" + num + " " + "|" + " " + fname + " " + "|" + " " + lname + " " + "|" + " " + mname + " " + "|" + " " + start + " " + "|" + " " + finish + " " + "|" + " " + club);

                            }

                        }
                        Console.WriteLine("");
                    }

                    if (n_filter == "2")
                    {   

                        for (int i = 0; i < size; i++)
                        {
                            DateTime start1 = Convert.ToDateTime(mas[i, 4]);
                            DateTime finish1 = Convert.ToDateTime(mas[i, 5]);
                            TimeSpan raz = finish1.Subtract(start1);
                            TimeSpan time = new TimeSpan(2, 50, 00);
                            if (raz < time)
                            {
                                string num = mas[i, 0].ToString();
                                string fname = mas[i, 1].ToString();
                                string lname = mas[i, 2].ToString();
                                string mname = mas[i, 3].ToString();
                                string start = mas[i, 4].ToString();
                                string finish = mas[i, 5].ToString();
                                string club = mas[i, 6].ToString();

                                Console.WriteLine("|" + num + " " + "|" + " " + fname + " " + "|" + " " + lname + " " + "|" + " " + mname + " " + "|" + " " + start + " " + "|" + " " + finish + " " + "|" + " " + club);

                            }

                        }
                        Console.WriteLine("");
                    }

                }

                else if (filters != "yes" && filters != "no")
                {
                    Console.WriteLine("Команда не верная");
                }

                } while (filters != "no") ;


                Console.ReadKey();
            
        }
    }
}
