using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Media;

namespace TicTacToe
{
	class Program
	{
		static void Main(string[] args)
		{
			SoundPlayer music = new SoundPlayer();
			music.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "OldTimeMemories_Loop.wav";
			music.Play();
		
			char player ='X';
			Char[,] board = new char[3, 3];
			Initialize(board);
			int movesplayed = 0;
			//bool gameEnd = false;
			while (true)
			{
				
				Print(board);
				
				Console.Write("Please enter row:");
				int row = Convert.ToInt32(Console.ReadLine());
				Console.Write("please enter col:");
				int col = Convert.ToInt32(Console.ReadLine());
				Console.Clear();
				board[row, col] = player;
				
				if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
				{
				
					Print(board);
					Console.WriteLine(player +  "has won the game!");
					Console.ReadKey();
					break;
					
				}
				if(player == board[0, 0] && player == board[1, 0] && player == board[2, 0])
				{
					Print(board);
					Console.WriteLine(player +  "has won the game!");
					Console.ReadKey();
					break;

				}
				if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
				{
					Print(board);
					Console.WriteLine(player +  "has won the game!");
					Console.ReadKey();
					break;

				}
				if (player == board[2, 0] && player == board[2, 1] && player == board[2,2])
				{
					Print(board);
					Console.WriteLine(player +  "has won the game!");
					Console.ReadKey();
					break;

				}
				if (player == board[0, 0] && player == board[1, 1] && player == board[2, 2])
				{
					Print(board);
					Console.WriteLine(player +  "has won the game!");
					Console.ReadKey();
					break;

				}
				if (player == board[2, 0] && player == board[1, 1] && player == board[0, 2])
				{
					Print(board);
					Console.WriteLine(player +  "has won the game!");
					Console.ReadKey();
					break;

				}
				if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1])
				{
					Print(board);
					Console.WriteLine(player + "has won the game!");
					Console.ReadKey();
					break;
				}
				if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2])
				{
					Print(board);
					Console.WriteLine(player +  "has won the game!");
					Console.ReadKey();
					break;

				}

				movesplayed = movesplayed + 1;
				if (movesplayed == 9)
				{
					Print(board);
					Console.WriteLine( "Draw" );
					//gameEnd = true;

				}
				player = changturn(player);
			}

		}

		static void Print(char[,] board)
		{
			Console.WriteLine(" 0  |1  |2  |");
			for (int row = 0; row < 3; row++)
			{
				Console.Write(row + "|");

				for (int col = 0; col < 3; col++)
				{
					Console.Write(board[row, col]);
					Console.Write(" | ");

				}
				Console.WriteLine();


			}
		}

		static void Initialize(char[,] board)
		{
			for (int row = 0; row < 3; row++)
			{
				for (int col = 0; col < 3; col++)
				{
					board[row, col] = ' ';

				}

			}

		}
		static char changturn(char currentplayer)
		{
			if (currentplayer == 'X')
			{
				return 'O';
			}
			else
			{
				return 'X';
			}
		}
		static void PlayMusic()
		{
			SoundPlayer player = new SoundPlayer();
			player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "OldTimeMemories_Loop.wav";
			player.Play();
			Console.ReadKey();

		}
	}

}
