using System;

internal class Program
{
    static void Main(string[] args)
    {
        Renderer renderer = new Renderer();
        Player player = new Player(7, 7, '@');

        renderer.Draw(player.PositionX, player.PositionY, player.Avatar);
    }
}

class Player
{
    public char Avatar { get; private set; }
    public int PositionX { get; private set; }
    public int PositionY { get; private set; }

    public Player(int positionX, int positionY, char avatar)
    {
        Avatar = avatar;
        PositionX = positionX;
        PositionY = positionY;
    }
}

class Renderer
{
    public void Draw(int positionX, int positionY, char avatar = 'Ж')
    {
        Console.SetCursorPosition(positionX, positionY);
        Console.Write(avatar);
    }
}
