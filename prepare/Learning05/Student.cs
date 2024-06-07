// a class that inherits from Person
public class Student : Person
{
    private string _number;

    public Student(string name, string number) : base(name)
    {
        _number = number;
    }

    public string GetNumber()
    {
        return _number;
    }
}