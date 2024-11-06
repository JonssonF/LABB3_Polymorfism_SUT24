namespace LABB3_Polymorfism_SUT24
{
    internal class Triangle : Geometry
    {
        public double triangleBase { get; set; }
        public double triangleHeight { get; set; }

        public Triangle(double triBase, double triHeight) // Constructor for when user creates a triangle. 
        {
            triangleBase = triBase;
            triangleHeight = triHeight;
        }

        public override double Area()
        {
            Console.Write("Area of Triangle : ");
            double triArea = triangleBase * triangleHeight / 2;
            return Math.Round(triArea, 2);

        }

        public override double Circumference()
        {
            double triSide = Math.Sqrt(Math.Pow(triangleBase / 2, 2) + Math.Pow(triangleHeight, 2));  //Calculates the side of an equilateral triangle.
            double circumference = triSide * 3;
            Console.Write("Perimiter of Triangle : ");
            return Math.Round(circumference, 2);

        }
    }
}
