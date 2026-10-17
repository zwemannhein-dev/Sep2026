List<Employee> employees = new List<Employee>();
int nextId = 1;

while (true)
{
    Console.WriteLine("=== HR Management System ===");
    Console.WriteLine("1. Add Employee");
    Console.WriteLine("2. View Employees");
    Console.WriteLine("3. Update Salary");
    Console.WriteLine("4. Remove Employee");
    Console.WriteLine("5. Exit");
    Console.Write("Choose: ");

    string choice = Console.ReadLine() ?? "";

    switch (choice)
    {
        case "1":
            Console.Write("Enter name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Enter salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            Employee employee = new Employee();
            employee.Id = nextId;
            employee.Name = name;
            employee.Salary = salary;

            employees.Add(employee);
            nextId++;
            Console.WriteLine("Employee added.");
            break;

        case "2":
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees.");
                break;
            }

            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"ID: {employees[i].Id} | Name: {employees[i].Name} | Salary: {employees[i].Salary}");
            }
            break;

        case "3":
            Console.Write("Enter employee ID: ");
            int updateId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter new salary: ");
            int newSalary = Convert.ToInt32(Console.ReadLine());

            bool employeeFound = false;

            foreach (Employee item in employees)
            {
                if (item.Id == updateId)
                {
                    item.Salary = newSalary;
                    employeeFound = true;
                }
            }

            if (employeeFound)
                Console.WriteLine("Salary updated.");
            else
                Console.WriteLine("Employee not found.");
            break;

        case "4":
            Console.Write("Enter employee ID: ");
            int removeId = Convert.ToInt32(Console.ReadLine());

            bool employeeRemoved = false;

            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id == removeId)
                {
                    employees.RemoveAt(i);
                    employeeRemoved = true;
                    break;
                }
            }

            if (employeeRemoved)
                Console.WriteLine("Employee removed.");
            else
                Console.WriteLine("Employee not found.");
            break;

        case "5":
            Console.WriteLine("Goodbye!");
            return;

        default:
            Console.WriteLine("Please choose 1 to 5.");
            break;
    }
}
