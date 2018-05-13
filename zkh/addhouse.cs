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
    public partial class addhouse : Form
    {
        public addhouse()
        {
            InitializeComponent();
        }

        private void buttonAddHouse_Click(object sender, EventArgs e)
        {
            int number, floor, entr, flat;
            string street;
            try
            {
                number = Convert.ToInt32(textBoxNumber.Text);
                floor = Convert.ToInt32(textBoxFloor.Text);
                entr = Convert.ToInt32(textBoxEntr.Text);
                flat = Convert.ToInt32(textBoxFlat.Text);
                street = textBoxStreet.Text;
                string query = "insert into house values ('" + number + "','" + street + "','" + floor + "','" + entr + "','" + flat + "')";
                Ado.ExecuteNonQuery(query);
                Main.RefForm.fillBuilds();
                MessageBox.Show("Добавлено!");
            }
            catch (Exception exc) {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
