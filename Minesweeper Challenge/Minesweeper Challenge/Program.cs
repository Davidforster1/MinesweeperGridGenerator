using System;

namespace Minesweeper_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, collumns, mines; // initialises the number of rows, collumns, mines and 

            Console.WriteLine("Please enter the number of rows followed by the number of collumns, then mines:");

            rows = Convert.ToInt32(Console.ReadLine()); // user enters rows, collumns and mines
            collumns = Convert.ToInt32(Console.ReadLine());
            mines = Convert.ToInt32(Console.ReadLine());

            rows += 2; collumns += 2; // attempting to validate edges of by adding extra grid

            string[,] grid = new string[rows, collumns]; // array initialisation 

            buildGrid(grid, rows, collumns, mines); // builds the grid with mines 
            checkMines(grid, rows, collumns, mines); // checks grid for mines to generate clues
            displayGrid(grid, rows, collumns); // displays the grid via console output
        }

        static void buildGrid(string[,] grid, int rows, int collumns, int mines) // populates array with mines to begin with
        {
            int number; // stores the randomly generated number
            int counter = 0; // counters number of times a mine spawns

            Random rand = new Random(); // randomly generates number

            for (int i = 1; i < rows - 1; i++) // loops through the array 
            {
                for (int j = 1; j < collumns - 1; j++) // loops through the array 
                {
                    number = rand.Next(0, 4); // RNG for mine generation

                    if (number == 0 && counter < mines) // spawns mines until entered ammount 
                    {
                        grid[i, j] = "x";
                        counter++;
                    }
                }
            }
        }

        static void checkMines(string[,] grid, int rows, int collumns, int mines) // checks for number of nearby mines
        {
            string arrayValue; // used to store minefounds variable as string
            int foundMine = 0;

            for (int i = 1; i < rows - 1; i++) // loops through the array 
            {
                for (int j = 1; j < collumns - 1; j++) // loops through the array 
                {
                    if (i - 1 >= 0 && j - 1 >= 0 || i + 1 < rows && j + 1 < collumns) // if calculation doesnt go out of bounds, 
                    {
                        if (grid[i - 1, j] == "x")
                        {
                            foundMine++;
                        }
                        else if (grid[i - 1, j - 1] == "x")
                        {
                            foundMine++;
                        }
                        else if (grid[i - 1, j + 1] == "x")
                        {
                            foundMine++;
                        }
                        else if (grid[i, j - 1] == "x")
                        {
                            foundMine++;
                        }
                        else if (grid[i, j + 1] == "x")
                        {
                            foundMine++;
                        }
                        else if (grid[i + 1, j - 1] == "x")
                        {
                            foundMine++;
                        }
                        else if (grid[i + 1, j] == "x")
                        {
                            foundMine++;
                        }
                        else if (grid[i + 1, j + 1] == "x")
                        {
                            foundMine++;
                        }

                        if (grid[i, j] != "x")
                        {
                            arrayValue = foundMine.ToString(); // mines found to string
                            grid[i, j] = arrayValue; // mines found placed in array
                            foundMine = 0; // resets mines found 
                        }
                    }
                }
            }
        }

        static void displayGrid(string[,] grid, int rows, int collumns) // displays the minesweeper grid
        {
            for (int i = 1; i < rows - 1; i++) // loops through the array 
            {
                for (int j = 1; j < collumns - 1; j++) // loops through the array 
                {
                    Console.Write(string.Format("{0} ", grid[i, j])); // adds space after each number
                }

                Console.Write(Environment.NewLine + Environment.NewLine); // adds a new line each row
            }

            Console.ReadLine(); // read output
        }
    }
}