namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
                new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
                new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
                new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
            };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var getAllStudents = classes.Select(s => s.Students).ToList().SelectMany(classroom => classroom).ToArray();
            return getAllStudents;
        }

        public class Classroom
        {
            public List<string> Students = new();
        }
    }
}
