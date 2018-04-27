using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace Rank.Util
{
    class ExportToExcel
    {
        private string path;

        public ExportToExcel(XLWorkbook workbook)
        {
            path = DialgoSaveFile();
            if (!path.Equals(""))
            {
                try
                {
                    workbook.SaveAs(path);
                    MessageBox.Show("El archivo fue exportado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("El archivo esta siendo usado por otra aplicación", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public ExportToExcel(XLWorkbook workbook, string title)
        {
            path = DialgoSaveFile(title);
            if (!path.Equals(""))
            {
                try
                {
                    workbook.SaveAs(path);
                    MessageBox.Show("El archivo fue exportado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("El archivo esta siendo usado por otra aplicación", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private string DialgoSaveFile()
        {
            path = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo Excell|*.xlsx",
                Title = "Gardar archivo como hoja de cálculo"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!saveFileDialog.FileName.Equals("")) { path = Path.GetFullPath(saveFileDialog.FileName); }
                else { MessageBox.Show("No es un nombre válido", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            return path;
        }

        private string DialgoSaveFile(string title)
        {
            path = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo Excell|*.xlsx",
                Title = "Gardar archivo como hoja de cálculo",
                FileName = title
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!saveFileDialog.FileName.Equals("")) { path = Path.GetFullPath(saveFileDialog.FileName); }
                else { MessageBox.Show("No es un nombre válido", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            return path;
        }
    }
}
