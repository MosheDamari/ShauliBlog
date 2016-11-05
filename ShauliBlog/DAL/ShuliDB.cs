using ShauliBlog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShauliBlog.DAL
{
    public class ShuliDB : DbContext
    {
        public DbSet<Comment> comments { get; set; }
        public DbSet<FanClubModel> FanClub { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}