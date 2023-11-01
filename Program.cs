using System;
class Program{
    static void Main(string[] args){

        List<Employee> employees = new List<Employee>();

            Employee e1 = new Employee{name = "Test", department = "Admin", salary = 2000};
            Employee e2 = new Employee{name = "Testington", department = "IT", salary = 1000};
            Employee e3 = new Employee{name = "TestER", department = "QA", salary = 1500};
            Employee e4 = new Employee{name = "Test1", department = "HR", salary = 1200};
            Employee e5 = new Employee{name = "Test2", department = "HR", salary = 1100};
            Employee e6 = new Employee{name = "Nep Nep", department = "Top nep!", salary = 20000};
            Employee e7 = new Employee{name = "Nepi", department = "Top nep!", salary = 2000};
            Employee e8 = new Employee{name = "Pomni", department = "Jester", salary = 1};
            Employee e9 = new Employee{name = "Nero", department = "Zoo", salary = 3000};
            Employee e10 = new Employee{name = "Jon", department = "IT", salary = 5000};

            employees.Add(e1);
            employees.Add(e2);
            employees.Add(e3);
            employees.Add(e4);
            employees.Add(e5);
            employees.Add(e6);
            employees.Add(e7);
            employees.Add(e8);
            employees.Add(e9);
            employees.Add(e10);

            
        var w = employees.Where(d => d.department == "IT");


        foreach (var d in w){
            Console.WriteLine($"Name: {d.name}, Salary: {d.salary}");
        }

    }   
}

class Employee{
    public string name { get; set; }
    public string department{ get ;set; }
    public int salary{ get; set; }

}
