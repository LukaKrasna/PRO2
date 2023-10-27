using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deljenje_z_nič
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Naloga: https://ucilnice.scng.si/pluginfile.php/4653/mod_resource/content/1/vaje2/vaja21.pdf
        }

        private void btnDeli_Click(object sender, EventArgs e)
        {
            try
            {
                    if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
                    {
                        if (num2 == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        else
                        {
                            double result = num1 / num2;
                            labRezultat.Text = result.ToString();
                        }
                    }
                    else
                    {
                        throw new FormatException();
                    }
                
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Attempted to devide by zero.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Vnešeni morata biti dve celi števili.");
            }

        }
    }
}
