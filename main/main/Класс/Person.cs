using Lab_1_2kurs.Validators;
using System;
namespace Lab_1_2kurs
{
    class Person
    {
        /// <summary>
        /// Констуктор, 4 параметра
        /// </summary>
        /// <param name="height">Рост</param>
        /// <param name="weight">Вес</param>
        /// <param name="BirthDay">Дата Рождения</param>
        /// <param name="FullName">Полное имя</param>
        public Person(int height, int weight, DateTime BirthDay, string FullName)
        {
            try
            {
                // Проверка для роста и веса
                if (ChangeHeight(height) == false)
                    throw new Exception("Неправильно указано значение для роста.");
                if (ChangeWeight(weight) == false)
                    throw new Exception("Неправильно указано значение для веса.");

                this.Birthday = BirthDay;

                // Проверка на пустое или неправильное имя
                if (string.IsNullOrWhiteSpace(FullName) || FullName.Contains("  "))
                    throw new Exception("Полное имя не может быть пустым или содержать двойные пробелы.");

                string fullName = FullName.Trim(); //Trim() перед обработкой полного имени, убираем все пробелы, в начале или в конце строки.

                // Разделение полного имени на имя и фамилию
                string[] nameParts = fullName.Split(new[] { ' ' }, 2); // Разделяем строку на имя и фамилию

                string firstNam = nameParts[0]; // имя
                string lastNam = nameParts[1];  // фамилия

                // Проверка на правильность разделения
                if (nameParts.Length != 2)
                    throw new Exception("Полное имя содержит только имя и фамилию, разделенные пробелом.");

                // Применяем изменения для имени и фамилии
                if (ChangeFirstName(firstNam) == false)
                    throw new Exception("Неправильно указано значение");
                if (ChangeLastName(lastNam) == false)
                    throw new Exception("Неправильно указано значение");


                // this.FullName = FullName;
                Console.WriteLine("Рост " + this.Height);
                Console.WriteLine("Вес " + this.Weight);
                Console.WriteLine("Дата рождения " + this.Birthday);
                Console.WriteLine("Полное имя " + this.FullName);
                Console.WriteLine("Имя " + this.FirstName);
                Console.WriteLine("Фамилия " + this.LastName);
                Console.WriteLine();
            }
            catch (IOException e)
            {
                Console.WriteLine($"Ошибка.{e.Message}");
            }

        }
        // Рост
        public int Height { get; private set; /* автоматическое свойство*/ }
        // Вес
        public double Weight { get; private set; }
        // Дата рождения
        public DateTime Birthday { get; }
        // Имя
        public string FirstName { get; private set; }
        // Фамилия
        public string LastName { get; private set; }
        // Полное имя - Имя и фамилия
        public string FullName
        {
            get // Не автоматическое свойство
            {
                return FirstName + " " + LastName;
            }
        }
        /// <summary>
        /// Изменение роста
        /// </summary>
        /// <param name="Height">Рост</param>
        /// <returns>true или false</returns>
        public bool ChangeHeight(int Height)
        {
            bool flag = IntValidator.Validate(Height);
            if (flag)
                this.Height = Height;
            return flag;
        }
        /// <summary>
        /// Изменение веса
        /// </summary>
        /// <param name="weight">Вес</param>
        /// <returns>true или false</returns>
        public bool ChangeWeight(int weight)
        {
            bool flag = IntValidator.Validate(weight);
            if (flag)
                Weight = weight;
            return flag;
        }
        /// <summary>
        /// Изменение имени
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <returns>true или false</returns>
        public bool ChangeFirstName(string firstName)
        {
            bool flag = StringValidators.Validate(firstName);
            if (flag)
                FirstName = firstName; //для true,будет возвращать имя
            return flag; 
        }
        /// <summary>
        /// Изменение фамилии
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns>true или false</returns>
        public bool ChangeLastName(string lastName)
        {
            bool flag = StringValidators.Validate(lastName);
            if (flag)
                this.LastName = lastName;
            return flag;
        }

    }
}

