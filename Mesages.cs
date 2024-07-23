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

    public partial class Mesages : Form
    {
        bool closure = false; 

        SoundPlayer sendingSound = new SoundPlayer(@"korotkiy-chpok.wav");
        SoundPlayer errorSound = new SoundPlayer(@"zvuk-windows-7-vosklitsanie-23060.wav");
        SoundPlayer openingSound = new SoundPlayer(@"knopka-tsifrovoi-odinochnyii-shumnyii.wav");
        SoundPlayer backSound = new SoundPlayer(@"natknulis-na-prepyatstvie.wav");

        string MyName;
        string MyLogin;

        string LoginOfAnotherUser;

        public Mesages(string recipientName, string recipientLogin)
        {
            InitializeComponent();

            MyName = recipientName;
            MyLogin = recipientLogin;

            DB dB = new DB("server=localhost;port=3306;username=root;password=root;database=databasedatingsearchprogram");

            MySqlDataAdapter adapterMessage = new MySqlDataAdapter($"SELECT * FROM usercorrespondence WHERE Login = '{MyLogin}' ", dB.GetConect());

            dB.Use(Modes.Open);

            DataSet dR = new DataSet();
            adapterMessage.Fill(dR);

            try
            {
                DataRow[] tableMesages = dR.Tables[0].Select();

                DataRow rowsMesage = tableMesages[0];

                NameUser.Text = rowsMesage[1].ToString();
                LoginOfAnotherUser = rowsMesage[2].ToString();
                Message.Text = rowsMesage[3].ToString();
            }
            catch (IndexOutOfRangeException)
            {
                closure = true;
                
            }
        }

        private void Mesages_Load(object sender, EventArgs e)
        {
            if (closure)
            {
                ToReturn(this, e);
                errorSound.Play();
                MessageBox.Show("Для вас эта вкладка не доступна");
            }
                


            // если LoginOfAnotherUser будет равно null это означает что в конструкторе было сгенерированно исключение 
            if (LoginOfAnotherUser == "") 
            {
                errorSound.Play();

                MessageBox.Show("Пока у вас нет сообщений");

                TextFromWhom.Hide();
                TextMessage.Hide();
                TextYourQuait.Hide();
                messageBeingSent.Hide();
                buttonSend.Hide();
            }
            else
            {
                openingSound.Play();
                textInfoYouHaveNoMessages.Hide();
            }

                
            
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            DB dB = new DB("server=localhost;port=3306;username=root;password=root;database=databasedatingsearchprogram");

            // произходит ошибка при попытке отправить сообщение старому пользователю по его логину
            // поскольку если старые пользователи создовались без таблицы с логинами и сообщениями

            MySqlCommand sendMessage = new MySqlCommand($"UPDATE usercorrespondence " +
                $"SET NameOfAnotherUser = '{MyName}', " +
                $"LoginOfAnotherUser = '{MyLogin}', " +
                $"MessageOfAnotherUser = '{messageBeingSent.Text}' " +
                $"WHERE Login = '{LoginOfAnotherUser}' ", dB.GetConect());

            dB.Use(Modes.Open);
            int result = sendMessage.ExecuteNonQuery();
            dB.Use(Modes.Close);

            if (result > 0)
            {
                sendingSound.Play();
                MessageBox.Show("Сообщение отправленно!");
            }
            else
            {
                errorSound.Play();
                MessageBox.Show("Ошибка отправки!");
            }
                

        }

        private void ToReturn(object sender, EventArgs e)
        {
            backSound.Play();
            Form form = Back.SearchForPreviousForm(NamesForms.SearchPeople);

            form.Show();
            this.Close();

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Exit.CloseMainWindow();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
