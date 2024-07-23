using MySql.Data.MySqlClient;
using GeneralResourcesForForms;
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
using System.Media;

namespace KCorrespondence
{
    public partial class SearchByName : Form
    {
        SoundPlayer openingFormsSound = new SoundPlayer(@"knopka-tsifrovoi-odinochnyii-shumnyii.wav");
        SoundPlayer backOrforward = new SoundPlayer("knopka-v-prostranstve-nizkii-vibriruyuschii.wav");
        SoundPlayer backToAnotherFormSound = new SoundPlayer("pryijok-v-igre.wav"); 

        User User;

        string[] LoginOfUserToWhomMessageBeingSents = new string[3];

        private Label[,] Labels = new Label[3, 10];
        private int UserIndex;

        public SearchByName(User user)
        {
            InitializeComponent();

            openingFormsSound.Play();

            User = user;

            TextNameSearh.Text = user.Name;
            TextLastNameSearh.Text = user.LastName;
            TextAgeSearh.Text = Convert.ToString(user.Age);
            TextLengthSearh.Text = Convert.ToString(user.Length);
            TextColorSearh.Text = user.Color;

            TextPreferMaxAgeSearh.Text = Convert.ToString(user.PreferMaxAge);
            TextPreferMinAgeSearh.Text = Convert.ToString(user.PreferMinAge);
            TextPreferMaxLengthSearh.Text = Convert.ToString(user.PreferMaxLength);
            TextPreferMinLengthSearh.Text = Convert.ToString(user.PreferMinLength);
            TextPreferColorSearch.Text = user.PreferColor;
            TextLoginSearh.Text = user.Login;

            int poziteonX = 300;
            int poziteonY = 55;

            for (int indexX = 0; indexX < СalculationOfArrayMeasurements.CalculationX(Labels); indexX++)
            {
                poziteonY = 55;

                for (int indexY = 0; indexY < СalculationOfArrayMeasurements.CalculationY(Labels); indexY++)
                {
                    Labels[indexX, indexY] = new Label() { Left = poziteonX, Top = poziteonY };
                    this.Controls.Add(Labels[indexX, indexY]);
                    poziteonY += 33;
                }

                poziteonX += 103;

            }

            Labels[0, 0].Click += ClickingOnNameUser0;
            Labels[1, 0].Click += ClickingOnNameUser1;
            Labels[2, 0].Click += ClickingOnNameUser2;
        }

