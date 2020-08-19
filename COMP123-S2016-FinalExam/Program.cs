using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{///-----------------------------------------------------------------
///   Files name:COMP123_M2020_FinalExam
///   Author's name:  chaeeun kim
///   Author's student number: 301060073
///   Changes Made: no  
///----------------------------------------------------------------
    public static class Program
    {   
        public static Character character = new Character();
        public static Splashform splashform;
        public static GenerateNameForm generateNameForm;
   
        


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

          // create splashfrom and generatenameform objects
            splashform = new Splashform();     
            generateNameForm = new GenerateNameForm();

         // the program starts with splashform
            Application.Run(splashform);

        }
    }
}
