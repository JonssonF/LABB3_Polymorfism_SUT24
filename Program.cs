using LABB3_Polymorfism_SUT24.Superclass;
using Rectangle = LABB3_Polymorfism_SUT24.Superclass.Rectangle;

namespace LABB3_Polymorfism_SUT24
{
    internal class Program   // Fredrik Jonsson SUT24
    {
        // Static List and shapes to be reached in the whole program.
        static List<Geometry> geometry = new List<Geometry>();
        static Geometry rectangle = new Rectangle();
        static Geometry circle = new Circle();
        static Geometry square = new Square();
        static int triMax = 0; // Limits the user to only make one triangle.
        

        static void Main(string[] args)
        {
            // Adds the ready shapes to the Geometry list.
            geometry.Add(rectangle);
            geometry.Add(circle);
            geometry.Add(square);
            
            DisplayMenu();

        }
        
        public static void DisplayMenu()
        {
            Console.WriteLine("Alright, im done with the Circle, Square & Rectangle,\ngo and check them out or you can build the triangle for me.\n");

            while (true) // Loop so the program can handle wrong inputs.
            {
                Console.WriteLine(
                    "1. Area:\n" +
                    "2. Circumference / Perimiter:\n" +
                    "3. Build a triangle:\n" +
                    "4. Exit Program.");

                string userChoice = Console.ReadLine();
                if (Int32.TryParse(userChoice, out int userOut)) // Tries user input.
                {
                    switch (userOut)
                    {
                        case 1:
                            Area();                           
                            break;
                        case 2:
                            Circumference();                           
                            break;
                        case 3:
                            BuildTriangle();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Thanks for using my program.");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid input, make sure you write a number between 1-4.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, make sure you write a number between 1-4.");
                }

            }
        }
        
        public static void Area()
        {
            Console.Clear();            
            

            foreach (Geometry form in geometry) // A loop that iterates through the list and uses the 'Geometry' method 'area'. 
            {
                Console.WriteLine(form.Area());
            }
            if (triMax <= 0) Console.WriteLine("**TRIANGLE SPOT**");
            Console.Write("\nPress any key to go back.");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Circumference()
        {
            Console.Clear();           
            foreach (Geometry form in geometry) // A loop that iterates through the list and uses the 'Geometry' method 'circumference'.
            {
                Console.WriteLine(form.Circumference());
            }
            if (triMax <= 0) Console.WriteLine("**TRIANGLE SPOT**");
            Console.Write("\nPress any key to go back.");
            Console.ReadKey();
            Console.Clear();
        }
        
        public static void BuildTriangle()
        {
            Console.Clear();

            triMax++;
            if (triMax >= 2) 
            {
                Console.WriteLine("In this program you can only make 1 triangle.");
                Thread.Sleep(2000);
                Console.Clear();
                return;
            }  
            double triBase = 0;
            while (true)
            {
                Console.Write("Set the base of the triangle: ");
                string userChoice = Console.ReadLine();
                if (Double.TryParse(userChoice, out triBase))
                {
                    if (triBase < 0)
                    {
                        Console.WriteLine("Invalid input, make sure you write a positive number.");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, make sure you write a positive number.");
                }
            }
                Console.Write($"Base: {triBase}\n" +
                    $"Now set the height:  ");
                while (true)
                {
                    double triHeight = 0;
                    string userHeight = Console.ReadLine();
                    if (Double.TryParse(userHeight, out triHeight))
                    {
                        if (triHeight < 0)
                        {
                            Console.WriteLine("Invalid input, make sure you write a number greater than 0.");
                        }
                        else
                        {
                            Geometry triangle = new Triangle(triBase, triHeight);
                            geometry.Add(triangle);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, make sure you write a number.");
                    }
                }
            Console.Clear();
            
        }

    }
}
