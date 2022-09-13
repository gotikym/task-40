using System;

internal class Program
{
    static void Main(string[] args)
    {
        Draw draw = new Draw();
        Player player = new Player(7, 7);

        draw.DrawPlayer(player.X, player.Y);
    }
}

class Player
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public Player(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Draw
{
    public void DrawPlayer(int x, int y, char simbol = 'Ж')
    {
        Console.SetCursorPosition(x, y);
        Console.Write(simbol);
    }
}