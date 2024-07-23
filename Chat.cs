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
    public partial class Chat : Form
    {
        SoundPlayer sendingSound = new SoundPlayer(@"korotkiy-chpok.wav");
        SoundPlayer openingSound = new SoundPlayer(@"knopka-tsifrovoi-odinochnyii-shumnyii.wav");
        SoundPlayer backToAnotherFormSound = new SoundPlayer("pryijok-v-igre.wav");
        SoundPlayer errorSound = new SoundPlayer(@"zvuk-windows-7-vosklitsanie-23060.wav");

        NamesForms CallingForm;

        public Chat(string nameOfReceivingUser, string loginOfResivingUser, string nameOfSendingUser, string loginOfSendingUser, NamesForms callingForm)
        {
            InitializeComponent();

            openingSound.Play();

            TextReceivingUserName.Text = nameOfReceivingUser;
            RecipientingUserLogin.Text = loginOfResivingUser; 

            SendingUserName.Text = nameOfSendingUser;
            SendingUserLogin.Text = loginOfSendingUser;

            CallingForm = callingForm;
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            DB dataBase = new DB("server = localhost; port = 3306; username = root; password = root; database = databasedatingsearchprogram");

            // КОМАНА UPDATE ПОЗВОЛЯЕТ ИЗМЕНЯТЬ ДАННЫЕ В СТРОКАХ
            MySqlCommand sendingMessage = new MySqlCommand($"UPDATE usercorrespondence " +
                $"SET NameOfAnotherUser = @rexeivingUserName, " +
                $"LoginOfAnotherUser = @rexeivingUserLogin, " +
                $"MessageOfAnotherUser = @message " +
                $"WHERE Login = @loginOfRecipient", dataBase.GetConect());

            sendingMessage.Parameters.Add("@rexeivingUserName", MySqlDbType.VarChar).Value = SendingUserName.Text;
            sendingMessage.Parameters.Add("@rexeivingUserLogin", MySqlDbType.VarChar).Value = SendingUserLogin.Text;
            sendingMessage.Parameters.Add("@message", MySqlDbType.VarChar).Value = Message.Text;
            sendingMessage.Parameters.Add("@loginOfRecipient", MySqlDbType.VarChar).Value = RecipientingUserLogin.Text;


            dataBase.Use(Modes.Open);

            try
            {
                int numberOfUsers = sendingMessage.ExecuteNonQuery();

                if (numberOfUsers == 1)
                {
                    sendingSound.Play();
                    MessageBox.Show("Сообщение отправленно");
                }
                else
                {
                    errorSound.Play();
                    MessageBox.Show("Ошибка отправки");
                }
                    

            }
            catch(Exception exc)
            {
                MessageBox.Show("Неудалось отправить сообщение! Исключение: {0}", exc.Message); 
            }



            dataBase.Use(Modes.Close);
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            backToAnotherFormSound.Play();
            Form form = Back.SearchForPreviousForm(CallingForm);

            form.Show();
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Exit.CloseMainWindow();
        }

        private void Message_TextChanged(object sender, EventArgs e)
        {

        }

        private void Chat_Load(object sender, EventArgs e)
        {

        }

        private void TextYourMessage_Click(object sender, EventArgs e)
        {

        }

     
    }
}

