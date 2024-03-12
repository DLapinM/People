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
    public partial class Form_add_woman : Form
    {
        public Form_add_woman()
        {
            InitializeComponent();
        }

        private void button_add_woman_finish_Click(object sender, EventArgs e)
        {
            string str_date_new_woman = dateTimePicker_new_woman.Value.Year.ToString() + "-" + dateTimePicker_new_woman.Value.Month.ToString() + "-" + dateTimePicker_new_woman.Value.Day.ToString();

            if ((textBox_new_woman_lastname.Text != "") && (textBox_new_woman_firstname.Text != "") && (textBox_new_woman_country.Text != "") && (textBox_new_woman_city.Text != "") && (textBox_new_woman_district.Text != "") && (str_date_new_woman != ""))
            {
                DataStatic.add_woman_lastname = textBox_new_woman_lastname.Text;
                DataStatic.add_woman_firstname = textBox_new_woman_firstname.Text;
                DataStatic.add_woman_birthday = str_date_new_woman;
                DataStatic.add_woman_country = textBox_new_woman_country.Text;
                DataStatic.add_woman_city = textBox_new_woman_city.Text;
                DataStatic.add_woman_district = textBox_new_woman_district.Text;

                this.Close();
            }
            else
            {
                MessageBox.Show("Одно или несколько полей формы пустые. Заполните все поля.");
            }
        }
    }
}
