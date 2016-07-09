using System;



public class Person
{
    public string Fname
    {
        get { return Fname; }
        private set { Fname = value; }
    }
    public string Sname
    {
        get { return Sname; }
        private set { Sname = value; }
    }
    public DateTime Btime
    {
        get { return Btime; }
        private set { Btime = value; }
    }
    public int year
    {
        get { return Btime.Year; }
        // set { Btime.Year = value; } не работает, не смог разобраться
    }
    public Person(DateTime btime, string fname, string sname)
    {
        Fname = fname;
        Sname = sname;
        Btime = btime;
    }
    public Person(Person p)
    {
        Fname = p.Fname;
        Sname = p.Sname;
        Btime = p.Btime;
    }
    public Person()
    {
        Fname = "Illya";
        Sname = "Iorin";
        Btime = new DateTime(21, 10, 1996);
    }
    public override string ToString()
    {
        return Fname + Sname + Btime.ToString();
    }

    public virtual string ToShortString() // нету метода который надо переопределить
    {
        return Fname + Sname;
    }

}

