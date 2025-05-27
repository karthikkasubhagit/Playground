using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace GameObserver
{
    public class HealthBarUI : IGameObserver
    {
        private readonly IPlayer _player;
        public HealthBarUI(IPlayer player)
        {
            _player = player;
        }
        public void Update()
        {
                Console.WriteLine($"Player health status is {_player.GetHealth()}");
        }
    }
}
