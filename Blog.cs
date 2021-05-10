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
    public partial class Blog : Form
    {
        public Blog()
        {
            InitializeComponent();
        }


        BLOG blog = new BLOG();


        private void btn_save_Click(object sender, EventArgs e)
        {
            CREATE();
            READ();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UPDATE();
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
            blog.Read_data();
            dataGridView1.DataSource = blog.dt;
        }

        //create
        public void CREATE()
        {
            blog.titre = titre.Text;
            blog.description = description.Text;

            blog.Create_data();


        }

        //create
        public void UPDATE()
        {
            blog.id = IDTXT.Text;
            blog.titre = u_titre.Text;
            blog.description = u_description.Text;

            blog.Update_data();


        }


        //delete

        public void DELETE()
        {
            blog.id = IDTXT.Text;
            blog.Delete_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;


            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                IDTXT.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                u_titre.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                u_description.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
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
