using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Project
{
   public class User
    {
        public int user_id { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int age { get; set; }
        public int phone { get; set; }
        public string type { get; set; }
        public char gender { get; set; }
        public User(int user_id,string Name,string email,string password,int phone,char gender,string type, int age) 
        {
            this.user_id = user_id;
            this.Name = Name;
            this.email = email;
            this.password = password;
            this.age = age;
            this.phone = phone;
            this.type = type;
            this.gender = gender;
        }    
    }
}
