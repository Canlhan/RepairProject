using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Entities.Concrete;

namespace RepairFor
{
    public partial class Form2 : Form
    {
        private ICustomerService _customerService;
        private IProductService _productService;
        private Customer cus;
        private Product prod;
        private Form1 frm1;
        public Form2(ICustomerService customerService, IProductService productService)
        {
            _customerService = customerService;
            _productService = productService;
            InitializeComponent(); 
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //int selecteRow = frm1.dataGridView1.SelectedCells[0].RowIndex;
            frm1 = new Form1(_customerService, _productService);
            var customerName = txtProductCode.Text;

            cus = _customerService.Get(customerName);

           

             prod = _productService.Get(cus.Id);

        }

        private void chcTeslimBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
            cus.FirstName = txtCustomerFirstName.Text;
            cus.LastName = txtCustomerLastName.Text;
            cus.TelefonNumber = txtcustomertelefon.Text;

            //Customer updatedCustomer = new Customer
            //    {FirstName = customerName, LastName = customerLastName, TelefonNumber = customerTelep};

            _customerService.Update(cus);

            var StartDate = DateTime.Now.Date;
            var FinishDate = DateTime.Now.Date;



            prod.Fault = txtfault.Text;
            if (chcTeslimBox.Checked)
            {
                prod.FinishDate = FinishDate;
            }
            
           prod.ImeiNumber = txtimei.Text;
            prod.Brand = txtbrand.Text;
            prod.CustomerId = cus.Id;
           prod.Description = txtdescription.Text;
            prod.Price = txtprice.Text;
           
           prod.Status = chcTeslimBox.Checked;

            
            _productService.Update(prod);

            frm1.DataLoad();
           frm1.dataGridView1.Refresh();
            frm1.Close();
            
           this.Close();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        PrintDialog dialog = new PrintDialog();
        private void btnyazdir_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            DialogResult dresult;
            dresult = dialog.ShowDialog();
            doc.PrintPage += Doc_PrintPage;

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            if (dresult==DialogResult.OK)
            {
                doc.Print();
            }

        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            string yazi = txtCustomerFirstName.Text + " " + txtCustomerLastName.Text;
            string barcode = txtProductCode.Text;
            Font fn = new Font("Arial",12);
            SolidBrush sldbr = new SolidBrush(Color.Black);
            e.Graphics.DrawString(barcode,fn,sldbr,10,10);
            e.Graphics.DrawString(yazi, fn, sldbr, 10, 50);

        }

       

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
