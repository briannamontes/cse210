using System;
using System.Collections.Generic;
namespace Tic_tac_toe
{
    class Program
    {
        static void displayBoard(char[] board){
            Console.WriteLine(board[0] + " | " +  board[1] + " | " + board[2]);
            Console.WriteLine("-+-+-");
            Console.WriteLine(board[3] + " | " +  board[4] + " | " + board[5]);
            Console.WriteLine("-+-+-");
            Console.WriteLine(board[6] + " | " +  board[7] + " | " + board[8]);
        }
        static bool isWon(char[] board){
            if ((board[0] == board[1] && board[1] == board[2]) ||
            (board[3] == board[4] && board[4] == board[5]) ||
            (board[6] == board[7] && board[7] == board[8]) ||
            (board[0] == board[3] && board[3] == board[6]) ||
            (board[1] == board[4] && board[4] == board[7]) ||
            (board[2] == board[5] && board[5] == board[8]) ||
            (board[0] == board[4] && board[4] == board[8]) ||
            (board[2] == board[4] && board[4] == board[6]))
            {
                return true;
            }
            else
             {
                return false;
             }
        }

        static void Main(string[] args)
        {   
            char[] board = new char[9];
            board [0] = '1';
            board [1] = '2';
            board [2] = '3';
            board [3] = '4';
            board [4] = '5';
            board [5] = '6';
            board [6] = '7';
            board [7] = '8';
            board [8] = '9';
            string userInput;

//inital value of the counter
//conditions to keep going
//what to do at the end of every loop
            for (int turn = 1; turn <= 9; turn++) 
            {
                //check to see if turn is odd
                if (turn % 2 == 1 ){
                   Console.WriteLine("x's turn to choose a square(1-9)");
                   userInput = Console.ReadLine();
                   board[int.Parse(userInput)-1] = 'x';
                }
                //check to see if even
                if (turn % 2 == 0 ){
                   Console.WriteLine("o's turn to choose a square(1-9)");
                   userInput = Console.ReadLine();
                   board[int.Parse(userInput)-1] = 'o';
                }
                displayBoard(board);
                if (isWon(board)){
                    break;
                }
            }
            Console.WriteLine("Good game! Thanks for playing");
        //     List <string> board = new List <string>();
        //     bool choice = true;
        //     while(choice)
        //     Console.WriteLine();

        //     Console.WriteLine("x's turn to choose a square(1-9)");
        //     string userInput = Console.ReadLine();
        //     Console.WriteLine("you chose: " + userInput);
        //     Console.WriteLine("Good game!");

        // IDictionary<int, string> numberNames = new Dictionary<int, string>();

        }
        //static bool someoneWon(List <string> board){
        //}
    }
}
