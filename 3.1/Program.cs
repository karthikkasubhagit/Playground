// See https://aka.ms/new-console-template for more information

using _3._1;

ConcreteSubject subject = new ConcreteSubject();

ConcreteObserver obserever = new ConcreteObserver(subject);
ConcreteObserver obserever2 = new ConcreteObserver(subject);
ConcreteObserver obserever3 = new ConcreteObserver(subject);

subject.Attach(obserever);
subject.Attach(obserever2);
subject.Attach(obserever3);

subject.SetState("state1");

Task.Delay(2000);

subject.SetState("state2");

