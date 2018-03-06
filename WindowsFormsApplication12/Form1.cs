using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        char[] c = new char[26];
        char[] p = new char[26];
        int os = 0;
        string pss;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string ps = textBox2.Text;
            int l;
            for(int y = 0; y < s.Length; y++)
            {
                for (int i = 0; i < ps.Length; i++)
                {
                    if(ps[i] != ' ')
                    {
                        pss += ps[i];
                        os = i;
                    }
                    else if (ps[i] == ' ')
                    {
                        os = 1 + i;
                        break;
                    }
                }
                l = Convert.ToInt32(pss);
                pss = "";
                for (int i = 0; i < 26; i++)
                {
                    if (s[y] == p[i])
                    {
                        textBox3.Text += p[(l + i) % 26];
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p[0] = 'a'; p[1] = 'b'; p[2] = 'c'; p[3] = 'd';
            p[4] = 'e'; p[5] = 'f'; p[6] = 'g'; p[7] = 'h';
            p[8] = 'i'; p[9] = 'j'; p[10] = 'k'; p[11] = 'l';
            p[12] = 'm'; p[13] = 'n'; p[14] = 'o'; p[15] = 'p';
            p[16] = 'q'; p[17] = 'r'; p[18] = 's'; p[19] = 't';
            p[20] = 'u'; p[21] = 'v'; p[22] = 'w'; p[23] = 'x';
            p[24] = 'y'; p[25] = 'z';
            //********************************************************************
            c[0] = 'a'; c[1] = 'b'; c[2] = 'c'; c[3] = 'd';
            p[4] = 'e'; p[5] = 'f'; p[6] = 'g'; p[7] = 'h';
            p[8] = 'i'; p[9] = 'j'; p[10] = 'k'; p[11] = 'l';
            p[12] = 'm'; p[13] = 'n'; p[14] = 'o'; p[15] = 'p';
            p[16] = 'q'; p[17] = 'r'; p[18] = 's'; p[19] = 't';
            p[20] = 'u'; p[21] = 'v'; p[22] = 'w'; p[23] = 'x';
            p[24] = 'y'; p[25] = 'z';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string ps = textBox2.Text;
            int l;
            for (int y = 0; y < s.Length; y++)
            {
                for (int i = 0; i < ps.Length; i++)
                {
                    if (ps[i] != ' ')
                    {
                        pss += ps[i];
                        os = i;
                    }
                    else if (ps[i] == ' ')
                    {
                        os = 1 + i;
                        break;
                    }
                }
                l = Convert.ToInt32(pss);
                pss = "";
                for (int i = 0; i < 26; i++)
                {
                    if (s[y] == c[i])
                    {
                        textBox3.Text += c[(l + i) % 26];
                    }
                }
            }
        }
    }
}
