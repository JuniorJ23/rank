using System;
using System.Windows.Forms;
using Npgsql;

namespace Rank.Util
{
    class GetLogic
    {
        private NpgsqlDataReader dr;
        private NpgsqlCommand command;
        private NpgsqlConnection connection;

        internal GetLogic(NpgsqlConnection connection)
        {
            dr = null;
            this.connection = connection;
            connection.Close();
            connection.Open();
        }

        internal NpgsqlDataReader GetListTrainer()
        {
            try
            {
                using (command = new NpgsqlCommand("select name_trainer, id_trainer from tb_trainer order by name_trainer", connection))
                {
                    dr = command.ExecuteReader();
                }
            }
            catch { MessageBox.Show("Ocurrió un error al conectar con la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return dr;
        }

        internal bool AddBattle(int id, int trainer_winner, int trainer_losser, int pkm_w, int pkm_l, DateTime date, int id_type, char id_group)
        {
            bool flag = false;
            try
            {
                using (command = new NpgsqlCommand("insert into tb_battle values (:id_battle, :id_trainer_winner, :id_trainer_losser, :pkm_trainer_winner, :pkm_triner_losser, :date, :id_type, :id_group)", connection))
                {
                    command.Parameters.AddWithValue("id_battle", id);
                    command.Parameters.AddWithValue("id_trainer_winner", trainer_winner);
                    command.Parameters.AddWithValue("id_trainer_losser", trainer_losser);
                    command.Parameters.AddWithValue("pkm_trainer_winner", pkm_w);
                    command.Parameters.AddWithValue("pkm_triner_losser", pkm_l);
                    command.Parameters.AddWithValue("date", date);
                    command.Parameters.AddWithValue("id_type", id_type);
                    command.Parameters.AddWithValue("id_group", id_group);
                    if (command.ExecuteNonQuery().Equals(1)) { flag = true; }
                    else { flag = false; }
                }
            }
            catch { MessageBox.Show("Ocurrió un error al conectar con la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return flag;
        }
    }
}
