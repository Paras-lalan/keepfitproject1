using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keepfit2._1._2
{
    public class datapath
    {
        public string mainpath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\keepfit2.1.2\keepfit2.1.2\maindb.mdf;Integrated Security=True";
        public string loginpath = @"";
        public string time = System.DateTime.Now.Date.ToString();
    }

    public class Get_Numrestrict
    {
        public static bool numcheck(char chr)
        {
            bool blnRetVal = false;
            try
            {
                if (!char.IsControl(chr) && !char.IsDigit(chr))
                {
                    blnRetVal = true;
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            return blnRetVal;
        }

        public static bool decimalControl(char chrInput, ref TextBox txtBox, int intNoOfDec)
        {
            bool chrRetVal = false;
            try
            {
                string strSearch = string.Empty;

                if (chrInput == '\b')
                {
                    return false;
                }

                if (intNoOfDec == 0)
                {
                    strSearch = "0123456789";
                    int INDEX = (int)strSearch.IndexOf(chrInput.ToString());
                    if (strSearch.IndexOf(chrInput.ToString(), 0) == -1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    strSearch = "0123456789.";
                    if (strSearch.IndexOf(chrInput, 0) == -1)
                    {
                        return true;
                    }
                }

                if ((txtBox.Text.Length - txtBox.SelectionStart) > (intNoOfDec) && chrInput == '.')
                {
                    return true;
                }

                if (chrInput == '\b')
                {
                    chrRetVal = false;
                }
                else
                {
                    strSearch = txtBox.Text;
                    if (strSearch != string.Empty)
                    {
                        if (strSearch.IndexOf('.', 0) > -1 && chrInput == '.')
                        {
                            return true;
                        }
                    }
                    int intPos;
                    int intAftDec;

                    strSearch = txtBox.Text;
                    if (strSearch == string.Empty) return false;
                    intPos = (strSearch.IndexOf('.', 0));

                    if (intPos == -1)
                    {
                        strSearch = "0123456789.";
                        if (strSearch.IndexOf(chrInput, 0) == -1)
                        {
                            chrRetVal = true;
                        }
                        else
                            chrRetVal = false;
                    }
                    else
                    {
                        if (txtBox.SelectionStart > intPos)
                        {
                            intAftDec = txtBox.Text.Length - txtBox.Text.IndexOf('.', 0);
                            if (intAftDec > intNoOfDec)
                            {
                                chrRetVal = true;
                            }
                            else
                                chrRetVal = false;
                        }
                        else
                            chrRetVal = false;
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            return chrRetVal;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
    }
}
