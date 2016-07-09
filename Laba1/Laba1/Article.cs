using System;

public class Article
{
    public Person Author
    {
        get;
        private set;
    }
    public string Title
    {
        get;
        private set;
    }
    public double Rate
    {
        get;
        private set;
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
        return Author.ToShortString() +" "+ Title + Rate.ToString();
    }
}
