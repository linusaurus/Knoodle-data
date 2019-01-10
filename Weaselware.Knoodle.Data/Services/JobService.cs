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
    public class JobService
    {
        private readonly Weaselware.Knoodle.Data.EFCode.KnoodleContext _context;

        public JobService(KnoodleContext context)
        {
            _context = context;
        }

        public async Task<Dictionary<int, Job>> GetAllJobs()
        {

            return await _context.Job.AsNoTracking().ToDictionaryAsync(key => key.Job_id);
        }

        public async Task<Job> Find(int id)
        {

            return await _context.Job.Include(m => m.ProductionGroup).Where(p => p.Job_id == id).SingleOrDefaultAsync();
        }
        


    }
}
