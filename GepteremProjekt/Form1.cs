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
using System.Text.RegularExpressions;

namespace GepteremProjekt
{
    public partial class Form1 : Form
    {
        PetrikLajosSzg petrik = new PetrikLajosSzg(new List<Gepterem>());
        int page = 0;
        string kepek = @"..//../Kepek/";
        public Form1()
        {
            InitializeComponent();
        }
        private void pages()
        {
            if (page > 0)
            {
                balnyil.ImageLocation = kepek + "bal.jpg";
                balnyil.Enabled = true;

            }
            else
            {
                balnyil.ImageLocation = "";
                balnyil.Enabled = false;

            }
            if (page < 2)
            {
                jobbnyil.ImageLocation = kepek + "jobb.jpg";
                jobbnyil.Enabled = true;
            }
            else
            {
                jobbnyil.ImageLocation = "";
                jobbnyil.Enabled = false;
            }
        }
        private void ertekeleskLoad(Gepterem gt)
        {
            panel1.Controls.Clear();
            gtPic.ImageLocation = kepek + petrik.Geptermek[page].Nev + ".jpg";
            gtPic.SizeMode = PictureBoxSizeMode.Zoom;
            int size = 60;
            for (int i = 0; i < gt.SorDb; i++)
            {
                for (int j = 0; j < gt.HelyDb; j++)
                {
                    PictureBox PB = new PictureBox();
                    PB.SizeMode = PictureBoxSizeMode.Zoom;
                    PB.BorderStyle = BorderStyle.FixedSingle;
                    PB.SetBounds(i * size, j * size, size, size);
                    PB.Name = $"{i};{j}";
                    pbLoad(PB, i, j);
                    PB.Click += (o, oe) =>
                    {
                        int[,] ertekeles = petrik.Geptermek[page].Ertekeles;
                        PictureBox bpb = (PictureBox)o;
                        int[] tmp = Array.ConvertAll(bpb.Name.Split(';'), int.Parse);
                        int a = tmp[0];
                        int b = tmp[1];
                        if (ertekeles[a, b] + 1 > 3)
                        {
                            ertekeles[a, b] = 0;
                        }
                        else
                        {
                            ertekeles[a, b] = ertekeles[a, b] += 1;
                        }
                        pbLoad(bpb, a, b);
                    };
                    panel1.Controls.Add(PB);
                }
            }
        }

        private void pbLoad(PictureBox pb, int a, int b)
        {
            string ertekeles = kepek + @"Pont" + petrik.Geptermek[page].Ertekeles[a, b] + ".jpg";
            string pont0 = kepek + @"Pont0.jpg";
            if (File.Exists(ertekeles))
            {
                pb.ImageLocation = ertekeles;
            }
            else
            {
                pb.ImageLocation = pont0;
            }
        }
        private Gepterem gtLoad(string txt)
        {
            string[] splitted = txt.Split('\n');
            int[] tmp = Array.ConvertAll(splitted[1].Split(';'), int.Parse);
            int[,] pbs = new int[tmp[1], tmp[0]];
            for (int i = 2; i < splitted.Length - 1; i++)
            {
                int[] ert = Array.ConvertAll(splitted[i].Split(';'), int.Parse);
                pbs[ert[1] - 1, ert[0] - 1] = ert[2];
            }
            return new Gepterem(pbs, tmp[0], splitted[0].Replace("\r", ""), tmp[1]);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string[] petrikgepek = Regex.Split(File.ReadAllText(@"..//../petrikgepek1.txt"), Environment.NewLine + Environment.NewLine);
            for (int i = 0; i < petrikgepek.Length; i++)
            {
                petrik.Geptermek.Add(gtLoad(petrikgepek[i]));
            }
            ertekeleskLoad(petrik.Geptermek[page]);
            pages();
            jobbnyil.SizeMode = PictureBoxSizeMode.Zoom;
            balnyil.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void jobbnyil_Click(object sender, EventArgs e)
        {
            page++;
            ertekeleskLoad(petrik.Geptermek[page]);
            jobbnyil.SizeMode = PictureBoxSizeMode.Zoom;
            balnyil.SizeMode = PictureBoxSizeMode.Zoom;
            pages();
        }

        private void balnyil_Click(object sender, EventArgs e)
        {
            page--;
            ertekeleskLoad(petrik.Geptermek[page]);
            jobbnyil.SizeMode = PictureBoxSizeMode.Zoom;
            balnyil.SizeMode = PictureBoxSizeMode.Zoom;
            pages();
        }
    }
}
