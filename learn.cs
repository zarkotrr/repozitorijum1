using System.Numerics;

namespace LearnCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dobrodosli u C# playlistu");
            

            string name = "Marko";
            string lastName = "Dormer";

            //Console.WriteLine(name);
            //Console.WriteLine(lastName);

            int someNumber = 50;

            Console.WriteLine(someNumber);

            char someChar = 'Z';
            
            Console.WriteLine(someChar);

            Console.WriteLine("Karakter: " + someChar);

            name = "XXX";
            Console.WriteLine(name);

            const int voltage = 12;

            Console.WriteLine(voltage);
            //

             int number = 5;
 float fNumber = 5.521F;
 double dNumber = 10.23893483498D;
 long lNumber = 10000000000L;

string somestrng = "Some string";
 char zChar = 'Z';

 double sciNumber = 15.36E23D;

 /*
 Console.WriteLine(number);
 Console.WriteLine(fNumber);
 Console.WriteLine(dNumber);
 Console.WriteLine(lNumber);
 Console.WriteLine(somestrng);
 Console.WriteLine(zChar);
 Console.WriteLine(sciNumber);
 */


 Console.WriteLine("Vrednost: " + number + " Datatype: " + number.GetType());
 Console.WriteLine("Vrednost: " + fNumber + " Datatype: " + fNumber.GetType());
 Console.WriteLine("Vrednost: " + dNumber + " Datatype: " + dNumber.GetType());
 Console.WriteLine("Vrednost: " + lNumber + " Datatype: " + lNumber.GetType());
 Console.WriteLine("Vrednost: " + somestrng + " Datatype: " + somestrng.GetType());
 Console.WriteLine("Vrednost: " + zChar + " Datatype: " + zChar.GetType());
 Console.WriteLine("Vrednost: " + sciNumber + " Datatype: " + sciNumber.GetType());
