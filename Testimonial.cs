using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using amineportfolio.classes;
using MySql.Data.MySqlClient;


namespace amineportfolio
{
    public partial class Testimonial : Form
    {
        TESTIMONIAL testimonial = new TESTIMONIAL();

        public Testimonial()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            CREATE();
            READ();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Update();
            READ();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DELETE();
            READ();
        }


        //read function

        public void READ()
        {
            dataGridView1.DataSource = null;
            testimonial.Read_data();
            dataGridView1.DataSource = testimonial.dt;
        }

        //create
        public void CREATE()
        {
            testimonial.name = name.Text;
            testimonial.message = message.Text;
            testimonial.metier = metier.Text;

            testimonial.Create_data();


        }

        //create
        public void UPDATE()
        {
            testimonial.id = IDTXT.Text;
            testimonial.name = u_name.Text;
            testimonial.message = u_message.Text;
            testimonial.metier = u_metier.Text;

            testimonial.Update_data();


        }


        //delete

        public void DELETE()
        {
            testimonial.id = IDTXT.Text;
            testimonial.Delete_data();
        }







        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            DataGridView senderGrid = (DataGridView)sender;


            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                IDTXT.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                u_name.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                u_message.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                u_metier.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
