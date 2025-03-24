using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    struct Workers
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public string Passport { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Name">Имя работника</param>
        /// <param name="Surname">Фамилия работника</param>
        /// <param name="Age">Возраст работника</param>
        /// <param name="Passport">Данные паспорта работника</param>
        public Workers(string Name, string Surname, string Age, string Passport)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
            this.Passport = Passport;
        }
    }
}