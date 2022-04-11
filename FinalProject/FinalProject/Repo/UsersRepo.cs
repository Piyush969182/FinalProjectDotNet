using FinalProject.Data;
using FinalProject.Infra;
using FinalProject.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Repo
{
    public class UsersRepo : IUsers
    {
        DataBaseContext _context;
        public UsersRepo(DataBaseContext context)
        {
            _context = context;
        }
        public List<Users> GetUsers()
        {
            return _context.Users.ToList();
        }
        public Users GetUserById(int UserId)
        {
            return _context.Users.FirstOrDefault(e => e.UserId == UserId);
        }
        public void AddUser(Users Users)
        {
            _context.Add(Users);
            _context.SaveChanges();
        }
        public void UpdateUser(Users Users)
        {
            _context.Update(Users);
            _context.SaveChanges();
        }

        public void DeleteUser(int UserId)
        {
            var User = _context.Users.Where(s => s.UserId == UserId).FirstOrDefault();
            if (User != null)
            {
                _context.Remove(User);
                _context.SaveChanges();
            }
        }
    }
}
