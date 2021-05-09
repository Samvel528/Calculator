using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    static class Program
    {
        private static ICalculator calculator = new Calculator();

        private static readonly Frm_Calculator _frm_Calculator = new Frm_Calculator(calculator);

        public static Frm_Calculator Frm_Calculator
        {
            get
            {
                return _frm_Calculator;
            }
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Frm_Calculator);
        }
    }
}
