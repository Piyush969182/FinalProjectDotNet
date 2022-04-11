using FinalProject.Infra;
using FinalProject.models;
using FinalProject.Repo;
using FinalProject.services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        /* public IActionResult Index()
         {
             return View();
         }*/
        UsersServices _repo;
        public UsersController(UsersServices repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetUsers")]
        public IActionResult GetUsers()
        {
            var user = _repo.GetUsers();
            return Ok(user);
        }
        [HttpGet]
        [Route("GetUserById")]
        public IActionResult GetUserById(int UserId)
        {
            var UserById = _repo.GetUserById(UserId);
            return Ok(UserById);
        }
        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUser(Users User)
        {
            _repo.AddUser(User);
            return Ok();
        }
        [HttpPut]
        [Route("UpdateUser")]
        public IActionResult UpdateUser(Users User)
        {
            _repo.UpdateUser(User);
            return Ok();
        }
        [HttpDelete]
        [Route("DeleteUser")]
        public IActionResult DeleteUser(int UserId)
        {
            _repo.DeleteUser(UserId);
            return Ok();
        }
    }
}
