namespace Task_6
{
    public class Department
    {
        public string Name;

        public int MaxEmployeeAmount;

        public List<Employee> Employees { get; set; }=new List<Employee>();

        public Department(string name, int maxEmployeeAmount)
        {
            Name = name;
            MaxEmployeeAmount = maxEmployeeAmount;
        }

        public void AddEmployee(Employee employee)
        {
            
            Employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }
    }
}
