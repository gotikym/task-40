using System;

internal class Program
{
    static void Main(string[] args)
    {
        Renderer draw = new Renderer();
        Player player = new Player(7, 7);

        draw.DrawPlayer(player.PlayerPositionX, player.PlayerPositionY);
    }
}

class Player
{
    public int PlayerPositionX { get; private set; }
    public int PlayerPositionY { get; private set; }

    public Player(int playerPositionX, int playerPositionY)
    {
        PlayerPositionX = playerPositionX;
        PlayerPositionY = playerPositionY;
    }
}

class Renderer
{
    public void DrawPlayer(int playerPositionX, int playerPositionY, char simbol = 'Ж')
    {
        Console.SetCursorPosition(playerPositionX, playerPositionY);
        Console.Write(simbol);
    }
}
