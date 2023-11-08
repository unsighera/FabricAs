public class Game
{
    public void PlayGame()
    {
        //запускаем игру
    }

    public void EscapeGame()
    {
        //выходимс из игры
    }

    public void PassGame()
    {
        //проходим игру
    }
}

public class Arcade : Game { }
public class Adventure : Game { }
public class Alive : Game { }
public class Shooter : Game { }
public class Novell : Game { }

public static class GamesStorage
{
    public static Game BuyGame(string type)
    {
        Game game = null;

        switch (type)
        {
            case "ARCADE":
                game = new Arcade();
                break;
            case "ADVENTURE":
                game = new Adventure();
                break;
            case "ALIVE":
                game = new Alive();
                break;
            case "SHOOTER":
                game = new Shooter();
                break;
            case "NOVELL":
                game = new Novell();
                break;
        }

        Console.WriteLine($"Спасибо за покупку {game.GetType()}! Пополните копилку Габена ещё!");
        return game;
    }
}