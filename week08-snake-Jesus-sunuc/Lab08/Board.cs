public class Board
{
    public string[,] LocalBoard { get; set; }
    public Board(int RowSize, int ColumnSize)
    {
        LocalBoard = new string[RowSize, ColumnSize];
    }
    public void DisplayBoard()
    {
        Console.WriteLine(" --------------------------------------------");

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 11; j++)
            {
                if (LocalBoard[i, j] == null)
                {
                    Console.Write("|   ");
                }
                else
                {
                    Console.Write($"|  {LocalBoard[i, j]} ");
                }
            }
            Console.WriteLine("|");
        }
         Console.WriteLine(" --------------------------------------------");

        Console.ForegroundColor = ConsoleColor.Green;
    }

    public void DisplayLostBoard()
    {
        Console.Clear();
        Console.WriteLine("YOU LOST!");
        Console.ForegroundColor = ConsoleColor.Red;
    }
}
