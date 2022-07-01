class Animal
{
    public Animal()
    {
        Console.WriteLine("Animal constructor with ount parameters");
    }
    public Animal(String name)
    {
        Console.WriteLine("Animal constructor with a string parameters ");    
    }
}

class Canine : Animal
{
    public Canine() : base("Linh") //chuyền cho 1 tham số chuỗi nên phương thức có tham số chuỗi nó sẽ chạy
    {
        Console.WriteLine("Derived Canine");
    }
}


class Details
{
    static void Main(String[] args)
    {
        Canine objCanine = new Canine();
    }
}