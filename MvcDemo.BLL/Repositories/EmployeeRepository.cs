using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcDemo.DAL.Contexts;
using MvcDemo.DAL.Entities;

namespace MvcDemo.BLL.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee> , IEmployeeRepository
    {
        private readonly MvcAppDbContext _context;

        public EmployeeRepository(MvcAppDbContext context) :base(context)
        {
            _context = context;
        }

        //public Employee Get(int? id)
        
        //   => _context.Employees.FirstOrDefault(e => e.Id == id);


        //public IEnumerable<Employee> GetAll()

        //    => _context.Employees.ToList();
        

        //public int Add(Employee Employee)
        //{
        //    _context.Employees.Add(Employee);
        //    return _context.SaveChanges();
        //}

        //public int Update(Employee Employee)
        //{
        //    _context.Employees.Update(Employee);
        //    return _context.SaveChanges();
        //}

        //public int Delete(Employee Employee)
        //{
        //    _context.Employees.Remove(Employee);
        //    return _context.SaveChanges();
        //}
        public async Task<IEnumerable<Employee>> GetEmployeeByDepartmentName(string departmentName)
            => await _context.Employees
                .Where(emp => emp.Department.Name == departmentName).ToListAsync();

        public async Task<string> GetDepartmentNameByEmployeeId(int? id)

        {
            var employee = await _context.Employees.Where(e => e.Id == id).Include(e => e.Department).FirstOrDefaultAsync();
            var department = employee.Department;
            return department.Name;
        }

        public async Task<IEnumerable<Employee>> Search(string name)
            => await _context.Employees.Where(emp => emp.Name.Contains(name)).ToListAsync();

        //public async Task<string> GetDepartmentNameByEmployeeId(int? id)
        //{
        //  var employee =await _context.Employees.Where(emp => emp.Department.Id == id).Include(e=>e.Department).FirstOrDefaultAsync();
        //  var department = employee.Department;
        //  employee.Department.Name = department.Name;
        //  return department.Name; 
        //}


    }
}
