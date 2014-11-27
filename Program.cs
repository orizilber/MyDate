using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDate
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            Soldier[] soldiers = new Soldier[]
            {
                new Soldier(123456, "firher", new MyDate(1,1,1), new MyDate(1,1,1942), new MyDate(1,1,1948)),
                new Soldier(12345, "firher", new MyDate(1,1,1), new MyDate(1,1,1942), new MyDate(1,1,1948)),
                new Soldier(1234, "firher", new MyDate(1,1,1), new MyDate(1,1,1942), new MyDate(1,1,1948)),
                new Soldier(123, "firher", new MyDate(1,1,1), new MyDate(1,1,1947), new MyDate(1,1,1948)),
                new Soldier(12, "firher", new MyDate(1,1,1), new MyDate(1,1,1942), new MyDate(1,1,1948))
            };

            PrintSadir(soldiers);


        }

        public static void PrintSadir(Soldier[] soldiers)
        {
            for (int i = 0; i < soldiers.Length ; i++)
            {
                MyDate liber = soldiers[i].GetDateOfLiberation();
                MyDate enlis = soldiers[i].GetDateOfEnlistment();
                Console.WriteLine(liber.DeferenceBetween(enlis));
                //Console.WriteLine(soldiers[i].GetDateOfLiberation().DeferenceBetween(soldiers[i].GetDateOfEnlistment()));
            }
        }

        public static soliders[] LiberateSoldier(MyDate thisDate)
        {
            for(i=0 , i<soldiers.Length , i++)
            {
                if(soldiers[i].GetDateOfLiberation.DeferenceBetween(thisDate) <= 0 )
                {
                    soldiers[i] = null;

                }
            }
        }
    }
}
