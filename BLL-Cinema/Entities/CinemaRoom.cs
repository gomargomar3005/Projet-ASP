using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Cinema.Entities
{
    public class CinemaRoom
    {
        public int Id_CinemaRoom { get; private set; }
        public int SeatsCount { get; set; }
        public int Number { get; set; }
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }
        public bool Can3D { get; set; }
        public bool Can4DX { get; set; }
        public int Id_CinemaPlace { get; set; }


        public CinemaRoom(int id_cinemaroom, int seatscount, int number, int screenwidth, int screenheight, bool can3d, bool can4dx, int id_cinemaplace)
        {
            Id_CinemaRoom = id_cinemaroom;
            SeatsCount = seatscount;
            Number = number;
            ScreenWidth = screenwidth;
            ScreenHeight = screenheight;
            Can3D = can3d;
            Can4DX = can4dx;
            Id_CinemaPlace = id_cinemaplace;
        }
    }
}