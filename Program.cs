namespace Assignment_1_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room currentRoom = SetUpMap();
            string userChoice = "";

            while (userChoice != "q")
            {
                DescribeRoom(currentRoom);
                Console.Write("> ");
                userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "n":
                        if (currentRoom.North != null)
                            currentRoom = currentRoom.North;
                        break;
                    case "e":
                        if (currentRoom.East != null)
                            currentRoom = currentRoom.East;
                        break;
                    case "s":
                        if (currentRoom.South != null)
                            currentRoom = currentRoom.South;
                        break;
                    case "w":
                        if (currentRoom.West != null)
                            currentRoom = currentRoom.West;
                        break;
                    case "q":
                        Console.WriteLine("End of game");
                        break;
                    default:
                        Console.WriteLine("[n] North");
                        Console.WriteLine("[e] East");
                        Console.WriteLine("[s] South");
                        Console.WriteLine("[w] West");
                        Console.WriteLine("[q] Quit");
                        break;
                }
            }
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


    static Room SetUpMap()
    //function for setting up the rooms
    {
        Room Entrance = new Room(
            "The Castle Entrance",
            "You are in a large room with a big staircase infront of you and a room to your right.");

        Room StorageRoom = new Room(
            "A Small Storage Room",
            "You are in a cramped storage cabinet, the air is thick and dusty.");

        Entrance.East = StorageRoom;
        StorageRoom.West = Entrance

        return Entrance;
    }


    static void DescribeRoom(Room room)
    //function for room directions
    {
        Console.WriteLine();
        Console.WriteLine(room.Title);

        Console.WriteLine("".PadLeft(room.Title.Length), '-');
        Console.WriteLine(room.Description);
        Console.WriteLine("".PadLeft(room.Title.Length), '-');

        Console.WriteLine("Exits: {0}{1}{2}{3}\n",
            room.North == null ? "" : "North "
            room.East == null ? "" : "East "
            room.South == null ? "" : "South "
            room.West == null ? "" : "West ");
    }
}