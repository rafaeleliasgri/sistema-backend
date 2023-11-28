using Controllers.Entities;
using MySql.Data.MySqlClient;

namespace Controllers.Repositories
{
    public class UsuarioRepository
    {
        private string _connectionString;

        public UsuarioRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int Inserir(Usuario usuario)
        {
            // Parei Aqui. precisou instalar a extensão MySql via comando:
            // "dotnet add package MySql.Data" no terminal
            var cnn = new MySqlConnection(_connectionString);

            var cmd = new MySqlCommand();
            cmd.Connection = cnn;

            cmd.CommandText = @"INSERT INTO usuario
                (nome, sobrenome, telefone, email, genero, senha, usuarioGuid)
                VALUES
                (@nome, @sobrenome, @telefone, @email, @genero, @senha, @usuarioGuid)";

            cmd.Parameters.AddWithValue("nome", usuario.Nome);
            cmd.Parameters.AddWithValue("sobrenome", usuario.Sobrenome);
            cmd.Parameters.AddWithValue("telefone", usuario.Telefone);
            cmd.Parameters.AddWithValue("email", usuario.Email);
            cmd.Parameters.AddWithValue("genero", usuario.Genero);
            cmd.Parameters.AddWithValue("senha", usuario.Senha);
            cmd.Parameters.AddWithValue("usuarioGuid", usuario.UsuarioGuid);

            cnn.Open();

            var affectedRows = cmd.ExecuteNonQuery();

            cnn.Close();

            return affectedRows;
        }

        public Usuario ObterUsuarioPorEmail(string email)
        {
            Usuario usuario = null;
            MySqlConnection cnn = new MySqlConnection(_connectionString);

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnn;

            cmd.CommandText = "SELECT * FROM usuario WHERE email= @email";

            cmd.Parameters.AddWithValue("email", email);

            cnn.Open();

            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                usuario = new Usuario();
                usuario.Nome = reader["nome"].ToString();
                usuario.Sobrenome = reader["sobrenome"].ToString();
                usuario.Telefone = reader["telefone"].ToString();
                usuario.Email = reader["email"].ToString();
                usuario.Genero = reader["genero"].ToString();
                usuario.Senha = reader["senha"].ToString();
                usuario.UsuarioGuid = new Guid(reader["usuarioGuid"].ToString());
            }

            return usuario;
        }

        public Usuario ObterPorGuid(Guid usuarioGuid)
        {
            Usuario usuario = null;

            var cnn = new MySqlConnection(_connectionString);

            var cmd = new MySqlCommand();
            cmd.Connection = cnn;

            cmd.CommandText = "SELECT * FROM usuario WHERE usuarioGuid = @usuarioGuid";

            cmd.Parameters.AddWithValue("usuarioGuid", usuarioGuid);

            cnn.Open();

            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                usuario = new Usuario();
                usuario = new Usuario();
                usuario.Nome = reader["nome"].ToString();
                usuario.Sobrenome = reader["sobrenome"].ToString();
                usuario.Telefone = reader["telefone"].ToString();
                usuario.Email = reader["email"].ToString();
                usuario.Genero = reader["genero"].ToString();
                usuario.Senha = reader["senha"].ToString();
                usuario.UsuarioGuid = new Guid(reader["usuarioGuid"].ToString());
            }

            cnn.Close();

            return usuario;
        }
    }
}