# MinesweeperGridGenerator
Creates a Minesweeper grid based on user input

Evaluation (Following the structure of the Minesweeper Generator PDF):

a. This is my attempt at solving the Minesweeper Generator challenge. My understanding of the problem is as follows:

   -  The user needs to input three parameters; rows, columns, mines.
   -  A grid will be created based on these inputs, the mines will be randomly generated within the row and column parameters.
   -  Clues will surround each mine location, telling the user how many mines are nearby.
   -  The grid will be displayed to the user at the end.

b. To solve this problem I will be required to read through the problem and take notes on the important factors of the problem such as the rules regarding mines and clues. 

c. My approach to this problem involved first reading over the problem several times to get a clear understanding of what was required. Once I understood the problem, I began to write down how I will structure the program. My early plans summarised the rules of the Minesweeper grid and the functions which I would use. 

My programming language of choice was c# as i am most familiar with this programming language. 

I built the program using four key functions: 

The main function, which declares shared variables, requests user input for the number of rows, columns and mines and initialises the Minesweeper grid as an array. This function also calls the other functions to apply logic to the Minesweeper grid. 

The buildGrid function, which populates the grid array with mines using two for loops until the number of mines is equal to the users requested number of mines. The fields where mines are located are marked with an "x".

The checkMines function, which checks each location in the array for whether it is next to a mine or not. For each mine that is next to the location of the array, a variable called foundMine increments; also using two for loops. The foundMine variable is then saved to each location in the array where there is not currently a mine. Once the foundMine variable has been written to the array, it resets and becomes 0.

The displayGrid function, prints the array to the console using two for loops through the 2 dimensional grid array so the user can see what they have created with their input.

d. As a result of undertaking this challenge, I am satisfied with the outcome of this challenge as I have a working solution despite a minor logic error. After vigorous testing and debugging, I have noticed the logic error is in my checkMines function which I have been unable to fix at this moment in time. I thoroughly enjoyed this exercise due to the challenge it provided and will attempt to fix the clue bug in the near future.
