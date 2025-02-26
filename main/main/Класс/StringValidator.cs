using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2kurs.Validators
{
    /// <summary>
    /// Класс для проверки строковых значений.
    /// </summary>
    class StringValidators
    {
        /// <summary>
        /// Проверяет, является ли строка непустой и состоит только из букв.
        /// </summary>
        /// <param name="value">Строка для проверки.</param>
        /// <returns>Возвращает true, если строка не пустая и содержит только буквы, иначе false.</returns>
        static public bool Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false; // Возвращаем false для пустых строк или строк, содержащих только пробелы.
            }

            foreach (char c in value)
            {
                if (!char.IsLetter(c)) //IsLetter(c)- проверка буква или ли
                {
                    return false; // Возвращаем false, если хоть один символ не является буквой.
                }
            }

            return true; // Возвращаем true, если все символы - буквы и строка не пустая.
        }
    }
}