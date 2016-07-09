using System;

public class Article
{
    public Person Author
    {
        get { return Author; }
        private set { Author = value; }
    }
    public string Title
    {
        get { return Title; }
        private set { Title = value; }
    }
    public double Rate
    {
        get { return Rate; }
        private set { Rate = value; }
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
        return Author.ToShortString() + Title + Rate.ToString();
    }
}
