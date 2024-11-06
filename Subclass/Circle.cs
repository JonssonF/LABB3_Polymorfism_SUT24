namespace LABB3_Polymorfism_SUT24.Superclass
{
    public class Circle : Geometry
    {

        public double Radius { get; set; } = 4;
        public double Pi = Math.PI;
        
        public Circle()
        {
            Radius = 4;
        }


        public override double Area()
        {
            Console.Write("Area of Circle : ");
            double circleArea = Radius * Radius * Pi;
            return Math.Round(circleArea, 2);
            
        }

        public override double Circumference()
        {
            double diameter = Radius + Radius;
            double circumference = diameter * Pi;
            Console.Write("Circumference of Circle : ");
            return Math.Round(circumference, 2);
            
        }

    }
}
