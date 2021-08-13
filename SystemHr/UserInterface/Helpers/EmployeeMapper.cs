using System.Collections.Generic;
using SystemHr.DataAccessLayer.Models;
using SystemHr.DataAccessLayer.ViewModels;

namespace SystemHR.UserInterface.Helpers
{
    public class EmployeeMapper
    {
        public static IList<EmployeeView> MapEmployeeToEmployeeView(IList<Employee> fakeEmployees) {
            IList<EmployeeView> employeesView = new List<EmployeeView>();

            foreach (Employee employee in fakeEmployees)
            {
                EmployeeView employeeView = new EmployeeView();
                employeeView.Id = employee.Id;
                employeeView.LastName = employee.LastName;
                employeeView.FirstName = employee.FirstName;
                employeeView.Code = employee.Code.ToString();
                employeeView.Position = string.Empty;
                employeeView.Status = employee.Status.ToString();
                employeesView.Add(employeeView);
            }
            return employeesView;
        }
    }
}
