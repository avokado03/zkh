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
    public partial class updDelFlat : Form
    {
        private int house;
        public updDelFlat()
        {
            InitializeComponent();
        }
        public updDelFlat(System.Collections.ArrayList arr, int house)
        {
            InitializeComponent();
            try
            {
                textBoxId.Text = arr[0].ToString();
                textBoxNumber.Text = arr[1].ToString();
                textBoxFlat.Text = arr[2].ToString();
                textBoxArea.Text = arr[3].ToString();
                this.house = house;
            }
            catch {
                this.Close();
            }
        }
        private void buttonUpdFlat_Click(object sender, EventArgs e)
        {
            int number;
            float area;
            int room;
            try
            {
                number = Convert.ToInt32(textBoxNumber.Text);
                room = Convert.ToInt32(textBoxFlat.Text);
                area = Convert.ToSingle(textBoxArea.Text);
                string query = "update apartment set number = " + number + ", area=" + area + ",numberofrooms=" + room + " where id = '" + textBoxId.Text + "'";
                Ado.ExecuteNonQuery(query);
                Main.RefForm.fillFlats(house);
                MessageBox.Show("Изменено!");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void buttonDelFlat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Хотите удалить запись? Все другие записи, связанные с ней будут удалены", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                string query = "delete from apartment where id='" + textBoxId.Text + "'";
                Ado.ExecuteNonQuery(query);
                Main.RefForm.fillFlats(house);
                MessageBox.Show("Удалено!");
            }
        }
    }
}
