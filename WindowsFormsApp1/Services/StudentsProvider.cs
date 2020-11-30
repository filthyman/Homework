using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using System.Data.SqlClient;


namespace WindowsFormsApp1.Services
{
    class StudentsProvider
    {
        private SqlConnection _connection;
        public StudentsProvider(SqlConnection connection)
        {
            _connection = connection;
        }
        public List<Student> GetAll() 
        {
            List<Student> result = new List<Student>();
            try
            {
                _connection.Open();
                var command = new SqlCommand(@"
                                                SELECT [group_id], [Groups].[name], [Groups].[year], [Students].[id], [Students].[name], [Students].[surname] 
                                                FROM [Students]
                                                LEFT JOIN [Groups] 
                                                ON [Students].[group_id] = [Groups].[id];

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

                        };
                        var student = new Student
                        {
                            Id = reader.GetInt32(4),
                            Name = reader.GetString(5),
                            Surname = reader.GetString(6),
                        };
                        student.Group = group;

                        result.Add(student);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return result;

        }

        public bool Add(Student student)
        {
            bool result = false;

            try
            {
                _connection.Open();
                var command = new SqlCommand(cmdText: @"
                                                        INSERT INTO [Students]
                                                            ([name], [surname])
                                                        VALUES
                                                            (@Name, @Surname)
                                                        ", _connection);
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@Code", student.Surname);

                result = command.ExecuteNonQuery() > 0;

            }
            finally 
            {
                _connection.Close();
            }
            return result;

        }

        public bool Update(int id, Student student)
        {
            bool result = false;
            try
            {
                _connection.Open();
                var command = new SqlCommand(
                    @"
                        UPDATE [Students]
                        SET
                            [surname] = @Surname,
                            [name] = @Name,
                            [groupId] = @GroupId
                        WHERE
                            [id] = @Id
                        "
                    , _connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Code", student.Surname);
                command.Parameters.AddWithValue("@Name", student.Name);

                result = command.ExecuteNonQuery() > 0;
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
                        DELETE FROM [Students]
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
