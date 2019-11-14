
namespace Chess
{
   public class Cell
    {
        char colum;
        int row;

        public Cell(char colum, int row)
        {
         if (row < 1 || row > 8 || (int)colum < 97 || (int)colum > 104)
            {
                throw new OutRowOrColumBoard();
            }
        Colum = (char)colum;
        Row = row;
        }
        public int Row { get => row; set => row = value; }
        public char Colum { get => colum ; set => colum = value; }
        public string GetCellColor()
        {
            if ((Row + (int)Colum) % 2 == 0)
            {
                return "black";
            }
            else return "white";
        }
        public int GetAsNumber()
        {
            return (row * 10) + ((int)colum- 96);
        }
    }
}
