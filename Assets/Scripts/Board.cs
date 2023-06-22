public class Board
{
    public int Width { get; private set; }
    public int Height { get; private set; }
    public int[] Grid { get; private set; }

    public Board(int width, int height, int[] grid)
    {
        Width = width;
        Height = height;
        Grid = grid;
    }
}