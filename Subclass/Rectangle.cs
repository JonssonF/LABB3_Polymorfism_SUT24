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
            Console.Write("The area of the rectangle is : ");
            return RecLength * RecWidth;
        }

        public override double Circumference()
        {
            throw new NotImplementedException();
        }
    }
}
