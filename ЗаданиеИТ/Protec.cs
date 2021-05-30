using System;
using System.Collections.Generic;
using System.Text;

namespace ЗаданиеИТ
{

    class Protec
    {
        protected string MyProtec = "(MyProtec)";
    }
         class ProtNasled : Protec
    {
       public void TestProtec()
            {
            Protec prot = new Protec();
            //prot.MyProtec = "изменено";//Ошибка 
            Console.WriteLine("Вызов через экземпляр класса недоступен");
            ProtNasled prn = new ProtNasled();
            prn.MyProtec = "Изменено";
            Console.WriteLine(prn.MyProtec);
            MyProtec = "Снова изменено";
            Console.WriteLine(MyProtec);
        }
       
    }

  }

