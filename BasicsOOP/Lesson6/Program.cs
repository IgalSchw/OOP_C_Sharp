using Lesson6.Methodical_Files;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Question 1-------------");

            BankAccount[] bankAccounts = new BankAccount[2];

            bankAccounts[0] = new BankAccount(50000.25, AccountType.Personal);
            bankAccounts[1] = new BankAccount(50000.24, AccountType.Personal);

            // first account
            //bankAccounts[0] = new BankAccount();
            //bankAccounts[0].AccountType = AccountType.Personal;
            //bankAccounts[0].Balance = 50000.25;

            Console.Write("Operator == ");
            Console.WriteLine(bankAccounts[0] == bankAccounts[0]);

            Console.Write("Operator != ");
            Console.WriteLine(bankAccounts[0] != bankAccounts[0]);

            Console.Write("Implementation of method equals");
            Console.WriteLine(bankAccounts[0].Equals(bankAccounts[0]));
            
            Console.WriteLine("Get HashCode= " + bankAccounts[0].GetHashCode());
            Console.WriteLine("Get HashCode= " + bankAccounts[1].GetHashCode());

            printAccounts(bankAccounts);

            Console.WriteLine("--------------Question 2-------------");

            Point circle = new Circle(10, 20, 5);

            circle.ColorFigure = Color.Red;
            circle.IsVisible = true;
            circle.X = 5;
            circle.Y = 10;

            circle.ChangeColor(Color.Green);

            circle.MoveHorizontal(10);
            circle.MoveVertical(5);


            Console.WriteLine("Figure: " + circle.GetType().Name);
            Console.WriteLine(circle.ToString());

            Console.WriteLine("Area of circle: " + circle.CalculateArea());

            Point rectangle = new Rectangle(5, 5);
            rectangle.ColorFigure = Color.Blue;
            rectangle.IsVisible = false;
            rectangle.MoveHorizontal(5);

            Console.WriteLine("Figure: " + rectangle.GetType().Name);
            Console.WriteLine(rectangle.ToString());

            Console.WriteLine("Area of rectangle: " + rectangle.CalculateArea());
            








            // from lesson
            #region Methodical

            /*
            Console.WriteLine("--------------------------------------------------");
            MotorVehicle car = new MotorVehicle();
            car.TankSize = 11;
            Console.WriteLine("Fuel: {0}g", car.FuelRemaining); // "0g"
            car.Refuel();
            Console.WriteLine("Fuel: {0}g", car.FuelRemaining); // "11g"
            Bicycle bike = new Bicycle();
            bike.RingBell();

            MySubclass mySubclass = new MySubclass();

            MySubclass test = new MySubclass(10);


        
            car.Indicate(true); // "Flashing left indicator" using virtual method in base class and ovveride this method in subclass
            bike.Indicate(true); // "Raising left arm"




            // Start from c# 9
            // List<int> ys = new(capacity: 10_000);

            /*
            Dictionary<int, List<int>> lookup = new()
            {
                [1] = new() { 1, 2, 3 },
                [2] = new() { 5, 8, 3 },
                [5] = new() { 1, 0, 4 }
            };
            */


            /*
            var a = new int[3] { 10, 20, 30 };
            var b = new int[] { 10, 20, 30 };
            var c = new[] { 10, 20, 30 };
            Console.WriteLine(c.GetType()); // output: System.Int32[]

            var example = new { Greeting = "Hello", Name = "World" };
            Console.WriteLine($"{example.Greeting}, {example.Name}!");
            Console.WriteLine(example.GetType());
            

            
            */

            #endregion

            #region lesson
            // exercise from the lesson
            /*

            Console.WriteLine("---------");

            Bar bar = new Bar();
            bar.DisplayName();
            bar.ShowDescription();

            Bar foo = new Foo();
            foo.DisplayName();
            foo.ShowDescription();

            Bar superFoo = new SupeFoo();
            superFoo.DisplayName();
            superFoo.ShowDescription();

            //List<GType> myList = new List<GType>();
            //myList.Add();

            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            // this class generic type receive only class method
            SafeMemList<SpecificationItem, List<SpecificationItem>> safeMemList = new FinalSafeMemList<SpecificationItem, List<SpecificationItem>>(new List<SpecificationItem>());

            SpecificationItem item1 = new SpecificationItem();
            item1.Id = 1;
            item1.Name = "Russia";

            SpecificationItem item2 = new SpecificationItem();
            item2.Id = 2;
            item2.Name = "Israel";

            safeMemList.Add(item1);
            safeMemList.Add(item2);

            SpecificationItem myValue = safeMemList.Get();
            */

            //item.Add(15);

            #endregion
        }


        // print all details from account and show implementation of ToString method
        public static void printAccounts(BankAccount[] accounts)
        {
            foreach (var item in accounts)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

