using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserEntity
    {

        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public UserEntity(){}
        public UserEntity(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
