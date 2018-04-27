using System;
using System.Security.Cryptography;
using System.Text;
using Npgsql;

namespace Rank.Util
{
    public class User
    {
        internal string user;
        internal string pswd;
        internal char permision;
        private NpgsqlCommand command;
        private NpgsqlConnection connection;
        private NpgsqlDataReader dr;

        // Constructor
        internal User(string user, string pswd, NpgsqlConnection connection)
        {
            this.user = user;
            MD5 md5Hash = MD5.Create();
            this.pswd = GetMd5Hash(md5Hash, pswd);
            permision = 'x';
            this.connection = connection;
            connection.Close();
            connection.Open();
        }

        // Main methods
        internal bool Login()
        {
            bool flag = false;
            command = new NpgsqlCommand("SELECT * FROM tb_user WHERE \"user\" = :user", connection);
            command.Parameters.AddWithValue("user", user);
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                string userDB = dr[0].ToString();
                string pswdDB = dr[1].ToString();
                char permDB = char.Parse(dr[2].ToString());
                if (user.Equals(userDB) && pswd.Equals(pswdDB))
                {
                    flag = true;
                    permision = permDB;
                }
            }
            connection.Close();
            connection.Open();
            return flag;
        }

        internal bool ChangePass(string newPass)
        {
            bool flag;
            MD5 md5Hash = MD5.Create();
            string passEncrypted = GetMd5Hash(md5Hash, newPass);

            command = new NpgsqlCommand("UPDATE tb_user SET \"pswd\" = :pswd WHERE \"user\" = :user", connection);
            command.Parameters.AddWithValue("pswd", passEncrypted);
            command.Parameters.AddWithValue("user", user);
            command.Connection = connection;
            if (command.ExecuteNonQuery().Equals(1)) { flag = true; }
            else { flag = false; }

            connection.Close();
            connection.Open();
            return flag;
        }

        // Auxiliary methods
        private bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            string hashOfInput = GetMd5Hash(md5Hash, input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0.Equals(comparer.Compare(hashOfInput, hash))) { return true; }
            else { return false; }
        }

        private string GetMd5Hash(MD5 md5Hash, string text)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++) { sBuilder.Append(data[i].ToString("x2")); }
            return sBuilder.ToString();
        }

        internal bool ValidatePass(string passDesyncripted)
        {
            MD5 md5Hash = MD5.Create();
            if (VerifyMd5Hash(md5Hash, passDesyncripted, pswd)) { return true; }
            else { return false; }
        }
    }
}
