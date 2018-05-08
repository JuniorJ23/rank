using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;
using Npgsql;
using Rank.Util;

namespace Rank
{
    public partial class FormMain : Form
    {
        private NpgsqlConnection connection;
        DataTable listTrainer;

        public FormMain()
        {
            InitializeComponent();
            connection = new ConnectionPostgreSQL().OpenConnection();
            listTrainer = new ExecuteFunction(connection).GetTrainer();
        }

        private void LeagueToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ExportStatistics Export = new ExportStatistics(new XLWorkbook());
            Export.AddRankLeague();
            Export.ExportExcel("Rank Pokémon League");
        }

        private void AddBattleToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new AddBattle(listTrainer)
            {
                Visible = true
            };
        }
    }
}
