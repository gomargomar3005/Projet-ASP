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
        #region CinemaPlace
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
        #endregion

        #region CinemaRoom

        public static BLL.CinemaRoom ToBLL (this DAL.CinemaRoom entity)
        {
            if (entity is null) return null;
            return new BLL.CinemaRoom(
                entity.Id_CinemaRoom,
                entity.SeatsCount,
                entity.Number,
                entity.ScreenWidth,
                entity.ScreenHeight,
                entity.Can3D,
                entity.Can4DX,
                entity.Id_CinemaPlace);
        }

        public static DAL.CinemaRoom ToDAL(this BLL.CinemaRoom entity)
        {
            if (entity is null) return null;
            return new DAL.CinemaRoom()
            {
                Id_CinemaRoom = entity.Id_CinemaRoom,
                SeatsCount = entity.SeatsCount,
                Number = entity.Number,
                ScreenWidth = entity.ScreenWidth,
                ScreenHeight = entity.ScreenHeight,
                Can3D = entity.Can3D,
                Can4DX = entity.Can4DX,
                Id_CinemaPlace = entity.Id_CinemaPlace
            };
        }

            #endregion

            #region Diffusion

            public static BLL.Diffusion ToBLL(this DAL.Diffusion entity)
            {
                if (entity is null) return null;
            return new BLL.Diffusion(
                entity.Id_Diffusion,
                entity.DiffusionDate,
                entity.DiffusionTime,
                entity.SubTitleLang,
                entity.Id_CinemaRoom,
                entity.Id_Movie
                );
            }

            public static DAL.Diffusion ToDAL(this BLL.Diffusion entity)
            {
                if (entity is null) return null;
                return new DAL.Diffusion()
                {
                    Id_Diffusion = entity.Id_Diffusion,
                    DiffusionDate = entity.DiffusionDate,
                    DiffusionTime = entity.DiffusionTime,
                    AudioLang = entity.AudioLang,
                    SubTitleLang = entity.SubTitleLang,
                    Id_CinemaRoom = entity.Id_CinemaRoom,
                    Id_Movie = entity.Id_Movie
        };

            }
        #endregion

        #region Movie

        public static BLL.Movie ToBLL(this DAL.Movie entity)
        {
            if (entity is null) return null;
            return new BLL.Movie(
                entity.Id_Movie,
                entity.SubTitle,
                entity.ReleaseYear,
                entity.Synopsis,
                entity.PosterUrl,
                entity.Duration
                );
        }
        public static DAL.Movie ToDAL(this BLL.Movie entity)
        {
            if (entity is null) return null;
            return new DAL.Movie()
            {
                Id_Movie = entity.Id_Movie,
                SubTitle = entity.SubTitle,
                ReleaseYear = entity.ReleaseYear,
                Synopsis = entity.Synopsis,
                PosterUrl = entity.PosterUrl,
                Duration = entity.Duration
            };

        }

        #endregion
    }

}
