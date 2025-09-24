namespace RPG_Game
{
    class Room
        // Room Defining
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


    class Program
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

        static Room SetUpMap()
        {
            // Room Creation
            Room StorageRoom = new Room(
               "A Storage Room",
               "You are in a cramped storage cabinet, the air is thick and dusty.");

            Room Entrance = new Room(
               "The Castle Entrance",
               "You are in a large room with a big staircase infront of you and a room to your right.");

            // Conecting Rooms Together
            StorageRoom.East = Entrance;
            Entrance.East = StorageRoom;

            // Sets Starting Room
            return Entrance;
        }

        static void DescribeRoom(Room room)
        // Movement Between Rooms
        {
            Console.WriteLine();
            Console.WriteLine(room.Title);

            Console.WriteLine("".PadLeft(room.Title.Length), '-');
            Console.WriteLine(room.Description);
            Console.WriteLine("".PadLeft(room.Title.Length), '-');

            Console.WriteLine("Exits: {0}{1}{2}{3}\n",
               room.North == null ? "" : "North ",
               room.East == null ? "" : "East ",
               room.South == null ? "" : "South ",
               room.West == null ? "" : "West");
        }
    }
}

