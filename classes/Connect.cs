using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;



namespace amineportfolio.classes
{
    class Connect
    {

        public MySqlConnection con;

        public Connect()

        {


            string host = "localhost";
            string db = "portfolio";
            string port = "3306";
            string user = "root";
            string pass = "";
            string constring = "datasource =" + host + "; database =" + db + "; port =" + port + "; username =" + user + "; password=" + pass + "; SslMode=none";

            con = new MySqlConnection(constring);

        }



    }


    class CRUD : Connect

    {

        public string titre { set; get; }
        public string description { set; get; }
        public string lien { set; get; }

        public string id { set; get; }

        //read proprite

        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();




        //create function

        public void Create_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "INSERT INTO `projet`(`titre`, `description`, `lien`) VALUES (@titre,@desc,@lien)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.Add("@titre", MySqlDbType.VarChar).Value = titre;
                cmd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = description;
                cmd.Parameters.Add("@lien", MySqlDbType.VarChar).Value = lien;

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }


        //update 

        public void Update_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "UPDATE `projet` SET `titre`=@titre,`description`=@desc,`lien`=@lien  WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.Add("@titre", MySqlDbType.VarChar).Value = titre;
                cmd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = description;
                cmd.Parameters.Add("@lien", MySqlDbType.VarChar).Value = lien;
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;


                cmd.ExecuteNonQuery();
                con.Close();

            }



        }


        //delete


        public void Delete_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "DELETE  FROM `projet` WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;


                cmd.ExecuteNonQuery();
                con.Close();

            }



        }



        //get all


        public void Read_data()
        {
            dt.Clear();
            string query = "SELECT * FROM `projet`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }


    }





    class BLOG : Connect

    {

        public string titre { set; get; }
        public string description { set; get; }


        public string id { set; get; }

        //read proprite

        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();




        //create function

        public void Create_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "INSERT INTO `BLOG`(`titre`, `description`) VALUES (@titre,@desc)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.Add("@titre", MySqlDbType.VarChar).Value = titre;
                cmd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = description;

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }


        //update 

        public void Update_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "UPDATE `blog` SET `titre`=@titre,`description`=@desc WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.Add("@titre", MySqlDbType.VarChar).Value = titre;
                cmd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = description;

                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;


                cmd.ExecuteNonQuery();
                con.Close();

            }



        }


        //delete


        public void Delete_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "DELETE  FROM `blog` WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;


                cmd.ExecuteNonQuery();
                con.Close();

            }



        }



        //get all


        public void Read_data()
        {
            dt.Clear();
            string query = "SELECT * FROM `blog`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }


    }



    class CONTACT : Connect

    {

        public string name { set; get; }
        public string lastname { set; get; }
        public string email { set; get; }

        public string budget { set; get; }
        public string phone { set; get; }

        public string organization { set; get; }

        public string message { set; get; }


        public string id { set; get; }

        //read proprite

        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();




        //create function

        public void Create_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "INSERT INTO `contact`(`name`, `lastname`, `email`, `budget` , `phone`, `organization` , `message`) VALUES (@name,@lastname,@email,@budget,@phone,@organization,@message)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@budget", MySqlDbType.VarChar).Value = budget;

                cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
                cmd.Parameters.Add("@organization", MySqlDbType.VarChar).Value = organization;

                cmd.Parameters.Add("@message", MySqlDbType.VarChar).Value = message;


                cmd.ExecuteNonQuery();
                con.Close();

            }
        }


        //update 

        public void Update_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "UPDATE `contact` SET `name`=@name,`lastname`=@lastname,`email`=@email,`budget`=@budget,`phone`=@phone,`organization`=@organization,`message`=@message  WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;


                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@budget", MySqlDbType.VarChar).Value = budget;

                cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
                cmd.Parameters.Add("@organization", MySqlDbType.VarChar).Value = organization;

                cmd.Parameters.Add("@message", MySqlDbType.VarChar).Value = message;

                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;


                cmd.ExecuteNonQuery();
                con.Close();

            }



        }


        //delete


        public void Delete_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "DELETE  FROM `contact` WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;


                cmd.ExecuteNonQuery();
                con.Close();

            }



        }



        //get all


        public void Read_data()
        {
            dt.Clear();
            string query = "SELECT * FROM `contact`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }


    }





    class TESTIMONIAL : Connect

    {

        public string name { set; get; }
      
        public string metier { set; get; }

        public string message { set; get; }


        public string id { set; get; }

        //read proprite

        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();




        //create function

        public void Create_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "INSERT INTO `testimonial`(`name`,  `metier` , `message`) VALUES (@name,@metier,@message)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;

                cmd.Parameters.Add("@metier", MySqlDbType.VarChar).Value = metier;

                cmd.Parameters.Add("@message", MySqlDbType.VarChar).Value = message;


                cmd.ExecuteNonQuery();
                con.Close();

            }
        }


        //update 

        public void Update_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "UPDATE `testimonial` SET `name`=@name,`metier`=@metier,`message`=@message  WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;


                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;

                cmd.Parameters.Add("@metier", MySqlDbType.VarChar).Value = metier;

                cmd.Parameters.Add("@message", MySqlDbType.VarChar).Value = message;
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;


                cmd.ExecuteNonQuery();
                con.Close();

            }



        }


        //delete


        public void Delete_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "DELETE  FROM `testimonial` WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;


                cmd.ExecuteNonQuery();
                con.Close();

            }



        }



        //get all


        public void Read_data()
        {
            dt.Clear();
            string query = "SELECT * FROM `testimonial`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }


    }

}
