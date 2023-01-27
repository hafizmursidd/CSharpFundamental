using UsefulConsept;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //Conceptual.ShowNullable();

        //int x = 10; //immutable

        //Conceptual.PassingValue(x);
        //Console.WriteLine($"on main program, Final value x: {x}");


        //int y = 20; //non immutable
        //Conceptual.PassingbyRef(ref y);
        //Console.WriteLine($"on main program, Final value for y : {y}");



        //Conceptual.IsOperator();
        //Conceptual.AsOperator();

        // decimal totalPrice;
        // decimal totalDiscount;

        //Employee.UpdatePromo(50_000, 1_000,out totalPrice, out totalDiscount);

        // Console.WriteLine("Total Price: "+totalPrice);
        // Console.WriteLine("Total Discount: " + totalDiscount);


        Employee em = new Employee(121);
        Console.WriteLine(em._id);


        em.AddNum(10);
        em.AddNum(11);
        em.AddNum(12);

        em.DisplayNums();
    }


}