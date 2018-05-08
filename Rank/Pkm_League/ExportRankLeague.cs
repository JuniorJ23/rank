using System.Data;
using ClosedXML.Excel;
using Npgsql;
using Rank.Util;

namespace Rank.Pkm_League
{
    class ExportRankLeague
    {
        NpgsqlConnection connection;

        public ExportRankLeague(XLWorkbook workbook)
        {
            ConnectionPostgreSQL accion = new ConnectionPostgreSQL();
            connection = accion.OpenConnection();
            DataTable dataRank = GenerateData(connection);
            AddRankLeague(workbook, dataRank);
        }


        internal DataTable GenerateData(NpgsqlConnection connection)
        {
            return new ExecuteFunction(connection).GetRankLeague();
        }

        internal void AddRankLeague(XLWorkbook workbook, DataTable dataRank)
        {
            IXLWorksheet worksheet = workbook.Worksheets.Add("rank_league");
            worksheet.ShowGridLines = false;

            int firstRow = 1;
            int firstColum = 1;

            worksheet.Cell(firstRow, firstColum).Value = "Rank Pkm League";
            worksheet.Cell(firstRow, firstColum).Style.Font.SetBold(true).Font.SetFontSize(18);
            worksheet.Cell(firstRow, firstColum).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            worksheet.Cell(firstRow, firstColum).Style.Font.FontName = "Berlin Sans FB Demi";
            worksheet.Range(firstRow, firstColum, firstRow, dataRank.Columns.Count + 1 + firstColum).Merge();

            ExportTable.ExportTableData(worksheet, dataRank, firstRow + 1, 1);
        }
    }
}
;