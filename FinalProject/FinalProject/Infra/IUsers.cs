using FinalProject.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Infra
{
    public interface IUsers
    {
        public List<Users> GetUsers();
        public Users GetUserById(int UserId);
        public void AddUser(Users Users);
        public void UpdateUser(Users Users);
        public void DeleteUser(int UserId);
    }
}
