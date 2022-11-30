using Task_6;

// Შექმენით კლასი Employee რომელსაც ექნება სახელი, გვარი, პირადი ნომერი და ხელფასის ველები. Შექმენით კლასი დეპარტამენტი რომელსაც ექნება დეპარტამენტის დასახელება და მაქსიმალური თანამშრომელის რაოდენობა (ველები). Employee კლასში დაამატეთ დეპარტამენტი ისე რომ შეიძებოდეს ამ დეპარტამენტებში თანამშრომლების დამატება , იმ შემთხვევაში თუ მაქსიმალურ რაოდენობას გადააჭარბა თანამშრომელი ვერ უნდა დაემატოს. Შექმენით მეთოდები რომელიც : 
//a.Დაამატებს თანამშრომელს დეპარტამენტში
//b.Წაშლის თანამშრომელს დეპარტამენტში
//c.Დაბეჭდავს დეპარტამენტების სიას
//d.Დაბეჭდავს თანამშრომლების სიას დეპარტამენტების მიხედვით
//e.Დაითვლის თანამშრომლების რაოდენობას თითოეულ დეპარტამენტში (ცალკე ველი არ უნდა გქონდეს დეპარტამენტის კლასში ამისთვის)


var emp1 = new Employee("Emp1", "e", "12123", 1000, "Accountant");
var emp2 = new Employee("Emp2", "e", "12124", 2000, "Accountant");
var emp3 = new Employee("Emp3", "e", "12125", 4000, "Management");
var employees = new List<Employee>() { emp1, emp2, emp3 };


var dep1 = new Department("Accountant", 5);
var dep2 = new Department("Management", 5);
var departments = new List<Department>() { dep1, dep2 };

dep1.AddEmployee(emp1);
dep1.AddEmployee(emp2);
dep2.AddEmployee(emp3);

//c.
foreach (var dep in departments)
{
    Console.WriteLine(dep.Name);
}

//d.
var employeeList = employees.GroupBy(x => x.DepartmentName);
foreach (var employee in employeeList)
{
    Console.WriteLine($"Department:{employee.Key}");
    foreach (var e in employee)
    {
        Console.WriteLine(e.Name);
    }
}

//e.
foreach (var dep in departments)
{
    Console.WriteLine($"{dep.Name}:{dep.Employees.Count()}");
}

