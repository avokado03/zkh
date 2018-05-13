using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zkh
{
    public partial class addDweller : Form
    {
        private int flat;
        public addDweller()
        {
            InitializeComponent();
        }
        public addDweller(int flat) {
            InitializeComponent();
            this.flat = flat;
        }

        private void buttonAddDweller_Click(object sender, EventArgs e)
        {
            string surn, name, middle, phone;
            int age;
            try
            {
                surn = textBoxSurn.Text;
                name = textBoxName.Text;
                middle = textBoxMiddle.Text;
                phone = textBoxPhone.Text;
                age = Convert.ToInt32(textBoxAge.Text);
                string query = "insert into dwellers values ('" + surn + "','" + name + "','" + middle + "','" + phone + "'," + age + ","+flat+ ")";
                Ado.ExecuteNonQuery(query);
                Main.RefForm.fillDwellers(flat);
                MessageBox.Show("Добавлено!");
            }
            catch (Exception exc) {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
