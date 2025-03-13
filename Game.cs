using System;
using System.Media;

namespace DungeonExplorer
{
    // The main entry point of the game
    internal class Program
    {
        static void Main()
        {
            // Create a new game instance and start the game
            Game game = new Game();
            game.Start();
        }
    }

    // The Game class controls the overall game flow
    internal class Game
    {
        private Player player; // The player in the game
        private Room currentRoom; // The room the player is currently in

        // Constructor: Initializes the game by setting up the player and the first room
        public Game()
        {
            player = new Player("Explorer"); // Creating a player with a name
            currentRoom = new Room("Entrance Hall", "A dark, eerie entrance."); // Creating the starting room
        }

        // Starts the game loop
        public void Start()
        {
            bool playing = true; // Game is running until the player exits
            Console.WriteLine("Welcome to Dungeon Explorer!");
            Console.WriteLine("Type 'exit' to quit.");

            while (playing)
            {
                // Display the current room details
                Console.WriteLine($"You are in {currentRoom.Name} - {currentRoom.Description}");
                Console.Write("Enter command: ");
                string input = Console.ReadLine().ToLower();

                // Handle user input
                if (input == "exit")
                {
                    playing = false; // Stop the game loop
                    Console.WriteLine("Thanks for playing!");
                }
                else
                {
                    Console.WriteLine("Unknown command. Try again.");
                }
            }
        }
    }

    // The Player class represents the player in the game
    internal class Player
    {
        public string Name { get; } // Player's name (read-only)

        // Constructor: Creates a player with a given name
        public Player(string name)
        {
            Name = name;
        }
    }

    // The Room class represents a room in the game
    internal class Room
    {
        public string Name { get; } // Room name (read-only)
        public string Description { get; } // Room description (read-only)

        // Constructor: Creates a room with a name and description
        public Room(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
