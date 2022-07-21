using System;

namespace StructuralCode
{
    class MainApp
    {
        public static void Main(string[] args)
        {
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run(); 
        }
    }

    //declares an interface for operations that create abstract products
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }

    //implements the operations to create concreate products
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    //implements the operations to create concreate products

    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    //declares an interface for a type of product object 
    abstract class AbstractProductA
    {

    }

    //declares an interface for a type of product object 
    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);  
    }

    //Defines a product object to be created by the correspoinding concrete
    //factory
    //implements the AbstractProduct Interface

    class ProductA1 : AbstractProductA
    {

    }

    //Defines a product object to be created by the correspoinding concrete
    //factory
    //implements the AbstractProduct Interface
    class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " " +
                "interacts with" + " " + a.GetType().Name + "\n");
        }
    }

    //Defines a product object to be created by the correspoinding concrete
    //factory
    //implements the AbstractProduct Interface
    class ProductA2 : AbstractProductA
    {

    }

    //Defines a product object to be created by the correspoinding concrete
    //factory
    //implements the AbstractProduct Interface
    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " " +
                "interacts with" + " " + a.GetType().Name);
        }
    }

    //Uses interfaces declared by AbstractFactory and AbstractProduct classes 
    class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        public Client(AbstractFactory factory)
        {
            _abstractProductB = factory.CreateProductB();
            _abstractProductA = factory.CreateProductA();
        }

        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}
