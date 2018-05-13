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
    public partial class addflat : Form
    {
        private int house;
        private int flat;
        public addflat()
        {
            InitializeComponent();
        }
        public addflat(int house, int flat)
        {
            InitializeComponent();
            this.house = house;
            this.flat = flat;
        }

        private void buttonAddFlat_Click(object sender, EventArgs e)
        {
            int number;
            float area;
            int room;
            try {
                number = Convert.ToInt32(textBoxNumber.Text);
                area = Convert.ToSingle(textBoxArea.Text);
                room = Convert.ToInt32(textBoxRoom.Text);
                if (flat > number)
                {
                    string query = "insert into apartment values (" + number + "," + area + "," + room + "," + house + ")";
                    Ado.ExecuteNonQuery(query);
                    Main.RefForm.fillFlats(house);
                    MessageBox.Show("Добавлено!");
                }
                else {
                    MessageBox.Show("Количество квартир в доме превышено");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
