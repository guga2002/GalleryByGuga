using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PIctureViewerByguga
{
    public partial class Form1 : Form
    {
        static string[] directories = new string[0];
        static string[] files=new string[0];
       static  string[] fgh=new string[0];
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void buttonadddir_Click(object sender, EventArgs e)
        {
            string[] st = directories;
            directories = new string[st.Length + 1];
            st.CopyTo(directories, 0);
            gooes:
            FolderBrowserDialog fld = new FolderBrowserDialog();
            if (fld.ShowDialog() == DialogResult.OK)
            {
                if (!Contains(directories, fld.SelectedPath))
                {
                    directories[st.Length] = fld.SelectedPath;
                }
                else
                {
                    MessageBox.Show("ukve aris direqtoria");
                    goto gooes;
                }

            }

            string[] fls = Directory.GetFiles(fld.SelectedPath);
            foreach (var item in fls)
            {
                if (item.Contains(".jpeg") || item.Contains(".png"))
                {
                    
                        string[] trm = fgh;
                        fgh = new string[trm.Length + 1];
                        fgh[trm.Length] = item;
                        string[] stte = files;
                        files = new string[stte.Length + 1];
                        stte.CopyTo(files, 0);
                        files[stte.Length] = item;
                    
                }
            }
        


            listBoxfordirectories.DataSource = directories;
            forpictures.DataSource = files;

        }

        public bool Contains(string []st,string value)
        {
            for (int i = 0;i<st.Length;i++)
            {
                if (st[i]==(value)) return true;
            }
            return false;
        }

        private void buttonrefresh_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonremovedir_Click(object sender, EventArgs e)
        {
            if (directories.Length > 0)
            {
                int deletethisindex = Array.IndexOf(directories, listBoxfordirectories.SelectedItem);//vnaxulobt masivishi elementis indeqs
                directories = directories.Where((val, index) => index != deletethisindex).ToArray();
            }

            listBoxfordirectories.DataSource = directories;
        }
        static int curent = 0;
        static int left = 0;
        static int right = 0;
        private async void buttonnextpic_Click(object sender, EventArgs e)
        {

            pictureBoxlefside.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxMainbox.SizeMode= PictureBoxSizeMode.CenterImage;
            pictureBoxMainbox.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxrightside.BackgroundImageLayout = ImageLayout.Stretch;


            if (curent < files.Length)
            {
                if(curent>0)
                {
                    left = curent - 1;
                }
                else
                {
                    left = 0;
                }
                   
                if(curent<files.Length-1)
                {
                    right = curent + 1;
                }
                else
                {
                    right = 0;
                }

                pictureBoxrightside.Image=new Bitmap(files[right]);
                pictureBoxMainbox.Image = new Bitmap(files[curent]);
                pictureBoxlefside.Image = new Bitmap(files[left]);
                curent++;

            }
            else
            {
                curent = 0;
               left = 0;
                right = 1;
                

            }


        }

        private void buttonpreviouspic_Click(object sender, EventArgs e)
        {
           if(curent>0)
            {
                
                int k = left-1;
                right = curent;
                curent =left;
                left = k;
                pictureBoxrightside.Image = new Bitmap(files[right]);
                pictureBoxMainbox.Image = new Bitmap(files[curent]);
                pictureBoxlefside.Image = new Bitmap(files[left]);
                curent--;
            }
           else
            {
                curent = files.Length - 1;
                left = curent-1;
                right = 0;
            }

        }

        private void listBoxfordirectories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxrightside_Click(object sender, EventArgs e)
        {
            buttonnextpic_Click(sender,e);
        }

        private void pictureBoxlefside_Click(object sender, EventArgs e)
        {
            buttonpreviouspic_Click(sender, e);
        }
    }
}
