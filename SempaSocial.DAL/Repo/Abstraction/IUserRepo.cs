using SempaSocial.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SempaSocial.DAL.Repo.Abstraction
{
    public interface IUserRepo
    {
        List<User> GetAll();
    }
}
