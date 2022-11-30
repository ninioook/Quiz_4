namespace Task_6
{
    public class Employee
    {
        public string Name;
        public string LastName;
        public string Id;
        public double Sallary;
        public string DepartmentName;

        public Employee(string name, string lastName, string id, double sallary, string departmentName)
        {
            Name = name;
            LastName = lastName;
            Id = id;
            Sallary = sallary;
            DepartmentName = departmentName;
        }
    }
}
