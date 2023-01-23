using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_project
{

    public class process
    {
        public TimeSpan test(string[,] mas)
        {
            int count = mas.GetLength(0);
            TimeSpan max = new TimeSpan(00, 00, 00);
            TimeSpan nol = new TimeSpan(00, 00, 00);
            for (int i = 0; i < count; i++)
            {
                DateTime start1 = Convert.ToDateTime(mas[i, 0]);
                DateTime finish1 = Convert.ToDateTime(mas[i, 1]);
                TimeSpan raz1 = finish1.Subtract(start1);

                if (max == nol)
                {
                    max = raz1;
                }
                else if (raz1 < max)
                {
                    max = raz1;
                }
                
                
            }

            return max;

        }
    }
}