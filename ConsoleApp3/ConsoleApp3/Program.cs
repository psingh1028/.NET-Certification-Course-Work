
 class Sample
{
    static void Main(string[]args)
    {
        bool exit = false;

        while (!exit)
        {
            Employee emp1 = new Employee();
            Console.WriteLine("Enter Employee ID:");
            emp1.empId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            emp1.empName = Console.ReadLine();
            Console.WriteLine("Enter Salary Per Hour:");
            emp1.salaryPerHour = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number of Working Hours:");
            emp1.noOfWorkingHours = int.Parse(Console.ReadLine());

            emp1.netSalary = (emp1.salaryPerHour) * emp1.noOfWorkingHours *52;

            Console.WriteLine($"Employee ID: {emp1.empId}\nEmployee Name:{emp1.empName}" +
                $"\nEmployee Wage per Hour: {emp1.salaryPerHour}\nEmployee Working Hours: {emp1.noOfWorkingHours}" +
                $"\nEmployee net salary: {emp1.netSalary}\nOrginization Name:" + Employee.orgazinationName);

            


            Console.WriteLine("Would you like to add another Employee? (yes/no)");
            string input = Console.ReadLine().ToLower();
            if (input != "yes")
            {
                exit = true;
            }

        }

        Console.ReadKey();

        //create object
       

        //get the values from fields
        
    }
}