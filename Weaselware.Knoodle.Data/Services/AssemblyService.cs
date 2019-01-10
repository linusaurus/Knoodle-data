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
    public class AssemblyService
    {
        private readonly KnoodleContext _context;

        public AssemblyService(KnoodleContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Assembly>> GetAll()
        {
            return await _context.Assemblies.Include(s => s.SubAssemblies).ToListAsync();
        }

        public async Task<Assembly> Find(int id)
        {
            return await _context.Assemblies.Include(s => s.SubAssemblies).FirstOrDefaultAsync(i => i.AssemblyID==id);
        }
    }
}
