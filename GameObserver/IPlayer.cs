using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObserver
{
    public interface IPlayer
    {
        public void Attach(IGameObserver  gameOver);
        public void RemoveGameOver(IGameObserver  gameOver);
        public void Notify();
        public void SetValues(int health, int score);
        public int GetHealth();
        public int GetScore();
    }
}
