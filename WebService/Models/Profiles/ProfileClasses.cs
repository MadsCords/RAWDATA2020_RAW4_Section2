using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataServiceLib;

namespace WebService.Models.Profiles
{
    public class TitleProfile : Profile
    {
        public TitleProfile()
        {
            CreateMap<Title_Basics, TitleDto>();
        }
    }
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Users, UsersDto>();
            CreateMap<UserForCreationDto, Users>();
        }
    }
    public class NameProfile : Profile
    {
        public NameProfile()
        {
            CreateMap<Name_Basics, NameBasicsDto>();
        }
    }
    public class FunctionProfile : Profile
    {
        public FunctionProfile()
        {
            CreateMap<SearchTitleFunction, FunctionsDto>();
            CreateMap<StructuredSearchFunction, StructuredSearchDto>();
        }
    }
}
