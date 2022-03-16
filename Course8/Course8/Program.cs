namespace Course8
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            Console.Write("How many studants for course A? ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                int studant = int.Parse(Console.ReadLine());
                set.Add(studant);
            }
            Console.Write("How many studants for course B? ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < b; i++)
            {
                int studant = int.Parse(Console.ReadLine());
                set.Add(studant);
            }
            Console.Write("How many studants for course C? ");
            int c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++)
            {
                int studant = int.Parse(Console.ReadLine());
                set.Add(studant);
            }
            Console.WriteLine("Total studants: " + set.Count);
        }
    }
}