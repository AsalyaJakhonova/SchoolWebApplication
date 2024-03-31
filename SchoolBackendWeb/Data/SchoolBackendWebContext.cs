using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolBackendWeb.Models;

namespace SchoolBackendWeb.Data
{
    public class SchoolBackendWebContext : DbContext
    {
        public SchoolBackendWebContext (DbContextOptions<SchoolBackendWebContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolBackendWeb.Models.Lesson> Lesson { get; set; } = default!;

        public DbSet<SchoolBackendWeb.Models.Student>? Student { get; set; }

        public DbSet<SchoolBackendWeb.Models.Teacher>? Teacher { get; set; }
    }
}
