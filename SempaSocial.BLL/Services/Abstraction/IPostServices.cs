using SempaSocial.BLL.ViewModel.PostVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SempaSocial.BLL.Services.Abstraction
{
    public interface IPostServices
    {
        List<GetPostVM> GetAll();
    }
}
