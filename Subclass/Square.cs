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
            Console.Write("The area of the square is : ");
            return SquareLength * SquareLength;
        }

        public override double Circumference()
        {
            throw new NotImplementedException();
        }
    }
}
