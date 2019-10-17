using System;
using System.Windows.Forms;
using DataBaseLibrary.Models;

namespace WindowsForm
{
    public partial class MainWindows : Form
    {
        
        public MainWindows()
        {
            InitializeComponent();
            
        }

        #region Menu>Exit block
        private void MenuExit_Click(object sender, EventArgs e)
        {
            CloseTheForm();
        }

        private void CloseTheForm()
        {
            var userResponse = MessageBox.Show(@"Are you sure to close this windows", @"Exit from program...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes== userResponse)
            {
                Close();
            }
        }
        #endregion
        #region Button Save block
        private void btnSave_Click(object sender, EventArgs e)
        {

            

        }
        #endregion

       

    }
}
