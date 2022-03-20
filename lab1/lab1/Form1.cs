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

namespace lab1
{
    public partial class Form1 : Form
    {
        DataSet dataset = new DataSet();
        SqlDataAdapter parentAdapter = new SqlDataAdapter();
        SqlDataAdapter childAdapter = new SqlDataAdapter();
        string connectionString = @"Server = DESKTOP-ODG6BU0\MSSQLSERVER01; Database = Gospodarul; Integrated Security = true;";
        SqlConnection connection = new SqlConnection(@"Server = DESKTOP-ODG6BU0\MSSQLSERVER01; Database = Gospodarul; Integrated Security = true;");

        BindingSource bsParent = new BindingSource();
        BindingSource bsChild = new BindingSource(); //acestea vor fi intermediare intre data si gridView


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //dataAdapter deschide si inchide singur conexiunea
                    //setam propr select pt fiecare adapter pt a popula data tables
                    parentAdapter.SelectCommand = new SqlCommand("SELECT * FROM Sectii;", connection);
                    childAdapter.SelectCommand = new SqlCommand("SELECT * FROM Angajati;", connection);
                    parentAdapter.Fill(dataset, "Sectii"); //specific numele tabelului pe care il creeaza va fi acelasi cu cel din baza de date
                    childAdapter.Fill(dataset, "Angajati"); //pana aici avem datele dar inca nu le vedem, setam data source ca sa le vedem
                    //ne folosim de binding source - afisare automata a datelor la selectare
                    DataColumn pkColumn = dataset.Tables["Sectii"].Columns["id"];
                    DataColumn fkColumn = dataset.Tables["Angajati"].Columns["sectie_id"];
                    DataRelation relation = new DataRelation("fk_Sectii_Angajati", pkColumn, fkColumn);
                    //acum adaugam in colectia de relatii a dataset ca sa fie functionala
                    dataset.Relations.Add(relation);

                    bsParent.DataSource = dataset.Tables["Sectii"];
                    dataGridViewParent.DataSource = bsParent;
                    labelParent.Text = "Departamente/Sectii"; //suna mai bine decat sectii
                    //bsChild.DataSource = dataset.Tables["Angajati"]; //asa ar fi nelegat de parent
                    bsChild.DataSource = bsParent;
                    bsChild.DataMember = "fk_Sectii_Angajati";
                    dataGridViewChild.DataSource = bsChild;
                    labelChild.Text = "Angajati";
                    textBox1.DataBindings.Add("Text", bsParent, "nume");
                    textBoxSectieId.DataBindings.Add("Text", bsParent, "id");
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message); 
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                childAdapter.InsertCommand = new SqlCommand("INSERT INTO Angajati VALUES (@nume, @prenume, @functie, @magazin_id, @sectie_id)", connection);
                childAdapter.InsertCommand.Parameters.Add("@nume", SqlDbType.VarChar).Value = textBoxNume.Text;
                childAdapter.InsertCommand.Parameters.Add("@prenume", SqlDbType.VarChar).Value = textBoxPrenume.Text;
                childAdapter.InsertCommand.Parameters.Add("@functie", SqlDbType.VarChar).Value = textBoxFunctie.Text;
                childAdapter.InsertCommand.Parameters.Add("@magazin_id", SqlDbType.Int).Value = textBoxMagazinId.Text;
                childAdapter.InsertCommand.Parameters.Add("@sectie_id", SqlDbType.Int).Value = textBoxSectieId.Text;

