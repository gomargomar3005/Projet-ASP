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
    internal class DiffusionService : BaseService,
        IDiffusionRepository<Diffusion>
    {
        public DiffusionService(IConfiguration configuration, string dbname) : base(configuration, dbname)
        {
        }
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Diffusion_Delete";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'est pas das la base de données");
                }
            }
        }

        public IEnumerable<Diffusion> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = connection.CreateCommand();
                command.CommandText = "SP_Diffusion_GetAll";
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return reader.ToDiffusion();
                    }
                }
            }
        }

        public Diffusion Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = connection.CreateCommand();
                command.CommandText = "SP_Diffusion_GetById";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) return reader.ToDiffusion();
                    throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la base de données.");
                }

            }
        }

        public int Insert(Diffusion data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaPlace_Insert";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("id_diffusion", data.Id_Diffusion);
                    command.Parameters.AddWithValue("diffusionDate", data.DiffusionDate);
                    command.Parameters.AddWithValue("diffusionTime", data.DiffusionTime);
                    command.Parameters.AddWithValue("audioLang", data.AudioLang);
                    command.Parameters.AddWithValue("subtitleLang", data.SubTitleLang);
                    command.Parameters.AddWithValue("id_cinemaRoom", data.Id_CinemaRoom);
                    command.Parameters.AddWithValue("id_movie", data.Id_Movie);

                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(Diffusion data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Diffusion_Update";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("id_diffusion", data.Id_Diffusion);
                    command.Parameters.AddWithValue("diffusionDate", data.DiffusionDate);
                    command.Parameters.AddWithValue("diffusionTime", data.DiffusionTime);
                    command.Parameters.AddWithValue("audioLang", data.AudioLang);
                    command.Parameters.AddWithValue("subtitleLang", data.SubTitleLang);
                    command.Parameters.AddWithValue("id_cinemaRoom", data.Id_CinemaRoom);
                    command.Parameters.AddWithValue("id_movie", data.Id_Movie);

                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(data.Id_Diffusion), $"L'identifiant {data.Id_Diffusion} n'est pas das la base de données");
                }
            }
        }
    }
}
