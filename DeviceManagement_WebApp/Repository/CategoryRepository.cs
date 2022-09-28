using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Repository
{
    public class CategoryRepository
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

        // GET: All Categories
        public async Task<List<Category>> GetAll()
        {
            return _context.Category.ToList();
        }

        // GET: Categories by ID
        public async Task<Category> GetById(Guid? id)
        {
            var category = await _context.Category.FirstOrDefaultAsync(m => m.CategoryId == id);

            return (category);
        }

        // GET: Categories by Editting
        public async Task<Category> ByEdit(Guid? id)
        {
            var category = await _context.Category.FindAsync(id);
            
            return (category);
        }


        //GET: Delete Category
        public async Task<Category> ByDelete(Guid? id)
        {
            var category = await _context.Category.FirstOrDefaultAsync(m => m.CategoryId == id);
           
            return (category);
        }

    }
}
