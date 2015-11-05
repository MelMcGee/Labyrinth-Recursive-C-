using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    class Program
    {
        //command line example of finding the exit to a virtual labyrinth recursively.
       static char[,] lab =
        {
            {' ',' ',' ',' '},
            {' ',' ',' ',' '},
            {' ',' ',' ',' '},
            {' ',' ',' ','e'}
          /*  
            just another test.
            {' ', ' ', ' ', '*', ' ', ' ', ' '},
            {'*', '*', ' ', '*', ' ', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', '*', '*', '*', '*', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', 'e'},*/
        };
       static int counter = 0;
        static void Main(string[] args)
        {
            FindExit(0, 0);
            Console.WriteLine(counter);
        }
        static void FindExit(int row, int col)
        {
            //check if we're out of the labyrinth
            if (row < 0 || col < 0 || row >= lab.GetLength(0) || col >= lab.GetLength(1))
            {
                return;
            }

            //check if we've found the exit
            if (lab[row, col] == 'e')
            {
                //Console.WriteLine("We found the exit!");
                counter++;
                return;
            }

            //check if not a space
            if (lab[row, col] != ' ')
            {
                return; //not an exit. bumped against a wall
            }

            //save this path

            //mark current cell as visited
            lab[row, col] = 's';

            //call paths
            FindExit(row - 1, col); //left
            FindExit(row, col - 1); //down
            FindExit(row + 1, col); //right
            FindExit(row, col + 1); //up

            //unmark current cell
            lab[row, col] = ' ';


        }
    }
}
