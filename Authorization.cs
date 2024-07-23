using System.Threading;
using GeneralResourcesForForms;
using System.Media;
using MySql.Data.MySqlClient;
using GeneralResourcesForForms.DataBasetManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace KCorrespondence
{
    public partial class Authorization : Form
    {
        readonly SoundPlayer SoundInterpreter = new SoundPlayer(@"knopka-jeskaya-zvonkii-blizkii-multyashnyii.wav");
        readonly SoundPlayer SoundCreate = new SoundPlayer(@"zvuk-windows-nt-40-vhod-v-sistemu-logon-sound-30494.wav");
        

        public Authorization()
        {
            InitializeComponent();

            SoundCreate.Play();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {

            SoundInterpreter.Play();


            DB dataBase = new DB("server = localhost; port = 3306; username = root; password = root; database = databasedatingsearchprogram");

            

            MySqlCommand getLoginAndPassword = 
                new MySqlCommand(
                "SELECT * " +
                "FROM `users` " +
                "WHERE Login = @login AND Password = @password", dataBase.GetConect());

            getLoginAndPassword.Parameters.Add("@login", MySqlDbType.VarChar).Value = TextBoxLogin.Text;
            getLoginAndPassword.Parameters.Add("@password", MySqlDbType.VarChar).Value = TextBoxPassword.Text;



            dataBase.Use(Modes.Open);

            MySqlDataAdapter adapterLoginPassword = new MySqlDataAdapter();
            adapterLoginPassword.SelectCommand= getLoginAndPassword;


            DataTable tableUserdLoginPasswords = new DataTable();
            adapterLoginPassword.Fill(tableUserdLoginPasswords);
               

            if(tableUserdLoginPasswords.Rows.Count > 0)
            {
                dynamic[] userLines = new dynamic[12];


                for (int indexRow = 0; indexRow < tableUserdLoginPasswords.Rows.Count; indexRow++)
                {
                    DataRow columns = tableUserdLoginPasswords.Rows[indexRow];

                    for (int indexLine = 0; indexLine < userLines.Length; indexLine++)
                    {
                        userLines[indexLine] = columns[indexLine];

                    }

                }

                SearchPeople searchPeople = new SearchPeople(new User(userLines[0], userLines[1], (int)userLines[2], (int)userLines[3], (string)userLines[4], (int)userLines[5], (int)userLines[6], (int)userLines[7], (int)userLines[8], (string)userLines[9], (string)userLines[10], (string)userLines[11])); 

                MessageBox.Show($"Приятно вас видеть! {userLines[0]} {userLines[1]}");

                this.Hide();
                searchPeople.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
               
            }



            dataBase.Use(Modes.Close);



        }

        private void ButtonRegistrtion_Click(object sender, EventArgs e)
        {
            SoundInterpreter.Play();

            this.Hide();

            Registation registation = new Registation();

            registation.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Exit.CloseMainWindow();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
           
        }

       
    }
}
