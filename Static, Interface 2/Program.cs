namespace Static__Interface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Mahir", "Musayev");
            Console.WriteLine($"Student 1 melumatlari: {student1}");

            Student student2 = new Student("Fuad", "Memmedov");
            Console.WriteLine($"Student 2 melumatlari: {student2}");
        }
    }
}
