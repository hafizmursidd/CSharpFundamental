using AdvancedCSharp.Generic;
using AdvancedCSharp.Generic.Constraint;
using AdvancedCSharp.Generic.Interface;

internal class Program
{
    private static void Main(string[] args)
    {

        //MyList.DisplayListString();
        //MyList.DisplayListInt();



        //Person <int> person = new Person<int>();
        //var a = person.DisplayInformation(12345);
        //Console.WriteLine("Person Int : "+a);

        //Person <String> person2 = new ();
        //var b = person2.DisplayInformation("Hello, From List Generic");
        //Console.WriteLine("Person string : " + b);

        //Person<char> person3 = new();
        //var c = person3.DisplayInformation('c');
        //Console.WriteLine("Person char : " + c);

        //call interface
        IVehicle<string> vehicle = new Car <string>();
        string color = vehicle.GetColor("Maroon");

        vehicle.InfoVehicle();
        Console.WriteLine($"Color: {color}");



        //generic constraint
        Employee emp1 = new("Hafiz", 100_000);
        Employee emp2 = new("Mursid", 200_000);
        Employee emp3 = new("HafizMursid", 300_000);


        //declare employee repo
        EmployeeRepository<Employee> empRepository = new();
        empRepository.AddEmployee(emp1);
        empRepository.AddEmployee(emp2);
        empRepository.AddEmployee(emp3);

        empRepository.DisplayEmployee();

        //create new object
        EmployeeRepository<Person> empRepository2 = new();


    }
}