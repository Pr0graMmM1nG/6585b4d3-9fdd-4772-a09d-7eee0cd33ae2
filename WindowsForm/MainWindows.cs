using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBaseLibrary.Repository.SQLite.CRUD cmd = new DataBaseLibrary.Repository.SQLite.CRUD();
            DataBaseLibrary.Models.Units units1 = new DataBaseLibrary.Models.Units();
            units1.Name = "tone";
            cmd.Add(units1);
            cmd.Save();
        }

       
    }
}
