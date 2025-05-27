using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    public interface Subject
    {
        public void Attach(Observer observer);
        public void Detach(Observer observer);
        public void SetState(string state);
        public string GetState();
        public void Notify();
    }
}
