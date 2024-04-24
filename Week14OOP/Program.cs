Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good girl");


Console.WriteLine($"My dogs name is {myDog.Name}");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}.");

myDog.Rename("Bad Boy");

while (myDog.LevelofHapiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();


class Dog
{
  private string _name; //field
  private int _levelofHapiness;

    //constructor
    public Dog(string name) //nmae -lets the use name the dog.
    {
        _name = name;
        _levelofHapiness = 0;
    }

    //getter
    public string Name
    {
        get { return _name; }
    }

    public int LevelofHapiness
    {
        get { return _levelofHapiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");

    }

    public void Bark()
    {
        Console.WriteLine("Woof-woof");
        _levelofHapiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wigglw!");
    }
}
