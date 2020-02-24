using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_forms
{
    static class Program
    {
        //Разработать программное обеспечение для мониторинга критических системных значений, 
        //в частности – +загрузки и 
        //температура процессора, 
        //температура системной платы, 
        //напряжения питания, 
        //*загрузка памяти. 
        //При длительном превышении 
        //выбранными параметрами порогового значения – выводить сообщение. 
        //Пороговые значения для каждого параметра задаются в абсолютном или процентном значении.
        //Изменения параметров заносятся в лог, который в дальнейшем можно просмотреть в удобной форме.

             [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
