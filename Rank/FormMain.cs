using System.Windows.Forms;
using ClosedXML.Excel;
using Npgsql;
using Rank.Util;

namespace Rank
{
    public partial class FormMain : Form
    {
        private NpgsqlConnection connection;

        public FormMain()
        {
            InitializeComponent();
            connection = new ConnectionPostgreSQL().OpenConnection();
        }

        private void pokémonLeagueToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ExportStatistics Export = new ExportStatistics(new XLWorkbook());
            Export.AddRankLeague();
            Export.ExportExcel("Rank Pokémon League");
        }
    }
}
