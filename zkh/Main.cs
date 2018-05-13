using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace zkh
{
    public partial class Main : Form
    {
        private int houseId;
        private int flat;
        private int flatId;
        public static Main RefForm { get; set; }
        public Main()
        {
            InitializeComponent();
            RefForm = this;
            fillBuilds();
            houseId = 0;
            flatId = 0;
            AddChooseBtn(dataGridViewHouse);
            AddUpdDelBtn(dataGridViewHouse);
            AddChooseBtn(dataGridViewFlat);
            AddUpdDelBtn(dataGridViewFlat);
            AddUpdDelBtn(dataGridViewDweller);
        }
        //добавление столбца с кнопками выбора
        public void AddChooseBtn(DataGridView d) {
            DataGridViewButtonColumn dgvbc = new DataGridViewButtonColumn();
            dgvbc.Name = "choose";
            dgvbc.HeaderText = "Выбрать";
            dgvbc.Text = "Выбрать";
            dgvbc.UseColumnTextForButtonValue = true;
            d.Columns.Add(dgvbc);
        }
        //добавление столбца с кнопками редактирования/удаления
        public void AddUpdDelBtn(DataGridView d) {
            DataGridViewButtonColumn dgvbc = new DataGridViewButtonColumn();
            dgvbc.Name = "updDel";
            dgvbc.HeaderText = "Изменить/удалить";
            dgvbc.Text = "Изменить/удалить";
            dgvbc.UseColumnTextForButtonValue = true;
            d.Columns.Add(dgvbc);
        }
        //выборка домов
        public void fillBuilds() {
            string query = "select id,number as Номер, street as Улица, numberoffloors as Этажей, numberofentrances as Подъездов, numberofflat as Квартир from house";
            dataGridViewHouse.DataSource = Ado.ExecuteReader(query);
        }
        //выборка квартир
        public void fillFlats(int house)
        {
            string query = "select id,number as Номер, numberofrooms as Комнат, area as [Площадь (кв.м)] from apartment where id_house="+house;
            dataGridViewFlat.DataSource = Ado.ExecuteReader(query);
        }
        //выборка жильцов
        public void fillDwellers(int flat)
        {
            string query = "select id,surname+space(1) + name +space(1)+ middlename as ФИО, phone as Телефон, age as Возраст from dwellers where id_apartment=" + flat;
            dataGridViewDweller.DataSource = Ado.ExecuteReader(query);
        }
        //заполнение коллекции данными для изменения
        public ArrayList fillAList(DataGridView d, int row, int beginCell) {
            ArrayList arr = new ArrayList();
            for (int i = beginCell; i < d.ColumnCount; i++)
            {
                arr.Add(Convert.ToString(d[i, row].Value));
            }
            return arr;
        }
        private void dataGridViewHouse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //выбор дома
            if (e.ColumnIndex == 0) {
                try
                {
                    dataGridViewFlat.DataSource = null;
                    dataGridViewFlat.Rows.Clear();
                    dataGridViewDweller.DataSource = null;
                    dataGridViewDweller.Rows.Clear();
                    houseId = Convert.ToInt32(dataGridViewHouse.Rows[e.RowIndex].Cells[2].Value);
                    flat = Convert.ToInt32(dataGridViewHouse[7,e.RowIndex].Value);
                    fillFlats(houseId);

                }
                catch {}  
            }
            //переход к изменению/удалению инфы о доме
            if (e.ColumnIndex == 1) {
                try
                {
                    updDelHouse udh = new updDelHouse(new ArrayList(fillAList(dataGridViewHouse, e.RowIndex, 2)));
                    udh.ShowDialog();
                }
                catch {
                }
            }
        }

        private void dataGridViewFlat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //выбор квартиры
            if (e.ColumnIndex == 0) {
                try
                {
                    dataGridViewDweller.DataSource = null;
                    dataGridViewDweller.Rows.Clear();
                    flatId = Convert.ToInt32(dataGridViewFlat.Rows[e.RowIndex].Cells[2].Value);
                    fillDwellers(flatId);
                }
                catch {}
            }
            //переход к изменению/удалению инфы о квартире
            if (e.ColumnIndex == 1) {
                try
                {
                    updDelFlat udf = new updDelFlat(new ArrayList(fillAList(dataGridViewFlat, e.RowIndex, 2)), houseId);
                    udf.ShowDialog();
                }
                catch { }
            }
        }
        //переход к добавлению дома
        private void buttonHouse_Click(object sender, EventArgs e)
        {
            addhouse ah = new addhouse();
            ah.ShowDialog();
        }
        //переход к добавлению квартиры
        private void buttonFlat_Click(object sender, EventArgs e)
        {
            addflat af = new addflat(houseId,flat);
            af.ShowDialog();
        }
        //переход к добавлению жильца
        private void buttonDweller_Click(object sender, EventArgs e)
        {
            addDweller ad = new addDweller(flatId);
            ad.ShowDialog();
        }
        //переход к изменению/удалению инфы о жильце
        private void dataGridViewDweller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) {
                try
                {
                    updDelDweller udd = new updDelDweller(new ArrayList(fillAList(dataGridViewDweller, e.RowIndex, 1)), flatId);
                    udd.ShowDialog();
                }
                catch { }
            }
        }
        // справка
        private void pictureBoxInfo_Click(object sender, EventArgs e)
        {
            Info i = new Info();
            i.ShowDialog();
        }
    }
}
