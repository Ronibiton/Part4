using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4___2048
{
    public class Board
    {
        public int[,] Data {  get; protected set; }

        public Board() 
        {
            Data = new int[4,4];
        }

        public void InitializationTwoCells()
        {
            Random rnd = new Random();
            int[] startingValues = { 2, 4 };
            int randomCellX = 0;
            int randomCellY = 0;
            for (int i = 0; i < 2; i++)
            {
                while (Data[randomCellX,randomCellY] == 2 || Data[randomCellX,randomCellY] == 4)
                {
                    randomCellX = rnd.Next(Data.GetLength(0));
                    randomCellY = rnd.Next(Data.GetLength(1));
                }
                Data[randomCellX, randomCellY] = startingValues[rnd.Next(0, 2)];
                randomCellX = 0;
                randomCellY = 0;
            }
        }

        public int Combine(int cell1, int Cell2)
        {
            return cell1 + Cell2;
        }
    }
}
