namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");
        }
    }

    class Room
    //class for room creation
    {
        public string Title;
        public string Description;
        public Room North;
        public Room East;
        public Room South;
        public Room West;

        public Room(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
