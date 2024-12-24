using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace Inventory_Manger
{
    internal class Excel
    {
        string path = "";
        int sheet;
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        double last;
        public Excel(string path,int sheet)
        {
            this.path = path;
            this.sheet = sheet;
            wb = excel.Workbooks.Open(path);
            ws = excel.Worksheets[sheet];
         last = ws.Cells[1, 1].value2;

        }
        public string readCell(int i,int j)
        {
            
            return Convert.ToString(ws.Cells[i,j].value2);

        }
        public double RowLength
        {
            get
            {
                
                return ws.Cells[1, 1].value2;
            }
        }
        public void addCell(string product,string quantity,string mrp,double last)
        {
            try
            {
            ws.Cells[last + 1, 1].value2 = last;
            ws.Cells[last+1,2].value2 = product;
            ws.Cells[last + 1,3].value2 = quantity;
            ws.Cells[last + 1,4].value2 = mrp;
            wb.Save();

            }
            catch(COMException)
            {
                MessageBox.Show("Close the excel file");
            }
           
        }
        public void removeCell(int row)
        {

            /*            ws.Cells[row, 1].value2 = "";
                        ws.Cells[row, 2].value2 = "";
                        ws.Cells[row, 3].value2 = "";
                        ws.Cells[row, 4].value2 = "";*/
            try
            {
            _Excel.Range roww = ws.Rows[row];
            roww.Delete();
            wb.Save();

            }
            catch(COMException)
            {
                MessageBox.Show("Close the excel file");
            }
           
        }
        public void close()
        {
            wb.Close();
        }
        public void closeExcel()
        {
            Marshal.ReleaseComObject(excel);
            GC.Collect();
        }
        public void update()
        {
            wb = excel.Workbooks.Open(path);
            ws = excel.Worksheets[sheet];
        }
        public void closeSheet()
        {
            Marshal.ReleaseComObject(ws);
        }
    }
}
