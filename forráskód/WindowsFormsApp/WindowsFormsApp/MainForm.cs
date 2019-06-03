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

    public partial class MainForm : Form
    {
        public string sqlstring = "";
        public string columnsearch = "";
        public string namesearch = "";
        public string exclude = "";
        //Getting an SQL statement and giving back the datatable
        public static DataTable GetDataTable(string sql)
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
                    return ds.Tables[0];
                }
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        //When we press the search button
        private void SearchButton_Click(object sender, EventArgs e)
        {
            //preventing problems, the program will not run if the search field is empty
            if (NameSearch_txtb.Text == "" || comboBox1.Text == "")
            { MessageBox.Show("Please fill the search field"); return; }

            //declaring variables for the SQL code


            //A switch case for the drop down menu (combobox). We let the user select what part of the table he want to search.
            switch (comboBox1.SelectedItem.ToString().Trim())
            {
                case "Title":
                    columnsearch = "movie.name";
                    break;

                case "Year":
                    columnsearch = "date";
                    break;

                case "File location":
                    columnsearch = "filelocation";
                    break;

                case "IMDB link":
                    columnsearch = "imdb";
                    break;

                case "Description":
                    columnsearch = "description";
                    break;

                case "Genre":
                    columnsearch = "genre.name";
                    break;

                case "Person":
                    columnsearch = $"person.fname LIKE '%{namesearch}%' OR person.lname";
                    break;

                case "Tag":
                    columnsearch = "tag.name";
                    break;

                default:
                    MessageBox.Show("Please contact support. Error in combobox1");
                    break;
            }

            if (NameSearch_txtb.Text != null && comboBox1.Text != null)
            {
                namesearch = NameSearch_txtb.Text;
            }
            //we are calling the GetDataTable method, and inserting our SQL code. 
            sqlstring = $"Select movie.name AS Title, movie.date, movie.filelocation, movie.imdb, movie.description, genre.name AS genre, tag.name AS tag, concat (person.fname, ' ', person.lname) AS personel FROM movie FULL JOIN mov_genr on movie.id = mov_genr.mov_id FULL JOIN mov_tag on movie.id = mov_tag.mov_id FULL JOIN genre on mov_genr.gen_id = genre.id FULL JOIN tag on mov_tag.tag_id = tag.id FULL JOIN role on role.mov_id = movie.id FULL JOIN person on person.id = role.pers_id WHERE {columnsearch} {exclude} LIKE '%{namesearch}%'";
            dataGridView.DataSource = GetDataTable(sqlstring);
            btn_addationalsearc.Visible = true;
            btn_search.Text = "New search";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //click event to open the entry add window and minimize the current window
        private void AddOpen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

            AddForm addform = new AddForm();
            addform.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }

        private void Btn_addationalsearc_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString().Trim())
            {
                case "Title":
                    columnsearch = "movie.name";
                    break;

                case "Year":
                    columnsearch = "date";
                    break;

                case "File location":
                    columnsearch = "filelocation";
                    break;

                case "IMDB link":
                    columnsearch = "imdb";
                    break;

                case "Description":
                    columnsearch = "description";
                    break;

                case "Genre":
                    columnsearch = "genre.name";
                    break;

                case "Person":
                    columnsearch = $"person.fname LIKE '%{namesearch}%' OR person.lname";
                    break;

                case "Tag":
                    columnsearch = "tag.name";
                    break;

            }
            if (NameSearch_txtb.Text != null && comboBox1.Text != null)
            {
                namesearch = NameSearch_txtb.Text;
            }
            sqlstring += $" AND {columnsearch} {exclude} LIKE '%{namesearch}%'";
            dataGridView.DataSource = GetDataTable(sqlstring);
        }

        //if the exclude box is ticked, the exclude string get changed.
        private void Exclude_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (exclude_checkBox.Checked == true)
                exclude = "NOT";
            else
                exclude = "";
        }
    }
}
