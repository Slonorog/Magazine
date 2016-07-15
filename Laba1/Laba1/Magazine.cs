using System;


public class Magazine
{
    public Magazine(string t, Frequency p, DateTime d, int c, Article[] l)
    {
        Title = t;
        periodicity = p;
        date = d;
        circulation = c;
        list = l;
    }
    public Magazine()
    {
        Title = "None";//
        periodicity = Frequency.Never;
        date = new DateTime(1917, 10, 25);
        circulation = -1;
        list = new Article[1];
        list[0] = new Article();
    }

    public double ave_r
    {
        get
        {
            double ave = 0;
            foreach (Article l in list)
            {
                ave += l.Rate;
            }
            return ave / list.Length;
        }
    }

    public bool this[Frequency f]
    {
        get
        {
            return f == periodicity ? true : false;
        }
    }

    public void AddArticles(params Article[] l)//Надо тестить и искать другое решение.
    {
        Article[] temp = new Article[list.Length + l.Length-1];
        list.CopyTo(temp, 0);

        l.CopyTo(temp, 0);
        list = temp;

    }
    public override string ToString()
    {
        string output = string.Format("Название Журнала: {0}\nПериодичность:{1}\nДата выхода:{2} \nТираж:{3}\n"
            , Title
            , periodicity.ToString()
            , date.ToString()
            , circulation.ToString()
            );
        foreach (var a in list)
        {
            output += a.ToString()+'\n';
        }
        return output;
         
    }

    public virtual string ToShortString()
    {
        return string.Format("Название Журнала: {0} Периодичность:{1} Дата выхода:{2} Тираж:{3} Средний рейтинг статьи:{4}"
            , Title
            , periodicity.ToString()
            , date.ToString()
            , circulation.ToString()
            , ave_r.ToString());
    }
    public string Title
    {
        get;
        private set;
    }
    public Frequency periodicity
    {
        get;
        private set;
    }
    
    public DateTime date
    {
        get;
        private set;
    }
    public int circulation
    {
    get;
    private set;
    }
    public Article[] list
    {
        get;
        private set;
    }
  

}