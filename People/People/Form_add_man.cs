using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People
{
    public partial class Form_add_man : Form
    {
        public Form_add_man()
        {
            InitializeComponent();
        }

        private void button_add_man_finish_Click(object sender, EventArgs e)
        {
            string str_date_new_man = dateTimePicker_new_man.Value.Year.ToString() + "-" + dateTimePicker_new_man.Value.Month.ToString() + "-" + dateTimePicker_new_man.Value.Day.ToString();

            if ((textBox_new_man_lastname.Text != "") && (textBox_new_man_firstname.Text != "") && (textBox_new_man_country.Text != "") && (textBox_new_man_city.Text != "") && (textBox_new_man_district.Text != "") && (str_date_new_man != ""))
            {
                DataStatic.add_man_lastname = textBox_new_man_lastname.Text;
                DataStatic.add_man_firstname = textBox_new_man_firstname.Text;
                DataStatic.add_man_birthday = str_date_new_man;
                DataStatic.add_man_country = textBox_new_man_country.Text;
                DataStatic.add_man_city = textBox_new_man_city.Text;
                DataStatic.add_man_district = textBox_new_man_district.Text;

                this.Close();
            }
            else
            {
                MessageBox.Show("Одно или несколько полей формы пустые. Заполните все поля.");
            }
        }
    }
}
