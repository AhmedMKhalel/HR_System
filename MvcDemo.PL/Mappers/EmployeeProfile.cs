using AutoMapper;
using MvcDemo.DAL.Entities;
using MvcDemo.PL.Models;

namespace MvcDemo.PL.Mappers
{
    public class EmployeeProfile:Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeViewModel>().ReverseMap();
        }
    }
}
