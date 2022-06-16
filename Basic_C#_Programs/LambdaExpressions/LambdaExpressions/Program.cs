using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new Employees();
            Employees emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8, emp9, emp10;
            
            emp1.empID = 000001;
            emp1.firstName = "Joe";
            emp1.lastName = "Johnson";

            emp2.empID = 000002;
            emp2.firstName = "Joe";
            emp2.lastName = "Eliason";

            emp3.empID = 000003;
            emp3.firstName = "Connor";
            emp3.lastName = "Blake";

            emp4.empID = 000004;
            emp4.firstName = "John";
            emp4.lastName = "Johnson";

            emp5.empID = 000005;
            emp5.firstName = "Jack";
            emp5.lastName = "Johnson";

            emp6.empID = 000006;
            emp6.firstName = "James";
            emp6.lastName = "Johnson";

            emp7.empID = 000007;
            emp7.firstName = "Jonathan";
            emp7.lastName = "Johnson";

            emp8.empID = 000008;
            emp8.firstName = "Jaques";
            emp8.lastName = "Johnson";

            emp9.empID = 000009;
            emp9.firstName = "JaShaun";
            emp9.lastName = "Johnson";

            emp10.empID = 000010;
            emp10.firstName = "Jimmy";
            emp10.lastName = "Johnson";

            List<Employees> myEmployees = new List<Employees>() { emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8, emp9, emp10 };

            foreach (var v in myEmployees)
            {
                if (employees.firstName == "Joe")
                {
                    List<Employees> joeEmployees = new List<Employees>();
                }
            }

            List<Employees> joe = myEmployees.Where(x => x.firstName == "Joe").ToList();

            List<Employees> moreThanFive = myEmployees.Where(x => x.empID > 5).ToList();

            foreach (var v in joe)
            {
                Console.WriteLine(joe);
            }

            foreach (var v in moreThanFive)
            {
                Console.WriteLine(moreThanFive);
            }
            
            Console.ReadLine();

        }

        public struct Employees
        {
            public int empID;
            public string firstName;
            public string lastName;
        }
    }
}
