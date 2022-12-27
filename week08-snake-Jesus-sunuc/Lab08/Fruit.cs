public class Fruits
{
    public Board board { get; set; }
    public Fruits(Board _board)
    {
        board = _board;
    }
    public void FruitPlacer()
    {
        Random random = new Random();
        if (IsThereAnotherFruitOnBoard(board) == false)
        {
            board.LocalBoard[random.Next(8), random.Next(11)] = "*";
        }
        
    }
    public bool IsThereAnotherFruitOnBoard(Board board)
    {
        foreach (string a in board.LocalBoard)
        {
            if (a == "*")
                return true;
        }
        return false;
    }
}