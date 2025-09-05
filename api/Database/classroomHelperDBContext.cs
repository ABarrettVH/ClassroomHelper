using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ClassroomHelperBackend.Models;
using Microsoft.Extensions.Configuration;

namespace ClassroomHelperBackend.Database;

public class ClassroomHelperDbContext : DbContext
{
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<TimetableSlot> TimetableSlots { get; set; }


    private IConfiguration _configuration;

    public ClassroomHelperDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration["ConnectionStrings:ClassroomHelperDb"]);
    }
}
