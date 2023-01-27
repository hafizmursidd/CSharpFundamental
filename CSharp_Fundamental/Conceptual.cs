using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulConsept
{
    internal class Conceptual
    {

        public static void PassingValue(int x) {

            x *= 2;
            Console.WriteLine($"x value : {x}");
        }

        public static void PassingbyRef(ref int y) {

            y *= 2;
            Console.WriteLine($"Body Passing value by ref: {y}");
        }

        public static void ShowNullable() {

            //ref value type
            string? name = "Hello World";
            
            if (name == null)
                Console.WriteLine("Null Value");

            //variable value type

            int? age = null;

            if (age.HasValue)
                Console.WriteLine($"Age: {age}");
            else
                Console.WriteLine("Age is null value");
        }


        class Shape { }

        class Circle : Shape { }
        class Reactangle : Shape { }

        public static void IsOperator() {

            Circle circle = new Circle();
            Reactangle reactangle = new Reactangle();
            Console.WriteLine($"Is Circle inherit from Shape? : {circle is Shape}");
            Console.WriteLine($"Is Circle reactangel from Shape? : {reactangle is Shape}");

        }

        public static void AsOperator()
        {

            Shape shape = new Shape();
            Circle circle = new Circle();

            Shape? convertToShape = circle as Shape;

            Console.WriteLine($"Convertion \'circle as shape\' produce: {convertToShape}");


            Circle? convertToCircle = shape as Circle;

            if (convertToCircle == null)
                Console.WriteLine($"Convertion shape as circle produces null");
            else
                Console.WriteLine($"Convertion shape as circle produces {convertToCircle}");
            

        }

        


    }


    internal class Employee
    {

        public const decimal baseSalary = 1000_000;
        public readonly int _id = 111;

        public Employee(int id)
        {
            _id = id;
        }

        public int age { get; set; } = 10;

        public readonly List<int> myNums = new();

        public void AddNum(int num) {

            myNums.Add(num);
        }

        public void DisplayNums() {

            foreach (var item in myNums) {
                Console.WriteLine($" {item}");
            }
        }




        public static void UpdatePromo(double price, float promo,
            out decimal totalPrice, out decimal totalDiscount)
        {

            totalPrice = (decimal)((price * (promo / 100)) + price);
            totalDiscount = (decimal)(price - promo);
        }


    }
}
