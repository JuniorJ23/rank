using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;

namespace Rank.Util
{
    internal class TableData
    {
        public DataTable ConvertDataTable(NpgsqlDataReader dataReader)
        {
            if (!(dataReader is null))
            {
                DataTable dtSchema = dataReader.GetSchemaTable();
                DataTable dataTable = new DataTable();

                List<DataColumn> listCols = new List<DataColumn>();
                if (!(dtSchema is null))
                {
                    foreach (DataRow drow in dtSchema.Rows)
                    {
                        string columnName = Convert.ToString(drow["ColumnName"]);
                        DataColumn column = new DataColumn(columnName, (Type)(drow["DataType"]));
                        listCols.Add(column);
                    }
                    dataTable.Columns.AddRange(listCols.ToArray());
                }
                while (dataReader.Read())
                {
                    DataRow dataRow = dataTable.NewRow();
                    for (int i = 0; i < listCols.Count; i++) { dataRow[listCols[i]] = dataReader[i]; }
                    dataTable.Rows.Add(dataRow);
                }
                return dataTable;
            }
            else { return null; }
        }

        internal DataTable GenerateTransposedTable(DataTable inputTable)
        {
            if (!(inputTable is null))
            {
                DataTable outputTable = new DataTable();
                outputTable.Columns.Add(inputTable.Columns[0].ColumnName.ToString());

                foreach (DataRow inRow in inputTable.Rows)
                {
                    string newColName = inRow[0].ToString();
                    outputTable.Columns.Add(newColName, typeof(decimal));
                }

                for (int rCount = 1; rCount <= inputTable.Columns.Count - 1; rCount++)
                {
                    DataRow newRow = outputTable.NewRow();

                    newRow[0] = inputTable.Columns[rCount].ColumnName.ToString();
                    for (int cCount = 0; cCount <= inputTable.Rows.Count - 1; cCount++)
                    {
                        string colValue = inputTable.Rows[cCount][rCount].ToString();
                        if (colValue.Equals("")) { newRow[cCount + 1] = DBNull.Value; }
                        else { newRow[cCount + 1] = colValue; }
                    }
                    outputTable.Rows.Add(newRow);
                }
                return outputTable;
            }
            else { return null; }
        }
    }
}
