namespace LABB3_Polymorfism_SUT24.Superclass
{
    public class Square : Geometry
    {
        public double SquareLength { get; set; }

        public Square()
        {
            SquareLength = 6;
        }


        public override double Area()
        {
            Console.Write("Area of Square : ");
            return SquareLength * SquareLength;
        }

        public override double Circumference()
        {
            double circumference = SquareLength * 4;
            Console.Write("Perimiter of Square : ");
            return Math.Round(circumference, 2);
        }
    }
}
