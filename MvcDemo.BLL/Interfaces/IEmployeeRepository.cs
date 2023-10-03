using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcDemo.BLL.Interfaces;
using MvcDemo.DAL.Entities;

namespace MvcDemo.BLL
{
    public interface IEmployeeRepository:IGenericRepoository<Employee>
    {
        //Employee Get(int? id);
        //IEnumerable<Employee> GetAll();
        //int Add(Employee Employee);
        //int Update(Employee Employee);
        //int Delete(Employee Employee);
        Task<IEnumerable<Employee>> GetEmployeeByDepartmentName(string departmentName);
        Task<string> GetDepartmentNameByEmployeeId(int? id); 
        Task<IEnumerable<Employee>> Search (string name);

    }
}
