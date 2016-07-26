using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Edition
{
    string Name;
    DateTime Release;
    int Count;
     public string pName
    {
        get { return Name; }
        private set { Name = value; }
    }
    public DateTime pRelease
    {
        get { return Release; }
        private set { Release = value; }
    }
    public int pCount
    {
        get {return Count; }
        set { Count = value; }
    }

    public Edition(string name, DateTime release, int count)
    {
        Name = name;
        Release = release;
        Count = count;
    }
   public Edition()
    {
        Name = "";
        Release = new DateTime();
        Count = 0;
    }
    int circulation
    {
        get { return Count; }
        set
        {
            if (value < 0) throw new Exception("value < 0");
            Count = value;
        }
    }
    public virtual object DeepCopy()
    {
        return this;
    }
    public override int GetHashCode()
    {
        return Name.GetHashCode() + Release.GetHashCode() + Count.GetHashCode();
    }
    public override bool Equals(object obj)
    {
        if (obj.GetType() == this.GetType())
        {
            Edition buf = (Edition)obj;
            if (buf == this)
                return true;
        }
        return false;
    }
    public override string ToString()
    {
        return string.Format("Название:{0} Дата выхода: {1} Тираж: {2}"
            , Name
            , Release
            , Count);

    }
    public static bool operator ==(Edition e1,Edition e2)
    {
        if (e1.Name == e2.Name
            && e1.Release == e2.Release
            && e1.Count == e2.Count)
            return true;
        return false;
    }
    public static bool operator !=(Edition e1, Edition e2)
    {
        return !(e1 == e2);
    }
}


