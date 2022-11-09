using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrvosiNobeldijasokGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_beiras_Click(object sender, EventArgs e)
        {
            
            int evellenorzes = 0;
            if (textBox1_ev.Text == "" || textBox2_nev.Text == "" || textBox3_szh.Text == "" || textBox4_orszag.Text == "")
            {
                MessageBox.Show(Environment.NewLine + "Töltsön ki minden mezőt!");
                return;
            }
            else 
            {
                evellenorzes = Convert.ToInt32(textBox1_ev.Text);
                if (!(evellenorzes > 1989))
                {
                    MessageBox.Show("Hiba! Az évszám nem megfelelő!");
                }
                else 
                {
                    try
                    {
                        if (!File.Exists("uj_dijazott.txt"))
                        {
                            File.WriteAllText("uj_dijazott.txt", "Év;Név;SzületésHalálozás;Országkód\n");
                            File.AppendAllText("uj_dijazott.txt", $"{textBox1_ev.Text};{textBox2_nev.Text};{textBox3_szh.Text};{textBox4_orszag.Text}\n");

                        }
                        else
                        {
                            File.AppendAllText("uj_dijazott.txt", $"{textBox1_ev.Text};{textBox2_nev.Text};{textBox3_szh.Text};{textBox4_orszag.Text}\n");
                        }

                    } 
                    catch(Exception x)
                    {
                        MessageBox.Show(Convert.ToString(x));
                    }
                    textBox1_ev.Clear();
                    textBox2_nev.Clear();
                    textBox3_szh.Clear();
                    textBox4_orszag.Clear();
                }
            }
                
        }
    }
}
