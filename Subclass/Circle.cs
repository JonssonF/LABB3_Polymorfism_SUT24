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
            Console.Write("The area of the circle is : ");
            return Radius * Radius * Pi;
            
        }

        public override double Circumference()
        {
            throw new NotImplementedException();
        }

    }
}
