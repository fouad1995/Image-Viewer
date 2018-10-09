using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
namespace Image_Viewer
{
    public partial class Form1 : Form
    {
        ListBox listBox_paths=new ListBox();

        //global counter to select images from list box 
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
            //stretch the image in the picture box
            pictureBox_ImageView.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] path;
            int i;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileNames;
                for (i = 0; i < path.Length; i++)
                    listBox_paths.Items.Add(path[i]);

            }

        }

        private void timer_viewer_Tick(object sender, EventArgs e)
        {
            //First refresh the picturebox
            pictureBox_ImageView.Refresh();

            //check if the counter > listbox bound reset it
            if (counter >= listBox_paths.Items.Count)
                counter = 0;
            //display the first image in the listbox
            pictureBox_ImageView.Image = new Bitmap(listBox_paths.Items[counter].ToString());

            //increase the counter 
            counter++;

        }

        private void newImageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string[] path;
            int i;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileNames;
                for (i = 0; i < path.Length; i++)
                    listBox_paths.Items.Add(path[i]);

            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            //change the interval of the timer
            timer_viewer.Interval = 1000 / Convert.ToInt32(numericUpDown_speed.Value); 
            
            //start the timer 
            timer_viewer.Start();
        }

        private void numericUpDown_speed_ValueChanged(object sender, EventArgs e)
        {
            //change the value of the timer
            timer_viewer.Interval = 1000 / Convert.ToInt32(numericUpDown_speed.Value);
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            ///stop the timer 
            if(timer_viewer.Enabled==true)
                timer_viewer.Stop();
        }

        private void btn_begin_Click(object sender, EventArgs e)
        {

            //stop the timer first
            if (timer_viewer.Enabled == true)
                timer_viewer.Stop();

            //always displays first image in list box
            pictureBox_ImageView.Image = new Bitmap(listBox_paths.Items[0].ToString());

            //start the timer again
            timer_viewer.Start();



        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            //stop the timer first
            if (timer_viewer.Enabled == true)
                timer_viewer.Stop();

            //always displays last image in list box
            pictureBox_ImageView.Image = new Bitmap(listBox_paths.Items[listBox_paths.Items.Count-1].ToString());

            //start the timer again
            timer_viewer.Start();
        }

        private void btn_skip_Click(object sender, EventArgs e)
        {
            //stop the timer first
            if (timer_viewer.Enabled == true)
                timer_viewer.Stop();
            //skip the current image and display the next one 
            if (counter >= listBox_paths.Items.Count)
                counter = 0;
            else
                counter++;
            pictureBox_ImageView.Image = new Bitmap(listBox_paths.Items[counter].ToString());

            //start timer again
            timer_viewer.Start();
        }

        private void saveCurrentImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //stop the timer first
            if (timer_viewer.Enabled == true)
                timer_viewer.Stop();
            pictureBox_ImageView.Image.Save("FFFFF.jpg");
        }
    }
}
