using System;

namespace TowerOfHanoi
{
    /*The Tower of Hanoi is a mathematical puzzle. It consists of three towers and a number of discs (3 in this puzzle)
    of different sizes, which can slide onto any tower. The puzzle starts with the discs in a neat stack in ascending order 
    of size on one tower (first tower in this puzzle), the smallest at the top, thus making a conical shape.*/

    /*The purpose of this puzzle is to move the discs one by one from the first tower to the last tower knowing the only
     condition is that smaller disc will always be on top of the bigger disc*/


    public class TowerOfHanoiMathPuzzle
    {
        public void SolvingProcedure(int discNo, string firstTowerName, string secondTowerName, string thirdTowerName)
        { 
            if(discNo == 1)
            {                              
                Console.WriteLine(firstTowerName + " -> " + thirdTowerName);
            }
            else
            {
                SolvingProcedure(discNo - 1, firstTowerName, thirdTowerName, secondTowerName);
                SolvingProcedure(1, firstTowerName, secondTowerName, thirdTowerName);
                SolvingProcedure(discNo - 1, secondTowerName, firstTowerName, thirdTowerName);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INPUT: Please input the number of discs, for example, 3. ");
            int discNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Please input the name of first tower, for example, A. ");
            string firstTowerName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Please input the name of second tower, for example, B. ");
            string secondTowerName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Please input the name of third tower, for example, C. ");
            string thirdTowerName = Console.ReadLine();           
            Console.WriteLine();

            /*In case of 3 discs we can solve the puzzle in minimum ((2 to the power 3) - 1 = 7) 7 movements*/
            Console.WriteLine("OUTPUT: Following movements are required for solving the puzzle:");
            Console.WriteLine("================================================================");           

            TowerOfHanoiMathPuzzle tower = new TowerOfHanoiMathPuzzle();
            tower.SolvingProcedure(discNo, firstTowerName, secondTowerName, thirdTowerName);           

            Console.ReadLine();
        }
    }
}
