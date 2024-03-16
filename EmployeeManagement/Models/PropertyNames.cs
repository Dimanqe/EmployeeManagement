using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public static class PropertyNames
    {
        public static string FirstName { get; } = typeof(Employee).GetProperty(nameof(Employee.FirstName)).Name;
        public static string LastName { get; } = typeof(Employee).GetProperty(nameof(Employee.LastName)).Name;
        public static string Age { get; } = typeof(Employee).GetProperty(nameof(Employee.Age)).Name;
        public static string CompanyName { get; } = typeof(Employee).GetProperty(nameof(Employee.CompanyName)).Name;
        public static string Position { get; } = typeof(Employee).GetProperty(nameof(Employee.Position)).Name;
        public static string CityName { get; } = typeof(Employee).GetProperty(nameof(Employee.CityName)).Name;
        public static string Id { get; } = typeof(Employee).GetProperty(nameof(Employee.Id)).Name;
    }
}
