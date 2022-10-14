using TE_CODEFIRST_CRUD.Models;
using Microsoft.EntityFrameworkCore;


namespace TE_CODEFIRST_CRUD.Data
{
    public class TraineeDbContext:DbContext
    {
        public TraineeDbContext(DbContextOptions<TraineeDbContext> options) : base(options)
        {

        }
        public DbSet<Trainee> Trainees { get; set; }
    }
}
