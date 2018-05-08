using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using Rank.Util;

namespace Rank
{
    public partial class AddBattle : Form
    {
        DataTable listTrainer;
        private NpgsqlConnection connection;

        public AddBattle(DataTable dt)
        {
            InitializeComponent();
            connection = new ConnectionPostgreSQL().OpenConnection();

            listTrainer = dt;
            dtpDate.Value = DateTime.Today;
            dtpTime.Value = DateTime.Parse("00:00:00");

            foreach (DataRow row in listTrainer.Rows)
            {
                cmbWinner.Items.Add(row.ItemArray[0]);
                cmbLosser.Items.Add(row.ItemArray[0]);
            }
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (cmbWinner.SelectedIndex > -1
                && cmbLosser.SelectedIndex > -1
                && cmbType.SelectedIndex > -1
                && !txtPkmL.Text.Equals("")
                && !txtPkmW.Text.Equals("")
                )
            {
                int trainer_w = int.Parse(listTrainer.Rows[cmbWinner.SelectedIndex].ItemArray[1].ToString());
                int trainer_l = int.Parse(listTrainer.Rows[cmbLosser.SelectedIndex].ItemArray[1].ToString());
                int pkm_w = 1;
                int pkm_l = 0;
                string date = dtpDate.Value.ToShortDateString();
                string time = dtpTime.Value.ToShortTimeString();
                DateTime dateTime = DateTime.Parse(date + " " + time);
                int type = cmbType.SelectedIndex;
                char group = 'l';

                new ExecuteFunction(connection).AddBattle(999, trainer_w, trainer_l, pkm_w, pkm_l, dateTime, type, group);

                MessageBox.Show("Batalla agregada", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Datos Incompletos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}