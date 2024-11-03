using LABB3_Polymorfism_SUT24.Superclass;
using Rectangle = LABB3_Polymorfism_SUT24.Superclass.Rectangle;

namespace LABB3_Polymorfism_SUT24
{
    internal class Program   // Fredrik Jonsson SUT24
    {
        static void Main(string[] args)
        {

            List<Geometry> geometry = new List<Geometry>();

            //geometry.Add(new Rectangle());
            //geometry.Add(new Circle());
            //geometry.Add(new Square());

            Geometry rectangle = new Rectangle();
            Geometry circle = new Circle();
            Geometry square = new Square();

            geometry.Add(rectangle);
            geometry.Add(circle);
            geometry.Add(square);

            foreach(Geometry form in geometry)
            {
                Console.WriteLine(form.Area());
            }
            
            

            Console.ReadLine();
        }
    }
}
