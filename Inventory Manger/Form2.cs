using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Sheets.v4.Data;
using Microsoft.Office.Interop.Excel;


namespace Inventory_Manger
{
    public partial class MainForm : Form
    {
        Form1 form1;
        string directory;
        Excel excel;
        double roww;
        public MainForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
             directory = Directory.GetCurrentDirectory();
             excel = new Excel(directory + "\\Book1.xlsx", 1);
            roww = excel.RowLength;
            //CreateFileWatcher(directory);
        }
            Panel panel = new Panel();

/*        public void CreateFileWatcher(string path)
        {
            // Create a new FileSystemWatcher and set its properties.
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = path;
            *//* Watch for changes in LastAccess and LastWrite times, and 
               the renaming of files or directories. *//*
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // Only watch text files.
            watcher.Filter = "*.xlsx";

            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);

            // Begin watching.
            watcher.EnableRaisingEvents = true;
        }

        // Define the event handlers.
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            // Specify what is done when a file is changed, created, or deleted.
           

        }

*/
        private void MainForm_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            System.Data.DataTable table = new System.Data.DataTable();


            int row, col;
            row = 3;
            col = 1;
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Product Name", typeof(string));
            table.Columns.Add("Quantity", typeof(string));
            table.Columns.Add("MRP", typeof(string));
            for (int i=1;i<roww; row++,i++)
            {
                    table.Rows.Add(excel.readCell(row,col), excel.readCell(row, col+1), excel.readCell(row, col+2), excel.readCell(row, col+3));
            }
            dataGridView1.DataSource = table;


        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            excel.closeSheet();
            excel.close();
            excel.closeExcel();
            form1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addItem.Show();
            removeItem.Show();

        }

        private void addItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.Show();
            
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(row);
            
            excel.removeCell(row+3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addItem.Hide();
            removeItem.Hide();
        }
        public void refresh_panel(string product, string quantity,string mrp)
        {
            
            roww++;
            excel.addCell(product,quantity,mrp,roww);
            
            System.Data.DataTable table = new System.Data.DataTable();
            
            table = (System.Data.DataTable)dataGridView1.DataSource;
            table.Rows.Add(Convert.ToString(roww),product,quantity,mrp);
            dataGridView1.DataSource = table;


      
            
            
        }
    }
}
