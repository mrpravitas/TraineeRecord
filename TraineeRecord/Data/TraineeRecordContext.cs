using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TraineeRecord.Models;

namespace TraineeRecord.Data
{
    public class TraineeRecordContext : DbContext
    {
        public TraineeRecordContext (DbContextOptions<TraineeRecordContext> options)
            : base(options)
        {
        }

        public DbSet<TraineeRecord.Models.Intern> Intern { get; set; } = default!;
        public DbSet<TraineeRecord.Models.Project> Project { get; set; } = default!;
    }
}
