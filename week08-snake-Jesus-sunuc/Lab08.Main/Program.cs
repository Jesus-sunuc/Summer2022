namespace Week08Code;
public class Program
{
    static void Main()
    {
        Console.WriteLine("The object of the game is to eat the fruit");
        Thread.Sleep(2000);
        Console.WriteLine("Press a to move left, d to move right, w to move up, s to move down");
        Thread.Sleep(3000);
        Snake snake = new Snake();
        Fruits fruits = new Fruits(snake.SnakeBoard);

        while (true)
        {
            Console.WriteLine($"Fruits Collected: {snake.FruitsEaten}");

            Thread Thread1 = new Thread(snake.AutomaticSnakeMover);
            Thread Thread2 = new Thread(snake.SnakeBoard.DisplayBoard);
            Thread Thread3 = new Thread(snake.DirectionChange);
            Thread Thread4 = new Thread(fruits.FruitPlacer);

            Thread1.Start();
            Thread2.Start();
            Thread3.Start();
            Thread4.Start();

            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
