﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BLL = BLL_Cinema.Entities;
using DAL = DAL_Cinema.Entities;

namespace BLL_Cinema.Mappers
{
    internal static class Mapper
    {
        public static BLL.CinemaPlace ToBLL(this DAL.CinemaPlace entity)
        {
            if (entity is null) return null;
            return new BLL.CinemaPlace(
                entity.Id_CinemaPlace,
                entity.Name,
                entity.City,
                entity.Street,
                entity.Number);
        }

        public static DAL.CinemaPlace ToDAL(this BLL.CinemaPlace entity)
        {
            if (entity is null) return null;
            return new DAL.CinemaPlace()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name,
                City = entity.City,
                Street = entity.Street,
                Number = entity.Number,
        };
        }
    }
}