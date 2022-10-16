using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal iUserDal;

        public UserManager(IUserDal iUserDal)
        {
            this.iUserDal = iUserDal;
        }


        public int addUser(User user)
        {
            UserEntity userEntity = new UserEntity();
            userEntity.name=user.userName;
            iUserDal.insert(userEntity);
            return userEntity.id;
        }

        public int deleteUser(User user)
        {
           UserEntity userEntity = new UserEntity();
            userEntity.id = user.id;
            iUserDal.delete(userEntity);
            return userEntity.id;
        }

        public User getById(int id)
        {
            UserEntity userEntity = iUserDal.getUserById(id);
            User user = new User(userEntity.id, userEntity.name);

            return user;

        }

        public List<User> getUsers()
        {
            List<User> userList = new List<User>();

            List<UserEntity> list = iUserDal.getListUsers();// Sort.by(Sort.Order.asc("id"));
            if (list != null)
            {
                foreach (UserEntity ue in list)
                {
                    userList.Add(new User(ue.id, ue.name));
                }
            }
            return userList;

        }

        public int updateUser(User user)
        {
            UserEntity userEntity = new UserEntity();
            userEntity.id=user.id;
            userEntity.name=user.userName;

            iUserDal.update(userEntity);

            return userEntity.id;
        }
    }
}
