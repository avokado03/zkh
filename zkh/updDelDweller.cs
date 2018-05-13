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
    public partial class updDelDweller : Form
    {
        private int flat;
        public updDelDweller()
        {
            InitializeComponent();
        }
        public updDelDweller (ArrayList arr, int flat)
        {
            InitializeComponent();
            try
            {
                textBoxId.Text = arr[0].ToString();
                //разбиваем строку на 3, потому что в ячейке у нас было фио вместе
                var fio = arr[1].ToString().Split(' ');
                textBoxSurn.Text = fio[0];
                textBoxName.Text = fio[1];
                textBoxMiddle.Text = fio[2];
                textBoxPhone.Text = arr[2].ToString();
                textBoxAge.Text = arr[3].ToString();
                this.flat = flat;
            }
            catch {
                this.Close();
            }
        }
        private void buttonUpdFlat_Click(object sender, EventArgs e)
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
                string query = "update dwellers set surname='" + surn + "',name='" + name + "',middlename='" + middle + "',phone='" + phone + "',age=" + age + "where id='" + textBoxId.Text +"'";
                Ado.ExecuteNonQuery(query);
                Main.RefForm.fillDwellers(flat);
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
                string query = "delete from dwellers where id='" + textBoxId.Text + "'";
                Ado.ExecuteNonQuery(query);
                Main.RefForm.fillDwellers(flat);
                MessageBox.Show("Удалено!");
            }
        }
    }
}
