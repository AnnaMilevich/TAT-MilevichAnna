using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cell cell1 = new Cell('c', 8);
                Cell cell2 = new Cell('e', 1);
                Chess chess1 = new Chess(cell1, cell2);
                Console.WriteLine(chess1.GetLocation());
                Console.WriteLine("{0}{1} cell color: "+ cell1.GetCellColor(),cell1.Colum,cell1.Row);
                Console.WriteLine("{0}{1} cell color: " + cell2.GetCellColor(), cell2.Colum, cell2.Row);

                Cell cell3 = new Cell('a', 5);
                Cell cell4 = new Cell('a', 5);
                Chess chess2 = new Chess(cell3, cell4);
                Console.WriteLine(chess2.GetLocation());
                Console.WriteLine("{0}{1} cell color: " + cell3.GetCellColor(), cell4.Colum, cell1.Row);
                Console.WriteLine("{0}{1} cell color: " + cell3.GetCellColor(), cell4.Colum, cell2.Row);
            }
            catch (OutRowOrColumBoard ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
