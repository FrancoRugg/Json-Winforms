using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp3.Models;

namespace Tp3_FrancoRuggiero
{
    public partial class frmDashboard : Form
    {
        private List<Product> products;
        public frmDashboard()
        {
            InitializeComponent();
            products = new List<Product>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetProducts();
        }

        public void GetProducts()
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string relativePath = Path.Combine(currentDirectory, "Db", "products.json");
            //string jsonFilePath = "C:\\Users\\fruggiero\\source\\repos\\Tp3-FrancoRuggiero\\Tp3-FrancoRuggiero\\Db\\products.json";
            //string jsonFilePath = "C:\\Users\\fruggiero\\source\\repos\\Tp3-FrancoRuggiero\\Tp3-FrancoRuggiero\\Db\\products.json";
            try
            {
                var jsonData = File.ReadAllText(relativePath);

                products = JsonConvert.DeserializeObject<List<Product>>(jsonData);

                grdDatos.DataSource = products;
                GetCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading JSON data: " + ex.Message);
            }
        }

        private void GetCount()
        {
            var currentProducts = grdDatos.DataSource as List<Product>;
            lblProducts.Text = "Total Productos: " + currentProducts.Count;
            lblMarca.Text = "Total Marcas: " + currentProducts.Select(p => p.NoM_Marca).Distinct().Count();
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtro = cmbFiltro.Text;

            if(cmbFiltro.Text == "All")
            {
                cmbColumnas.Visible = false;
                lblChange.Visible = false;

                GetProducts();
            }
            else
            {
                cmbColumnas.Visible = true;
                lblChange.Visible = true;

                lblChange.Text = "Filtrar por " + filtro + " :";


                var values = products
                            .Select(p => p.GetType().GetProperty(filtro)?.GetValue(p, null)?.ToString())
                            .Where(v => v != null)
                            .Distinct()
                            .OrderBy(v => v)
                            .ToList();

                cmbColumnas.DataSource = values;
                
                //var filteredData = products
                //.Where(p => p.GetType().GetProperty(filtro)?.GetValue(p, null)?.ToString() == filtro)
                //.ToList();

            }
        }

        private void cmbColumnas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColumn = cmbFiltro.Text;
            string selectedValue = cmbColumnas.Text;

            var filteredProducts = products
            .Where(p => p.GetType().GetProperty(selectedColumn)?.GetValue(p, null)?.ToString() == selectedValue)
            .ToList();

            grdDatos.DataSource = filteredProducts;
            GetCount();
        }


        private void exportarHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string deskPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//captura la ruta del escritorio
            string archivo = Path.Combine(deskPath, "Dashboard.html");

            ExportarHTML(grdDatos, archivo);
            
        }

        public static void ExportarHTML(DataGridView datagrid, string path)
        {
            StringBuilder sb = new StringBuilder();//Clase a utilizar si quiero generar un objeto con texto

            sb.Append("<html>");
            sb.Append("<head>");
            sb.Append("<style>");
            sb.Append("table {width 100%; border-collapse: collapse; }");
            sb.Append("th, td {border: solid 1px black; padding: 8px; text-align: left; }");
            sb.Append("th {background-color: #f2f2f2; }");
            sb.Append("</style>");
            sb.Append("</head>");
            sb.Append("<body>");

            sb.Append("<table>");

            sb.Append("<tr>");
            foreach (DataGridViewColumn column in datagrid.Columns)
            {
                sb.AppendFormat("<td>{0}</th>", column.HeaderText);
            }
            sb.Append("</tr>");

            foreach (DataGridViewRow row in datagrid.Rows)
            {
                if (row.IsNewRow) continue;
                sb.Append("<tr>");

                foreach (DataGridViewCell cell in row.Cells)
                {

                    sb.AppendFormat("<td>{0}</th>", cell.Value?.ToString() ?? string.Empty);
                }

                sb.Append("</tr>");
            }


            sb.Append("</table>");

            sb.Append("</body>");
            sb.Append("</html>");

            File.WriteAllText(path, sb.ToString());//Te pega todo el contenido agregado

            MessageBox.Show("Reporte Exportado Correctamente!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
