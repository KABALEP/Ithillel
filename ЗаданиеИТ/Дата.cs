using System;
using System.Collections.Generic;
using System.Text;

namespace ЗаданиеИТ
{
    class Дата
    {
        public  void Dat(string x)
        {
            try
            {
                DateTime date;
                date = DateTime.Parse(x);
                Console.WriteLine("Дата: "+date.ToString("dd MMM, h:mm tt",System.Globalization.CultureInfo.InvariantCulture));
            }
            catch
            {
                Console.WriteLine("Введите коректрую дату");
            }


        }
    }
}
