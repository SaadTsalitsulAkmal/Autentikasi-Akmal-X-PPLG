using MySql.Data.MySqlClient;

namespace SchoolApp
{
    public static class Validation
    {
        public static bool UniqueData(string table, string entity, string inputUser)
        {
            Connection conn = new Connection();
            using (MySqlConnection connection = conn.ConnectionToSql())
            {
                bool isRegisted = false;
                try
                {
                    connection.Open();
                    string query = $"SELECT {entity} FROM {table} WHERE {entity} = @inputUser";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@inputUser", inputUser);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        // Jika count lebih besar dari 0, berarti data adda (true). Jika 0, data tidak ada (false).
                        isRegisted = count > 0;
                        return isRegisted;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Koneksi Gagal. Error: {ex.Message}");
                }
            }
            return false;
        }
    }
}