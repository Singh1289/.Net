using ProductCrudConnected.DataAccessLayer;
using ProductCrudConnected.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProductCrudConnected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDAL productDal = new ProductDAL();
        List <Models.Products> proList;
        int currentRowNo = 0;

        private void Navigate(int index)
        {
            if (proList.Count > 0)
            {
                txtProId.Text = proList[index].productID.ToString();
                txtProName.Text = proList[index].productName.ToString();
                txtProPrice.Text = proList[index].productPrice.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            proList = productDal.GetAllProducts();
            Navigate(currentRowNo);
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            currentRowNo = 0;
            Navigate(currentRowNo);
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            if (currentRowNo > 0)
            {
                currentRowNo--;
                Navigate(currentRowNo);
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (currentRowNo < proList.Count - 1)
            {
                currentRowNo++;
                Navigate(currentRowNo);
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            currentRowNo = proList.Count - 1;
            Navigate(currentRowNo);
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            txtProId.Text = String.Empty;
            txtProName.Text = String.Empty;
            txtProPrice.Text = String.Empty;
            txtProId.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Products pro = new Products()
            {
                productID = int.Parse(txtProId.Text),
                productName = txtProName.Text,
                productPrice = int.Parse(txtProPrice.Text)
            };
            productDal.InsertProduct(pro);
           
            Form1_Load(sender, e);
            btn_New_Click(sender, e);
            MessageBox.Show("Record saved successfully.");
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            Products pro = new Products()
            {
                productID = int.Parse(txtProId.Text),
                productName = txtProName.Text,
                productPrice = int.Parse(txtProPrice.Text)
            };
            productDal.UpdateProduct(pro);
            Form1_Load(sender, e);
            btn_New_Click(sender, e);
            MessageBox.Show("Record updated successfully.");
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            productDal.DeleteProduct(int.Parse(txtProId.Text));
           
            Form1_Load(sender, e);
            btn_New_Click(sender, e);
            MessageBox.Show("Record Delete successfully.");
        }
    }
}
