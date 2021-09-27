using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CustomerList
{
    public partial class Form1 : Form
    {
        public List<Customer> Customers = new List<Customer>();
        public Form1()
        {
            InitializeComponent();
        }


        public void ShowDetails(Customer cus)
        {
            String FullName = cus.LastName + cus.FirstName;
            CusFullName.Text = FullName;
            CusAge.Text = cus.Age.ToString();
            CusAddress.Text = cus.Address;
            CusDecription.Text = cus.Description;
        }



        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer(CusNewFirstName.Text, CusNewLastName.Text,  DateTime.Parse(CusNewBirthday.Text));
            cus.Address = CusNewAddress.Text;
            cus.Description = CusNewDescription.Text;
            CusList.Rows.Add(cus.FirstName, cus.Age, cus.Address);

            Customers.Add(cus);
            CusNewAddress.Text = "";
            CusNewDescription.Text = "";
            CusNewLastName.Text = "";
            CusNewFirstName.Text = "";
            CusNewBirthday.Text = "";

        }

   

        private void CusList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NewcusCreate.Hide();
            CusDetail.Show();
            //string firstName = CusList.Selected****.ToString();
            string firstName = (string)CusList.Rows[e.RowIndex].Cells[0].Value;
            foreach (Customer cus in Customers)
            {
                if (cus.FirstName == firstName)
                {
                    ShowDetails(cus);
                    break;
                }
            }
        }

        private void NewCusCreate_Click(object sender, EventArgs e)
        {
            NewcusCreate.Show();
            CusDetail.Hide();
        }

        private void DesignSet(object sender, EventArgs e)
        {
            NewcusCreate.Hide();
            //CusView.Dock = DockStyle.Left;
            NewcusCreate.Dock = DockStyle.Right;
            CusDetail.Dock = DockStyle.Right;
        }
    }
}