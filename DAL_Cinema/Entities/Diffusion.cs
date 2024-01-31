﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Cinema.Entities
{
    public class Diffusion
    {
        public int Id_Diffusion { get; set; }
        public DateTime DiffusionDate { get; set; }
        public TimeOnly DiffusionTime { get; set; }
        public string AudioLang { get; set; }
        public string? SubTitleLang { get; set; } 
        public int Id_CinemaRoom { get; set; }
        public int Id_Movie { get; set; }
    }
}