using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaApp
{
    public partial class frmBankAccount : Form
    {
        private Current ca1;
        private MediaService ms1 = new MediaService();
        private MediaAccount ma1 = new MediaAccount();


        public frmBankAccount()
        {
            InitializeComponent();
        }

        private void FrmBankAccount_Load(object sender, EventArgs e)
        {
            ms1 = new MediaService();
            ms1.addSongs();
            ms1.ListSongs(lstSongs);
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
            ca1 = new Current(txtName.Text, Convert.ToDouble(txtDeposit.Text));
            lblAccInfo.Text = ca1.displayStatement();
            MessageBox.Show("Account Created");
            btnCreate.Hide();
            }
            catch
            {
                MessageBox.Show("Invalid Format or Value" + "\n" + "Use text in text field and numbers for number field");
            }
            ClearFields();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
            double money = Convert.ToDouble(txtWithdraw.Text);
            ca1.withdraw(money);
            lblAccInfo.Text = ca1.displayStatement();
            }
            catch
            {
                MessageBox.Show("Invalid Format");
            }
            ClearFields();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {

            Double money = Convert.ToDouble(txtDeposit2.Text);
            ca1.deposit(money);
            lblAccInfo.Text = ca1.displayStatement();
            }
            catch
            {
                MessageBox.Show("Invalid Format");
            }
            ClearFields();
        }

        private void btnAddFunds_Click(object sender, EventArgs e)
        {
            try
            {
            Double money = Convert.ToDouble(txtMSDeposit.Text);
            ca1.transfer(money, ms1);
            lblMediaServBalance.Text = ms1.displayStatement();
            lblAccInfo.Text = ca1.displayStatement();
            }
            catch
            {
                MessageBox.Show("Invalid Value or Format");
            }
            ClearFields();
        }
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            try
            {
            double amount = (ms1.songs[lstSongs.SelectedIndex].songPrice);
            ms1.purchase(amount);
            lblMediaServBalance.Text = ms1.displayStatement();


            MA_Node temp = new MA_Node(ms1.songs[lstSongs.SelectedIndex].SongName, ms1.songs[lstSongs.SelectedIndex].SongPrice);
            ma1 = new MediaAccount();
            ma1.InsertFront(temp);

            Iterator it = ma1.createIterator();

            while (it.hasMore())
            {
                lblIterate.Text += "\n" + it.getNext();
            }
            }
            catch
            {
                MessageBox.Show("Please Add Funds");
            }

        }

        private void ClearFields()
        {
            txtDeposit.Text = "";
            txtDeposit2.Text = "";
            txtMSDeposit.Text = "";
            txtName.Text = "";
            txtWithdraw.Text = "";


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GrpMediaAccount_Enter(object sender, EventArgs e)
        {

        }
    }
}
