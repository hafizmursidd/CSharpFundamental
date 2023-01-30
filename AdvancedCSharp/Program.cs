using AdvancedCSharp.Delegate;
using AdvancedCSharp.Generic;
using AdvancedCSharp.Generic.Constraint;
using AdvancedCSharp.Generic.Interface;
using AdvancedCSharp.Lambda;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {

        //MyList.DisplayListString();
        //MyList.DisplayListInt();



        //Person <int> person = new Person<int>();
        //var a = person.DisplayInformation(12345);
        //Console.WriteLine("Person Int : "+a);

        ////Person <String> person2 = new ();
        ////var b = person2.DisplayInformation("Hello, From List Generic");
        ////Console.WriteLine("Person string : " + b);

        ////Person<char> person3 = new();
        ////var c = person3.DisplayInformation('c');
        ////Console.WriteLine("Person char : " + c);

        ////call interface
        //IVehicle<string> vehicle = new Car <string>();
        //string color = vehicle.GetColor("Maroon");

        //vehicle.InfoVehicle();
        //Console.WriteLine($"Color: {color}");



        ////generic constraint
        //Employee emp1 = new("Hafiz", 100_000);
        //Employee emp2 = new("Mursid", 200_000);
        //Employee emp3 = new("HafizMursid", 300_000);


        ////declare employee repo
        //EmployeeRepository<Employee> empRepository = new();
        //empRepository.AddEmployee(emp1);
        //empRepository.AddEmployee(emp2);
        //empRepository.AddEmployee(emp3);

        //empRepository.DisplayEmployee();

        ////create new object
        //EmployeeRepository<Person> empRepository2 = new();




        //call wtihout delegate

        //Console.WriteLine($"Call method without delegate, a+b: ={SampleDelegate.Sum(10,2)}");
        //Console.WriteLine($"Call method without delegate, a-b: ={SampleDelegate.Different(10, 2)}");

        ////call instance delegate types, then assign with method sum and differnce
        //calculate calc = SampleDelegate.Sum;
        //Console.WriteLine($"Sum delegate: {calc.Invoke(10,2)}");

        //calc = SampleDelegate.Different;
        //Console.WriteLine($"Different delegate: {calc.Invoke(10, 2)}");

        //int AddOne (int a, int b) => a+ b;
        //int MinusOne(int a, int b) => a - b;

        // Console.WriteLine($"call addOne Invoke: {new calculate(AddOne).Invoke(10,2)}");
        //Console.WriteLine($"call minusOne Invoke: {new calculate(MinusOne).Invoke(10, 2)}");
        //Console.WriteLine(AddOne);




        Console.WriteLine();
        //action, func predicate is pre-define generic delegate type
        //Action <param1, param2, . . . param 16>
        //action is used to call method void
        //Funct<out return>
        //Func < param1, param2, . . . param 16, out return>
        //Func is used to call method return


        //ex action Implementation

        //Action actionDel = SampleDelegate.Show1;
        //actionDel();

        ////with parameters action
        //Action <string>actionDel22 = SampleDelegate.Show22;
        //actionDel22("Hafiz Mursid");

        ////multidelegate or multichain delegate
        //Action<string> actionDel2 = SampleDelegate.Show2;
        //actionDel2 += SampleDelegate.Show3;             //concat delegate
        //actionDel2("Hafiz fafafa");

        //Action<string, int> actionDel3 = SampleDelegate.Show4;
        //actionDel3+= SampleDelegate.Show5;          //concat delegate with more than 1 parameters
        //actionDel3("Hafiz", 100);


        ////ex implement Func
        //Func<int, int, int> funcDelegate = SampleDelegate.Sum;
        //Console.WriteLine($"Funct delegate sum: {funcDelegate(12,134)}");

        //funcDelegate = SampleDelegate.Different;
        //Console.WriteLine($"Funct delegate diff: {funcDelegate(12, 12)}");

        //Func<int, int, int> funcChainDelegate = SampleDelegate.Sum;
        //funcChainDelegate += SampleDelegate.Different;
        //Console.WriteLine($"Func Chain Delegate di {funcChainDelegate(12,13)}");


        //Console.WriteLine();
        ////predicate: used t evaluate something with return value is Boolean
        //Predicate<int> isGreaterThan20 = SampleDelegate.TestGreaater20;
        //Console.WriteLine($"is 25 Greater than 20? {isGreaterThan20(25)}");
        //Console.WriteLine($"is 15 Greater than 20? {isGreaterThan20(15)}");


        Console.WriteLine();
        //Lambda is anonymous method, lambda is function oriented with always have return value

        //ex simple lambda
        var a = SimpleLambda.isEven(20);
        Console.WriteLine(a);
        var b = SimpleLambda.isEvenWithoutLambda(20);
        Console.WriteLine(b);

        int[] list = {1,2,3,4,5,6,7,8 };
        int totalEven = SimpleLambda.Count(list, SimpleLambda.isEven);
        Console.WriteLine($"Total Even : {totalEven}");

        int y = SimpleLambda.Count(list, x =>
        {
            Console.WriteLine(x);
            return x % 2 == 0;
        });


        int z = SimpleLambda.Count(list, x =>x %2 ==0);
        Console.WriteLine($"Total Even : {z}");

    }
}