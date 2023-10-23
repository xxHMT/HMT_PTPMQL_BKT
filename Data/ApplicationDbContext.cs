using Microsoft.EntityFrameworkCore;
using HMT_PTPMQL_BKT.Models;

namespace HMT_PTPMQL_BKT.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}

    }
}