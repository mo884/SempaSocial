using AutoMapper;
using SempaSocial.BLL.ViewModel.PostVM;
using SempaSocial.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SempaSocial.BLL.Mapping
{
    public class DomainProfile:Profile
    {
        public DomainProfile()
        {
            CreateMap<Post, GetPostVM>()
           .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.FullName));
        }
    }
}
