using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Spielerei
{
    public partial class Rijtjes : Form
    {

        public int ronde = 0;
        public int maxrondes = 3;
        List<Ronde> rondes = new List<Ronde>();


        public class Ronde
        {
            public Bitmap pic1src;
            public Bitmap pic2src;
            public Bitmap pic3src;
            public Bitmap pic4src;
            public Bitmap pic5src;
            public Bitmap pic6src;
            public int juisteantwoord;

            public Ronde(Bitmap pic1src, Bitmap pic2src, Bitmap pic3src, Bitmap pic4src, Bitmap pic5src, Bitmap pic6src, int juisteantwoord)
            {
                this.pic1src = pic1src;
                this.pic2src = pic2src;
                this.pic3src = pic3src;
                this.pic4src = pic4src;
                this.pic5src = pic5src;
                this.pic6src = pic6src;
                this.juisteantwoord = juisteantwoord;
            }

        }
        public Rijtjes()
        {
            InitializeComponent();
            

            

                rondes.Add(new Ronde(
                Spielerei.Properties.Resources._116citroen,
                Spielerei.Properties.Resources._116peer,
                Spielerei.Properties.Resources._116blokken,
                Spielerei.Properties.Resources._116kiwi,
                Spielerei.Properties.Resources._116sinaasappel,
                Spielerei.Properties.Resources._116ananas,
                3));

                rondes.Add(new Ronde(
                Spielerei.Properties.Resources._116ezel,
                Spielerei.Properties.Resources._116krab,
                Spielerei.Properties.Resources._116hond,
                Spielerei.Properties.Resources._116kip,
                Spielerei.Properties.Resources._116peer,
                Spielerei.Properties.Resources._116onijn,
                5));


                rondes.Add(new Ronde(
                Spielerei.Properties.Resources._116frietjes,
                Spielerei.Properties.Resources._116brood,
                Spielerei.Properties.Resources._116pizza,
                Spielerei.Properties.Resources._116vlinder,
                Spielerei.Properties.Resources._116kaas,
                Spielerei.Properties.Resources._116spaghetti,
                4));

                rondes.Add(new Ronde(
                Spielerei.Properties.Resources._116puzzel,
                Spielerei.Properties.Resources._116teddybeer,
                Spielerei.Properties.Resources._116pop,
                Spielerei.Properties.Resources._116ballon,
                Spielerei.Properties.Resources._116hobbelpaar,
                Spielerei.Properties.Resources._116peer,
                6));




            picture1.Visible = false;
            picture2.Visible = false;
            picture3.Visible = false;
            picture4.Visible = false;
            picture5.Visible = false;
            picture6.Visible = false;

            picture1.Enabled = false;
            picture2.Enabled = false;
            picture3.Enabled = false;
            picture4.Enabled = false;
            picture5.Enabled = false;
            picture6.Enabled = false;

            picture1.SizeMode = PictureBoxSizeMode.StretchImage;
            picture2.SizeMode = PictureBoxSizeMode.StretchImage;
            picture3.SizeMode = PictureBoxSizeMode.StretchImage;
            picture4.SizeMode = PictureBoxSizeMode.StretchImage;
            picture5.SizeMode = PictureBoxSizeMode.StretchImage;
            picture6.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void groupBox1_Click(object sender, EventArgs e)
        {
            StartSpel();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StartSpel();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StartSpel();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            StartSpel();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            StartSpel();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            StartSpel();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            StartSpel();
        }

        private void StartSpel()
        {
            groupBox1.Visible = false;
            groupBox1.Enabled = false;

            picture1.Visible = true;
            picture2.Visible = true;
            picture3.Visible = true;
            picture4.Visible = true;
            picture5.Visible = true;
            picture6.Visible = true;

            picture1.Enabled = true;
            picture2.Enabled = true;
            picture3.Enabled = true;
            picture4.Enabled = true;
            picture5.Enabled = true;
            picture6.Enabled = true;


            TekenRonde(ronde);

        }

        private void StopSpel()
        {
            groupBox1.Visible = true;
            groupBox1.Enabled = true;

            picture1.Visible = false;
            picture2.Visible = false;
            picture3.Visible = false;
            picture4.Visible = false;
            picture5.Visible = false;
            picture6.Visible = false;

            picture1.Enabled = false;
            picture2.Enabled = false;
            picture3.Enabled = false;
            picture4.Enabled = false;
            picture5.Enabled = false;
            picture6.Enabled = false;

        }

        public void TekenRonde(int ronde)
        {
            picture1.Image = rondes[ronde].pic1src;
            picture2.Image = rondes[ronde].pic2src;
            picture3.Image = rondes[ronde].pic3src;
            picture4.Image = rondes[ronde].pic4src;
            picture5.Image = rondes[ronde].pic5src;
            picture6.Image = rondes[ronde].pic6src;

        }

        private void picture1_Click(object sender, EventArgs e)
        {
            Valideren(1);
        }

        private void picture2_Click(object sender, EventArgs e)
        {
            Valideren(2);
        }

        private void picture3_Click(object sender, EventArgs e)
        {
            Valideren(3);
        }

        private void picture4_Click(object sender, EventArgs e)
        {
            Valideren(4);
        }

        private void picture5_Click(object sender, EventArgs e)
        {
            Valideren(5);
        }

        private void picture6_Click(object sender, EventArgs e)
        {
            Valideren(6);
        }


        private void Valideren(int keuze)
        {
            if (keuze == rondes[ronde].juisteantwoord)
            {
                SoundPlayer correct = new SoundPlayer(Spielerei.Properties.Resources.correct);
                correct.Play();
                ronde++;
                if (ronde <= maxrondes)
                {
                    TekenRonde(ronde);
                }
                else
                {
                    SoundPlayer applaus = new SoundPlayer(Spielerei.Properties.Resources.applaus);
                    applaus.Play();

                    StopSpel();
                }
            
            }
            else
            {
                SoundPlayer fout = new SoundPlayer(Spielerei.Properties.Resources.wrong);
                fout.Play();
            }


        }
    }
}
