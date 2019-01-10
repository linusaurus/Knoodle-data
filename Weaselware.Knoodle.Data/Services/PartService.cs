using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using Weaselware.Knoodle.Data.EFCode;
using Weaselware.Knoodle.Data.Models;
using System.Text;
using System.Threading.Tasks;

namespace Weaselware.Knoodle.Data.Services
{
    public class PartService
    {
        private readonly Weaselware.Knoodle.Data.EFCode.KnoodleContext _context;

        public PartService(KnoodleContext context)
        {
            _context = context;
        }

        public  async Task<Dictionary<int,Part>> GetAllParts()
        {
 
              return await _context.Part.ToDictionaryAsync(key => key.PartID);
        }

        public async Task<Dictionary<int, Part>> Find(int id)
        {

            return await _context.Part.Where(p => p.PartID == id).ToDictionaryAsync(key => key.PartID);
        }


    }
}
