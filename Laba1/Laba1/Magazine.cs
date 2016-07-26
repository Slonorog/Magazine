using System;
using System.Collections;

public class Magazine : Edition, IRateAndCopi
{
    public override object DeepCopy()
    {
        Console.WriteLine("DeepCopy override");
        return new Magazine(this);
    }
    object IRateAndCopi.DeepCopy()
    {
        Console.WriteLine("DeepCopy interface");
        return new Magazine(this);
    }
    public Magazine(string t, Frequency p, DateTime d, int c, 
        Article[] _articleArray, 
        Person[] _personArray)
        : base(t, d, c)
    {
        Periodicity = p;
        ArticleList = new ArrayList();
        foreach (var item in _articleArray)
            ArticleList.Add( new Article(item));
        AuthorList = new ArrayList();
        foreach (var item in _personArray)
            AuthorList.Add(new Person(item));
    }
    public Magazine() : base()
    {
        Periodicity = Frequency.Never;
        ArticleList = new ArrayList();
        AuthorList = new ArrayList();
    }
    public Magazine(Magazine _m) : base(_m.pName, _m.pRelease, _m.pCount)
    {
        pPeriodicity = _m.pPeriodicity;
        _m.ArticleList.Clone();
    }
    public double ave_r
    {
        get
        {
            double ave = 0;
            foreach (Article l in ArticleList)
            {
                ave += l.pRate;
            }
            return ave / ArticleList.Count;
        }
    }

    public bool this[Frequency f]
    {
        get
        {
            return f == Periodicity ? true : false;
        }
    }
    public void AddArticles(params Article[] l)

    {
        foreach (var item in l)
        {
            ArticleList.Add(item);
        }

  }
    public override string ToString()
    {
        string output = string.Format("Название Журнала: {0}\nПериодичность:{1}\nДата выхода:{2} \nТираж:{3}\n"
            , pName
            , Periodicity
            , pRelease
            , pCount
            );
        foreach (var a in AuthorList)
        {
            output += a.ToString() + '\n';
        }
        foreach (var a in ArticleList)
        {
            output += a.ToString() + '\n';
        }
        return output;

    }

    public virtual string ToShortString()
    {
        return string.Format("Название Журнала: {0} Периодичность:{1} Дата выхода:{2} Тираж:{3} Средний рейтинг статьи:{4}"
            , pName
            , Periodicity
            , pRelease
            , pCount
            , ave_r);
    }

    
    private Frequency Periodicity;

    public Frequency pPeriodicity
    {
        get { return Periodicity; }
        private set { Periodicity = value; }
    }
    private ArrayList AuthorList;
    public ArrayList pAuthorList
    {
        get
        {
            return AuthorList;
        }
        private set
        {
            AuthorList = value;
        }
    }
    private ArrayList ArticleList;
    public ArrayList pArticleList
    {
        get { return ArticleList; }
        private set { ArticleList = value; }
    }



    public double Rating
    {
        get
        {
            return ave_r;
        }
    }

}