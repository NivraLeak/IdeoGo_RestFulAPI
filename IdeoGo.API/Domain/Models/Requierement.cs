﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdeoGo.API.Domain.Models
{
    public class Requierement
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public int ProjectId { get; set; }
        public Project Project { get; set; }


    }
}