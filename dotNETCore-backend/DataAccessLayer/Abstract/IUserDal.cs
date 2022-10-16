using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IUserDal
    {
        void insert(UserEntity userEntity);

        void delete(UserEntity userEntity);


        UserEntity getUserById(int id);


        List<UserEntity> getListUsers();


        void update(UserEntity userEntity);
       
    }
}
