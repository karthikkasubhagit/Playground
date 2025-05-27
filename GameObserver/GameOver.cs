using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace GameObserver
{
    public class GameOver : IGameObserver
    {
        private readonly IPlayer _player;
        public GameOver(IPlayer player)
        {
            _player = player;
        }
        public void Update()
        {
            if (_player.GetHealth() == 0)
            {
                Console.WriteLine("Game Over");
            }
        }
    }
}
