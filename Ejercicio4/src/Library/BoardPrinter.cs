using System;
using System.Text;
using System.Threading;

namespace GameOfLife
{
    public class BoardPrinter
    {
        public int width; //variabe que representa el ancho del tablero
        public int height; //variabe que representa altura del tablero
        public string PrintBoard(bool[,] b)
        {
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<height;y++)
                {
                    for (int x = 0; x<width; x++)
                    {
                        if(b[x,y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
                Board board = new Board();
                board.GameLogic(b);
                Thread.Sleep(300);
            }
         }
    }
}