using Decorator.Pattern_01;

ConcreteComponent concreteComponent = new ConcreteComponent();
concreteComponent.Operation();

Console.WriteLine("----------------------------------------------------");

ConcreteComponent concreteComponent2 = new ConcreteComponent();

ConcreteDecorator concreteDecorator = new ConcreteDecorator(concreteComponent2);
concreteDecorator.Operation();

Console.ReadLine();