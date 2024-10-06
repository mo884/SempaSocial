using AutoMapper;
using SempaSocial.BLL.Services.Abstraction;
using SempaSocial.BLL.ViewModel.PostVM;
using SempaSocial.DAL.Repo.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SempaSocial.BLL.Services.Implementation
{
    public class PostServices : IPostServices
    {
        private readonly IPostRepo postRepo;
        private readonly IMapper mapper;

        public PostServices(IPostRepo postRepo,IMapper mapper)
        {
            this.postRepo=postRepo;
            this.mapper=mapper;
        }
        public List<GetPostVM> GetAll()
        {
            var posts = postRepo.GetAllPosts(p=>p.IsDeleted != true);
            var Result = mapper.Map<List<GetPostVM>>(posts);
            return Result;
        }
    }
}
