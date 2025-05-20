using mid_proj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_proj.Services
{
    public interface IUserService
    {
        bool Register(User user);
        User Authenticate(string email, string password);
    }
}
