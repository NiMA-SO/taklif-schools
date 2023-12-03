using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_poodeman
{
    class Program
    {
        static void Main(string[] args)
        {
            //صحفه 61
            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i <= 30; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= number; i++)
            //{
            //    Console.WriteLine(i);
            //}












            //2

            //string[] name = new string[5];
            //string[] LastName = new string[5];
            //int[] nomre = new int[5];

            //string maxName;
            //float max = 0;

            //string minName;
            //float min = 0;

            //float avg = 0;

            //int j = 0;


            //Console.Write("Enter your Name number {0} :", j + 1);
            //name[j] = Console.ReadLine();

            //Console.Write("Enter your LastName number {0} :", j + 1);
            //LastName[j] = Console.ReadLine();

            //Console.Write("Enter your nomre number {0} :", j + 1);
            //nomre[j] = int.Parse(Console.ReadLine());

            //maxName = name[j] + " " + LastName[j];
            //minName = name[j] + " " + LastName[j];
            //max = nomre[j];
            //min = nomre[j];
            //avg += nomre[j];

            //for (int i = 1; i < name.Length; i++)
            //{
            //    Console.WriteLine();
            //    Console.Write("Enter your Name number {0} :", i + 1);
            //    name[i] = Console.ReadLine();

            //    Console.Write("Enter your LastName number {0} :", i + 1);
            //    LastName[i] = Console.ReadLine();

            //    Console.Write("Enter your nomre number {0} :", i + 1);
            //    nomre[i] = int.Parse(Console.ReadLine());

            //    if (nomre[i] > max)
            //    {
            //        maxName = name[i] + " " + LastName[i];
            //        max = nomre[i];
            //    }
            //    if (nomre[i] < min)
            //    {
            //        minName = name[i] + " " + LastName[i];
            //        min = nomre[i];
            //    }
            //    avg += nomre[i];
            //}

            //Console.WriteLine();

            //int count = 0;
            //foreach (string item in name)
            //{
            //    Console.WriteLine("{0}_Name & LastName = {1} {2} nomre = {3}", count + 1, item, LastName[count], nomre[count]);
            //    count++;
            //}
            //Console.WriteLine();

            //Console.WriteLine("max name = {0} == nomre {1} \nmin name = {2} == nomre {3}", maxName, max, minName, min);

            //float avge = avg / nomre.Length;
            //Console.WriteLine("average = {0}", avge);














            //3
            //string[] kalaName = new string[10] { "mous", "keyboard", "cooler", "flash", "hard", "cpu", "gpu", "mother board", "cd", "monitor" };
            //float[] price = { 100, 200, 500, 50, 600, 800, 700, 40, 50, 90 };
            //string forosh;
            //float max;
            //float min;

            //Console.WriteLine("if your have help print ( help )");

            //foreach (int allItem in price)
            //{
            //    Console.Write("enter your kala name for buy : ");
            //    forosh = Console.ReadLine();


            //    if (forosh == "help")
            //    {
            //        int i = 0;
            //        foreach (string item in kalaName)
            //        {
            //            Console.WriteLine(" {0} == {1}", item, price[i]);
            //            i++;
            //        }
            //    }
            //    for (int count = 0; count < kalaName.Length; count++)
            //    {
            //        if (forosh == kalaName[count])
            //        {
            //            Console.WriteLine("price = {0} ", price[count]);
            //        }

            //    }
            //}
            






            //4
            //int a = 10;
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("{0} + {1}",i,a);
            //    a--;
            //}



            //5
            /*
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
             */


            //6
            /*
            for (int i = 100; i <= 999; i++)
            {
                Console.WriteLine(i);
            }
             */



            //7
            /*
            Console.Write("fard :");
            for (int i = 1; i < 30; i+=2)
            {
                Console.Write("{0,5}",i);
            }
            Console.WriteLine(" ");
            Console.Write("zooj :");
            for (int a = 2; a < 30; a += 2)
            {
                Console.Write("{0,5}",a);
            }
            */


            /*
            8 & 9
            Console.WriteLine("4 ==");
            for (int i = 2; i <= 30; i += 2)
            {
                Console.WriteLine("{0,5}",i);
            }
            Console.WriteLine("5 ==");
            for (int a = 2; a <= 30; a++)
            {
                a++;
                Console.WriteLine("{0,5}", a);
            }

            */

            //10
            /*
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
             */


            //11
            /*
            for (int i = 0; i < 10; i+=3)
            {
                Console.WriteLine(i);
            }
            */


            //12
            /*
            for (int i = 10; i >= 0; i-=2)
            {
                Console.WriteLine(i);
            }
            */


            //13
            /*
            int a=10;
            int b = 1;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("goroh :{0}  ",b);
                Console.WriteLine("number   {0} & {1}",i,a);
                a--;
                b++;
            }
            */


            //14
            /*
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine("Hop");
                }
                else
                {
                    Console.WriteLine(i);
                }
                Console.Write("final i :"+i);
            }
             */
             

            //15
            /*
            int sum=0;
            int minute;
            for (int i = 1; i < 8; i++)
            {
                Console.WriteLine("please rate the day {0} enter in minutes =",i);
                minute = int.Parse(Console.ReadLine());
                sum += minute;
            }
            Console.WriteLine("you studied for {0} minutes a week", sum);
            */

            //16
            /*
            int sum = 0;
            int hours;
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("please rate the week {0} enter in hour =", i);
                hours = int.Parse(Console.ReadLine());
                sum += hours;
            }
            Console.WriteLine("you studied for {0} hours a month", sum);
            */


            //17
            /*
            int sum = 0;
            int hours;
            int i;
            for (i = 1; i <= 4; i++)
            {
                Console.WriteLine("please rate the week {0} enter in hour =", i);
                hours = int.Parse(Console.ReadLine());
                sum += hours;
            }
            sum /= i - 1;
            Console.WriteLine("avarage hours in month : {0} ", sum);
            */









            //18
            /*

            int score = 5;
            int month;
            Console.Write("enter number your month :");
            month = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 1; i <= 5; i++)
            {
                int guess;
                Console.Write("your guess?");
                guess = int.Parse(Console.ReadLine());
                if (guess == month) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("you win");
                    Console.WriteLine("your score: {0}",score);
                    break;
                }
                else
                {
                    score -= 1;
                    Console.WriteLine("try again  !");
                }
            }

            */




            //19
            //int hour;
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.Write("\nenter hour ");
            //int max = 0;
            //hour = int.Parse(Console.ReadLine());
            //max = hour;
            //while (hour > 0)
            //{
            //    if (hour > max)
            //        max = hour;
            //    Console.WriteLine("\n enter 0 for exit");
            //    Console.Write("enter hour:");
            //    hour = int.Parse(Console.ReadLine());


            //}
            //Console.WriteLine("max = {0}", max);




            //20
            //int hour;
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.Write("\nenter hour ");
            //int min = 0;
            //hour = int.Parse(Console.ReadLine());
            //min = hour;
            //while (hour > 0)
            //{
            //    if (hour < min)
            //        min = hour;
            //    Console.WriteLine("\n enter 0 for exit");
            //    Console.Write("enter hour:");
            //    hour = int.Parse(Console.ReadLine());


            //}
            //Console.WriteLine("max = {0}", min);




            //21
            //int hour;
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.Write("\nenter hour ");
            //int max = 0;
            //int min = 0;
            //hour = int.Parse(Console.ReadLine());
            //max = hour;
            //min = hour;


            //while (hour > 0)
            //{
            //    if (hour > max)
            //    {
            //        max = hour;
            //    }

            //    if (hour < min)
            //    {
            //        min = hour;
            //    }

            //    Console.WriteLine("\n enter 0 for exit");
            //    Console.Write("enter hour:");
            //    hour = int.Parse(Console.ReadLine());


            //}
            //Console.WriteLine("max = {0}", max);
            //Console.WriteLine("min = {0}", min);







            //24
            //int b = 1;
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write("{0,4}", i * 1);
            //    Console.Write("{0,4}", i * 2);
            //    Console.Write("{0,4}", i * 3);
            //    Console.Write("{0,4}", i * 4);
            //    Console.WriteLine();
            //}


            //25
            //for (int x = 0; x <= 25; x++)
            //{
            //    for (int y = 0; y <= 10; y++)
            //    {
            //        if (2000 * x + 5000 * y == 50000)
            //        {
            //            Console.WriteLine("x = {0} , y = {1}",x,y);
            //        }
            //    }
            //}




            //26
            //string[] week = {"shanbe","yek shanbe","do shanbe","seh shanbe","chehar shanbe","panj shanbe","jome"};
            //int count = 1;
            //while (count <= week.Length)
            //{
            //Console.Write("Enter the number day week (1-7) :");
            //byte num = byte.Parse(Console.ReadLine());
            //Console.WriteLine(week[num-1]);
            //count++;
            //}




            Console.ReadKey();
        }
    }
}
