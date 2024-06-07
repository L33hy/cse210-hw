using System;

public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;

    public Person(string firstName, string lastName)
    {
        _title = " ";
        _firstName = firstName;
        _lastName = lastName;
    }

    public string GetInformalSignature()
    {
        return "Thanks" + _firstName;
    }

    public string GetFormalSignature()
    {
        return "Sincerely" + _firstName + _lastName;
    }

    private string GetFullName()
    {
        return _firstName + " " + _lastName;
    }


}