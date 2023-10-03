using MvcDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcDemo.DAL.Contexts;

namespace MvcDemo.BLL.Repositories
{
    public class DepartmentRepository : GenericRepository<Department> ,IDepartmentRepository
    {
        //why readonly?? =>  علشان الريد اونلي شبه الكونستانت مبقدرش اعدل ف الكومبايليشن تايم ولا الرن تايم 
        //ونفس الكلام الريد اونلي مش هعرف اعدل ف الرن تايم علشان اضمن ان الداتا بيز كونتكست ميتغيرش قبل
        // ما اعملها انجيكت وهو دا ال ديبندنسي انجيكشن
        private readonly MvcAppDbContext _context;

        //private MvcAppDbContext context;
        public DepartmentRepository(MvcAppDbContext context) : base(context)
        {
            _context = context;
            //context= new MvcAppDbContext();
        }
        //public int Add(Department department)
        //{
        //    _context.Departments.Add(department);
        //    return _context.SaveChanges();

        //}

        //public int Delete(Department department)
        //{
        //    _context.Departments.Remove(department);
        //    return _context.SaveChanges();
        //}

        //public Department Get(int? id)
        
        //    => _context.Departments.FirstOrDefault(dept => dept.Id == id);
            
        

        //public IEnumerable<Department> GetAll()
        
        //   =>  _context.Departments.ToList();
        

        //public int Update(Department department)
        //{
        //    _context.Departments.Update(department);
        //    return _context.SaveChanges();
        //}
    }
}
