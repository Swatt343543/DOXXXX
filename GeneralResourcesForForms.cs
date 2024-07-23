using MySql.Data.MySqlClient; // что бы работать базой данных Sql нужно подключть её это пространство имён
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data;

namespace GeneralResourcesForForms
{
    namespace DataBasetManager
    {
        public enum Modes { Open, Close }

        class ActionForDataExeption : Exception
        {
            public ActionForDataExeption(string message) : base(message) { }

        }

        internal class DB // создал класс который управляет базой данных
        {
            // мы создали объект подключения к серверу 

            MySqlConnection connectDataUsers; // new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=DatingProgramDatabase");    

            public DB(string database)
            {
                connectDataUsers = new MySqlConnection(database);
            }

            public void Use(Modes mode)
            {
                    switch (mode)
                    {
                        case Modes.Open:
                            if (connectDataUsers.State == ConnectionState.Closed)
                                connectDataUsers.Open();
                            else
                                throw new AccessViolationException("Попытка открытть и так открытфй файл!");
                        break;

                        case Modes.Close:
                            if (connectDataUsers.State == ConnectionState.Open) 
                                connectDataUsers.Close();
                            else 
                                throw new ActionForDataExeption("Попытка закрыть и так закрытый файл!");
                        break;
                    }

            }

            public MySqlConnection GetConect()
            {
                return connectDataUsers;
            }


        }
    }


    public enum NamesForms { Authorization, Registation, SearchPeople, Chat, Mesages, ToChangeUserData, SearchByName }

    static class Back
    {
        

        public static Form SearchForPreviousForm(NamesForms nameForm)
        {
            foreach(Form form in Application.OpenForms)
            {
                if(form.Name == Convert.ToString(nameForm))
                    return form;
            }

            return null;
        }

    }

    internal static class Exit
    {
        static readonly SoundPlayer soundExit = new SoundPlayer(@"bryanchanie-konservnoy-banki1.wav");

        public static void CloseMainWindow()
        {
            soundExit.Play();

            DateTime dateTime = DateTime.Now;
            int secondStart = dateTime.Second;

            for (; ; )
            {
                dateTime = DateTime.Now;

                if ((secondStart + 1) < dateTime.Second)
                {
                    Form form = Application.OpenForms[0]; // массив OpenForms хранит в себе все формы включая главную 
                    form.Close();                         // главная форма в этом массиве наъолится под номером 0
                    return;                               // и когда мы закрываем её закрываются все фоормы!
                }

            }
        }

    }

    public class User
    {
        int age;
        int length;
        int preferMaxAge;
        int preferMinAge;
        int preferMaxLength;
        int prferMinLength;
        

      
        public string Name { get; set; }

        public string LastName { get; set; }

        public int Age
        {
            get { return age; }
            set
            {
                if(value >= 0 && value <= 150)
                {
                    age = value;
                }
                else if(value < 0)
                {
                    age = -value;
                }
                else if(value > 150)
                {
                    age = 150;
                }
                    
            }
        }

        public int Length
        {
            get { return length; }
            set
            {
                if (value >= 0 && value <= 280)
                {
                    length = value;
                }
                else if (value < 0)
                {
                    length = -value;
                }
                else if (value > 280)
                {
                    length = 280;
                }
            }

        }

        public string Color { get;  set; }

        public int PreferMaxAge
        {
            get
            {
                return preferMaxAge;
            }
            set
            {
                if (value >= 0 && value <= 150)
                {
                    preferMaxAge = value;
                }
                else if (value < 0)
                {
                    preferMaxAge = -value;
                }
                else if (value > 150)
                {
                    preferMaxAge = 150;
                }
            }
                
            

        }

        public int PreferMinAge
        {
            get
            {
                return preferMinAge;
            }
            set
            {
                if (value >= 0 && value <= 150)
                {
                    preferMinAge = value;
                }
                else if (value < 0)
                {
                    preferMinAge = -value;
                }
                else if (value > 150)
                {
                    preferMinAge = 150;
                }
            }
        }

        public int PreferMaxLength
        {
            get
            {
                return preferMaxLength;
            }
            set
            {
                if (value >= 0 && value <= 280)
                {
                    preferMaxLength = value;
                }
                else if (value < 0)
                {
                    preferMaxLength = -value;
                }
                else if (value > 280)
                {
                    preferMaxLength = 280;
                }
            }

        }

        public int PreferMinLength
        {
            get
            {
                return prferMinLength;
            }
            set
            {
                if (value >= 0 && value <= 280)
                {
                    prferMinLength = value;
                }
                else if (value < 0)
                {
                    prferMinLength = -value;
                }
                else if (value > 280)
                {
                    prferMinLength = 280;
                }
            }

        }

        public string PreferColor { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

    

        public User(string name, string lastName, int age, int length, string color, int preferMaxAge, int preferMinAge, int preferMaxLength, int preferMinLength, string preferColor, string login, string password)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Length = length;
            Color = color;
            PreferMaxAge = preferMaxAge;
            PreferMinAge = preferMinAge;
            PreferMaxLength = preferMaxLength;
            PreferMinLength = preferMinLength;
            PreferColor = preferColor;
            Login = login;
            Password = password;
        }
    } 

    
}