        private void ButtonSearchForFollowing_Click(object sender, EventArgs e)
        {
            backOrforward.Play();

            char[] separationSymbols = { ' ', ',' };
            string[] NameAndLastName = NameAndLastNameUser.Text.Split(separationSymbols, StringSplitOptions.RemoveEmptyEntries);

            DB dataBaseUsers = new DB("server=localhost;port=3306;username=root;password=root;database=databasedatingsearchprogram");


            MySqlDataAdapter getUsersByName = null;
            try
            {
                getUsersByName = new MySqlDataAdapter(
                $"SELECT * FROM users " +
                $"WHERE Name = '{NameAndLastName[0]}' AND " +
                $"LastName = '{NameAndLastName[1]}' AND " +
                $"Login != '{User.Login}'" +
                $"ORDER BY Age, Length, PreferMaxAge, PreferMinAge, PreferMaxLength, PreferMinLength", dataBaseUsers.GetConect());
            }
            catch (IndexOutOfRangeException) 
            { 
                MessageBox.Show("Нужно ввести имя и фамилию!");
                return;
            }
            



            dataBaseUsers.Use(Modes.Open);

            DataSet myServerDatabases = new DataSet(); // DataSet это объект базы данных 
            getUsersByName.Fill(myServerDatabases);

            DataRow[] usersByNameRows = myServerDatabases.Tables[0].Select();

            try
            {
                for (int indexX = 0, indexRow = UserIndex; indexX < СalculationOfArrayMeasurements.CalculationX(Labels); indexX++, indexRow++)
                {

                    object[] user = usersByNameRows[indexRow].ItemArray;


                    if (indexRow < usersByNameRows.Length)
                        user = usersByNameRows[indexRow].ItemArray;
                    else
                        throw new AppealsToNonExistentUsersException("Попытка обратиться к пользователем которых нет", "Лево");


                    for (int indexY = 0; indexY < СalculationOfArrayMeasurements.CalculationY(Labels); indexY++)
                    {
                        object column = user[indexY];

                        Labels[indexX, indexY].Text = column.ToString();
                    }

                }

                UserIndex += 3;


            }
            catch (AppealsToNonExistentUsersException)
            {
                MessageBox.Show("Вы пытаетесь посмотреть следующих пользователей в самом конце");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("по вашем критериям пользователей больше не найдено!");
            }



            try
            {
                if(UserIndex == 0)
                {
                    for(int indexArray = 0, indexRow = UserIndex;  indexRow < LoginOfUserToWhomMessageBeingSents.Length; indexArray++, indexRow++)
                    {
                        object[] lines = usersByNameRows[indexRow].ItemArray;
                        LoginOfUserToWhomMessageBeingSents[indexArray] = lines[10].ToString();
                    }
                }
                else
                {
                    for (int indexArray = 2, indexRow = UserIndex - 1; indexArray < LoginOfUserToWhomMessageBeingSents.Length; indexArray--, indexRow--)
                    {
                        object[] lines = usersByNameRows[indexRow].ItemArray;
                        LoginOfUserToWhomMessageBeingSents[indexArray] = lines[10].ToString();

                    }
                }
                
            }
            catch { }


            // добавления обработчикв событий
            // присвоение обработчиков событий на события нажатияя имени пользователя в конструкторе решило проблему создания нескольких форм Chat при одном нажатие


            dataBaseUsers.Use(Modes.Close);

        }
        private void ButtonSearchForPrevies_Click(object sender, EventArgs e)
        {
            backOrforward.Play();

            char[] separationSymbols = { ' ', ',' };
            string[] NameAndLastName = NameAndLastNameUser.Text.Split(separationSymbols, StringSplitOptions.RemoveEmptyEntries);

            DB dataBaseUsers = new DB("server=localhost;port=3306;username=root;password=root;database=databasedatingsearchprogram");


            MySqlDataAdapter getUsersByName = null;
            try
            {
                getUsersByName =
                new MySqlDataAdapter($"SELECT * FROM users " +
                $"WHERE Name = '{NameAndLastName[0]}' " +
                $"AND LastName = '{NameAndLastName[1]}' " +
                $"AND Login != '{User.Login}' " +
                $"ORDER BY Age, Length, PreferMaxAge, PreferMinAge, PreferMaxLength, PreferMinLength", dataBaseUsers.GetConect());
            
            }
            catch (IndexOutOfRangeException) 
            { 
                MessageBox.Show("Нужно ввести имя и фамилию!");
                return;
            }

            dataBaseUsers.Use(Modes.Open);

            DataSet myServerDatabases = new DataSet(); // DataSet это объект базы данных 
            getUsersByName.Fill(myServerDatabases);

            DataRow[] usersByNameRows = myServerDatabases.Tables[0].Select();



            try
            {
                for (int indexX = 0, indexRow = UserIndex - 6; indexX < СalculationOfArrayMeasurements.CalculationX(Labels); indexX++, indexRow++)
                {

                    object[] lines = null;

                    if (indexRow >= 0)
                        lines = usersByNameRows[indexRow].ItemArray;
                    else
                        throw new AppealsToNonExistentUsersException("Попытка обратиться к пользователем которых нет", "Лево");

                    for (int indexY = 0; indexY < СalculationOfArrayMeasurements.CalculationY(Labels); indexY++)
                    {
                        object column = lines[indexY];

                        Labels[indexX, indexY].Text = column.ToString();
                    }

                }

                if (UserIndex >= 6) // идёт возврат к обратной позиции!
                {                   // 
                    UserIndex -= 3;
                }

            }
            catch (AppealsToNonExistentUsersException)
            {
                MessageBox.Show("Вы пытаетесь посмотреть предыдущих пользователей в самом начале");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("по вашем критериям пользователей больше не найдено!");
            }


            try
            {
                // сделать цикл который будет присваивать все логины выводим пользователей в элементы массива 
                for (int indexArray = 0, indexRow = UserIndex - 3; indexArray < LoginOfUserToWhomMessageBeingSents.Length; indexArray++, indexRow++)
                {
                    object[] lines = usersByNameRows[indexRow].ItemArray;
                    LoginOfUserToWhomMessageBeingSents[indexArray] = lines[10].ToString();

                }
            }
            catch { }

        }
        private void ClickingOnNameUser0(object sender, EventArgs e)
        {
            this.Hide();
            Chat chatForm = new Chat(Labels[0, 0].Text, LoginOfUserToWhomMessageBeingSents[0], TextNameSearh.Text, TextLoginSearh.Text, NamesForms.SearchByName);
            chatForm.Show();

        }
        private void ClickingOnNameUser1(object sender, EventArgs e)
        {
            this.Hide();
            Chat chatForm = new Chat(Labels[1, 0].Text, LoginOfUserToWhomMessageBeingSents[1], TextNameSearh.Text, TextLoginSearh.Text, NamesForms.SearchByName);
            chatForm.Show();

        }
        private void ClickingOnNameUser2(object sender, EventArgs e)
        {
            this.Hide();                                // раньше здесь была ошибка при которой брался пользователь не тот что нужен а через три после него
            Chat chatForm = new Chat(Labels[2, 0].Text, LoginOfUserToWhomMessageBeingSents[2], TextNameSearh.Text, TextLoginSearh.Text, NamesForms.SearchByName);
            chatForm.Show();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            backToAnotherFormSound.Play();
            Form form = Back.SearchForPreviousForm(NamesForms.SearchPeople);

            form.Show();
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Exit.CloseMainWindow();
        }

        private void SearchByName_Load(object sender, EventArgs e)
        {

        }

        private void TextNameSearh_Click(object sender, EventArgs e)
        {

        }

        
    }
}
