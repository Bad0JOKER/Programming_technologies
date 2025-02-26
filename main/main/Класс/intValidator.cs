using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2kurs.Validators
{
    /// <summary>
    /// Класс проверки целочисленных данных
    /// </summary>
    class IntValidator
    {
        /// <summary>
        /// Проверка числа, чтобы не было меньше 0
        /// </summary>
        /// <param name="value">Значение</param>
        /// <returns>Возвращается true, если значение больше 0, если меньше 0, то false</returns>
        static public bool Validate(int value)
        {
            return value > 0;
        }
    }
}

