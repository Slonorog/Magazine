using System;

public class Article:  IRateAndCopi

{
    Person Author;
    public Person pAuthor
    {
        get { return Author; }
        private set { Author = value; }
    }
    string Title;
    public string pTitle
    {
        get { return Title; }
        private set { Title = value; }
    }
    double Rate;
    public double pRate
    {
        get { return Rate; }
        private set { Rate = value; }
    }
    public object DeepCopy()// to do
    {
        return new Article(this);
    }
    public double Rating { get {return Rate; } }

    
    public Article( Article _copy)
    {
        Author = new Person( _copy.Author);
        Title = _copy.Title;
        Rate = _copy.Rate;
    }
    public Article(Person a, string t, double r)
    {
        Author = new Person(a);
        Title = t;
        Rate = r;
    }
    public Article()
    {
        Author = new Person();
        Title = "None";
        Rate = 0.0f;
    }
    public override string ToString()
    {
        return string.Format("\tИмя автора:{0} \n\tНазвание статьи:{1} \n\tрейтинг:{2}"
           , Author.ToShortString()
           , Title
           , Rate.ToString());
    }
}
