using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    public class ConcreteObserver(Subject subject): Observer
    {
        public void Update()
        {
            string state = subject.GetState();

            Console.WriteLine($"The state is changed to {state}");
        }
    }
}
