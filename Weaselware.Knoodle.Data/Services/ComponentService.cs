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
    class ComponentPartService
    {
        private readonly KnoodleContext _context;

        public ComponentPartService(KnoodleContext context)
        {
            _context = context;
        }
    }
}
