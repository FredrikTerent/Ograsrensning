﻿using Microsoft.EntityFrameworkCore;
using OgraasApi.Models;
using System;

namespace OgraasApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Board> Boards { get; set; }
        public DbSet<Cell> Cells { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Weed> Weeds { get; set; }
        public DbSet<Maskros> Maskros { get; set; }
        public DbSet<Kardborre> Kardborres { get; set; }
        public DbSet<Kvickrot> Kvickrots { get; set; }
        public DbSet<Kirskal> Kirskals { get; set; }
    }
}
