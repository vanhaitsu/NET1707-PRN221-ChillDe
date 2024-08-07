﻿using Microsoft.Data.SqlClient;

namespace IMS.Repositories.Common
{
    public class InitialSeeding
    {
        private static readonly string[] roles =
       {
           Enums.RoleEnum.Admin.ToString(),
           Enums.RoleEnum.HR.ToString(),
           Enums.RoleEnum.Mentor.ToString(),
        };


        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            var connectionString = "server = (local); Database = IMS; uid = sa; pwd = 12345; TrustServerCertificate = true";

            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                foreach (string role in roles)
                {
                    bool roleExists = await CheckRoleExistsAsync(connection, role);
                    if (!roleExists)
                    {
                        await AddRoleAsync(connection, role);
                    }
                }
            }
        }

        private static async Task<bool> CheckRoleExistsAsync(SqlConnection connection, string roleName)
        {
            var query = "SELECT COUNT(1) FROM Roles WHERE Name = @RoleName";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@RoleName", roleName);

                var result = (int)await command.ExecuteScalarAsync();
                return result > 0;
            }
        }

        private static async Task AddRoleAsync(SqlConnection connection, string roleName)
        {
            var query = "INSERT INTO Roles (Name, CreationDate, IsDeleted) VALUES (@RoleName, GETDATE(), 'false')";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@RoleName", roleName);

                await command.ExecuteNonQueryAsync();
            }
        }
    }
}