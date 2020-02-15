using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat
{
    class Form1Controller
    {

        public static String getTextBoxTextByInput(String aktualisTextBoxText, String inputChar)
        {

            String outputString = aktualisTextBoxText;

            if (outputString == "0")
            {
                outputString = "";
            }

            if (inputChar == ".")
            {

                if (outputString.Contains("."))
                {
                    return outputString;
                }
                else if (outputString.Length == 0)
                {
                    inputChar = "0" + inputChar;
                }
            }

            return outputString + inputChar;
        }
    }
}
