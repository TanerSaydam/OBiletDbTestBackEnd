using Microsoft.EntityFrameworkCore;

namespace OBiletDbTestBackEnd.Context;

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
}
