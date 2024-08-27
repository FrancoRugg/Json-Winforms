using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tp3.Models;

namespace Tp3.Services.Services
{
    public class ProductService
    {
        
        //public void GetProducts()
        //{
        //    string jsonFilePath = "C:\\Users\\fruggiero\\source\\repos\\Tp3-FrancoRuggiero\\Tp3-FrancoRuggiero\\Db\\products.json";


        //    try
        //    {
        //        var jsonData = File.ReadAllText(jsonFilePath);

        //        var users = JsonConvert.DeserializeObject<List<Product>>(jsonData);

        //        grdDatos.DataSource = users;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error loading JSON data: " + ex.Message);
        //    }
        //}

        //private void AddComboBoxFilters()
        //{
        //    foreach (DataGridViewColumn column in grdDatos.Columns)
        //    {
        //        if (column.CellType == typeof(DataGridViewTextBoxCell))
        //        {
        //            ComboBox comboBox = new ComboBox
        //            {
        //                Name = "cmb" + column.Name,
        //                DropDownStyle = ComboBoxStyle.DropDownList
        //            };
        //            comboBox.SelectedIndexChanged += (s, e) => ApplyFilter();
        //            panelFilters.Controls.Add(comboBox);

        //            var values = products.Select(p => p.GetType().GetProperty(column.Name).GetValue(p, null)?.ToString())
        //                                 .Distinct().OrderBy(v => v).ToList();
        //            values.Insert(0, "All");
        //            comboBox.DataSource = values;
        //        }
        //    }
        //}

        //private void ApplyFilter()
        //{
        //    IEnumerable<Product> filteredProducts = products;

        //    foreach (ComboBox comboBox in panelFilters.Controls.OfType<ComboBox>())
        //    {
        //        string selectedValue = comboBox.SelectedItem.ToString();
        //        if (selectedValue != "All")
        //        {
        //            string propertyName = comboBox.Name.Replace("cmb", "");
        //            filteredProducts = filteredProducts.Where(p => p.GetType().GetProperty(propertyName).GetValue(p, null)?.ToString() == selectedValue);
        //        }
        //    }

        //    grdDatos.DataSource = filteredProducts.ToList();
        //    UpdateProductAndBrandCount();
        //}

        //private void UpdateProductAndBrandCount()
        //{
        //    var currentProducts = dataGridView1.DataSource as List<Product>;
        //    lblProducts.Text = "Total Productos: " + currentProducts.Count;
        //    lblMarca.Text = "Total Marcas: " + currentProducts.Select(p => p.NoM_Marca).Distinct().Count();
        //}
    }
}
