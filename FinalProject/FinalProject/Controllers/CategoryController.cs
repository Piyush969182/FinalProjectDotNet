using AutoMapper;
using FinalProject.models;
using FinalProject.services;
using FinalProject.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
        }*/
        CategoryServices _repo;
        public CategoryController(CategoryServices repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetCategory")]
        public IActionResult GetCategory()
        {
            try
            {
                var Category = _repo.GetCategory();
                return Ok(Category);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetCategoryById")]
        public IActionResult GetCategoryById(int CategoryId)
        {
            try
            {
                var Category = _repo.GetCategoryById(CategoryId);
                return Ok(Category);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddCategory")]
        public IActionResult AddCategory(CategoryVM CategoryVM)
        {
            try
            {
                _repo.AddCategory(CategoryVM);
                return Ok(new Response { Status = "Success", Message = "Category Added successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateCategory")]
        public IActionResult UpdateCategory(CategoryVM CategoryVM)
        {
            try
            {
                _repo.UpdateCategory(CategoryVM);
                return Ok(new Response { Status = "Success", Message = "Category Updated successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteCategory")]
        public IActionResult DeleteCategory(int CategoryId)
        {
            try
            {
                _repo.DeleteCategory(CategoryId);
                return Ok(new Response { Status = "Success", Message = "Category Deleted successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
