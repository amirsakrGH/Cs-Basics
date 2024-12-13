namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q01
            Console.WriteLine("Question01");
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number);
            #endregion

            #region Q02
            //Value Type
            Console.WriteLine("\n----------------------------------------------------------------------------\n");
            Console.WriteLine("Question02");
            short firstNumber = 15;
            short secondNumber ;

            secondNumber = firstNumber;
            Console.WriteLine("firstNumber: {0}",firstNumber);
            Console.WriteLine("secondNumber: {0}", secondNumber);

            ++firstNumber;
            Console.WriteLine("\nAfter Modifying\n");
            
            Console.WriteLine("firstNumber: {0}", firstNumber);
            Console.WriteLine("secondNumber: {0}", secondNumber);
            /*
             After incrementing firstNumber, no changes occur in secondNumber. 
             This happens because they are value types, meaning we are assigning the value of variables, 
              not their memory addresses.
             */
            #endregion

            #region Q03
            //Reference Type
            Console.WriteLine("\n----------------------------------------------------------------------------\n");
            Console.WriteLine("Question02");

            Point P01 = new Point();
            Point P02 = new Point();

            P01.x = 5;
            P02.x = 10;

            Console.WriteLine("P01.x: {0}\nP02.x: {1}", P01.x, P02.x);


            P02 = P01;//they share the same memory address

            Console.WriteLine("After Assigning:");
            Console.WriteLine("P01.x: {0}", P01.x);
            Console.WriteLine("P02.x: {0}", P02.x);

            P02.x = 45;

            Console.WriteLine("After Modifying P02:");
            Console.WriteLine("P01.x: {0}", P01.x);
            Console.WriteLine("P02.x: {0}", P02.x);

            /*
             After assigning two reference variables, they point to the same memory location in the heap
             */
            #endregion
        }
    }
}
