using AutoMapper;
using MvcDemo.DAL.Entities;
using MvcDemo.PL.Models;

namespace MvcDemo.PL.Mappers
{
    public class DepartmentProfile:Profile
    {

        public DepartmentProfile()
        {
            CreateMap<Department, DepartmentViewModel>().ReverseMap();
        }
    }
}
