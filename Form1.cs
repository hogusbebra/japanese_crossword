using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace japanese_hogus
{
    public partial class table : Form
    {
        public table()
        {
            InitializeComponent();
        }
        int pobeda = 0;
        int but3 = 0;
        int but8 = 0;
        int but9 = 0;
        int but11 = 0;
        int but13 = 0;
        int but14 = 0;
        int but16 = 0;
        int but17 = 0;
        int but18 = 0;
        int but21 = 0;
        int but23 = 0;
        int but25 = 0;
        int sum = 12;
        private void che() {
            if (sum == but3+but8+but9+but11+but13+but14+but16+but17+but18+but21+but23+but25+pobeda)
            {
                MessageBox.Show("Ура! Победа!");
        
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.ForeColor != Color.Black)
            {
                button1.ForeColor = Color.Black;
                button1.BackColor = Color.Black;
                pobeda -= 1;
                che();
            }
            else
            {
                button1.ForeColor = Color.White;
                button1.BackColor = Color.White;
                pobeda += 1;
                che();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.ForeColor != Color.Black)
            {
                button2.ForeColor = Color.Black;
                button2.BackColor = Color.Black;
                pobeda -= 1;
                che();
            }
            else
            {
                button2.ForeColor = Color.White;
                button2.BackColor = Color.White;
                pobeda += 1;
                che();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.ForeColor != Color.Black)
            {
                button3.ForeColor = Color.Black;
                button3.BackColor = Color.Black;
                but3 = 1;
                che();
            }
            else
            {
                button3.ForeColor = Color.White;
                button3.BackColor = Color.White;
                but3 = 0;
                che();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.ForeColor != Color.Black)
            {
                button4.ForeColor = Color.Black;
                button4.BackColor = Color.Black;
                pobeda -= 1;
                che();
            }
            else
            {
                button4.ForeColor = Color.White;
                button4.BackColor = Color.White;
                pobeda += 1;
                che();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.ForeColor != Color.Black)
            {
                button5.ForeColor = Color.Black;
                button5.BackColor = Color.Black;
                pobeda -= 1;
                che();
            }
            else
            {
                button5.ForeColor = Color.White;
                button5.BackColor = Color.White;
                pobeda += 1;
                che();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.ForeColor != Color.Black)
            {
                button6.ForeColor = Color.Black;
                button6.BackColor = Color.Black;
                pobeda -= 1;
                che();
            }
            else
            {
                button6.ForeColor = Color.White;
                button6.BackColor = Color.White;
                pobeda += 1;
                che();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.ForeColor != Color.Black)
            {
                button7.ForeColor = Color.Black;
                button7.BackColor = Color.Black;
                pobeda -= 1;
                che();
            }
            else
            {
                button7.ForeColor = Color.White;
                button7.BackColor = Color.White;
                pobeda += 1;
                che();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.ForeColor != Color.Black)
            {
                button8.ForeColor = Color.Black;
                button8.BackColor = Color.Black;
                but8 = 1;
                che();
            }
            else
            {
                button8.ForeColor = Color.White;
                button8.BackColor = Color.White;
                but8 = 0;
                che();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.ForeColor != Color.Black)
            {
                button9.ForeColor = Color.Black;
                button9.BackColor = Color.Black;
                but9 = 1;
                che();
            }
            else
            {
                button9.ForeColor = Color.White;
                button9.BackColor = Color.White;
                but9 = 0;
                che();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.ForeColor != Color.Black)
            {
                button10.ForeColor = Color.Black;
                button10.BackColor = Color.Black;
                pobeda -= 1;
                che();
            }
            else
            {
                button10.ForeColor = Color.White;
                button10.BackColor = Color.White;
                pobeda += 1;
                che();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.ForeColor != Color.Black)
            {
                button11.ForeColor = Color.Black;
                button11.BackColor = Color.Black;
                but11 = 1;
                che();
            }
            else
            {
                button11.ForeColor = Color.White;
                button11.BackColor = Color.White;
                but11 = 0;
                che();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.ForeColor != Color.Black)
            {
                button12.ForeColor = Color.Black;
                button12.BackColor = Color.Black;
                pobeda -= 1;
                che();
            }
            else
            {
                button12.ForeColor = Color.White;
                button12.BackColor = Color.White;
                pobeda += 1;
                che();
            }
        }


        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.ForeColor != Color.Black)
            {
                button13.ForeColor = Color.Black;
                button13.BackColor = Color.Black;
                but13 = 1;
                che();
            }
            else
            {
                button13.ForeColor = Color.White;
                button13.BackColor = Color.White;
                but13 = 0;
                che();
            }
        }


        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.ForeColor != Color.Black)
            {
                button14.ForeColor = Color.Black;
                button14.BackColor = Color.Black;
                but14 = 1;
                che();
            }
            else
            {
                button14.ForeColor = Color.White;
                button14.BackColor = Color.White;
                but14 = 0;
                che();
            }
        }


        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.ForeColor != Color.Black)
            {
                button15.ForeColor = Color.Black;
                button15.BackColor = Color.Black;
                pobeda -= 1;
                che();
            }
            else
            {
                button15.ForeColor = Color.White;
                button15.BackColor = Color.White;
                pobeda += 1;
                che();
            }
        }

 

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.ForeColor != Color.Black)
            {
                button16.ForeColor = Color.Black;
                button16.BackColor = Color.Black;
                but16 = 1;
                che();
            }
            else
            {
                button16.ForeColor = Color.White;
                button16.BackColor = Color.White;
                but16 = 0;
                che();
            }
        }



        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.ForeColor != Color.Black)
            {
                button17.ForeColor = Color.Black;
                button17.BackColor = Color.Black;
                but17 = 1;
                che();
            }
            else
            {
                button17.ForeColor = Color.White;
                button17.BackColor = Color.White;
                but17 = 0;
                che();
            }
        }


        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.ForeColor != Color.Black)
            {
                button18.ForeColor = Color.Black;
                button18.BackColor = Color.Black;
                but18 = 1;
                che();
            }
            else
            {
                button18.ForeColor = Color.White;
                button18.BackColor = Color.White;
                but18 = 0;
                che();
            }
        }



        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.ForeColor != Color.Black)
            {
                button19.ForeColor = Color.Black;
                button19.BackColor = Color.Black;
                pobeda -= 1;
                che();
            }
            else
            {
                button19.ForeColor = Color.White;
                button19.BackColor = Color.White;
                pobeda += 1;
                che();
            }
        }



        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.ForeColor != Color.Black)
            {
                button20.ForeColor = Color.Black;
                button20.BackColor = Color.Black;
                pobeda -= 1;
                che();
            }
            else
            {
                button20.ForeColor = Color.White;
                button20.BackColor = Color.White;
                pobeda += 1;
                che();
            }
        }



        private void button21_Click(object sender, EventArgs e)
        {
            if (button21.ForeColor != Color.Black)
            {
                button21.ForeColor = Color.Black;
                button21.BackColor = Color.Black;
                but21 = 1;
                che();
            }
            else
            {
                button21.ForeColor = Color.White;
                button21.BackColor = Color.White;
                but21 = 0;
                che();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button22.ForeColor != Color.Black)
            {
                button22.ForeColor = Color.Black;
                button22.BackColor = Color.Black;
                pobeda -= 1;
                che();
            }
            else
            {
                button22.ForeColor = Color.White;
                button22.BackColor = Color.White;
                pobeda += 1;
                che();
            }
        }



        private void button23_Click(object sender, EventArgs e)
        {
            if (button23.ForeColor != Color.Black)
            {
                button23.ForeColor = Color.Black;
                button23.BackColor = Color.Black;
                but23 = 1;
                che();
            }
            else
            {
                button23.ForeColor = Color.White;
                button23.BackColor = Color.White;
                but23 = 0;
                che();
            }
        }



        private void button24_Click(object sender, EventArgs e)
        {
            if (button24.ForeColor != Color.Black)
            {
                button24.ForeColor = Color.Black;
                button24.BackColor = Color.Black;
                pobeda -= 1;
                che();
            }
            else
            {
                button24.ForeColor = Color.White;
                button24.BackColor = Color.White;
                pobeda += 1;
                che();
            }
        }



        private void button25_Click(object sender, EventArgs e)
        {
            if (button25.ForeColor != Color.Black)
            {
                button25.ForeColor = Color.Black;
                button25.BackColor = Color.Black;
                but25 = 1;
                che();
            }
            else
            {
                button25.ForeColor = Color.White;
                button25.BackColor = Color.White;
                but25 = 0;
                che();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
