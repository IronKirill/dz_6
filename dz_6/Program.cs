using SevenWonders;

namespace dz_6
{
    public class Program
    {
        static void Main(string[] args)
        {
            var wonders = new object[]
            {
                new EgyptianPyramids(),
                new HangingGardens(),
                new StatueOfZeus(),
                new TempleOfArtemis(),
                new MausoleumAtHalicarnassus(),
                new ColossusOfRhodes(),
                new LighthouseOfAlexandria()
            };

            Console.WriteLine("The Seven Wonders of the Ancient World:");
            Console.WriteLine();
            
            foreach (var i in wonders)
            {
                var j = i.GetType().GetMethod("getDescription");

                if (j != null)
                {
                    var description = j.Invoke(i, null);
                    Console.WriteLine($"{description}");
                }
            }
        }
    }
}
