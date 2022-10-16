using Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        int addUser(User user);
        int deleteUser(User user);
        int updateUser(User user);
        List<User> getUsers();
        User getById(int id);
    }
}
