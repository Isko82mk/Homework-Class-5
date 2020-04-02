using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////drivers
            Driver driver1 = new Driver("Bob", 5);
            Driver driver2 = new Driver("Greg", 7);
            Driver driver3 = new Driver("Jill", 6);
            Driver driver4 = new Driver("Bob", 4);

            //cars
            Car car1 = new Car("Hyundai", 160, driver);
            Car car2 = new Car("Mazda", 180, aDriver);
            Car car3 = new Car("Ferrari", 360, aDriver);
            Car car4 = new Car("Porsche", 320, aDriver);

            ///////////////////////////////////////////////////////

            Console.WriteLine("Select two drivers by number:\n");
            Console.WriteLine("Select first driver\n");
            Console.WriteLine(
                "1.Bob\n" +
                "2.Greg\n" +
                "3.Jill\n" +
                "4.Anne\n");
            Console.WriteLine("Select first driver\n");
            int d1 = 0;
            bool isInteger1 = int.TryParse(Console.ReadLine(), out d1);
            Console.WriteLine("Select second driver\n");
            int d2 = 0;
            bool isInteger2 = int.TryParse(Console.ReadLine(), out d2);


            //Console.WriteLine($"{d1}{d2}"); ok 

            Console.WriteLine("Select two cars by number:");
            
            Console.WriteLine( 
                "1.Hyundai\n" +
                "2.Mazda\n" +
                "3.Ferrari\n" +
                "4.Porsche\n");

            Console.WriteLine("Select first car");
            int c1 = 0;
            bool isinteger3 = int.TryParse(Console.ReadLine(),out c1);


            Console.WriteLine("Select second car");
            int c2 = 0;
            bool isinteger4 = int.TryParse(Console.ReadLine(), out c2);

         
             




            Console.ReadLine();
        }

      




    }
}
