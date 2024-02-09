using DAL_Cinema.Entities;
using Microsoft.Extensions.Configuration;
using Shared_Cinema.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Cinema.Mappers;

namespace DAL_Cinema.Services
{
    public class CinemaRoomService : BaseService,
        ICinemaRoomRepository<CinemaRoom>
    {
        public CinemaRoomService(IConfiguration configuration, string dbname) : base(configuration, dbname)
        {
        }
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaRoom_Delete";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'est pas das la base de données");
                }
            }
        }

        public IEnumerable<CinemaRoom> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = connection.CreateCommand();
                command.CommandText = "SP_CinemaRoom_GetAll";
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return reader.ToCinemaRoom();
                    }
                }
            }
        }

        public CinemaRoom Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = connection.CreateCommand();
                command.CommandText = "SP_CinemaRoom_GetById";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) return reader.ToCinemaRoom();
                    throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la base de données.");
                }

            }
        }

        public int Insert(CinemaRoom data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaRoom_Insert";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("id_CinemaRoom", data.Id_CinemaRoom);
                    command.Parameters.AddWithValue("seatsCount", data.SeatsCount);
                    command.Parameters.AddWithValue("number", data.Number);
                    command.Parameters.AddWithValue("screenWidth", data.ScreenWidth);
                    command.Parameters.AddWithValue("screenHeight", data.ScreenHeight);
                    command.Parameters.AddWithValue("can3d", data.Can3D);
                    command.Parameters.AddWithValue("can4dx", data.Can4DX);
                    command.Parameters.AddWithValue("id_cinemaRoom", data.Id_CinemaRoom);

                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(CinemaRoom data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaRoom_Update";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("id_CinemaRoom", data.Id_CinemaRoom);
                    command.Parameters.AddWithValue("seatsCount", data.SeatsCount);
                    command.Parameters.AddWithValue("number", data.Number);
                    command.Parameters.AddWithValue("screenWidth", data.ScreenWidth);
                    command.Parameters.AddWithValue("screenHeight", data.ScreenHeight);
                    command.Parameters.AddWithValue("can3d", data.Can3D);
                    command.Parameters.AddWithValue("can4dx", data.Can4DX);
                    command.Parameters.AddWithValue("id_cinemaRoom", data.Id_CinemaRoom);

                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(data.Id_CinemaRoom), $"L'identifiant {data.Id_CinemaRoom} n'est pas das la base de données");
                }
            }
        }
    }
}