using System;
using System.Collections;
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
    public partial class updDelHouse : Form
    {
        public updDelHouse()
        {
            InitializeComponent();
        }
        public updDelHouse(ArrayList arr) {
            InitializeComponent();
            textBoxId.Text = arr[0].ToString();
            textBoxNumber.Text = arr[1].ToString();
            textBoxStreet.Text = arr[2].ToString();
            textBoxFloor.Text = arr[3].ToString();
            textBoxEntr.Text = arr[4].ToString();
            textBoxFlat.Text = arr[5].ToString();
        }

        private void buttonUpdHouse_Click(object sender, EventArgs e)
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
                string query = "update house set number = '" + number + "', street='" + street + "',numberoffloors='" + floor + "',numberofentrances='" + entr + "',numberofflat='" + flat + "' where id = '"+textBoxId.Text+"'";
                Ado.ExecuteNonQuery(query);
                Main.RefForm.fillBuilds();
                MessageBox.Show("Изменено!");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void buttonDelHouse_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Хотите удалить запись? Все другие записи, связанные с ней будут удалены","Удаление",  MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes) {
                string query = "delete from house where id='" + textBoxId.Text + "'";
                Ado.ExecuteNonQuery(query);
                Main.RefForm.fillBuilds();
                MessageBox.Show("Удалено!");
            }
        }
    }
}
