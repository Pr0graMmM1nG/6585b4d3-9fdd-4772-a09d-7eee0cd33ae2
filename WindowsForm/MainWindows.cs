using System;
using System.Windows.Forms;
using DataBaseLibrary.Models;

namespace WindowsForm
{
    public partial class MainWindows : Form
    {
        DataBaseLibrary.Repository.SQLite.CRUD cmdSQL;
        public MainWindows()
        {
            InitializeComponent();
            cmdSQL = new DataBaseLibrary.Repository.SQLite.CRUD();
        }

        #region Menu>Exit block
        private void MenuExit_Click(object sender, EventArgs e)
        {
            CloseTheForm();
        }

        private void CloseTheForm()
        {
            var UserResponse = MessageBox.Show("Are you sure to close this windows", "Exit from program...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes== UserResponse)
            {
                Close();
            }
        }
        #endregion
        #region Button Save block
        private void btnSave_Click(object sender, EventArgs e)
        {

            Units tone1 = new Units
            {
                Name = "tone"
            };
            cmdSQL.Add(tone1);
            cmdSQL.Save();
            var list= cmdSQL.GetAll<Units>();
            foreach (var item in list)
            {
                MessageBox.Show(item.Name);
            }

        }
        #endregion

        private void MenuAdd_UM_Click(object sender, EventArgs e)
        {

        }

        private void txtBxPriceValue_Click(object sender, EventArgs e)
        {
            txtBxPriceValue.Text = String.Empty;
        }

    }
}
