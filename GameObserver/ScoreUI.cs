using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace GameObserver
{
    public class ScoreUI : IGameObserver
    {
        private readonly IPlayer _player;
        public ScoreUI(IPlayer player)
        {
            _player = player;
        }
        public void Update()
        {
                Console.WriteLine($"Player score is {_player.GetScore()}");
        }
    }
}
