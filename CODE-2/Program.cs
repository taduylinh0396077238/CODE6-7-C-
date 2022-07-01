class Animal
{
    public void Eat()
    {
        Console.WriteLine("Every animal eats smonething");
    }
    public void Dosomething()
    {
        Console.WriteLine("Every animal dose something");
    }
class Cat : Animal
    {
        static void Main(string[] args)
        {
            Cat objCat = new Cat();
            objCat.Eat();
            objCat.Dosomething();
        }
    }
}