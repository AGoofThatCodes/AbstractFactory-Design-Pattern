# AbstractFactory-Design-Pattern

Abstract factory design pattern provides an interface for creating families of 
related or dependant objects without specifying their concrete classes

![image](https://user-images.githubusercontent.com/29014368/180211096-b6797cde-f16c-4b6a-8f2f-02b278aa13ed.png)

The Real World example code demonstrate the creation of different animal worlds for a computer
game using different factories. Although the animals created by the continent factories are
different, the interactions among the animals remain the same

ContinentFactory(AbstractFactory)
- Declares an interface for operations that creat abstract producs

AmericanFactory and AfricanFactory(ConcreteFactory)
- implements the operations to create concrete product objects

Herbivore and Carnivore(AbstractProduct)
- Declares an interface for a type f product object


Wildbeest, Lion, Bison and Wold(Product)

- Defines a product object to be created by the corresponding concrete factory(Africa and America)
- Implements the AbstractProduct interface(Herbivore and Carnivore)

Animal World(Client)
- Uses interfaces by AbstractFactory and AbstractProduct classes
