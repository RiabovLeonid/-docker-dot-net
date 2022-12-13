using AutoMapper;
using BuisnessLogicLayer.DTO;
using DataAccessLayer.Entities;
using System;

namespace BuisnessLogicLayer
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Spending, SpendingDTO>().ReverseMap();
            CreateMap<Department, DepartmentDTO>().ReverseMap();
            CreateMap<Spending_type, SpendingTypeDTO>().ReverseMap();
            CreateMap<LimitValue, LimitValueDTO>().ReverseMap();
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
        }
    }
}
