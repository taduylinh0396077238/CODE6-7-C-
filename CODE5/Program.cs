class Employees
{
    int _empId = 1;
    string _empName = "James Anderson";
    int _age = 25;
    public void Display()
    {
        Console.WriteLine("EmployeeID :" + _empId);
        Console.WriteLine("EmployeeName :" + _empName);
    }
}
class Department : Employees
    {
        int _depId = 501;
        string _depName = "sales";
        new void Display()
        {
            base.Display();
            Console.WriteLine("Department ID:" + _depId);
            Console.WriteLine("Department Name:" + _depName);
        }

        static void Main(string[] args)
        {
            Department objDepartment = new Department();
            objDepartment.Display();

        }
    }
