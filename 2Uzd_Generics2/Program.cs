namespace _2Uzd_Generics2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FourSideGeometricFigure fourSideGeometricFigure = new FourSideGeometricFigure("kvadratas" , 2, 5);
            Console.WriteLine($"figura 1: {fourSideGeometricFigure}");


            Generator<FourSideGeometricFigure> generator = new ();
            generator.Show(fourSideGeometricFigure);


        }
    }
}