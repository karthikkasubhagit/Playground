using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObserver
{
    public class Player: IPlayer
    {
        private readonly List<IGameObserver> m_gameOvers;

        private int _health;
        private int _score;

        public Player()
        {
            m_gameOvers = new List<IGameObserver>();
        }
        public void Attach(IGameObserver gameOver)
        {
            m_gameOvers.Add(gameOver);
        }

        public void RemoveGameOver(IGameObserver gameOver)
        {
            m_gameOvers.Remove(gameOver);
        }

        public void Notify()
        {
            foreach (var game in m_gameOvers)
            {
                game.Update();
            }
        }

        public void SetValues(int health, int score)
        {
            _health = health;
            _score = score;
            Notify();
        }

        public int GetHealth()
        {
            return _health;
        }

        public int GetScore()
        {
            return _score;
        }
    }
}
