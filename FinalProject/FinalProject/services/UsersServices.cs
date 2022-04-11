using FinalProject.Infra;
using FinalProject.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.services
{
    public class UsersServices
    {
        IUsers _service;
        public UsersServices(IUsers service)
        {
            _service = service;
        }
        public List<Users> GetUsers()
        {
            return _service.GetUsers().ToList();
            //List<Supplier> supplier = _sservice.GetSupplier();
            // return supplier.ToList();
        }
        public Users GetUserById(int UserId)
        {
            return _service.GetUserById(UserId);
        }
        public void AddUser(Users Users)
        {
            _service.AddUser(Users);
        }
        public void UpdateUser(Users Users)
        {
            _service.UpdateUser(Users);
        }
        public void DeleteUser(int Userid)
        {
            _service.DeleteUser(Userid);
        }
    }
}
