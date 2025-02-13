using Microsoft.EntityFrameworkCore;

namespace Assignment6_Durham.Models;

    public class MusicFormContext : DbContext
    {
        public MusicFormContext(DbContextOptions<MusicFormContext> options) : base(options) // Constructor
        {
        }
        
        public DbSet<SubmissionForm> Forms { get; set; }
    }


    