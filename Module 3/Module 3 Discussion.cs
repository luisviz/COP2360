
// An example of the class Test
Test.Message.Dump();

public class Test
{
  public const string Message = "Hello World";

// An example of the class Person 
  Person p = new Person ("Alice", "Jones");
p.Print();    // Alice Jones

class Person (string firstName, string lastName)
{
  public void Print() => Console.WriteLine (firstName + " " + lastName);
}
}
