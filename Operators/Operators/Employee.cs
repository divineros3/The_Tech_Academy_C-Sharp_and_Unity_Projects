using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public override bool Equals(object obj)
        //{
        //    if (obj is Employee otherEmployee)
        //    {
        //        return Id == otherEmployee.Id;
        //    }
        //    return false;
        //}

        //public override int GetHashCode()
        //{
        //    return Id.GetHashCode();
        //}

        //public static bool operator ==(Employee employee1, Employee employee2)
        //{
        //    if (ReferenceEquals(employee1, employee2))
        //    {
        //        return true;
        //    }

        //    if (employee1 is null || employee2 is null)
        //    {
        //        return false;
        //    }

        //    return employee1.Id == employee2.Id;
        //}

        //public static bool operator !=(Employee employee1, Employee employee2)
        //{
        //    return !(employee1 == employee2);
        //}
    }
}
