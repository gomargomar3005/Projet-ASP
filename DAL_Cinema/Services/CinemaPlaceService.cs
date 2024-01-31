using System;
using Shared_Cinema.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Cinema.Entities;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using DAL_Cinema.Mappers;

namespace DAL_Cinema.Services
{
    public class CinemaPlaceService : BaseService,
        ICinemaPlaceRepository<CinemaPlace>
    {
        public CinemaPlaceService(IConfiguration configuration, string dbname) : base(configuration, dbname)
        {
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaPlace_Delete";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'est pas das la base de données");
                }
            }
        }

        public IEnumerable<CinemaPlace> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = connection.CreateCommand();
                command.CommandText = "SP_CinemaPlace_GetAll";
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return reader.ToCinemaPlace();
                    }
                }
            }
        }

        public CinemaPlace Get(int id) {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = connection.CreateCommand();
                command.CommandText = "SP_CinemaPlace_GetById";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) return reader.ToCinemaPlace();
                    throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la base de données.");
                }
                
            }
        }

        public int Insert(CinemaPlace data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaPlace_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_CinemaPlace", data.Id_CinemaPlace);
                    command.Parameters.AddWithValue("name", data.Name);
                    command.Parameters.AddWithValue("city", data.City);
                    command.Parameters.AddWithValue("street", data.Street);
                    command.Parameters.AddWithValue("number", data.Number);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(CinemaPlace data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaPlace_Update";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("id_CinemaPlace", data.Id_CinemaPlace);
                    command.Parameters.AddWithValue("name", data.Name);
                    command.Parameters.AddWithValue("city", data.City);
                    command.Parameters.AddWithValue("street", data.Street);
                    command.Parameters.AddWithValue("number", data.Number);

                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(data.Id_CinemaPlace), $"L'identifiant {data.Id_CinemaPlace} n'est pas das la base de données");
                }
            }
        }
    }
}
