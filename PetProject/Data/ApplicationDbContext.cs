﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetProject.Models;

namespace PetProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Fighter> Fighters { get; set; }
        public DbSet<Name> Names { get; set; }
        public DbSet<Portrait> Portraits { get; set; }
        public DbSet<Opponent> Opponents { get; set; }
    }
}
