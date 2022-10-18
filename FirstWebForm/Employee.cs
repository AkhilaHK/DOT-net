using System;

namespace FirstWebForm
{
    [Serializable()]
    public class Employee
    {
        public Employee()
        {
        }

        public int EmpId { get; set; }
        public string name { get; set; }
        public string Designation { get; set; }
    }
}