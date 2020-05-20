using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace timtro.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<AdminPermission> AdminPermissions { get; set; }
        public DbSet<PermissionDetail> PermissionDetails { get; set; }
    }
}