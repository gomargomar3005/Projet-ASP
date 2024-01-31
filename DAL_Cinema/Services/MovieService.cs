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
    internal class MovieService : BaseService,
        IMovieRepository<Movie>
    {
        public MovieService(IConfiguration configuration, string dbname) : base(configuration, dbname)
        {
        }
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Movie_Delete";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'est pas das la base de données");
                }
            }
        }

        public IEnumerable<Movie> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = connection.CreateCommand();
                command.CommandText = "SP_Movie_GetAll";
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return reader.ToMovie();
                    }
                }
            }
        }

        public Movie Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = connection.CreateCommand();
                command.CommandText = "SP_Movie_GetById";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) return reader.ToMovie();
                    throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la base de données.");
                }

            }
        }

        public int Insert(Movie data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Movie_Insert";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("id_movie", data.Id_Movie);
                    command.Parameters.AddWithValue("title", data.Title);
                    command.Parameters.AddWithValue("subTitle", data.SubTitle);
                    command.Parameters.AddWithValue("releaseYear", data.ReleaseYear);
                    command.Parameters.AddWithValue("synopsis", data.Synopsis);
                    command.Parameters.AddWithValue("posterUrl", data.PosterUrl);
                    command.Parameters.AddWithValue("duration", data.Duration);


                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(Movie data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaPlace_Update";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("id_movie", data.Id_Movie);
                    command.Parameters.AddWithValue("title", data.Title);
                    command.Parameters.AddWithValue("subTitle", data.SubTitle);
                    command.Parameters.AddWithValue("releaseYear", data.ReleaseYear);
                    command.Parameters.AddWithValue("synopsis", data.Synopsis);
                    command.Parameters.AddWithValue("posterUrl", data.PosterUrl);
                    command.Parameters.AddWithValue("duration", data.Duration);

                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(data.Id_Movie), $"L'identifiant {data.Id_Movie} n'est pas das la base de données");
                }
            }
        }
    }
}
