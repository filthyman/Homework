using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Services
{
    public class GroupsProvider
    {
        private SqlConnection _connection;
        public GroupsProvider(SqlConnection connection)
        {
            _connection = connection;
        }
        public List<Groups> GetAll( ) 
        {
            List<Groups> result = new List<Groups>();
            try
            {
                _connection.Open();
                var command = new SqlCommand(@"
                                                SELECT [groups_id], [Groups].[name], [year], [specialty_id], [Specialties].[name], [Specialties].[code] 
                                                FROM [Groups]
                                                LEFT JOIN [Specialties] 
                                                ON [Groups].[specialty_id] = [Specialties].[id];

                                               ", _connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var group = new Groups
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Year = reader.GetInt32(2),
                            SpecialtyId =reader.GetInt32(3)

                        };
                        var specialty = new Specialty
                        {
                            Id = reader.GetInt32(4),
                            Code = reader.GetString(5),
                            Name = reader.GetString(6)
                        };
                        group.Specialty = specialty;

                        result.Add(group);
                    }
                }

            }
            finally
            {
                _connection.Close();
            }

            return result;
        }
        public bool Add(Groups groups) 
        {
            bool result = false;
            try
            {
                _connection.Open();
                var command = new SqlCommand(
                    cmdText:
                    @"
                            INSERT INTO [Groups]
                                ([name], [year])
                            VALUES
                                (@Name, @Year)

                    ", _connection);
                command.Parameters.AddWithValue("@Name", groups.Name);
                command.Parameters.AddWithValue("@Year", groups.Year);
            }
            finally 
            {
                _connection.Close();

            }

            return result;
        }
        public bool Update(int id, Groups groups) 
        {
            bool result = false;
            try
            {
                _connection.Open();
                var command = new SqlCommand
                    (@"
                        UPDATE [Groups]
                        SET
                            [year] = @Уear,
                            [name] = @Name
                        WHERE
                            [id] = @Id

                    ", _connection);
                command.Parameters.AddWithValue("@Name", groups.Name);
                command.Parameters.AddWithValue("@Year", groups.Year);
                command.Parameters.AddWithValue("@Id", groups.Id);
            }
            finally
            {
                _connection.Close();

            }
            return result;
        }
        public bool Delete(int id) 
        {
            bool result = false;
            try
            {
                _connection.Open();
                var command = new SqlCommand(
                    @"
                        DELETE FROM [Groups]
                        WHERE [id] = @Id
                    ",
                    _connection
                    );
                command.Parameters.AddWithValue("@Id", id);

                result = command.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();

            }
            return result;
        }

    }
}
