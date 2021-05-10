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
    public partial class Projet : Form
    {
        CRUD crud = new CRUD();

        public Projet()
        {
            InitializeComponent();
        }

        private void Projet_Load(object sender, EventArgs e)
        {

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
            crud.Read_data();
            dataGridView1.DataSource = crud.dt;
        }

        //create
        public void CREATE()
        {
            crud.titre = titre.Text;
            crud.description = description.Text;
            crud.lien = lien.Text;

            crud.Create_data();


        }

        //create
        public void UPDATE()
        {
            crud.id = IDTXT.Text;
            crud.titre = u_titre.Text;
            crud.description = u_description.Text;
            crud.lien = u_lien.Text;

            crud.Update_data();


        }


        //delete

        public void DELETE()
        {
            crud.id = IDTXT.Text;
            crud.Delete_data();
        }






      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            DataGridView senderGrid = (DataGridView)sender;


            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                IDTXT.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                u_titre.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                u_description.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                u_lien.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
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
