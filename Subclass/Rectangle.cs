namespace LABB3_Polymorfism_SUT24.Superclass
{
    public class Rectangle : Geometry
    {

        public double RecLength { get; set; }
        public double RecWidth { get; set; }

        public Rectangle()
        {
            RecLength = 5;
            RecWidth = 7;
        }
        public override double Area()
        {
            Console.Write("Area of Rectangle : ");
            return RecLength * RecWidth;
        }

        public override double Circumference()
        {
            double circumference = RecLength * 2 + RecWidth * 2;
            Console.Write("Perimiter of Rectangle : ");
            return Math.Round(circumference, 2);
        }
    }
}
