using System;

public class Person
{
    private int age;
    public Person(String name,int age)
	{
        Name = name;
        Age = age;
	}

    public string Name
    {
        get;
        set;
    }

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            age = (value > 0)? value :1;
        }
    }

    public override String toString()
    {
        return Name + "agé(e) de " + Age + "ans";
    }
}
