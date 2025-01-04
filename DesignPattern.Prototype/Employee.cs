namespace DesignPattern.Prototype
{
    public class Employee
    {
        public string Department { get; set; }
        public string EmployeeName { get; set; }
        public string CompanyName { get; set; }
        // Assume that creating Address is expensive operation
        public Address EmployeeAddress { get; set; }

        public Employee ShallowCopy()
        {
            return (Employee)MemberwiseClone();
        }
        public Employee DeepCopy()
        {
            Employee tmepEmployee = (Employee)MemberwiseClone();
            tmepEmployee.EmployeeAddress = new Address
            {
                Country = EmployeeAddress.Country,
                City = EmployeeAddress.City
            };
            tmepEmployee.CompanyName = this.CompanyName;
            tmepEmployee.Department = this.Department;
            tmepEmployee.EmployeeName = this.EmployeeName;

            return tmepEmployee;
        }
        public override string ToString()
        {
            return $"Employee Name: [{EmployeeName}] - Department:[{Department}] - Company Name: [{CompanyName}] - Country: [{EmployeeAddress.Country}]- City: [{EmployeeAddress.City}]";
        }
    }
}
