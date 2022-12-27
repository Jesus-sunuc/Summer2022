public class Directions
{
    public enum Direction { North, East, South, West }
    public Direction MyDirection { get; set; }
    public Directions(Direction mydirection) => MyDirection = mydirection;
}