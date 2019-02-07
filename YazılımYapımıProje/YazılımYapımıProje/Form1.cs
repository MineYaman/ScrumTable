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
    public partial class STORY : Form
    {
        public static Story s = new Story();
     
        int i = 0;
        public STORY()
        {

            InitializeComponent();
        }

        private void btnStoryEkle_Click(object sender, EventArgs e)
        {
            s.StoryID= Convert.ToInt32(txtStoryId.Text);
            s.StoryDate = txtStoryDate.DateTime;
            s.StoryTitle = this.txtStoryTitle.Text;
            s.Description = this.txtDescription.Text;
            s.StoryAuthor = this.txtStoryAuthor.Text;
            i++;
            s.StorySayisi = i;

            s.StoryEkle(s);
            btnTaskEkle.Visible = true;
           

            listBoxCntrlStoryEkle.Items.Add("STORIES");
            listBoxCntrlStoryEkle.Items.Add("Story ID:" + txtStoryId.Text);
            listBoxCntrlStoryEkle.Items.Add("Story Title:" + txtStoryTitle.Text);
            listBoxCntrlStoryEkle.Items.Add("Description:" + txtDescription.Text);  
            listBoxCntrlStoryEkle.Items.Add( "Story Author:" + txtStoryAuthor.Text);
            listBoxCntrlStoryEkle.Items.Add("Deadline:" + txtStoryDate.DateTime);
           listBoxCntrlStoryEkle.BackColor = Color.DeepPink;
            listBoxCntrlStoryEkle.ForeColor = Color.DarkBlue;
            
    

            if (i== 2)
            {
                FileStream fs = new FileStream("Story2.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter Dosya = new StreamWriter(fs);
                try
                {
                    Dosya.Write("Story ID: " + txtStoryId.Text);
                    Dosya.Write("\nDescription: " + txtDescription.Text);
                    Dosya.Write("\nStory Author: " + txtStoryAuthor.Text);
                    Dosya.Write("\nStory Title: " + txtStoryTitle.Text);
                    Dosya.Write("\nStory Date: " + txtStoryDate.DateTime);
                    Dosya.Close();
                    fs.Close();
                    MessageBox.Show("Kayıt başarılı");
                }

                catch (Exception ex)

                {
                    MessageBox.Show("sanırım bir sorun var " + ex);

                }
            }
            else if(i==3)
            {
                FileStream fs = new FileStream("Story3.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter Dosya = new StreamWriter(fs);
                try
                {
                    Dosya.Write("Story ID: " + txtStoryId.Text);
                    Dosya.Write("\nDescription: " + txtDescription.Text);
                    Dosya.Write("\nStory Author: " + txtStoryAuthor.Text);
                    Dosya.Write("\nStory Title: " + txtStoryTitle.Text);
                    Dosya.Write("\nStory Date: " + txtStoryDate.DateTime);
                    Dosya.Close();
                    fs.Close();
                    MessageBox.Show("Kayıt başarılı");
                }

                catch (Exception ex)

                {
                    MessageBox.Show("sanırım bir sorun var " + ex);

                }
            }

            else if(i==1)
            {
                FileStream fs = new FileStream("Story1.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter Dosya = new StreamWriter(fs);
                try
                {
                    Dosya.Write("Story ID: " + txtStoryId.Text);
                    Dosya.Write("\nDescription: " + txtDescription.Text);
                    Dosya.Write("\nStory Author: " + txtStoryAuthor.Text);
                    Dosya.Write("\nStory Title: " + txtStoryTitle.Text);
                    Dosya.Write("\nStory Date: " + txtStoryDate.DateTime);
                    Dosya.Close();
                    fs.Close();
                    MessageBox.Show("Kayıt başarılı");
                }

                catch (Exception ex)

                {
                    MessageBox.Show("sanırım bir sorun var " + ex);

                }
            }
            else
            {
                MessageBox.Show("En fazla 3 story girebilirsiniz!!.");
            }
                 
        }

        private void btnTablo_Click(object sender, EventArgs e)
        {
            frmScrumTable sc = new frmScrumTable();
            sc.Show();
        }

        private void btnTaskEkle_Click(object sender, EventArgs e)
        {
            frmTaskEkle te = new frmTaskEkle();
            te.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmStorySil ss = new frmStorySil();
            ss.Show();
           
        }
    }
}
