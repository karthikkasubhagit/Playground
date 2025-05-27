namespace _3._1
{
    public class ConcreteSubject : Subject
    {
        private readonly List<Observer> _observers;
        private string _state = string.Empty;

        public void SetState(string state)
        {
            _state = state;
            Notify();
        }

        public string GetState()
        {
            return _state;
        }
        public ConcreteSubject()
        {
            _observers = new List<Observer>();
        }
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer o in _observers)
            {
                o.Update();
            }
        }
    }
}
