using System;
using System.Collections;
using System.IO;

namespace Learning_place
{
    class Program
    {
        static void Main(string[] args)
        {
            int magistr = 0;
            int bakalavr = 0;
            ArrayList list = new ArrayList();
            int first_course = 0;
            int second_course = 0;
            int third_course = 0;
            int fourth_course = 0;
            int fifth_course = 0;
            int sixth_course = 0;
            DateTime td = DateTime.Now;
            Students_count(magistr, bakalavr, list, fifth_course, sixth_course);
            AgeSort();
            Stud18(first_course, second_course, third_course, fourth_course, fifth_course, sixth_course);
            Stud19(first_course, second_course, third_course, fourth_course, fifth_course, sixth_course);
            Stud20(first_course, second_course, third_course, fourth_course, fifth_course, sixth_course);
            Console.WriteLine(DateTime.Now - td);
        }
        public static void Stud18(int first_course, int second_course, int third_course, int fourth_course, int fifth_course, int sixth_course)
        {
            StreamReader sr = new StreamReader("..\\..\\..\\students_1.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    if (int.Parse(s[5]) == 18 & int.Parse(s[6]) == 1) first_course++;
                    if (int.Parse(s[5]) == 18 & int.Parse(s[6]) == 2) second_course++;
                    if (int.Parse(s[5]) == 18 & int.Parse(s[6]) == 3) third_course++;
                    if (int.Parse(s[5]) == 18 & int.Parse(s[6]) == 4) fourth_course++;
                    if (int.Parse(s[5]) == 18 & int.Parse(s[6]) == 5) fifth_course++;
                    if (int.Parse(s[5]) == 18 & int.Parse(s[6]) == 6) sixth_course++;
                }
                catch
                {

                }
            }
            Console.WriteLine("Среди 18-ти летних студентов" + " " + first_course + " " + "первого курса");
            Console.WriteLine(second_course + " " + "второго курса");
            Console.WriteLine(third_course + " " + "третьего курса");
            Console.WriteLine(fourth_course + " " + "четвёртого курса");
            Console.WriteLine(fifth_course + " " + "пятого курса");
            Console.WriteLine(sixth_course + " " + "шестого курса");
            sr.Close();
        }
        public static void Stud19(int first_course, int second_course, int third_course, int fourth_course, int fifth_course, int sixth_course)
        {
            StreamReader sr = new StreamReader("..\\..\\..\\students_1.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    if (int.Parse(s[5]) == 19 & int.Parse(s[6]) == 1) first_course++;
                    if (int.Parse(s[5]) == 19 & int.Parse(s[6]) == 2) second_course++;
                    if (int.Parse(s[5]) == 19 & int.Parse(s[6]) == 3) third_course++;
                    if (int.Parse(s[5]) == 19 & int.Parse(s[6]) == 4) fourth_course++;
                    if (int.Parse(s[5]) == 19 & int.Parse(s[6]) == 5) fifth_course++;
                    if (int.Parse(s[5]) == 19 & int.Parse(s[6]) == 6) sixth_course++;
                }
                catch
                {

                }
            }
            Console.WriteLine("Среди 19-ти летних студентов" + " " + first_course + " " + "первого курса");
            Console.WriteLine(second_course + " " + "второго курса");
            Console.WriteLine(third_course + " " + "третьего курса");
            Console.WriteLine(fourth_course + " " + "четвёртого курса");
            Console.WriteLine(fifth_course + " " + "пятого курса");
            Console.WriteLine(sixth_course + " " + "шестого курса");
            sr.Close();
        }
        public static void Stud20(int first_course, int second_course, int third_course, int fourth_course, int fifth_course, int sixth_course)
        {
            StreamReader sr = new StreamReader("..\\..\\..\\students_1.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    if (int.Parse(s[5]) == 20 & int.Parse(s[6]) == 1) first_course++;
                    if (int.Parse(s[5]) == 20 & int.Parse(s[6]) == 2) second_course++;
                    if (int.Parse(s[5]) == 20 & int.Parse(s[6]) == 3) third_course++;
                    if (int.Parse(s[5]) == 20 & int.Parse(s[6]) == 4) fourth_course++;
                    if (int.Parse(s[5]) == 20 & int.Parse(s[6]) == 5) fifth_course++;
                    if (int.Parse(s[5]) == 20 & int.Parse(s[6]) == 6) sixth_course++;
                }
                catch
                {

                }
            }
            Console.WriteLine("Среди 20-ти летних студентов" + " " + first_course + " " + "первого курса");
            Console.WriteLine(second_course + " " + "второго курса");
            Console.WriteLine(third_course + " " + "третьего курса");
            Console.WriteLine(fourth_course + " " + "четвёртого курса");
            Console.WriteLine(fifth_course + " " + "пятого курса");
            Console.WriteLine(sixth_course + " " + "шестого курса");
            sr.Close();
        }
        public static void AgeSort()
        {
            StreamReader sr = new StreamReader("..\\..\\..\\students_1.csv");
            ArrayList agelist = new ArrayList();
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    agelist.Add(s[5] + " " + s[1] + " " + s[0]);
                }
                catch
                {

                }
            }
            agelist.Sort();
            foreach (var v in agelist) Console.WriteLine(v);
            sr.Close();
        }
        public static void Students_count(int magistr, int bakalavr, ArrayList list, int fifth_course, int sixth_course)
        {
            StreamReader sr = new StreamReader("..\\..\\..\\students_1.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(s[1] + " " + s[0]);
                    if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;
                    if (int.Parse(s[6]) == 5) fifth_course++;
                    if (int.Parse(s[6]) == 6) sixth_course++;

                }
                catch
                {

                }
            }
            list.Sort();
            foreach (var v in list) Console.WriteLine(v);
            Console.WriteLine("Всего студентов: {0}", list.Count);
            Console.WriteLine("Магистров: {0}", magistr);
            Console.WriteLine("Бакалавров: {0}", bakalavr);
            Console.WriteLine("Студентов пятого курса {0}", fifth_course);
            Console.WriteLine("Студентов шестого курса {0}", sixth_course);
            fifth_course = 0;
            sixth_course = 0;
        }
    }
}
