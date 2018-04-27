using System.Data;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace sComercial.Statistics
{
    class GetRank
    {
        private NpgsqlDataReader dr;
        private NpgsqlCommand command;
        private NpgsqlConnection connection;

        internal GetRank(NpgsqlConnection connection)
        {
            dr = null;
            this.connection = connection;
            connection.Close();
            connection.Open();
        }

        internal NpgsqlDataReader getRankLeague()
        {
            try
            {
                using (command = new NpgsqlCommand("fnc_rank_league", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    dr = command.ExecuteReader();
                }
            }
            catch { MessageBox.Show("Ocurrió un error al conectar con la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return dr;
        }
    }
}