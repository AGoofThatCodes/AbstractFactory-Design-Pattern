using System;

namespace RealWorldCode
{
    class MainApp
    {
        public static void Main()
        {
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            ContinentFactory america = new AmericaFactory();
            AnimalWorld world1 = new AnimalWorld(america);
            world1.RunFoodChain();

        }
    }

    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }

    class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
    }

    class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
    }

    abstract class Herbivore
    {

    }

    abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }

    class Wildebeest: Herbivore
    {

    }

    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + 
                " " + "eats" + " " + h.GetType().Name + "\n");
        }
    }

    class Bison : Herbivore
    {

    }

    class Wolf: Carnivore
    {
        public override void Eat(Herbivore h)
        {
           Console.Write(this.GetType().Name + " " 
               + "eats" + " " + h.GetType().Name + "\n");
        }
    }

    class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalWorld(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}