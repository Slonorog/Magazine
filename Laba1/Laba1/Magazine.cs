﻿using System;


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
        Title += "None";
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
        Article[] temp = new Article[list.Length + l.Length];
        list.CopyTo(temp, 0);

        l.CopyTo(temp, 0);
        list = temp;

    }
    public override string ToString()
    {
        return Title 
            + periodicity.ToString() 
            + date.ToString()
            + circulation.ToString()
            +list.ToString();// test
    }

    public virtual string ToShortString()
    {
        return Title
            + periodicity.ToString()
            + date.ToString()
            + circulation.ToString()
            + ave_r.ToString();
    }
    public string Title
    {
        get { return Title; }
        private set { Title = value; }
    }
    public Frequency periodicity
    {
        get { return periodicity; }
        private set { periodicity = value; }
    }
    public DateTime date
    {
        get { return date; }
        private set { date = value; }
    }
    public int circulation
    {
        get { return circulation; }
        private set { circulation = value; }
    }
    public Article[] list
    {
        get { return list; }
        private set { list = value; }
    }

}