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
    public partial class frmScrumTable : Form
    {
       
        public static List<Story> s = new List<Story>();
        public static List<Tasklar> t = new List<Tasklar>();
        int i = 0;
        int j = 0;
        public frmScrumTable()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            i = STORY.s.StorySayisi;
            j = frmTaskEkle.t.TaskSayisi;
                 
            if(i==1)
            {
                StreamReader oku;
                oku = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story1.txt");

                string yazi;

                while ((yazi = oku.ReadLine()) != null) //satır boş olana kadar satır satır okumaya devam eder
                {
                    lstbxscrumStory1.Visible = true;
                    lstbxscrumStory1.Items.Add(yazi.ToString());
                    lstbxscrumStory1.BackColor = Color.DeepPink;
                    lstbxscrumStory1.ForeColor = Color.DarkBlue;
                }

                oku.Close();
                if(j==1)
                {
                    StreamReader oku1;
                    oku1= File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story1Task1.txt");

                    string yazi1;

                    while ((yazi1 = oku1.ReadLine()) != null) //satır boş olana kadar satır satır okumaya devam eder
                    {
                        lstbxStory1Task1.Visible = true;
                        lstbxStory1Task1.Items.Add(yazi1.ToString());
                        lstbxStory1Task1.BackColor = Color.DeepPink;
                        lstbxStory1Task1.ForeColor = Color.DarkBlue;
                    }

                    oku1.Close();
                }
                else if(j==2)
                {
                    StreamReader oku1;
                    StreamReader oku2;
                    oku1 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story1Task1.txt");
                    oku2 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story1Task2.txt");

                    string yazi1;
                    string yazi2;
                    
                    while ((yazi1 = oku1.ReadLine()) != null) //satır boş olana kadar satır satır okumaya devam eder
                    {
                        lstbxStory1Task1.Visible = true;
                        lstbxStory1Task1.Items.Add(yazi1.ToString());
                        lstbxStory1Task1.BackColor = Color.DeepPink;
                        lstbxStory1Task1.ForeColor = Color.DarkBlue;
                    }
                    oku1.Close();
                    while ((yazi2 = oku2.ReadLine()) != null) //satır boş olana kadar satır satır okumaya devam eder
                    {
                        lstbxStory1Task2.Visible = true;
                        lstbxStory1Task2.Items.Add(yazi2.ToString());
                        lstbxStory1Task2.BackColor = Color.DeepPink;
                        lstbxStory1Task2.ForeColor = Color.DarkBlue;
                    }
                    
                    oku2.Close();
                }
                else if(j==3)
                {
                    StreamReader oku1;
                    StreamReader oku2;
                    StreamReader oku3;
                    oku1 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story1Task1.txt");
                    oku2 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story1Task2.txt");
                    oku3 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story1Task3.txt");
                    string yazi1;
                    string yazi2;
                    string yazi3;
                    
                    while ((yazi1 = oku1.ReadLine()) != null) //satır boş olana kadar satır satır okumaya devam eder
                    {
                        lstbxStory1Task1.Visible = true;
                        lstbxStory1Task1.Items.Add(yazi1.ToString());
                        lstbxStory1Task1.BackColor = Color.DeepPink;
                        lstbxStory1Task1.ForeColor = Color.DarkBlue;
                    }
                    oku1.Close();
                    while ((yazi2 = oku2.ReadLine()) != null) //satır boş olana kadar satır satır okumaya devam eder
                    {
                        lstbxStory1Task2.Visible = true;
                        lstbxStory1Task2.Items.Add(yazi2.ToString());
                        lstbxStory1Task2.BackColor = Color.DeepPink;
                        lstbxStory1Task2.ForeColor = Color.DarkBlue;
                    }
                    oku2.Close();
                    while ((yazi3 = oku3.ReadLine()) != null) //satır boş olana kadar satır satır okumaya devam eder
                    {
                        lstbxStory1Task3.Visible = true;
                        lstbxStory1Task3.Items.Add(yazi3.ToString());
                        lstbxStory1Task3.BackColor = Color.DeepPink;
                        lstbxStory1Task3.ForeColor = Color.DarkBlue;
                    }
                    oku3.Close();
                }
            }
           
           else if(i==2)
            {
                StreamReader okuStory1;
                okuStory1 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story1.txt");

                string yazi;

                while ((yazi = okuStory1.ReadLine()) != null) //satır boş olana kadar satır satır okumaya devam eder
                {
                    lstbxscrumStory1.Visible = true;
                    lstbxscrumStory1.Items.Add(yazi.ToString());
                    lstbxscrumStory1.BackColor = Color.DeepPink;
                    lstbxscrumStory1.ForeColor = Color.DarkBlue;
                }
                okuStory1.Close();
                StreamReader okuStory2;
                okuStory2= File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story2.txt");

                string yaz;

                while ((yaz = okuStory2.ReadLine()) != null) //satır boş olana kadar satır satır okumaya devam eder
                {
                    lstbxscrumStory2.Visible = true;
                    lstbxscrumStory2.Items.Add(yaz.ToString());
                    lstbxscrumStory2.ForeColor = Color.DarkBlue;
                    lstbxscrumStory2.BackColor = Color.MediumPurple;

                }
                okuStory2.Close();
                string DosyaDizini1 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story1Task1.txt";
                string DosyaDizini2 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story1Task2.txt";
                string DosyaDizini3 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story1Task3.txt";
              
                if ((File.Exists(DosyaDizini1) == true))
                 {
                    StreamReader oku1;
                    string yazi1;
                    oku1 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story1Task1.txt");
                    while ((yazi1 = oku1.ReadLine()) != null)
                    {
                        lstbxStory1Task1.Visible = true;
                        lstbxStory1Task1.Items.Add(yazi1.ToString());
                        lstbxStory1Task1.BackColor = Color.DeepPink;
                        lstbxStory1Task1.ForeColor = Color.DarkBlue;
                    }
                    oku1.Close();
                }
                if((File.Exists(DosyaDizini2) == true))
                {
                    StreamReader oku2;
                    string yazi2;
                    oku2 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story1Task2.txt");
                    while ((yazi2 = oku2.ReadLine()) != null)
                    {
                        lstbxStory1Task2.Visible = true;
                        lstbxStory1Task2.Items.Add(yazi2.ToString());
                        lstbxStory1Task2.BackColor = Color.DeepPink;
                        lstbxStory1Task2.ForeColor = Color.DarkBlue;

                    }
                    oku2.Close();
                }
                if((File.Exists(DosyaDizini3) == true))
                { 
                      StreamReader  oku3;
                      string   yazi3;
                    oku3 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story1Task3.txt");

                    while ((yazi3 = oku3.ReadLine()) != null)
                    {
                        lstbxStory1Task3.Visible = true;
                        lstbxStory1Task3.Items.Add(yazi3.ToString());
                        lstbxStory1Task3.BackColor = Color.DeepPink;
                        lstbxStory1Task3.ForeColor = Color.DarkBlue;
                    }
                    oku3.Close();
                 } 
                
               
                if(j==1)
                {

                    StreamReader okuStory2Task1;
                    okuStory2Task1 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story2Task1.txt");
                    string yaziTask1;
                    while ((yaziTask1 = okuStory2Task1.ReadLine()) != null)
                    {
                        lstbxStory2Task1.Visible = true;
                        lstbxStory2Task1.Items.Add(yaziTask1.ToString());
                        lstbxStory2Task1.ForeColor = Color.DarkBlue;
                        lstbxStory2Task1.BackColor = Color.MediumPurple;
                    }
                    okuStory2Task1.Close();
                }
                else if(j==2)
                {

                    StreamReader okuStory2Task1,okuStory2Task2; 
                    okuStory2Task1 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story2Task1.txt");
                    okuStory2Task2 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story2Task2.txt");
                    string yaziTask1,yaziTask2;
                    while ((yaziTask1 = okuStory2Task1.ReadLine()) != null)
                    {
                        lstbxStory2Task1.Visible = true;
                        lstbxStory2Task1.Items.Add(yaziTask1.ToString());
                        lstbxStory2Task1.ForeColor = Color.DarkBlue;
                        lstbxStory2Task1.BackColor = Color.MediumPurple;
                    }

                    while ((yaziTask2 = okuStory2Task2.ReadLine()) != null)
                    {
                        lstbxStory2Task2.Visible = true;
                        lstbxStory2Task2.Items.Add(yaziTask2.ToString());
                        lstbxStory2Task2.ForeColor = Color.DarkBlue;
                        lstbxStory2Task2.BackColor = Color.MediumPurple;
                    }
                    okuStory2Task1.Close();
                    okuStory2Task2.Close();
                 }
                else if(j==3)
                {
                    StreamReader okuStory2Task1, okuStory2Task2, okuStory2Task3; 
                    okuStory2Task1 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story2Task1.txt");
                    okuStory2Task2 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story2Task2.txt");
                    okuStory2Task3 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story2Task3.txt");
                    string yaziTask1, yaziTask2,yaziTask3;
                    while ((yaziTask1 = okuStory2Task1.ReadLine()) != null)
                    {
                        lstbxStory2Task1.Visible = true;
                        lstbxStory2Task1.Items.Add(yaziTask1.ToString());
                        lstbxStory2Task1.ForeColor = Color.DarkBlue;
                        lstbxStory2Task1.BackColor = Color.MediumPurple;
                    }

                    while ((yaziTask2 = okuStory2Task2.ReadLine()) != null)
                    {
                        lstbxStory2Task2.Visible = true;
                        lstbxStory2Task2.Items.Add(yaziTask2.ToString());
                        lstbxStory2Task2.ForeColor = Color.DarkBlue;
                        lstbxStory2Task2.BackColor = Color.MediumPurple;
                    }
                    while ((yaziTask3 = okuStory2Task3.ReadLine()) != null)
                    {
                        lstbxStory2Task3.Visible = true;
                        lstbxStory2Task3.Items.Add(yaziTask3.ToString());
                        lstbxStory2Task3.ForeColor = Color.DarkBlue;
                        lstbxStory2Task3.BackColor = Color.MediumPurple;
                    }
                    okuStory2Task1.Close();
                    okuStory2Task2.Close();
                    okuStory2Task3.Close();

                }
            }
            else if(i==3)
            {
               
                StreamReader okuStory1;
                okuStory1 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story1.txt");

                string yazi;

                while ((yazi = okuStory1.ReadLine()) != null) //satır boş olana kadar satır satır okumaya devam eder
                {
                    lstbxscrumStory1.Visible = true;
                    lstbxscrumStory1.Items.Add(yazi.ToString());
                    lstbxscrumStory1.BackColor = Color.DeepPink;
                    lstbxscrumStory1.ForeColor = Color.DarkBlue;

                }
                StreamReader okuStory2;
                okuStory2 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story2.txt");

                string yaz;

                while ((yaz = okuStory2.ReadLine()) != null) //satır boş olana kadar satır satır okumaya devam eder
                {
                    lstbxscrumStory2.Visible = true;
                    lstbxscrumStory2.Items.Add(yaz.ToString());
                    lstbxscrumStory2.ForeColor = Color.DarkBlue;
                    lstbxscrumStory2.BackColor = Color.MediumPurple;

                }
                StreamReader okuStory3;
                okuStory3 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story3.txt");

                string yaziStory3;

                while ((yaziStory3 = okuStory3.ReadLine()) != null) //satır boş olana kadar satır satır okumaya devam eder
                {
                    lstbxscrumStory3.Visible = true;
                    lstbxscrumStory3.Items.Add(yaziStory3.ToString());
                    lstbxscrumStory3.BackColor = Color.Aqua;
                    lstbxscrumStory3.ForeColor = Color.Black;

                }
                string DosyaDizini1 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story1Task1.txt";
                string DosyaDizini2 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story1Task2.txt";
                string DosyaDizini3 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story1Task3.txt";
                string DosyaDizini4 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story2Task1.txt";
                string DosyaDizini5 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story2Task2.txt";
                string DosyaDizini6 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story2Task3.txt";

                if ((File.Exists(DosyaDizini1) == true))
                {
                    StreamReader oku1;
                    string yazi1;
                    oku1 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story1Task1.txt");
                    while ((yazi1 = oku1.ReadLine()) != null)
                    {
                        lstbxStory1Task1.Visible = true;
                        lstbxStory1Task1.Items.Add(yazi1.ToString());
                        lstbxStory1Task1.BackColor = Color.DeepPink;
                        lstbxStory1Task1.ForeColor = Color.DarkBlue;
                    }
                    oku1.Close();
                }
                if ((File.Exists(DosyaDizini2) == true))
                {
                    StreamReader oku2;
                    string yazi2;
                    oku2 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story1Task2.txt");
                    while ((yazi2 = oku2.ReadLine()) != null)
                    {
                        lstbxStory1Task2.Visible = true;
                        lstbxStory1Task2.Items.Add(yazi2.ToString());
                        lstbxStory1Task2.BackColor = Color.DeepPink;
                        lstbxStory1Task2.ForeColor = Color.DarkBlue;

                    }
                    oku2.Close();
                }
                if ((File.Exists(DosyaDizini3) == true))
                {
                    StreamReader oku3;
                    string yazi3;
                    oku3 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story1Task3.txt");

                    while ((yazi3 = oku3.ReadLine()) != null)
                    {
                        lstbxStory1Task3.Visible = true;
                        lstbxStory1Task3.Items.Add(yazi3.ToString());
                        lstbxStory1Task3.BackColor = Color.DeepPink;
                        lstbxStory1Task3.ForeColor = Color.DarkBlue;
                    }
                    oku3.Close();
                }
                if((File.Exists(DosyaDizini4) == true))
                 {
                    StreamReader okuStory2Task1;
                    string yaziTask1;
                    okuStory2Task1 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story2Task1.txt");
                    while ((yaziTask1 = okuStory2Task1.ReadLine()) != null)
                    {
                        lstbxStory2Task1.Visible = true;
                        lstbxStory2Task1.Items.Add(yaziTask1.ToString());
                        lstbxStory2Task1.ForeColor = Color.DarkBlue;
                        lstbxStory2Task1.BackColor = Color.MediumPurple;
                    }
                    okuStory2Task1.Close();

                }
                if ((File.Exists(DosyaDizini5) == true))
                {
                    StreamReader okuStory2Task2;
                    string yaziTask2;
                    okuStory2Task2 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story2Task2.txt");
                    while ((yaziTask2 = okuStory2Task2.ReadLine()) != null)
                    {
                        lstbxStory2Task2.Visible = true;
                        lstbxStory2Task2.Items.Add(yaziTask2.ToString());
                        lstbxStory2Task2.ForeColor = Color.DarkBlue;
                        lstbxStory2Task2.BackColor = Color.MediumPurple;
                    }
                    okuStory2Task2.Close();

                }
                if ((File.Exists(DosyaDizini6) == true))
                {
                    StreamReader okuStory2Task3;
                    okuStory2Task3 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story2Task3.txt");
                    string yaziTask3;

                    while ((yaziTask3 = okuStory2Task3.ReadLine()) != null)
                    {
                        lstbxStory2Task3.Visible = true;
                        lstbxStory2Task3.Items.Add(yaziTask3.ToString());
                        lstbxStory2Task3.ForeColor = Color.DarkBlue;
                        lstbxStory2Task3.BackColor = Color.MediumPurple;
                    }
                    okuStory2Task3.Close();
                }
                okuStory1.Close();
                okuStory2.Close();
                okuStory3.Close();
                if(j==1)
                {
                    StreamReader okuStory3Task1;
                    okuStory3Task1 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story3Task1.txt");
                    string yaziStory3Task1;
                    while ((yaziStory3Task1 = okuStory3Task1.ReadLine()) != null)
                    {
                        lstbxStory3Task1.Visible = true;
                        lstbxStory3Task1.Items.Add(yaziStory3Task1.ToString());
                        lstbxStory3Task1.BackColor = Color.Aqua;
                        lstbxStory3Task1.ForeColor = Color.Black;
                    }

                    okuStory3Task1.Close();
                }
                else if(j==2)
                {
                    StreamReader okuStory3Task1, okuStory3Task2;
                    okuStory3Task1 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story3Task1.txt");
                    okuStory3Task2 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story3Task2.txt");
                    string yaziStory3Task1, yaziStory3Task2;
                    while ((yaziStory3Task1 = okuStory3Task1.ReadLine()) != null)
                    {
                        lstbxStory3Task1.Visible = true;
                        lstbxStory3Task1.Items.Add(yaziStory3Task1.ToString());
                        lstbxStory3Task1.BackColor = Color.Aqua;
                        lstbxStory3Task1.ForeColor = Color.Black;
                    }
                    while ((yaziStory3Task2 = okuStory3Task2.ReadLine()) != null)
                    {
                        lstbxStory3Task2.Visible = true;
                        lstbxStory3Task2.Items.Add(yaziStory3Task2.ToString());
                        lstbxStory3Task2.BackColor = Color.Aqua;
                        lstbxStory3Task2.ForeColor = Color.Black;
                    }
                   
                    okuStory3Task1.Close();
                    okuStory3Task2.Close();
                }
                else if(j==3)
                {
                    StreamReader okuStory3Task1, okuStory3Task2, okuStory3Task3;
                    okuStory3Task1 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story3Task1.txt");
                    okuStory3Task2 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story3Task2.txt");
                    okuStory3Task3 = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\\Story3Task3.txt");
                    string yaziStory3Task1, yaziStory3Task2, yaziStory3Task3;
                    while ((yaziStory3Task1 = okuStory3Task1.ReadLine()) != null)
                    {
                        lstbxStory3Task1.Visible = true;
                        lstbxStory3Task1.Items.Add(yaziStory3Task1.ToString());
                        lstbxStory3Task1.BackColor = Color.Aqua;
                        lstbxStory3Task1.ForeColor = Color.Black;
                    }
                    while ((yaziStory3Task2 = okuStory3Task2.ReadLine()) != null)
                    {
                        lstbxStory3Task2.Visible = true;
                        lstbxStory3Task2.Items.Add(yaziStory3Task2.ToString());
                        lstbxStory3Task2.BackColor = Color.Aqua;
                        lstbxStory3Task2.ForeColor = Color.Black;
                    }
                    while ((yaziStory3Task3 = okuStory3Task3.ReadLine()) != null)
                    {
                        lstbxStory3Task3.Visible = true;
                        lstbxStory3Task3.Items.Add(yaziStory3Task3.ToString());
                        lstbxStory3Task3.BackColor = Color.Aqua;
                        lstbxStory3Task3.ForeColor = Color.Black;
                    }

                    okuStory3Task1.Close();
                    okuStory3Task2.Close();
                    okuStory3Task3.Close();
                }


            }

            else
            {
                MessageBox.Show("Story bulunamadı.");
            }
           
        }

        private void frmScrumTable_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(lstbxStory1Task1,true);
            ControlExtension.Draggable(lstbxStory1Task2, true);
            ControlExtension.Draggable(lstbxStory1Task3, true);
            ControlExtension.Draggable(lstbxStory2Task1, true);
            ControlExtension.Draggable(lstbxStory2Task2, true);
            ControlExtension.Draggable(lstbxStory2Task2, true);
            ControlExtension.Draggable(lstbxStory2Task3, true);
            ControlExtension.Draggable(lstbxStory3Task1, true);
            ControlExtension.Draggable(lstbxStory3Task2, true);
            ControlExtension.Draggable(lstbxStory3Task3, true);

        }
    }
}