                connection.Open(); //de ce imi cere sa deschid conexiunea?
                childAdapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Inregistrarea a fost adaugata cu succes!");
                populate();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            connection.Close();
        }

        private int getChildId()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                childAdapter.SelectCommand = new SqlCommand("SELECT max(id) FROM Angajati", connection);
                int angajat_id = (int)childAdapter.SelectCommand.ExecuteScalar();

                return angajat_id;
            }
        }

        private void populate()
        {
            try
            {
                parentAdapter.SelectCommand.Connection = connection; //isi deschide si inchide singur conexiunea
                dataset.Tables["Angajati"].Clear();
                dataset.Tables["Sectii"].Clear();
                parentAdapter.SelectCommand = new SqlCommand("SELECT * FROM Sectii;", connection);
                childAdapter.SelectCommand = new SqlCommand("SELECT * FROM Angajati;", connection);
                parentAdapter.Fill(dataset, "Sectii");
                childAdapter.Fill(dataset, "Angajati");
                bsChild.DataSource = bsParent;
                bsChild.DataMember = "fk_Sectii_Angajati";
                dataGridViewChild.DataSource = bsChild;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dataGridViewChild_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // adaugat manual in form1.designer           this.dataGridViewChild.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChild_CellClick);
            try
            {
                connection.Open();
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = this.dataGridViewChild.Rows[e.RowIndex];

                    String angajatId = selectedRow.Cells["id"].Value.ToString();
                    String nume = selectedRow.Cells["nume"].Value.ToString();
                    String prenume = selectedRow.Cells["prenume"].Value.ToString();
                    String functie = selectedRow.Cells["functie"].Value.ToString();
                    String magazinId = selectedRow.Cells["magazin_id"].Value.ToString();
                    String sectieId = selectedRow.Cells["sectie_id"].Value.ToString();

                    labelAngajatId.Text = angajatId;
                    textBoxNume.Text = nume;
                    textBoxPrenume.Text = prenume;
                    textBoxFunctie.Text = functie;
                    textBoxMagazinId.Text = magazinId;
                    textBoxSectieId.Text = sectieId;
                }
                //connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            connection.Close();
        }



        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                childAdapter.UpdateCommand = new SqlCommand("UPDATE Angajati " +
                    "SET nume=@nume, prenume=@prenume, functie=@functie, magazin_id=@magazinId, sectie_id=@sectieId WHERE id=@angajatId", connection);
                childAdapter.UpdateCommand.Parameters.Add("@angajatId", SqlDbType.Int).Value = labelAngajatId.Text;
                childAdapter.UpdateCommand.Parameters.Add("@nume", SqlDbType.VarChar).Value = textBoxNume.Text;
                childAdapter.UpdateCommand.Parameters.Add("@prenume", SqlDbType.VarChar).Value = textBoxPrenume.Text;
                childAdapter.UpdateCommand.Parameters.Add("@functie", SqlDbType.VarChar).Value = textBoxFunctie.Text;
                childAdapter.UpdateCommand.Parameters.Add("@magazinId", SqlDbType.VarChar).Value = textBoxMagazinId.Text;
                childAdapter.UpdateCommand.Parameters.Add("@sectieId", SqlDbType.VarChar).Value = textBoxSectieId.Text;
                //childAdapter.UpdateCommand.Connection = connection; // trebuia cand am uitat sa pun in SqlCommand, altfel dadea: ExecuteNonQuery: Connection property has not been initialized. 
                connection.Open();
                childAdapter.UpdateCommand.ExecuteNonQuery();
                this.populate();
                MessageBox.Show("Inregistrarea a fost modificata cu succes!");
                labelAngajatId.Text = "AngajatId";
                textBoxNume.Text = "";
                textBoxPrenume.Text = "";
                textBoxFunctie.Text = "";
                textBoxMagazinId.Text = "";
                textBoxSectieId.Text = "";
                //connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
            connection.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                childAdapter.DeleteCommand = new SqlCommand("DELETE FROM Angajati WHERE id = @angajatId", connection);
                childAdapter.DeleteCommand.Parameters.Add("@angajatId", SqlDbType.Int).Value = labelAngajatId.Text;
                connection.Open();
                childAdapter.DeleteCommand.ExecuteNonQuery();
                this.populate();
                MessageBox.Show("Inregistrarea a fost stearsa!");
                labelAngajatId.Text = "AngajatId";
                textBoxNume.Text = "";
                textBoxPrenume.Text = "";
                textBoxFunctie.Text = "";
                textBoxMagazinId.Text = "";
                textBoxSectieId.Text = "";
            }
            catch (Exception exeption) { MessageBox.Show(exeption.Message.ToString()); }
            connection.Close();
        }
    }
}
