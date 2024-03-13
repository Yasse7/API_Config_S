using Application.Students.Model;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<StudentEntity, Student>().ReverseMap()
            .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.Age));
            ;
               // Mapping de List<StudentEntity> vers List<Student> (et vice versa)
          
        }
    }
}
