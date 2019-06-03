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

namespace WindowsFormsApp
{
    public partial class AddForm : Form
    {
        string tablename = "";
        string sqlcode;
        public static void RunSQL(string sql)
        {
            using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["WindowsFormsApp.Properties.Settings.DatabaseConnectionString"].ConnectionString))
            //Here we call the connection string. Needed System.Configuration added to References
            {
                cn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(sql, cn))
                {
                    da.SelectCommand.CommandTimeout = 60;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }
                cn.Close();
            }
        }

        public AddForm()
        {
            InitializeComponent();

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            AddLabel1.Visible = false;
            AddLabel2.Visible = false;
            AddLabel3.Visible = false;
            AddLabel4.Visible = false;
            AddtextBox1.Visible = false;
            AddtextBox2.Visible = false;
            AddtextBox3.Visible = false;
            AddtextBox4.Visible = false;
        }

        //A drop down menu where we select wich table we want to add an entity
        private void ComboBox1_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                switch (comboBox1.SelectedItem.ToString().Trim())
                {
                    case "Add new Movie":
                        tablename = "movie"; // we sat the table names
                                             //change the lables and boxes depenmding on the selected item
                        AddLabel1.Text = "Title";
                        AddLabel2.Text = "Year";
                        AddLabel3.Text = "IMDB Link";
                        AddLabel4.Text = "Description";
                        AddLabel1.Visible = true;
                        AddLabel2.Visible = true;
                        AddLabel3.Visible = true;
                        AddLabel4.Visible = true;
                        AddtextBox1.Visible = true;
                        AddtextBox2.Visible = true;
                        AddtextBox3.Visible = true;
                        AddtextBox4.Visible = true;
                        break;

                    case "Add new Genre":
                        tablename = "genre";
                        AddLabel1.Text = "Genre name:";
                        AddLabel1.Visible = true;
                        AddLabel2.Visible = false;
                        AddLabel3.Visible = false;
                        AddLabel4.Visible = false;
                        AddtextBox1.Visible = true;
                        AddtextBox2.Visible = false;
                        AddtextBox3.Visible = false;
                        AddtextBox4.Visible = false;
                        break;

                    case "Add new Person":
                        tablename = "person";
                        AddLabel1.Text = "First name:";
                        AddLabel2.Text = "Last Name";
                        AddLabel3.Text = "Birthday";
                        AddLabel4.Text = "Bio";
                        AddLabel1.Visible = true;
                        AddLabel2.Visible = true;
                        AddLabel3.Visible = true;
                        AddLabel4.Visible = true;
                        AddtextBox1.Visible = true;
                        AddtextBox2.Visible = true;
                        AddtextBox3.Visible = true;
                        AddtextBox4.Visible = true;
                        break;

                    default:
                        MessageBox.Show("Error in combobox1. Please contact the developers");
                        break;
                }
            }

        }


        
        private void AddButton_Click(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedItem.ToString().Trim())
            {
                case "Add new Movie":
                    if (AddtextBox1.Text == "" || AddtextBox2.Text == "" || AddtextBox3.Text == "" || AddtextBox4.Text == "") //we check if these fields are filled out or not
                        MessageBox.Show("Please fill out the required fields"); //we don't let the sql run to an error in case they didn't filled up the required fields
                    else  // we insert the SQL code based on the filled out fields and selected menu
                    {
                        sqlcode = $"INSERT INTO {tablename} (name, date, imdb, description) VALUES ('{AddtextBox1.Text}', {AddtextBox2.Text}, '{AddtextBox3.Text}', '{AddtextBox4.Text}')";
                        RunSQL(sqlcode);
                        MessageBox.Show("Added");
                        this.Close();
                    }
                    break;

                case "Add new Genre":
                    if (AddtextBox1.Text == "" )
                        MessageBox.Show("Please fill out the required fields");
                    else
                    {
                        sqlcode = $"INSERT INTO {tablename} (name) VALUES ('{AddtextBox1.Text}')";
                        RunSQL(sqlcode);
                        MessageBox.Show("Added");
                        this.Close();
                    }
                    break;

                case "Add new Person":
                    if (AddtextBox1.Text == "" || AddtextBox2.Text == "" || AddtextBox3.Text == "" || AddtextBox4.Text == "")
                        MessageBox.Show("Please fill out the required fields");
                    else
                    {
                        sqlcode = $"INSERT INTO {tablename} (fname, lname, birthday, bio) VALUES ('{AddtextBox1.Text}', {AddtextBox2.Text}, '{AddtextBox3.Text}', '{AddtextBox4.Text}')";
                        RunSQL(sqlcode);
                        MessageBox.Show("Added");
                        this.Close();
                    }
                    break;

                default:
                    MessageBox.Show("You not suppose to fix it. If you do please contact the devs");
                    break;
            }

        }
    }
}
