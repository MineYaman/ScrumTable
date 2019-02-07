using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YazılımYapımıProje
{
    public partial class frmStorySil : Form
    {
        public static List<Story> s = new List<Story>();
        int i = 0;
        public frmStorySil()
        {
            InitializeComponent();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            i = STORY.s.StorySayisi;
            if (i == 1 || i==2 || i==3 )
            {
                StreamReader oku;
                oku = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story1.txt");

                string yazi;

                while ((yazi = oku.ReadLine()) != null) //satır boş olana kadar satır satır okumaya devam eder
                {
                    lstbxStory1.Visible = true;
                    lstbxStory1.Items.Add(yazi.ToString());
                    lstbxStory1.BackColor = Color.DeepPink;
                    lstbxStory1.ForeColor = Color.DarkBlue;
                    lstbxStory1.Visible = true;
                    btnStory1Sil.Visible = true;
                }

                oku.Close();
            }
            if (i == 2 || i == 3)
            {
                StreamReader okuStory2;
                okuStory2 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story2.txt");

                string yaz;

                while ((yaz = okuStory2.ReadLine()) != null) //satır boş olana kadar satır satır okumaya devam eder
                {
                    lstbxStory2.Visible = true;
                    lstbxStory2.Items.Add(yaz.ToString());
                    lstbxStory2.ForeColor = Color.DarkBlue;
                    lstbxStory2.BackColor = Color.MediumPurple;
                    lstbxStory2.Visible = true;
                    btnStory2Sil.Visible = true;

                }
                okuStory2.Close();
            }
            if(i==3)
            {
                StreamReader okuStory3;
                okuStory3 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story3.txt");

                string yaziStory3;

                while ((yaziStory3 = okuStory3.ReadLine()) != null) //satır boş olana kadar satır satır okumaya devam eder
                {
                   lstbxStory3.Visible = true;
                   lstbxStory3.Items.Add(yaziStory3.ToString());
                   lstbxStory3.BackColor = Color.Aqua;
                   lstbxStory3.ForeColor = Color.Black;
                    lstbxStory3.Visible = true;
                    btnStory3Sil.Visible = true;

                }
                okuStory3.Close();
            }
        }

        private void btnStory1Sil_Click(object sender, EventArgs e)
        {
            string DosyaDizini1 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story1.txt";
            string DosyaDizini2 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story1Task1.txt";
            string DosyaDizini3 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story1Task2.txt";
            string DosyaDizini4 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story1Task3.txt";
            File.Delete(DosyaDizini1);
            File.Delete(DosyaDizini2);
            File.Delete(DosyaDizini3);
            File.Delete(DosyaDizini4);
            MessageBox.Show("Story ve Tasklar silindi");
        }

        private void btnStory2Sil_Click(object sender, EventArgs e)
        {
            string DosyaDizini1 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story2.txt";
            string DosyaDizini2 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story2Task1.txt";
            string DosyaDizini3 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story2Task2.txt";
            string DosyaDizini4 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story2Task3.txt";
            File.Delete(DosyaDizini1);
            File.Delete(DosyaDizini2);
            File.Delete(DosyaDizini3);
            File.Delete(DosyaDizini4);
            MessageBox.Show("Story ve Tasklar silindi");
        }

        private void btnStory3Sil_Click(object sender, EventArgs e)
        {
            string DosyaDizini1 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story3.txt";
            string DosyaDizini2 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story3Task1.txt";
            string DosyaDizini3 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story3Task2.txt";
            string DosyaDizini4 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story3Task3.txt";
            File.Delete(DosyaDizini1);
            File.Delete(DosyaDizini2);
            File.Delete(DosyaDizini3);
            File.Delete(DosyaDizini4);
            MessageBox.Show("Story ve Tasklar silindi");
        }
    }
}