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
    public partial class frmTaskEkle : Form
    {
        public static Tasklar t = new Tasklar();
        public static List<Story> s = new List<Story>();
        int i = 0;
        public frmTaskEkle()
        {
            InitializeComponent();
        }

        private void btnTaskOlusur_Click(object sender, EventArgs e)
        {

                t.TaskNo = Convert.ToInt32(txtTaskNo.Text);
                t.OncelikSirasi = Convert.ToInt32(txtOncelikSirasi.Text);
                t.TaskIcerigi = this.txtTaskIcerigi.Text;
                t.TaskOlustur(t);
                t.TaskSayisi= Convert.ToInt32(txtTaskSayisi.Text);

                t.TaskAuthor = STORY.s.StoryAuthor;
                listBoxCntrlTaskOlustur.Items.Add("   TASK1");
                listBoxCntrlTaskOlustur.Items.Add(" Task No:" + txtTaskNo.Text);
                listBoxCntrlTaskOlustur.Items.Add(" Öncelik Sirasi:" + txtOncelikSirasi.Text);
                listBoxCntrlTaskOlustur.Items.Add(" Task İçeriği:" + txtTaskIcerigi.Text);
                listBoxCntrlTaskOlustur.Items.Add("Task Sorumlusu:" + t.TaskAuthor);
                listBoxCntrlTaskOlustur.Items.Add("   TASK2");
                listBoxCntrlTaskOlustur.Items.Add(" Task No:" + txtTaskNo2.Text);
                listBoxCntrlTaskOlustur.Items.Add(" Öncelik Sirasi:" + txtOncelikSirasi2.Text);
                listBoxCntrlTaskOlustur.Items.Add(" Task İçeriği:" + txtTaskIcerigi2.Text);
                listBoxCntrlTaskOlustur.Items.Add("Task Sorumlusu:" + t.TaskAuthor);
                listBoxCntrlTaskOlustur.Items.Add("   TASK3");
                listBoxCntrlTaskOlustur.Items.Add(" Task No:" + txtTaskNo3.Text);
                listBoxCntrlTaskOlustur.Items.Add(" Öncelik Sirasi:" + txtOncelikSirasi3.Text);
                listBoxCntrlTaskOlustur.Items.Add(" Task İçeriği:" + txtTaskIcerigi3.Text);
                listBoxCntrlTaskOlustur.Items.Add("Task Sorumlusu:" + t.TaskAuthor);

                listBoxCntrlTaskOlustur.BackColor = Color.LightSeaGreen;
                listBoxCntrlTaskOlustur.BackColor = Color.MediumPurple;

                string DosyaDizini1 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story1.txt";
                string DosyaDizini2 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story2.txt";
                string DosyaDizini3 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Story3.txt";

            t.TaskDeadline = STORY.s.StoryDate;
            i = STORY.s.StorySayisi;

            if (File.Exists(DosyaDizini1) == true && i == 1)

            {

                if (t.TaskSayisi == 1)
                {
                    FileStream fs1 = new FileStream("Story1Task1.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Dosya1 = new StreamWriter(fs1);

                    try
                    {
                        Dosya1.WriteLine("TASK1");
                        Dosya1.WriteLine("Task No::" + txtTaskNo.Text);
                        Dosya1.WriteLine("Öncelik Sirasi:" + txtOncelikSirasi.Text);
                        Dosya1.WriteLine("Task İçeriği:" + txtTaskIcerigi.Text);
                        Dosya1.WriteLine("Task Sorumlusu:" + t.TaskAuthor);
                        Dosya1.WriteLine("Deadline:" + t.TaskDeadline);
                        Dosya1.Close();
                        fs1.Close();
                        MessageBox.Show("Kayıt başarılı");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("sanırım bir sorun var " + ex);
                    }
                }
                else if (t.TaskSayisi == 2)
                {
                    FileStream fs1 = new FileStream("Story1Task1.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Dosya1 = new StreamWriter(fs1);
                    FileStream fs2 = new FileStream("Story1Task2.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Dosya2 = new StreamWriter(fs2);

                    try
                    {
                        Dosya1.WriteLine("TASK1");
                        Dosya1.WriteLine("Task No:" + txtTaskNo.Text);
                        Dosya1.WriteLine("Öncelik Sirasi:" + txtOncelikSirasi.Text);
                        Dosya1.WriteLine("Task İçeriği:" + txtTaskIcerigi.Text);
                        Dosya1.WriteLine("Task Sorumlusu:" + t.TaskAuthor);
                        Dosya1.WriteLine("Deadline:" + t.TaskDeadline);
                        Dosya1.Close();
                        fs1.Close(); ;
                        Dosya2.WriteLine("TASK2");
                        Dosya2.WriteLine("Task No:" + txtTaskNo2.Text);
                        Dosya2.WriteLine("Öncelik Sirasi:" + txtOncelikSirasi2.Text);
                        Dosya2.WriteLine("Task İçeriği:" + txtTaskIcerigi2.Text);
                        Dosya2.WriteLine("Task Sorumlusu:" + t.TaskAuthor);
                        Dosya2.WriteLine("Deadline:" + t.TaskDeadline);

                        Dosya2.Close();
                        fs2.Close();
                        MessageBox.Show("Kayıt başarılı");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("sanırım bir sorun var " + ex);
                    }
                }
                else if (t.TaskSayisi == 3)
                {
                    FileStream fs1 = new FileStream("Story1Task1.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Dosya1 = new StreamWriter(fs1);
                    FileStream fs2 = new FileStream("Story1Task2.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Dosya2 = new StreamWriter(fs2);
                    FileStream fs3 = new FileStream("Story1Task3.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Dosya3 = new StreamWriter(fs3);

                    try
                    {
                        Dosya1.WriteLine("TASK1");
                        Dosya1.WriteLine("Task No::" + txtTaskNo.Text);
                        Dosya1.WriteLine("Öncelik Sirasi:" + txtOncelikSirasi.Text);
                        Dosya1.WriteLine("Task İçeriği:" + txtTaskIcerigi.Text);
                        Dosya1.WriteLine("Task Sorumlusu:" + t.TaskAuthor);
                        Dosya1.WriteLine("Deadline:" + t.TaskDeadline);
                        Dosya1.Close();
                        fs1.Close(); ;
                        Dosya2.WriteLine("TASK2");
                        Dosya2.WriteLine("Task No::" + txtTaskNo2.Text);
                        Dosya2.WriteLine("Öncelik Sirasi:" + txtOncelikSirasi2.Text);
                        Dosya2.WriteLine("Task İçeriği:" + txtTaskIcerigi2.Text);
                        Dosya2.WriteLine("Task Sorumlusu:" + t.TaskAuthor);
                        Dosya2.WriteLine("Deadline:" + t.TaskDeadline);
                        Dosya2.Close();
                        fs2.Close();
                        Dosya3.WriteLine("TASK3");
                        Dosya3.WriteLine("Task No:" + txtTaskNo3.Text);
                        Dosya3.WriteLine("Öncelik Sirasi:" + txtOncelikSirasi3.Text);
                        Dosya3.WriteLine("Task İçeriği:" + txtTaskIcerigi3.Text);
                        Dosya3.WriteLine("Task SOrumlusu:" + t.TaskAuthor);
                        Dosya3.WriteLine("Deadline:" + t.TaskDeadline);
                        Dosya3.Close();
                        fs3.Close();
                        MessageBox.Show("Kayıt başarılı");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("sanırım bir sorun var " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Tasklar kaydedilemedi!!");
                }
            }

            else if (File.Exists(DosyaDizini2) == true && i == 2)

            {
                if (t.TaskSayisi == 1)
                {
                    FileStream fs2 = new FileStream("Story2Task1.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Dosya2 = new StreamWriter(fs2);

                    try
                    {
                        Dosya2.WriteLine("TASK1");
                        Dosya2.WriteLine(" Task No::" + txtTaskNo.Text);
                        Dosya2.WriteLine("Öncelik Sirasi:" + txtOncelikSirasi.Text);
                        Dosya2.WriteLine(" Task İçeriği:" + txtTaskIcerigi.Text);
                        Dosya2.WriteLine("Task Sorumlusu:" + t.TaskAuthor);
                        Dosya2.WriteLine("Deadline:" + t.TaskDeadline);
                        Dosya2.Close();
                        fs2.Close();
                        MessageBox.Show("Kayıt başarılı");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("sanırım bir sorun var " + ex);
                    }
                }

                else if (t.TaskSayisi == 2)
                {

                    FileStream fs1 = new FileStream("Story2Task1.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Dosya1 = new StreamWriter(fs1);
                    FileStream fs2 = new FileStream("Story2Task2.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Dosya2 = new StreamWriter(fs2);

                    try
                    {
                        Dosya1.WriteLine("TASK1");
                        Dosya1.WriteLine(" Task No::" + txtTaskNo.Text);
                        Dosya1.WriteLine("Öncelik Sirasi:" + txtOncelikSirasi.Text);
                        Dosya1.WriteLine(" Task İçeriği:" + txtTaskIcerigi.Text);
                        Dosya1.WriteLine("Task Sorumlusu:" + t.TaskAuthor);
                        Dosya1.WriteLine("Deadline:" + t.TaskDeadline);
                        Dosya1.Close();
                        fs1.Close();
                        Dosya2.WriteLine("TASK2");
                        Dosya2.WriteLine(" Task No::" + txtTaskNo2.Text);
                        Dosya2.WriteLine("Öncelik Sirasi:" + txtOncelikSirasi2.Text);
                        Dosya2.WriteLine(" Task İçeriği:" + txtTaskIcerigi2.Text);
                        Dosya2.WriteLine("Task Sorumlusu:" + t.TaskAuthor);
                        Dosya2.WriteLine("Deadline:" + t.TaskDeadline);
                        Dosya2.Close();
                        fs2.Close();
                        MessageBox.Show("Kayıt başarılı");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("sanırım bir sorun var " + ex);
                    }
                }

                else if (t.TaskSayisi == 3)
                {

                    FileStream fs1 = new FileStream("Story2Task1.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Dosya1 = new StreamWriter(fs1);
                    FileStream fs2 = new FileStream("Story2Task2.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Dosya2 = new StreamWriter(fs2);
                    FileStream fs3 = new FileStream("Story2Task3.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Dosya3 = new StreamWriter(fs3);

                    try
                    {
                        Dosya1.WriteLine("TASK1");
                        Dosya1.WriteLine(" Task No::" + txtTaskNo.Text);
                        Dosya1.WriteLine("Öncelik Sirasi:" + txtOncelikSirasi.Text);
                        Dosya1.WriteLine(" Task İçeriği:" + txtTaskIcerigi.Text);
                        Dosya1.WriteLine("Task Sorumlusu:" + t.TaskAuthor);
                        Dosya1.WriteLine("Deadline:" + t.TaskDeadline);
                        Dosya1.Close();
                        fs1.Close();
                        Dosya2.WriteLine("TASK2");
                        Dosya2.WriteLine("Task No::" + txtTaskNo2.Text);
                        Dosya2.WriteLine("Öncelik Sirasi:" + txtOncelikSirasi2.Text);
                        Dosya2.WriteLine("Task İçeriği:" + txtTaskIcerigi2.Text);
                        Dosya2.WriteLine("Task Sorumlusu:" + t.TaskAuthor);
                        Dosya2.WriteLine("Deadline:" + t.TaskDeadline);
                        Dosya2.Close();
                        fs2.Close();
                        Dosya3.WriteLine("TASK3");
                        Dosya3.WriteLine("Task No:" + txtTaskNo3.Text);
                        Dosya3.WriteLine("Öncelik Sirasi:" + txtOncelikSirasi3.Text);
                        Dosya3.WriteLine("Task İçeriği:" + txtTaskIcerigi3.Text);
                        Dosya3.WriteLine("Task Sorumlusu:" + t.TaskAuthor);
                        Dosya3.WriteLine("Deadline:" + t.TaskDeadline);
                        Dosya3.Close();
                        fs3.Close();
                        MessageBox.Show("Kayıt başarılı");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("sanırım bir sorun var " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Tasklar kaydedilemedi!!");
                }

            }

            else if (File.Exists(DosyaDizini3) == true && i == 3)

            {

                if (t.TaskSayisi == 1)
                {
                    FileStream fs3 = new FileStream("Story3Task1.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Dosya3 = new StreamWriter(fs3);

                    try
                    {
                        Dosya3.WriteLine("TASK1");
                        Dosya3.WriteLine("Task No:" + txtTaskNo.Text);
                        Dosya3.WriteLine("Öncelik Sirasi:" + txtOncelikSirasi.Text);
                        Dosya3.WriteLine("Task İçeriği:" + txtTaskIcerigi.Text);
                        Dosya3.WriteLine("Task Sorumlusu:" + t.TaskAuthor);
                        Dosya3.WriteLine("Deadline:" + t.TaskDeadline);
                        Dosya3.Close();
                        fs3.Close();
                        MessageBox.Show("Kayıt başarılı");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("sanırım bir sorun var " + ex);
                    }
                }
                else if (t.TaskSayisi == 2)
                {
                    FileStream fs1 = new FileStream("Story3Task1.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Dosya1 = new StreamWriter(fs1);
                    FileStream fs2 = new FileStream("Story3Task2.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Dosya2 = new StreamWriter(fs2);

                    try
                    {
                        Dosya1.WriteLine("TASK1");
                        Dosya1.WriteLine(" Task No::" + txtTaskNo.Text);
                        Dosya1.WriteLine("Öncelik Sirasi:" + txtOncelikSirasi.Text);
                        Dosya1.WriteLine(" Task İçeriği:" + txtTaskIcerigi.Text);
                        Dosya1.WriteLine("Task Sorumlusu:" + t.TaskAuthor);
                        Dosya1.WriteLine("Deadline:" + t.TaskDeadline);
                        Dosya1.Close();
                        fs1.Close();
                        Dosya2.WriteLine("TASK2");
                        Dosya2.WriteLine("Task No::" + txtTaskNo2.Text);
                        Dosya2.WriteLine("Öncelik Sirasi:" + txtOncelikSirasi2.Text);
                        Dosya2.WriteLine("Task İçeriği:" + txtTaskIcerigi2.Text);
                        Dosya2.WriteLine("Task Sorumlusu:" + t.TaskAuthor);
                        Dosya2.WriteLine("Deadline:" + t.TaskDeadline);
                        Dosya2.Close();
                        fs2.Close();
                        MessageBox.Show("Kayıt başarılı");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("sanırım bir sorun var " + ex);
                    }
                }
                else if(t.TaskSayisi==3)
                {
                    FileStream fs1 = new FileStream("Story3Task1.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Dosya1 = new StreamWriter(fs1);
                    FileStream fs2 = new FileStream("Story3Task2.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Dosya2 = new StreamWriter(fs2);
                    FileStream fs3 = new FileStream("Story3Task3.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Dosya3 = new StreamWriter(fs3);

                    try
                    {
                        Dosya1.WriteLine("TASK1");
                        Dosya1.WriteLine("Task No::" + txtTaskNo.Text);
                        Dosya1.WriteLine("Öncelik Sirasi:" + txtOncelikSirasi.Text);
                        Dosya1.WriteLine("Task İçeriği:" + txtTaskIcerigi.Text);
                        Dosya1.WriteLine("Task Sorumlusu:" + t.TaskAuthor);
                        Dosya1.WriteLine("Deadline:" + t.TaskDeadline);
                        Dosya1.Close();
                        fs1.Close();
                        Dosya2.WriteLine("TASK2");
                        Dosya2.WriteLine(" Task No::" + txtTaskNo2.Text);
                        Dosya2.WriteLine("Öncelik Sirasi:" + txtOncelikSirasi2.Text);
                        Dosya2.WriteLine(" Task İçeriği:" + txtTaskIcerigi2.Text);
                        Dosya2.WriteLine("Task Sorumlusu:" + t.TaskAuthor);
                        Dosya2.WriteLine("Deadline:" + t.TaskDeadline);
                        Dosya2.Close();
                        fs2.Close();
                        Dosya3.WriteLine("TASK3");
                        Dosya3.WriteLine("Task No:" + txtTaskNo3.Text);
                        Dosya3.WriteLine("Öncelik Sirasi:" + txtOncelikSirasi3.Text);
                        Dosya3.WriteLine("Task İçeriği:" + txtTaskIcerigi3.Text);
                        Dosya3.WriteLine("Task Sorumlusu:" + t.TaskAuthor);
                        Dosya3.WriteLine("Deadline:" + t.TaskDeadline);
                        Dosya3.Close();
                        fs3.Close();
                        MessageBox.Show("Kayıt başarılı");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("sanırım bir sorun var " + ex);
                    }

                }
                else
                {

                    MessageBox.Show("Tasklar kaydedilemedi!!");
                }
                   
          }

            else
                {
                    MessageBox.Show("Story Oluşturulamadı.");
                }

        }
        private void btnTaskSayisiGir_Click(object sender, EventArgs e)
        {
            t.TaskSayisi = Convert.ToInt32(txtTaskSayisi.Text);
            switch (t.TaskSayisi)
            {
                case 3:
                    {
                        lblTaskSayisi.Visible = false;
                        txtTaskSayisi.Visible = false;
                        btnTaskSayisiGir.Visible = false;
                        lblTaskBilgi1.Visible = true;
                        lblTaskNo1.Visible = true;
                        txtTaskNo.Visible = true;
                        lblOncelikSırası.Visible = true;
                        txtOncelikSirasi.Visible = true;
                        lblTaskIcerigi.Visible = true;
                        txtTaskIcerigi.Visible = true;
                        lblTaskBilgi2.Visible = true;
                        lblTaskNo2.Visible = true;
                        txtTaskNo2.Visible = true;
                        lblOncelikSirasi2.Visible = true;
                        txtOncelikSirasi2.Visible = true;
                        lblTaskIcerigi2.Visible = true;
                        txtTaskIcerigi2.Visible = true;
                        lblTaskBilgi3.Visible = true;
                        lblTaskNo3.Visible = true;
                        txtTaskNo3.Visible = true;
                        lblOncelikSirasi3.Visible = true;
                        txtOncelikSirasi3.Visible = true;
                        lblTaskIcerigi3.Visible = true;
                        txtTaskIcerigi3.Visible = true;
                        btnTaskOlusur.Visible = true;
                        listBoxCntrlTaskOlustur.Visible = true;
                        break;
                    }
                case 2:
                    {
                        lblTaskSayisi.Visible = false;
                        txtTaskSayisi.Visible = false;
                        btnTaskSayisiGir.Visible = false;
                        lblTaskBilgi1.Visible = true;
                        lblTaskNo1.Visible = true;
                        txtTaskNo.Visible = true;
                        lblOncelikSırası.Visible = true;
                        txtOncelikSirasi.Visible = true;
                        lblTaskIcerigi.Visible = true;
                        txtTaskIcerigi.Visible = true;
                        lblTaskBilgi2.Visible = true;
                        lblTaskNo2.Visible = true;
                        txtTaskNo2.Visible = true;
                        lblOncelikSirasi2.Visible = true;
                        txtOncelikSirasi2.Visible = true;
                        lblTaskIcerigi2.Visible = true;
                        txtTaskIcerigi2.Visible = true;
                        btnTaskOlusur.Visible = true;
                        listBoxCntrlTaskOlustur.Visible = true;
                        break;
                    }
                case 1:
                    {
                        lblTaskSayisi.Visible = false;
                        txtTaskSayisi.Visible = false;
                        btnTaskSayisiGir.Visible = false;
                        lblTaskBilgi1.Visible = true;
                        lblTaskNo1.Visible = true;
                        txtTaskNo.Visible = true;
                        lblOncelikSırası.Visible = true;
                        txtOncelikSirasi.Visible = true;
                        lblTaskIcerigi.Visible = true;
                        txtTaskIcerigi.Visible = true;
                        listBoxCntrlTaskOlustur.Visible = true;
                        btnTaskOlusur.Visible = true;
                        listBoxCntrlTaskOlustur.Visible = true;
                        break;
                    }
                default:
                    throw new Exception("Task Sayısı Max 3 OLABİLİR...");
            }
        }
    }
}
