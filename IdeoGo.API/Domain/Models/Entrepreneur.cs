﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdeoGo.API.Domain.Models
{
    public class Entrepreneur : User
    {

        public int ProfileId { get; set; }
        public Profile Profile { get; set; }

        public IList<Project> Projects { get; set; } = new List<Project>();
        public IList<Request> Requests { get; set; } = new List<Request>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Request>()

            .HasOne(b => b.Project)
            .WithMany(i => i.Requests);
    }


    }
}
