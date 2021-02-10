using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТРПО_конвертер
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //кнопка конвертировать
        private void button20_Click(object sender, EventArgs e)
        {

        }

    }

    public class Converter_10_p
    {
        //Преобразовать целое в символ.
        public static char int_to_сhar(int n) 
        {
            return '1';
        }

        //Преобразовать десятичное целое в с.сч. с основанием р.
        public static string int_to_P(int n, int p) 
        {
            return "1";
        }
        //Преобразовать десятичную дробь в с.сч. с основанием р.
        public static string float_to_P(double n, int p, int c) 
        {
            return "1";
        }

        //Преобразовать десятичное 
        //действительное число в с.сч. с осн. р.
        public static string Do(double n, int p, int c)
        {
            return "1";
        }

    }
}
