
namespace Chess
{
   public class Chess
    {
        Cell playerOne;
        Cell playerTwo;
        public Chess(Cell playerOne, Cell playerTwo)
        {
            if(playerOne.Row==playerTwo.Row && playerOne.Colum == playerTwo.Colum)
            {
                throw new OutRowOrColumBoard();
            }
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
        }
        public Cell PlayerOne { get => playerOne; set => playerOne = value; }
        public Cell PlayerTwo { get => playerTwo; set => playerTwo = value; }
        public string GetLocation()
        {
            if (playerOne.Row==playerTwo.Row)
            {
                return $"Stand on one horizontal line";
            }
            if (playerOne.Colum==playerTwo.Colum)
            {
                return $"Stand on one vertical line";
            }
            if ((playerOne.GetAsNumber()-playerTwo.GetAsNumber())%9==0 || (playerOne.GetAsNumber() - playerTwo.GetAsNumber()) % 11 == 0)
            {
                return $"Stand on the same diagonal";
            }
            else return $"No common line";
        }
    }
}
