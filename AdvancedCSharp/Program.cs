using AdvancedCSharp.Generic;

internal class Program
{
    private static void Main(string[] args)
    {

        MyList.DisplayListString();
        MyList.DisplayListInt();



        Person <int> person = new Person<int>();
        var a = person.DisplayInformation(12345);
        Console.WriteLine("Person Int : "+a);

        Person <String> person2 = new ();
        var b = person2.DisplayInformation("Hello, From List Generic");
        Console.WriteLine("Person string : " + b);
    }
}