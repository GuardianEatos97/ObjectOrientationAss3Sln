namespace ObjectOrientationAss3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TvSpecs TV1 = new TvSpecs("Samsung", 50, 150, true, "Fior", "Black", false) ;

            Console.WriteLine($"The brand of the Tv is {TV1.BrandOfTv} and is {TV1.WidthOfTv}cm wide and {TV1.HeightOfTv}cm tall. The tv {TV1.Resolution}.");
            TV1.PowerButton();
        }
    }
}
