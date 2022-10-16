using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class UserRepository : IUserDal
    {
        //Context c = new Context();
        public void insert(UserEntity userEntity)
        {
            using var c = new Context();
            c.Add(userEntity);
            c.SaveChanges();

        }

        public void delete(UserEntity userEntity)
        {
            using var c = new Context();
            c.Remove(userEntity);
            c.SaveChanges();
            
        }

        public UserEntity getUserById(int id)
        {
            using var c = new Context();
            return c.Users.Find(id);
        }

        public List<UserEntity> getListUsers()
        {
            using var c = new Context();
            return c.Users.ToList();
        }

        public void update(UserEntity userEntity)
        {
            using var c = new Context();
            c.Update(userEntity);
            c.SaveChanges();
        }
    }
}
