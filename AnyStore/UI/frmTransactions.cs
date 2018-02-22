using AnyStore.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyStore.UI
{
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }

        transactionDAL tdal = new transactionDAL();
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            //Dispay all the transactions
            DataTable dt = tdal.DisplayAllTransactions();
            dgvTransactions.DataSource = dt;
        }

        private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the Value from Combobox
            string type = cmbTransactionType.Text;

            DataTable dt = tdal.DisplayTransactionByType(type);
            dgvTransactions.DataSource = dt;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            //Dispay all the transactions
            DataTable dt = tdal.DisplayAllTransactions();
            dgvTransactions.DataSource = dt;
        }
    }
}
