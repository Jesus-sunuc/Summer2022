public class Snake
{
    public Board SnakeBoard { get; set; } = new Board(8, 11);
    public Directions SnakeDirection { get; set; } = new Directions(Directions.Direction.East);
    public int SnakeHeadRow { get; set; } = 5;
    public int SnakeHeadColumn { get; set; } = 5;
    public List<Tuple<int, int>> PreviousCoordinates = new List<Tuple<int, int>>() { new Tuple<int, int>(0, 0) };
    public int SnakeSize = 0;
    public int FruitsEaten = 0;

    public void DirectionChange()
    {
        char key = 'W';
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        if (Console.KeyAvailable)
        {
            keyInfo = Console.ReadKey(true);
            key = keyInfo.KeyChar;
        }

        if (key == 'w')
        {
            SnakeDirection.MyDirection = Directions.Direction.North;
        }

        else if (key == 's')
        {
            SnakeDirection.MyDirection = Directions.Direction.South;
        }

        else if (key == 'a')
        {
            SnakeDirection.MyDirection = Directions.Direction.West;
        }

        else if (key == 'd')
        {
            SnakeDirection.MyDirection = Directions.Direction.East;
        }
    }

    public void AutomaticSnakeMover()
    {
        try
        {
            CheckIfSnakeEatFruit();
            CheckIfSnakeEatItself();

            switch (SnakeDirection.MyDirection)
            {

                case Directions.Direction.East:
                    PreviousCoordinates.Add(new Tuple<int, int>(SnakeHeadRow, SnakeHeadColumn));

                    SnakeBoard.LocalBoard[SnakeHeadRow, SnakeHeadColumn] = "#";

                    SnakeHeadColumn += 1;

                    if (SnakeSize == 0)
                    {
                        SnakeBoard.LocalBoard[PreviousCoordinates[PreviousCoordinates.Count() - 2].Item1, PreviousCoordinates[PreviousCoordinates.Count() - 2].Item2] = null;
                    }

                    if (SnakeSize >= 1)
                    {
                        for (int i = 1; i <= SnakeSize; i++)
                        {
                            SnakeBoard.LocalBoard[PreviousCoordinates[PreviousCoordinates.Count() - i].Item1, PreviousCoordinates[PreviousCoordinates.Count() - i].Item2] = "#";
                        }
                        SnakeBoard.LocalBoard[PreviousCoordinates[PreviousCoordinates.Count() - (SnakeSize + 2)].Item1, PreviousCoordinates[PreviousCoordinates.Count() - (SnakeSize + 2)].Item2] = null;
                    }
                    break;

                case Directions.Direction.West:

                    PreviousCoordinates.Add(new Tuple<int, int>(SnakeHeadRow, SnakeHeadColumn));

                    SnakeBoard.LocalBoard[SnakeHeadRow, SnakeHeadColumn] = "#";

                    SnakeHeadColumn -= 1;

                    if (SnakeSize == 0)
                    {
                        SnakeBoard.LocalBoard[PreviousCoordinates[PreviousCoordinates.Count() - 2].Item1, PreviousCoordinates[PreviousCoordinates.Count() - 2].Item2] = null;
                    }

                    if (SnakeSize >= 1)
                    {
                        for (int i = 1; i <= SnakeSize; i++)
                        {
                            SnakeBoard.LocalBoard[PreviousCoordinates[PreviousCoordinates.Count() - i].Item1, PreviousCoordinates[PreviousCoordinates.Count() - i].Item2] = "#";
                        }

                        SnakeBoard.LocalBoard[PreviousCoordinates[PreviousCoordinates.Count() - (SnakeSize + 2)].Item1, PreviousCoordinates[PreviousCoordinates.Count() - (SnakeSize + 2)].Item2] = null;
                    }

                    break;

                case Directions.Direction.North:

                    PreviousCoordinates.Add(new Tuple<int, int>(SnakeHeadRow, SnakeHeadColumn));

                    SnakeBoard.LocalBoard[SnakeHeadRow, SnakeHeadColumn] = "#";

                    SnakeHeadRow -= 1;

                    if (SnakeSize == 0)
                    {
                        SnakeBoard.LocalBoard[PreviousCoordinates[PreviousCoordinates.Count() - 2].Item1, PreviousCoordinates[PreviousCoordinates.Count() - 2].Item2] = null;
                    }

                    if (SnakeSize >= 1)
                    {
                        for (int i = 1; i <= SnakeSize; i++)
                        {
                            SnakeBoard.LocalBoard[PreviousCoordinates[PreviousCoordinates.Count() - i].Item1, PreviousCoordinates[PreviousCoordinates.Count() - i].Item2] = "#";
                        }

                        SnakeBoard.LocalBoard[PreviousCoordinates[PreviousCoordinates.Count() - (SnakeSize + 2)].Item1, PreviousCoordinates[PreviousCoordinates.Count() - (SnakeSize + 2)].Item2] = null;
                    }

                    break;

                case Directions.Direction.South:

                    PreviousCoordinates.Add(new Tuple<int, int>(SnakeHeadRow, SnakeHeadColumn));

                    SnakeBoard.LocalBoard[SnakeHeadRow, SnakeHeadColumn] = "#";

                    SnakeHeadRow += 1;

                    if (SnakeSize == 0)
                    {
                        SnakeBoard.LocalBoard[PreviousCoordinates[PreviousCoordinates.Count() - 2].Item1, PreviousCoordinates[PreviousCoordinates.Count() - 2].Item2] = null;
                    }

                    if (SnakeSize >= 1)
                    {
                        for (int i = 1; i <= SnakeSize; i++)
                        {
                            SnakeBoard.LocalBoard[PreviousCoordinates[PreviousCoordinates.Count() - i].Item1, PreviousCoordinates[PreviousCoordinates.Count() - i].Item2] = "#";
                        }

                        SnakeBoard.LocalBoard[PreviousCoordinates[PreviousCoordinates.Count() - (SnakeSize + 2)].Item1, PreviousCoordinates[PreviousCoordinates.Count() - (SnakeSize + 2)].Item2] = null;
                    }

                    break;
            }
        }

        catch (IndexOutOfRangeException)
        {
            SnakeBoard.DisplayLostBoard();
            System.Environment.Exit(0);
        }
    }

    public void CheckIfSnakeEatFruit()
    {
        if (SnakeBoard.LocalBoard[SnakeHeadRow, SnakeHeadColumn] == "*")
        {
            FruitsEaten += 1;
            SnakeSize += 1;
        }
        else
        {
            return;
        }
    }

    public void CheckIfSnakeEatItself()
    {
        Console.CursorVisible = false;
        if (SnakeBoard.LocalBoard[SnakeHeadRow, SnakeHeadColumn] == "#")
        {
            SnakeBoard.DisplayLostBoard();
            System.Environment.Exit(0);
        }
        else
        {
            return;
        }
    }
}