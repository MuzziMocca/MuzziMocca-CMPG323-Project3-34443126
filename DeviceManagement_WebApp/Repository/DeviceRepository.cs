using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Repository
{
    public class DeviceRepository
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

        // GET: All Devices
        public async Task<List<Device>> GetAll()
        {
            var device = _context.Device.Include(d => d.Category).Include(d => d.Zone);
            return (await device.ToListAsync());
         
        }

        // GET: Categories by ID
        public async Task<Device> GetById(Guid? id)
        {

            var device = await _context.Device
                .Include(d => d.Category)
                .Include(d => d.Zone)
                .FirstOrDefaultAsync(m => m.DeviceId == id);
            
            return (device);
        }

        // GET: Categories by Editting
        public async Task<Device> ByEdit(Guid? id)
        {
            var device = await _context.Device.FindAsync(id);
            
            return (device);
        }


        //GET: Delete Category
        public async Task<Device> ByDelete(Guid? id)
        {
            var device = await _context.Device
                .Include(d => d.Category)
                .Include(d => d.Zone)
                .FirstOrDefaultAsync(m => m.DeviceId == id);
            
            return (device);
        }
    }
}