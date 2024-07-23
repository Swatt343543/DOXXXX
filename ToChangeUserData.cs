using GeneralResourcesForForms;
using GeneralResourcesForForms.DataBasetManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace KCorrespondence
{

    public partial class ToChangeUserData : Form
    {
        SoundPlayer startSound = new SoundPlayer("knopka-tsifrovoi-odinochnyii-shumnyii.wav");
        SoundPlayer soundArkade = new SoundPlayer("zvuk-otkryitiya-novogo-urovnya.wav");

        User oldUser;
        bool dataChanged;

        public ToChangeUserData(User user)
        {
            InitializeComponent();

            startSound.Play();

            oldUser = user;

            textBoxName.Text = user.Name;
            textBoxLastName.Text = user.LastName;
            textBoxAge.Text = user.Age.ToString();
            textBoxLength.Text = user.Length.ToString();
            textBoxColor.Text = user.Color;
            textBoxPreferMaxAge.Text = user.PreferMaxAge.ToString();
            textBoxPreferMinAge.Text = user.PreferMinAge.ToString();
            textBoxPreferMaxLength.Text = user.PreferMaxLength.ToString();
            textBoxPreferMinLength.Text = user.PreferMinLength.ToString();
            textBoxPreferColor.Text = user.PreferColor;
            textLogin.Text = user.Login;


        }

        private void resetDataUser_Click(object sender, EventArgs e)
        {
            soundArkade.Play();

            DB dB = new DB("server=localhost;port=3306;username=root;password=root;database=databasedatingsearchprogram");

            // для команды SELECT метод ExeteNonQiary возвраящет -1
            MySqlCommand userVerification = new MySqlCommand($"SELECT Login, Password FROM users " +
                $"WHERE Login = '{textLogin.Text}' AND " +
                $"Password = '{textBoxPassword.Text}'", dB.GetConect());

            MySqlDataAdapter adapterVerification = new MySqlDataAdapter();
            adapterVerification.SelectCommand = userVerification;

            dB.Use(Modes.Open);
            DataTable tableWithCorrespondingUser = new DataTable();
            adapterVerification.Fill(tableWithCorrespondingUser);
            dB.Use(Modes.Close);


            if (tableWithCorrespondingUser.Rows.Count < 1)
            {
                MessageBox.Show("Введён не верный пароль!");
                return;
            }


          

            MySqlCommand resetDataUser = new MySqlCommand("UPDATE users " +
                "SET Name = @name, " +
                "LastName = @lastName, " +
                "Age = @age, " +
                "Length = @length, " +
                "Color = @color, " +
                "PreferMaxAge = @preferMaxAge, " +
                "PreferMinAge = @preferMinAge, " +
                "PreferMaxLength = @preferMaxLength, " +
                "PreferMinLength = @preferMinLength, " +
                "PreferColor = @preferColor " +
                "WHERE Login = @login", dB.GetConect());

            

            resetDataUser.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxName.Text;
            resetDataUser.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = textBoxLastName.Text;
            resetDataUser.Parameters.Add("@age", MySqlDbType.Int32).Value = Convert.ToInt32(textBoxAge.Text);
            resetDataUser.Parameters.Add("@length", MySqlDbType.Int32).Value = Convert.ToInt32(textBoxLength.Text);
            resetDataUser.Parameters.Add("@color", MySqlDbType.VarChar).Value = textBoxColor.Text; // 
            resetDataUser.Parameters.Add("@preferMaxAge", MySqlDbType.Int32).Value = Convert.ToInt32(textBoxPreferMaxAge.Text);
            resetDataUser.Parameters.Add("@preferMinAge", MySqlDbType.Int32).Value = Convert.ToInt32(textBoxPreferMinAge.Text);
            resetDataUser.Parameters.Add("@preferMaxLength", MySqlDbType.Int32).Value = Convert.ToInt32(textBoxPreferMaxLength.Text);
            resetDataUser.Parameters.Add("@preferMinLength", MySqlDbType.Int32).Value = Convert.ToInt32(textBoxPreferMinLength.Text);
            resetDataUser.Parameters.Add("@preferColor", MySqlDbType.VarChar).Value = textBoxPreferColor.Text;
            resetDataUser.Parameters.Add("@login", MySqlDbType.VarChar).Value = textLogin.Text;


            dB.Use(Modes.Open);
            if (resetDataUser.ExecuteNonQuery() < 1)
            {
                MessageBox.Show("Не удалось изменить данные!");
                return;
            }
            dB.Use(Modes.Close);



            MySqlCommand editUserMessages = new MySqlCommand("UPDATE usercorrespondence " +
                $"SET NameOfAnotherUser = '{textBoxName.Text}' " +
                $"WHERE LoginOfAnotherUser = '{textLogin.Text}'", dB.GetConect());


            dB.Use(Modes.Open);
            int usersWithWhomHeСommunicates = editUserMessages.ExecuteNonQuery();
            dB.Use(Modes.Close);

            Console.WriteLine(usersWithWhomHeСommunicates);
            MessageBox.Show("Данные измененны!");

            dataChanged = true;

        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            soundArkade.Play();


            SearchPeople searchPeople = null;
            if (dataChanged)
            {
                searchPeople = new SearchPeople(new User(
                     textBoxName.Text,
                     textBoxLastName.Text,
                     Convert.ToInt32(textBoxAge.Text),
                     Convert.ToInt32(textBoxLength.Text),
                     textBoxColor.Text,
                     Convert.ToInt32(textBoxPreferMaxAge.Text),
                     Convert.ToInt32(textBoxPreferMinAge.Text),
                     Convert.ToInt32(textBoxPreferMaxLength.Text),
                     Convert.ToInt32(textBoxPreferMinLength.Text),
                     textBoxPreferColor.Text,
                     textLogin.Text, "")
                    );
            }
            else
            {
                MessageBox.Show("ДАННЫЕ НЕ БЫЛИ ИЗМЕННЕНЫ!");

                searchPeople = new SearchPeople(new User(
                    oldUser.Name,
                    oldUser.LastName,
                    oldUser.Age,
                    oldUser.Length,
                    oldUser.Color,
                    oldUser.PreferMaxAge,
                    oldUser.PreferMinAge,
                    oldUser.PreferMaxLength,
                    oldUser.PreferMinLength,
                    oldUser.PreferColor,
                    oldUser.Login,
                    oldUser.Password
                    ));
            }    

                searchPeople.Show();
                this.Close();
             
            
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Exit.CloseMainWindow();
        }

        private void ToChangeUserData_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
