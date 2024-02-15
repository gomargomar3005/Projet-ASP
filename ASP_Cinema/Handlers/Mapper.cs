using ASP_Cinema.Models;
using BLL_Cinema.Entities;

namespace ASP_Cinema.Handlers
{
    public static class Mapper
    {
        #region CinemaPlace
        public static CinemaPlaceListViewModel ToListItem(this CinemaPlace entity)
        {
            if (entity is null) return null;
            return new CinemaPlaceListViewModel()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name,
                City = entity.City,
                Street = entity.Street,
                Number = entity.Number
            };
        }

        public static CinemaPlaceDetailsViewModel ToDetails(this CinemaPlace entity)
        {
            if (entity is null) return null;
            return new CinemaPlaceDetailsViewModel()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name,
                City = entity.City,
                Street = entity.Street,
                Number = entity.Number
            };
        }

        public static CinemaPlace ToBLL(this CinemaPlaceCreateForm entity)
        {
            if (entity is null) return null;
            return new CinemaPlace(
                0,
                entity.Name,
                entity.City,
                entity.Street,
                entity.Number);
        }

        #endregion

        #region CinemaRoom

        public static CinemaRoom ToBLL(this CinemaRoomCreateForm entity)
        {
            if (entity is null) return null;
            return new CinemaRoom(
                0,
                entity.SeatsCount,
                entity.Number,
                entity.ScreenWidth,
                entity.ScreenHeight,
                entity.Can3D,
                entity.Can4DX,
                0);
        }

        public static CinemaRoomListViewModel ToListItem(this CinemaRoom entity)
        {
            if (entity is null) return null;
            return new CinemaRoomListViewModel()
            {
                SeatsCount = entity.SeatsCount,
                Number = entity.Number,
                ScreenWidth = entity.ScreenWidth,
                ScreenHeight = entity.ScreenHeight,
                Can3D = entity.Can3D,
                Can4DX = entity.Can4DX,
                Id_CinemaPlace = entity.Id_CinemaPlace
            };
        }

        public static CinemaRoomDetailsViewModel ToDetails(this CinemaRoom entity)
        {
            if (entity is null) return null;
            return new CinemaRoomDetailsViewModel()
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

        public static DiffusionDetailsViewModel ToDetails(this Diffusion entity)
        {
            if (entity is null) return null;
            return new DiffusionDetailsViewModel()
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

        public static DiffusionListViewModel ToListItem(this Diffusion entity)
        {
            if (entity is null) return null;
            return new DiffusionListViewModel()
            {
                Id_Diffusion = entity.Id_Diffusion,
                DiffusionDate = entity.DiffusionDate,
                DiffusionTime = entity.DiffusionTime,
                Id_CinemaRoom = entity.Id_CinemaRoom,
                Id_Movie = entity.Id_Movie
            };
        }

        public static Diffusion ToBLL(this DiffusionCreateForm entity)
        {
            if (entity is null) return null;
            return new Diffusion(
                0,
                entity.DiffusionDate,
                entity.DiffusionTime,
                entity.AudioLang,
                0,
                0);
        }

        #endregion
    }
}
