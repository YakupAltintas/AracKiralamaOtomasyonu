using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu1
{
    class csExceleGonder
    {
        public void Excel(DataGridView dataGridView)
        {
            Excel.Application app = new Excel.Application();
            Workbook kitap = app.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sayfa = (Worksheet)kitap.Sheets[1];
            app.Visible = true;
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                Range alan = (Range)sayfa.Cells[1, 1];
                alan.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                
            }
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView.Rows.Count ; j++)
                {
                    Range alan2 = (Range)sayfa.Cells[j + 1, i + 1];
                    alan2.Cells[2, 1] = dataGridView[i,j].Value;
                }
            }

        }
    }
}
