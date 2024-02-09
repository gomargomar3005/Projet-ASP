using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Cinema.Entities
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


        public Diffusion(int id_Diffusion, DateTime diffusionDate, TimeOnly diffusionTime, string? subTitleLang, int id_CinemaRoom, int id_Movie)
        {
            Id_Diffusion = id_Diffusion;
            DiffusionDate = diffusionDate;
            DiffusionTime = diffusionTime;
            SubTitleLang = subTitleLang;
            Id_CinemaRoom = id_CinemaRoom;
            Id_Movie = id_Movie;
        }
    }
}
