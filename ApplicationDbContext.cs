using Microsoft.EntityFrameworkCore;

namespace ReSharperIssue;

public class ApplicationDbContext : DbContext
{
    public DbSet<Customer>? Customers { get; set; }
}