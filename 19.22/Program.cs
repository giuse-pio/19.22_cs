namespace _19._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numreri = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                numreri.Add(random.Next(1, 101));
            }
            foreach (int n in numreri)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("--------------");
            numreri.Reverse();
            for (int i = 0; i < numreri.Count; i++)
            {
                Console.WriteLine(numreri[i]);
            }
        }
    }
}
