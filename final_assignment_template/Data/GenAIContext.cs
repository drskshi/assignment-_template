using final_assignment_template.Models;
using Microsoft.EntityFrameworkCore;

public class GenAIContext : DbContext
{
    public GenAIContext(DbContextOptions<GenAIContext> options)
        : base(options)
    {
    }

    public DbSet<GenAI> GenAIs { get; set; }
}