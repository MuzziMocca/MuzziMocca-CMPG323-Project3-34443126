using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class ZoneRepository
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

        // GET: All Zones
        public async Task<List<Zone>> GetAll()
        {
            return _context.Zone.ToList();
        }

        // GET: Zone by ID
        public async Task<Zone> GetById(Guid? id)
        {
            var zone = await _context.Zone.FirstOrDefaultAsync(m => m.ZoneId == id);
            
            return (zone);
        }

        // GET: Zone by Editting
        public async Task<Zone> ByEdit(Guid? id)
        {
            var zone = await _context.Zone.FindAsync(id);

            return (zone);
        }


        //GET: Delete Zone
        public async Task<Zone> ByDelete(Guid? id)
        {
            var zone = await _context.Zone.FirstOrDefaultAsync(m => m.ZoneId == id);
           
            return(zone);
        }

    }
}
