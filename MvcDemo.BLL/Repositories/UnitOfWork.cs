using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcDemo.BLL.Interfaces;

namespace MvcDemo.BLL.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        public UnitOfWork(IEmployeeRepository employeeRepository,IDepartmentRepository idDepartmentRepository)
        {
            EmployeeRepository = employeeRepository;
            DepartmentRepository = idDepartmentRepository;
            
        }
        public IEmployeeRepository EmployeeRepository { get; set; }
        public IDepartmentRepository DepartmentRepository { get; set; }
    }
}
