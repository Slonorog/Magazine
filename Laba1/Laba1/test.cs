using System;

public class Class
{
    static void Main(string[] args)
    {
      /*  Person[] Test1 = new Person[300 * 100];
        Person[,] Test2 = new Person[300,100];
        Person[][] Test3 = new Person[300][];
        for(int i = 0; i < Test3.Length; ++i)
        {
            Test3[i] = new Person[100];
        }*/
        Magazine Test = new Magazine();
        Console.WriteLine(Test.ToString());
        Console.ReadKey();
    }
   
}
