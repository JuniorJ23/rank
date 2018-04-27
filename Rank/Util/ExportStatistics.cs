using System.Data;
using ClosedXML.Excel;
using Rank.Pkm_League;

namespace Rank.Util
{
    class ExportStatistics
    {
        private XLWorkbook workbook;

        public ExportStatistics(XLWorkbook workbook) => this.workbook = workbook;

        internal void AddRankLeague()
        {
            var accion = new ExportRankLeague(workbook);
        }

        internal void ExportExcel(string title)
        {
            ExportToExcel accion = new ExportToExcel(workbook, title);
        }
    }
}
