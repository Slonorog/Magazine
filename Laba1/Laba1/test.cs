using System;

public class Class
{
    static void magaz() //1-th laba
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


    static void Main(string[] args)
    {
        eq();
        Console.ReadKey();
    }
   
}
