using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmissionCommittee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.admissionCommitteeDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "admissionCommitteeDataSet1.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.admissionCommitteeDataSet1.Students);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void studentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                Students userObj = new Students();
                userObj.FIO = textBox1.Text;
                userObj.id_specialty = int.Parse(comboBox2.Text);
                userObj.date_of_birth = DateTime.Parse(textBox2.Text);
                userObj.age = textBox3.Text;
                userObj.id_gruppa = int.Parse(comboBox1.Text);
                userObj.addres = textBox5.Text;
                userObj.number_phone = textBox4.Text;
                db.Students.Add(userObj);
                db.SaveChanges();
                MessageBox.Show("Новые данные добавлены!");
            }
            label9.Text = (studentsDataGridView.RowCount - 1).ToString();
          
        }
    }
}
