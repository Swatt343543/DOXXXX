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
using System.IO;

namespace KCorrespondence
{
 
    // в исходном файле где находиться форма первым классом должна быть сама форма а не другой класс!
    /*
       class f ошибка
       {
          
       }
     */


    public partial class Registation : Form
    {
        readonly SoundPlayer SoundOfLoudButton = new SoundPlayer(@"knopka-jeskaya-zvonkii-blizkii-multyashnyii.wav");


        public Registation()
        {
            InitializeComponent();
        }


        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            SoundOfLoudButton.Play();


            try
            {
                string userName = BoxNameReg.Text;
                string userLastName = BoxLastNameReg.Text;
                int userAge = Convert.ToInt32(BoxAgeReg.Text);
                int userLength = Convert.ToInt32(BoxLengthReg.Text);
                string userColor = BoxColorReg.Text;
                string userLogin = BoxLoginReg.Text;
                string userPassword = BoxPasswordReg.Text;

                int preferMaxAge = Convert.ToInt32(BoxPreferMaxAgeReg.Text);
                int preferMinAge = Convert.ToInt32(BoxPreferMinAgeReg.Text);
                int preferMaxLength = Convert.ToInt32(BoxPreferMaxLengthReg.Text);
                int preferMinLength = Convert.ToInt32(BoxPreferMinLengthReg.Text);
                string preferColor = BoxPreferColorReg.Text;

                if (userName == "" || userLastName == "" || userLogin == "" || userPassword == "")
                    throw new CreatingUserWithoutData("Имя, Фамилия, Логин и пароль не могут не содержать значений!");
                                                                                                 


                DB dB = new DB("server=localhost;port=3306;username=root;password=root;database=databasedatingsearchprogram");

                MySqlCommand checkingForExistence = new MySqlCommand($"SELECT `Login` FROM `users` WHERE `Login` = @userLogin", dB.GetConect());
                checkingForExistence.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = userLogin;

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                MySqlCommand creatingUser = null;
                MySqlCommand creatingMesagesUser = null;


                dataAdapter.SelectCommand = checkingForExistence;

                dB.Use(Modes.Open); 

                DataTable dataRow = new DataTable();
                dataAdapter.Fill(dataRow);

                dB.Use(Modes.Close);
                 
                
                if (dataRow.Rows.Count < 1)
                {
                    // в качестве первого парметра здесь служит команда
                 creatingUser = new MySqlCommand(
                    "INSERT INTO `users` (`Name`, `LastName`, `Age`, `Length`, `Color`, `PreferMaxAge`, `PreferMinAge`, `PreferMaxLength`, `PreferMinLength`, `PreferColor`, `Login`, `Password`) " +
                    "VALUES (@name, @lastName, @age, @length, @color, @preferMaxAge, @preferMinAge, @PreferMaxLength, @preferMinLength, @preferColor, @login, @password)", dB.GetConect());

                    // значения которые мы хотим инициализировать должны быть в скобках а тагже сами значения которые мы хотим присвоить должны быть в скобках!
                    creatingMesagesUser = new MySqlCommand("INSERT INTO usercorrespondence (Login) " +
                        "VALUES (@login)", dB.GetConect());
                }
                else
                {
                    MessageBox.Show("Уже существует пользователь с указанным вами логином");
                    return;
                }
                

                // а в качестве второго объект который подключается к базе данных 
                // заклушки нужно указывать не в '' иначе мы присвом не заглушку которую можно поменять на  хначения а текст который мы указали в ''


                // передавая в качеств аргумента dB.GetConect() мы передаём ссылку на объект подключения к sql и далее 

                creatingUser.Parameters.Add("@name", MySqlDbType.VarChar).Value = userName;
                creatingUser.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = userLastName;
                creatingUser.Parameters.Add("@age", MySqlDbType.Int32).Value = userAge; 
                creatingUser.Parameters.Add("@length", MySqlDbType.Int32).Value = userLength;
                creatingUser.Parameters.Add("@color", MySqlDbType.VarChar).Value = userColor;
                creatingUser.Parameters.Add("@preferMaxAge", MySqlDbType.Int32).Value = preferMaxAge;
                creatingUser.Parameters.Add("@preferMinAge", MySqlDbType.Int32).Value = preferMinAge;
                creatingUser.Parameters.Add("@preferMaxLength", MySqlDbType.Int32).Value = preferMaxLength;
                creatingUser.Parameters.Add("@preferMinLength", MySqlDbType.Int32).Value = preferMinLength;
                creatingUser.Parameters.Add("@preferColor", MySqlDbType.VarChar).Value = preferColor;
                creatingUser.Parameters.Add("@login", MySqlDbType.VarChar).Value = userLogin;
                creatingUser.Parameters.Add("@password", MySqlDbType.VarChar).Value = userPassword;


                creatingMesagesUser.Parameters.Add("@login", MySqlDbType.VarChar).Value = userLogin;
         


                FileStream stream = new FileStream("有关设备发生的数据.txt", FileMode.Open);
                StreamReader streamReader = new StreamReader(stream);
                StreamWriter streamWriter = new StreamWriter(stream);

                try
                {
                   
                  if (!streamReader.ReadLine().Contains("no"))
                    {
                        dB.Use(Modes.Open);

                        creatingUser.ExecuteNonQuery();
                        creatingMesagesUser.ExecuteNonQuery();

                        MessageBox.Show($"Приветтвуем вас {userName} {userLastName}!\nВы были успешно зарегистрированны!");

                        stream.Position = 0;
                        streamWriter.Write("no"); // после тогоо как будет сделана конечнаяя версия этой программы, коментарий нужно убрать!!!!  
                        streamWriter.Flush();


                        this.Close();

                        // оздаём другую фору в этой форме и присваиваем её полю UserName значение userName, полю UserLastName присваиваем userLastName и так далее

                        User newUser = new User(userName, userLastName, userAge, userLength, userColor, preferMaxAge, preferMinAge, preferMaxLength, preferMinLength, preferColor, userLogin, userPassword);
                        SearchPeople searchObj = new SearchPeople(newUser);

                        searchObj.Show();
                    }
                    else
                    {
                        MessageBox.Show("Вы уже зарегестрировались!");
                    }


                         


                }
                finally
                {
                    dB.Use(Modes.Close);
                    streamReader.Close();
                    stream.Close();
                }







            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка регистрации! Вы ввели некоректные данные!!");
            }
            catch (CreatingUserWithoutData exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (ActionForDataExeption)
            {
                Console.WriteLine("ОТкрытие и так открытого файла!");
            }
         
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            SoundOfLoudButton.Play();
            Form form = Back.SearchForPreviousForm(NamesForms.Authorization);

            form.Show();
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Exit.CloseMainWindow();
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_Click(object sender, EventArgs e)
        {

        }

        private void TextName_Click(object sender, EventArgs e)
        {

        }

        private void PreferLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxLoginReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
    }

    class CreatingUserWithoutData : Exception
    {
        public CreatingUserWithoutData(string message) : base(message) { }
    }


}
