using System;



public class Person
{
    public string Fname
    {
        get;
        private set;
    }
    public string Sname
    {
        get;
        private set;
    }
    public DateTime Btime
    {
        get;
    
        private set ;
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
        Btime = new DateTime(1996,10,21);
    }
    // public override bool Equals(object obj)
    //{
    //return
    //}
    public override int GetHashCode()
    {
        return (Fname.GetHashCode()+Sname.GetHashCode()+Btime.GetHashCode()).GetHashCode();
    }
    public static bool operator ==(Person p, Person p1)
    {
        return p.Fname == p1.Fname
            && p.Fname == p1.Fname
            && p.Btime == p1.Btime;
    }
    public static bool operator !=(Person p, Person p1)
    {
        return !(p.Fname == p1.Fname);
    }
    public override string ToString()
    {
        return Fname +' '+ Sname +' '+ Btime.ToString();
    }

    public virtual string ToShortString() // нету метода который надо переопределить
    {
        return Fname +' '+ Sname;
    }

}

