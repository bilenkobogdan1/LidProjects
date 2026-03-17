using AutoMapper;
using BLL.ModelDTO;
using Data.LidProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Infrastructure.Mapping
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile() 
        {
            CreateMap<ContactLidsDTO, ContactLids>();
            CreateMap<ContactLids, ContactLidsDTO>();
            CreateMap<CategoryLidsDTO, CategoryLids>();
            CreateMap<CategoryLids, CategoryLidsDTO>();
        }
    }
}
