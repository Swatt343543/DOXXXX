using GeneralResourcesForForms;
using GeneralResourcesForForms.DataBasetManager;
using System.IO;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace KCorrespondence
{

    public partial class SearchPeople : Form
    {
        
        readonly SoundPlayer SoundCreate = new SoundPlayer(@"knopka-voda-zvonkii-blizkii-v-prostranstve.wav");
        SoundPlayer openingFormsSound = new SoundPlayer(@"knopka-tsifrovoi-odinochnyii-shumnyii.wav");

        User User;

        DataRow[] usersTable;

        string[] LoginOfUserToWhomMessageBeingSents = new string[3];

        public Label[,] Labels { get; private set; } = new Label[3, 10];
        public int UserIndex { get; private set; }

        

        public SearchPeople(User user)
        {
            InitializeComponent();

            // теперь у класса SearchPeople нет свойств потому что эти свойства описывали пользователя а не форму поэтой причине я их убрал 

            

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

            
            DB conectorDataBase = new DB("server=localhost;port=3306;username=root;password=root;database=databasedatingsearchprogram");
            // когда мы записываем SELECT * FROM `users` мы говоим что нам нужно выбрать все ячейки из таблицы `users` тагже можо укахывать только отдельные ячейки

            MySqlDataAdapter dataAdapter =null;

            if(user.PreferColor != "")
            {
                dataAdapter = new MySqlDataAdapter("SELECT * FROM `users` WHERE " +
                   $"Age <= {user.PreferMaxAge} AND Age >= {user.PreferMinAge} AND " +
                   $"Length <= {user.PreferMaxLength} AND Length >= {user.PreferMinLength} AND " +
                   $"Color = '{user.PreferColor}' AND " +
                   $"Login != '{user.Login}' " +
                   $"ORDER BY Age, Length, PreferMaxAge, PreferMinAge, PreferMaxLength, PreferMinLength, PreferMaxLength", conectorDataBase.GetConect());
            }
            else
            {
                dataAdapter = new MySqlDataAdapter("SELECT * FROM `users` WHERE " +
                   $"Age <= {user.PreferMaxAge} AND Age >= {user.PreferMinAge} AND " +
                   $"Length <= {user.PreferMaxLength} AND Length >= {user.PreferMinLength} AND " +
                   $"Login != '{user.Login}' " +
                   $"ORDER BY Age, Length, PreferMaxAge, PreferMinAge, PreferMaxLength, PreferMinLength, PreferMaxLength", conectorDataBase.GetConect());
            }
            

            conectorDataBase.Use(Modes.Open);

            DataSet myServerDatabases = new DataSet(); // DataSet это объект базы данных 
            dataAdapter.Fill(myServerDatabases); // заполнили объет dataSet таблицей в уоторой содержаться только правильные ползователи!

            usersTable = myServerDatabases.Tables[0].Select();

            int poziteonX = 450;
            int poziteonY = 50;

            for (int indexX = 0; indexX < СalculationOfArrayMeasurements.CalculationX(Labels); indexX++)
            {
                poziteonY = 50;

                for (int indexY = 0; indexY < СalculationOfArrayMeasurements.CalculationY(Labels); indexY++)
                {
                    Labels[indexX, indexY] = new Label() { Left = poziteonX, Top = poziteonY};
                    this.Controls.Add(Labels[indexX, indexY]);
                    poziteonY += 33;
                }

                poziteonX += 103;

            }

            conectorDataBase.Use(Modes.Close);

            // добавления обработчикв событий
            // присвоение обработчиков событий на события нажатияя имени пользователя в конструкторе решило проблему создания нескольких форм Chat при одном нажатие
            Labels[0, 0].Click += ClickingOnNameUser0;
            Labels[1, 0].Click += ClickingOnNameUser1;
            Labels[2, 0].Click += ClickingOnNameUser2;


        }

     
        // поиск следующих пользователей
        private void ButtunSearhtheFolowing_Click(object sender, EventArgs e)
        {

            SoundCreate.Play();


            // мы стачало получаем таблицу затем получаем столбец из этой таблиы и наконец в конце получаем отдельные строки изстолбца и выводим их


            try
            {
                for (int indexX = 0, indexRow = UserIndex; indexX < СalculationOfArrayMeasurements.CalculationX(Labels); indexX++, indexRow++)
                {

                    object[] lines = usersTable[indexRow].ItemArray;


                    if (indexRow < usersTable.Length - 1)
                        lines = usersTable[indexRow].ItemArray;
                    else
                        throw new AppealsToNonExistentUsersException("Попытка обратиться к пользователем которых нет", "Лево");
                    

                    for (int indexY = 0; indexY < СalculationOfArrayMeasurements.CalculationY(Labels); indexY++)
                    {
                        object column = lines[indexY];

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
                // сделать цикл который будет присваивать все логины выводим пользователей в элементы массива 
                for (int indexArray = 2, indexRow = UserIndex - 1; indexArray < LoginOfUserToWhomMessageBeingSents.Length; indexArray--, indexRow--)
                {
                    object[] lines = usersTable[indexRow].ItemArray;
                    LoginOfUserToWhomMessageBeingSents[indexArray] = lines[10].ToString();

                }
            }
            catch { }


        }

        // Поиск предыдущих пользователей!
        private void ButtunSearhthePrevious_Click_1(object sender, EventArgs e)
        {

            SoundCreate.Play();
            

            try
            {
                for (int indexX = 0, indexRow = UserIndex - 6; indexX < СalculationOfArrayMeasurements.CalculationX(Labels); indexX++, indexRow++)
                {

                    object[] lines = null;

                    if (indexRow >= 0)
                        lines = usersTable[indexRow].ItemArray;
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
                    object[] lines = usersTable[indexRow].ItemArray;
                    LoginOfUserToWhomMessageBeingSents[indexArray] = lines[10].ToString();

                }
            }
            catch { }



        }


        private void ClickingOnNameUser0(object sender, EventArgs e)
        {

            // Labels[0, 0].Text имя полюзователя которому отправляется сообщение 
            // LoginOfUserToWhomMessageBeingSents[0] это логин пользователя которму будет отправлятся значение
            // TextNameSearh.Text имя пользователя отправляющего сообщение 
            // TextLoginSearh.Text логин пользователя отправляющего сообщение 
            this.Hide();
            Chat chatForm = new Chat(Labels[0, 0].Text, LoginOfUserToWhomMessageBeingSents[0], TextNameSearh.Text, TextLoginSearh.Text, NamesForms.SearchPeople );
            chatForm.Show();

        }
        private void ClickingOnNameUser1(object sender, EventArgs e)
        {
            this.Hide();
            Chat chatForm = new Chat(Labels[1, 0].Text, LoginOfUserToWhomMessageBeingSents[1], TextNameSearh.Text, TextLoginSearh.Text, NamesForms.SearchPeople);
            chatForm.Show();

        }
        private void ClickingOnNameUser2(object sender, EventArgs e)
        {
            this.Hide();                                // раньше здесь была ошибка при которой брался пользователь не тот что нужен а через три после него
            Chat chatForm = new Chat(Labels[2, 0].Text, LoginOfUserToWhomMessageBeingSents[2], TextNameSearh.Text, TextLoginSearh.Text, NamesForms.SearchPeople);
            chatForm.Show();

        }

        private void ButtonResetDataUser_Click(object sender, EventArgs e)
        {
            
            ToChangeUserData changeUserForm = new ToChangeUserData(User);

            changeUserForm.Show();
            this.Close();
        }

        private void ButtunViewMessages_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mesages mesageForm = new Mesages(TextNameSearh.Text, TextLoginSearh.Text);

            mesageForm.Show();
            

        }

        private void ButtonSearchByName_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchByName searchByNameForm = new SearchByName(User);
            searchByNameForm.Show();
        }


        private void ButtonBack_Click(object sender, EventArgs e)
        {
            openingFormsSound.Play();
            Form form = Application.OpenForms[0];
            form.Show();
            
            this.Close();
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            Exit.CloseMainWindow();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {

        }

        private void ButtonToChangeData_Click(object sender, EventArgs e)
        {

        }

        private void SearchPeople_Load(object sender, EventArgs e)
        {

        }

        private void TextPreferMaxAge_Click(object sender, EventArgs e)
        {

        }

        private void TextPreferMinAge2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TextUsersPreferMinAge_Click(object sender, EventArgs e)
        {

        }

        private void TextUsersPreferMinLength_Click(object sender, EventArgs e)
        {

        }

        private void TextUsersPreferColor_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void TextLoginSearh_Click(object sender, EventArgs e)
        {

        }

       
    }
    static class СalculationOfArrayMeasurements
    {
        public static int CalculationX(dynamic array)
        {
            int ArrayMeasurements = 0;

            try
            {
                for (int index = 0; index < int.MaxValue; index++)
                {
                    dynamic p = array[index, 0]; // данная переменная негде не используется она нужна только для того что бы можно воспользоватся элементом по индексу!
                    ArrayMeasurements++;
                }
            }
            catch (IndexOutOfRangeException) { }

            return ArrayMeasurements;

        }
        public static int CalculationY(dynamic array)
        {
            int ArrayMeasurements = 0;

            try
            {
                for (int index = 0; index < int.MaxValue; index++)
                {
                    dynamic p = array[0, index]; // данная переменная негде не используется она нужна только для того что бы можно воспользоватся элементом по индексу!
                    ArrayMeasurements++;
                }
            }
            catch (IndexOutOfRangeException) { }

            return ArrayMeasurements;

        }



    }

    class AppealsToNonExistentUsersException : Exception
    {
        public string Side { get; private set; }

        public AppealsToNonExistentUsersException(string message, string side) : base(message)
        {
            Side = side;
        }

        public override string ToString()
        {
            return "Причина ошибки: " + Message + "Сторона в которую произошо о обращение к пользователям и обращение к которой дало исключение: " + Side;
        }
    }
}
