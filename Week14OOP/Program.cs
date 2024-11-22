
Console.WriteLine("Name your dog");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good girl");


Console.WriteLine($"My dogs name is {myDog.Name}");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}"); 

myDog.Rename("Bad boy");

while (myDog.LevelOfHapiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();

class Dog
{
    private string _name = "Koer";
    private int _levelOfHappiness = 0;

    public Dog(string name)
    {
        _name = name;
        _levelOfHappiness = 0;
    }

    public string Name
    {
        get { return _name; }
    }
     
    public int LevelOfHapiness
    {
        get { return _levelOfHappiness; }
    }
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamend to: {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("woof-woof");
        _levelOfHappiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("wiggle-wiggle");
    }

}

