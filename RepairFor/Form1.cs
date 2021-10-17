using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using Google.Protobuf.WellKnownTypes;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace RepairFor
{
    public partial class Form1 : Form
    {
        private ICustomerService _customerService;
        private IProductService _productService;
       
        private Form2 frm2;
        public Form1( ICustomerService customerService, IProductService productService)
        {
            _productService = productService;
            _customerService = customerService;
            InitializeComponent();
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 15F, GraphicsUnit.Pixel);
            }

        }

        

        public void Form1_Load(object sender, EventArgs e)
        {
            
            frm2 = new Form2(_customerService, _productService);
            DataLoad();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int selecteRow = dataGridView1.SelectedCells[0].RowIndex;
            frm2.txtCustomerFirstName.Text = dataGridView1.Rows[selecteRow].Cells[0].Value.ToString();
            frm2.txtCustomerLastName.Text = dataGridView1.Rows[selecteRow].Cells[1].Value.ToString();
            frm2.txtProductCode.Text= dataGridView1.Rows[selecteRow].Cells[3].Value.ToString();
            frm2.txtcustomertelefon.Text = dataGridView1.Rows[selecteRow].Cells[2].Value.ToString();
            frm2.txtimei.Text = dataGridView1.Rows[selecteRow].Cells[10].Value.ToString();
            frm2.txtbrand.Text = dataGridView1.Rows[selecteRow].Cells[9].Value.ToString();
            frm2.txtfault.Text = dataGridView1.Rows[selecteRow].Cells[8].Value.ToString();
            frm2.txtdescription.Text = dataGridView1.Rows[selecteRow].Cells[5].Value.ToString();
            frm2.txtprice.Text = dataGridView1.Rows[selecteRow].Cells[4].Value.ToString();
            frm2.ShowDialog();
            

        }

       public void DataLoad()
       {
             dataGridView1.DataSource = _customerService.GetAll().ToArray();

           // dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
        }

      

        private void btnsave_Click(object sender, EventArgs e)
        {
            customerSve();
            DataLoad();
            emptyBox();
        }

        private void emptyBox()
        {
            txtCustomerFirstName.Text = "";
            txtCustomerLastName.Text = "";
            txtbrand.Text = "";
            txtcustomertelefon.Text = "";
            txtdescription.Text = "";
            txtfault.Text = "";
            txtimei.Text = "";
            txtprice.Text = "";
            txtsearch.Text = "";
        }
        private void customerSve()
        {
            
            var customerfirstName = txtCustomerFirstName.Text;
            var customerLastName = txtCustomerLastName.Text;
            var telephoneNumber = txtcustomertelefon.Text;
            var imeiNumber = txtimei.Text;
            var brand = txtbrand.Text;
            var fault = txtfault.Text;
            var description = txtdescription.Text;
            var price = txtprice.Text;
            var status = false;
            var customerUniqueId = Guid.NewGuid().ToString().Substring(0,6);

            var StartDate = DateTime.Now.Date;
          
            Customer customer = new Customer
            {
                FirstName = customerfirstName, LastName = customerLastName, TelefonNumber = telephoneNumber,
                UniqueId = customerUniqueId
            };
            _customerService.Add(customer);
            Product product = new Product
            {
                CustomerId = customer.Id,
                Brand = brand,
                Description = description,
                Fault = fault,
                StartingDate = StartDate,
                ImeiNumber = imeiNumber,
                Price = price,
                Status = status
            };
            _productService.Add(product);
            

        }

       
       

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //
            //dataGridView1.DataSource = _customerService.SortByFirstName(columnValue);
            dataGridView1.Columns["CustomerLastName"].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.Columns["CustomerFirstName"].SortMode = DataGridViewColumnSortMode.Automatic;
            
            BindingList<CustomerDetail> words = new BindingList<CustomerDetail>(_customerService.GetAll());
            var columnValue = dataGridView1.Columns[e.ColumnIndex].DataPropertyName.ToString();
            var customers = _customerService.GetAll();
            Array.Reverse(customers.ToArray());
            switch (columnValue)
            {
                case "FirstName":
                    dataGridView1.DataSource = words.OrderBy(c => c.FirstName).ToList();
                    break;
                case "LastName":
                    dataGridView1.DataSource = words.OrderBy(c => c.LastName).ToList();
                    break;
                case "StartingDate":
                    dataGridView1.DataSource = words.OrderBy(c => c.StartingDate).ToList();
                    break;
                case "FinishDate":
                    dataGridView1.DataSource = words.OrderBy(c => c.FinishDate).ToList();
                    break;

                default:
                    DataLoad();
                    break;

            }
           
               
            
            //SortableBindingList<CustomerDetail> words = new SortableBindingList<CustomerDetail>(_customerService.GetAll());
            
           

           




            //System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            //messageBoxCS.AppendFormat("{0} = {1}", "Column", e.RowIndex);
            //messageBoxCS.AppendLine();
            //MessageBox.Show(messageBoxCS.ToString(), "ColumnSortModeChanged Event");


        }

       

        private void chcdelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (chcdelivery.Checked==true)
            {
                dataGridView1.DataSource = _customerService.GetAll().Where(c => c.FinishDate != null).ToList();
            }
            else
            {
                DataLoad();
                dataGridView1.Refresh();
            }
        }

       
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnproductcode_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _customerService.GetAll().Where(c => c.CustomerUniqueId==txtsearch.Text.Trim()).ToList();
            dataGridView1.Refresh();
        }

        private void chcnotdelivery_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chcnotdelivery.Checked != true)
            {
                DataLoad();
                dataGridView1.Refresh();
            }
            else
            {
                dataGridView1.DataSource = _customerService.GetAll().Where(c => c.FinishDate == null).ToList();
            }
        }

        private void btnnumber_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _customerService.GetAll().Where(c => c.TelefonNumber == txtsearch.Text.Trim()).ToList();
            dataGridView1.Refresh();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _customerService.GetAll().Where(c => c.FirstName.Contains(txtsearch.Text.Trim())).ToList();
            dataGridView1.Refresh();
        }

        private void dataGridView1_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Back)
            {
              DialogResult dgr=  MessageBox.Show("Silmek istediğine emin misin?", "",MessageBoxButtons.YesNo );
                if (dgr == DialogResult.Yes)
                {
                    int selecteRow = dataGridView1.SelectedCells[0].RowIndex;
                    var uniqueCode = dataGridView1.Rows[selecteRow].Cells[3].Value.ToString();
                    var customer = _customerService.Get(uniqueCode);
                    var product = _productService.Get(customer.Id);
                    _productService.Delete(product);
                    _customerService.Delete(customer);
                    DataLoad();
                    dataGridView1.Refresh();
                }
               
            }
            
        }

        private void dtpicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dtpicker.Value.Date;

            dataGridView1.DataSource = _customerService.GetAll().Where(c => c.FinishDate == dt).ToList();
        }

        private void btnlastnm_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _customerService.GetCustomerByLastName(txtsearch.Text.Trim());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
