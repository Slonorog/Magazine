using System;
using System.Collections;

public class Test
{
    static void magaz1() //1-th laba
    {
        Magazine Test = new Magazine();
        Console.WriteLine(Test.ToString());
        Console.WriteLine(Test[Frequency.Weekly]);
        Console.WriteLine(Test[Frequency.Monthly]);
        Console.WriteLine(Test[Frequency.Yearly]);
        Console.WriteLine(Test[Frequency.Never]);
        Test.AddArticles(
             new Article()
            , new Article()
            , new Article());
        Console.WriteLine(Test.ToString());
    }
    static void art() //сравнение массивов
    {
        Article[] Test1 = new Article[3000 * 1000];
        Article[,] Test2 = new Article[3000, 1000];
        Article[][] Test3 = new Article[3000][];
        int time = Environment.TickCount;

        for (int i = 0; i < Test1.Length; ++i)
        {
            Test1[i] = new Article();
            Test1[i].ToString();
        }
        Console.WriteLine("Веремя выполнения инициализации для одномерного массива 3000*1000: " + ((Environment.TickCount - time)).ToString());
        time = Environment.TickCount;
        for (int i = 0; i < 3000; ++i)
        {
            for (int j = 0; j < 1000; ++j)
            {
                Test2[i, j] = new Article();
                (Test2[i, j]).ToString();
            }
        }
        Console.WriteLine("Веремя выполнения инициализации для  массива [3000,1000]: " + ((Environment.TickCount - time)).ToString());
        for (int i = 0; i < Test3.Length; ++i)
        {
            Test3[i] = new Article[1000];
        }
        time = Environment.TickCount;
        for (int i = 0; i < 3000; ++i)
        {
            for (int j = 0; j < 1000; ++j)
            {
                Test3[i][j] = new Article();
                Test3[i][j].ToString();
            }
        }
        Console.WriteLine("Веремя выполнения инициализации для  массива [3000][1000]: " + ((Environment.TickCount - time)).ToString());
    }
    static void eq()// тест метода еквалс
    {
        Person k = new Person();
        Person k1 = new Person();
        Console.WriteLine(k.Equals(k1));
    }
    static void dc()
    {
        Magazine m = new Magazine();
        Console.WriteLine(m.DeepCopy());
        IRateAndCopi m1 = new Magazine();
        Console.WriteLine(m1.DeepCopy());
    }
    static void index()
    {
        Magazine a = new Magazine();
       bool k= a[Frequency.Monthly];
        Console.WriteLine(k);
        k = a[Frequency.Never];
        Console.WriteLine(k);
    }

    static void arrlist1()
    {
        ArrayList a1 = new ArrayList();
        a1.Add(1);
        a1.Add(2);
        foreach (var item in a1)
        {
            Console.WriteLine(item);
        }
        ArrayList a2 = (ArrayList)a1.Clone();
        foreach (var item in a2)
        {
            Console.WriteLine(item);
        }
        a2[0] = 100;
        foreach (var item in a1)
        {
            Console.WriteLine(item);
        }
    }
    static void arrlist2() 
    {
        ArrayList a1 = new ArrayList();
        a1.Add(new Person());
        foreach (var item in a1)
        {
            Console.WriteLine(item);
        }
        ArrayList a2 = (ArrayList)a1.Clone();
        foreach (var item in a2)
        {
            Console.WriteLine(item);
        }
        ((Person)a2[0]).Sname = "123";
        foreach (var item in a1)
        {
            Console.WriteLine(item);
        }
    }

    static void Main(string[] args)
    {
        arrlist2();
        Console.ReadKey();
    }
   
}
