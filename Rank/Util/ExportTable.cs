using System.Data;
using ClosedXML.Excel;

namespace Rank.Util
{
    class ExportTable
    {
        internal static void ExportTableData(IXLWorksheet worksheet, DataTable data, int firstRow, int firstColumn)
        {
            int lastRow = data.Rows.Count + firstRow;
            int lastColumn = data.Columns.Count + firstColumn + 1;

            int numRow = lastRow - firstRow + 1;
            int numColumn = lastColumn - firstColumn + 1;

            int lastValue = firstRow + 1;

            IXLRange rangeValues = worksheet.Range(firstRow + 1, firstColumn + 4, lastRow, lastColumn - 1);
            rangeValues.Style.NumberFormat.NumberFormatId = 3;

            rangeValues = worksheet.Range(firstRow + 1, lastColumn, lastRow, lastColumn);
            rangeValues.Style.NumberFormat.NumberFormatId = 10;

            rangeValues = worksheet.Range(firstRow + 1, firstColumn, lastRow, firstColumn + 3);
            rangeValues.Style.Font.SetBold(true);

            rangeValues = worksheet.Range(firstRow, lastColumn - 1, lastRow, lastColumn);
            rangeValues.Style.Font.SetBold(true);

            rangeValues = worksheet.Range(firstRow, firstColumn, firstRow, lastColumn);
            rangeValues.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            rangeValues.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            rangeValues.Style.Font.SetBold(true);


            // Data Table
            worksheet.Cell(firstRow, firstColumn).Value = "Posición";
            foreach (DataColumn column in data.Columns)
            {
                int actualColumn = column.Ordinal + firstColumn + 1;
                worksheet.Cell(firstRow, actualColumn).Value = column.ColumnName;
                worksheet.Column(actualColumn).Width = 10.71;
            }
            worksheet.Cell(firstRow, lastColumn).Value = "% Victorias";
            worksheet.Column(lastColumn).Width = 10.00;

            worksheet.Cell(firstRow + 1, firstColumn + 1).Value = data;
            worksheet.Column(firstColumn + 1).AdjustToContents();

            IXLRange range = worksheet.Range(firstRow, firstColumn, lastRow, lastColumn);
            range.Style.Border.SetInsideBorder(XLBorderStyleValues.Thin);
            range.Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin);

            var table = range.CreateTable();
            table.Theme = XLTableTheme.TableStyleMedium16;
            table.ShowAutoFilter = false;

            for (int i = 1; i < numRow; i++)
            {
                int actRow = firstRow + i;
                worksheet.Cell(actRow, firstColumn).FormulaA1 = "RANK(H" + actRow + ",$H$" + (firstRow + 1) + ":$H$" + lastRow + ",0)";
                worksheet.Cell(actRow, lastColumn).FormulaA1 = "F" + actRow + "/E" + actRow;
            }
        }
    }
}
