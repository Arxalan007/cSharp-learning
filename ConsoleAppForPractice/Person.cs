namespace ConsoleAppForPractice;

public class Person(int id, string name) : Human
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
}