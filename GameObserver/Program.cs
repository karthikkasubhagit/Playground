namespace GameObserver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPlayer player = new Player();
            

            player.Attach(new GameOver(player));
            player.Attach(new ScoreUI(player));
            player.Attach(new HealthBarUI(player));

            player.SetValues(10, 0);
            player.SetValues(20, 10);
            player.SetValues(40, 20);
            player.SetValues(60, 30);
            player.SetValues(0, 30);
        }
    }
}
