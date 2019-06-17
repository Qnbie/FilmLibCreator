using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibCreator
{
    public partial class Form1 : Form
    {

        private List<string> Characters = new List<string>();
        private List<string> Props = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BCreate_Click(object sender, EventArgs e)
        {
            string strTmp;
            string placeHolder = "";
            for(int i = 0; i < nSceneNumber.Value.ToString().Length; i++)
            {
                placeHolder += "0";
            }
            if (tbFilmTitle.Text == "" || tbPath.Text == "")
            {
                errorEmpty();
            }
            else
            {
                // Base Directory of the film
                string directorybase = tbPath.Text + "\\" + tbFilmTitle.Text;
                /******DEVS******/
                Directory.CreateDirectory(directorybase + "\\DEVS");
                File.Copy(Directory.GetCurrentDirectory() + "\\maxTemplate.max", directorybase + "\\DEVS\\maxTemplate.max");
                File.Copy(Directory.GetCurrentDirectory() + "\\Adder.exe", directorybase + "\\DEVS\\Adder.exe");
                /******CHARACTER******/
                Directory.CreateDirectory(directorybase + "\\CHR");
                Directory.CreateDirectory(directorybase + "\\CHR\\SELPANEL");
                for (int i = 0; i < Characters.Count(); i++)
                {
                    //Characters
                    strTmp = directorybase + "\\CHR" + "\\" + Characters[i].ToUpper();
                    Directory.CreateDirectory(strTmp);
                    Directory.CreateDirectory(strTmp + "\\MODEL");
                    File.Copy(Directory.GetCurrentDirectory() + "\\maxTemplate.max", strTmp + $"\\MODEL\\{Characters[i].ToUpper()}_MODEL_01.max");
                    Directory.CreateDirectory(strTmp + "\\RIG");
                    File.Copy(Directory.GetCurrentDirectory() + "\\maxTemplate.max", strTmp + $"\\RIG\\{Characters[i].ToUpper()}_RIG_01.max");
                    Directory.CreateDirectory(strTmp + "\\TEXT");
                    Directory.CreateDirectory(strTmp + "\\HAIR");
                    File.Copy(Directory.GetCurrentDirectory() + "\\maxTemplate.max", strTmp + $"\\HAIR\\{Characters[i].ToUpper()}_HAIR_01.max");
                    Directory.CreateDirectory(strTmp + "\\RENDER");
                    File.Copy(Directory.GetCurrentDirectory() + "\\maxTemplate.max", strTmp + $"\\RENDER\\{Characters[i].ToUpper()}_RENDER_01.max");
                    Directory.CreateDirectory(strTmp + "\\LATVANY");
                    Directory.CreateDirectory(strTmp + "\\ANIM");
                    Directory.CreateDirectory(strTmp + "\\MARI");
                }
                /******VEGAS******/
                Directory.CreateDirectory(directorybase + "\\VEGAS");
                Directory.CreateDirectory(directorybase + "\\VEGAS\\PREVIEW_A");
                Directory.CreateDirectory(directorybase + "\\VEGAS\\PREVIEW_B");
                Directory.CreateDirectory(directorybase + "\\VEGAS\\RENDER");
                Directory.CreateDirectory(directorybase + "\\VEGAS\\ANIMATIK");
                /******JELENETEK******/
                Directory.CreateDirectory(directorybase + "\\JELENETEK");
                Directory.CreateDirectory(directorybase + "\\JELENETEK\\MATYIsHITS");
                for (int i = 1; i <= nSceneNumber.Value; i++)
                {
                    strTmp = directorybase + "\\JELENETEK" + "\\" + i.ToString(placeHolder);
                    //Directorys
                    Directory.CreateDirectory(strTmp + "\\RENDER");
                    Directory.CreateDirectory(strTmp + "\\SIM");
                    Directory.CreateDirectory(strTmp + "\\PC");
                    Directory.CreateDirectory(strTmp + "\\HANG");
                    Directory.CreateDirectory(strTmp + "\\ANIM");
                    //Template Files
                    File.Copy(Directory.GetCurrentDirectory() + "\\maxTemplate.max", strTmp + $"\\ANIM\\{i.ToString(placeHolder)}_ANIM_01.max");
                    File.Copy(Directory.GetCurrentDirectory() + "\\maxTemplate.max", strTmp + $"\\RENDER\\{i.ToString(placeHolder)}_RENDER_01.max");
                }
                /******BG******/
                Directory.CreateDirectory(directorybase + "\\BG");
                Directory.CreateDirectory(directorybase + "\\BG\\EMESE");
                Directory.CreateDirectory(directorybase + "\\BG\\MATYI");
                Directory.CreateDirectory(directorybase + "\\BG\\GIGI");
                Directory.CreateDirectory(directorybase + "\\BG\\SCAN");
                /******MODELS******/
                Directory.CreateDirectory(directorybase + "\\MODELS");
                for (int i = 0; i < Props.Count(); i++)
                {
                    //models
                    strTmp = directorybase + "\\MODELS" + "\\" + Props[i].ToUpper();
                    Directory.CreateDirectory(strTmp);
                    Directory.CreateDirectory(strTmp + "\\MODEL");
                    File.Copy(Directory.GetCurrentDirectory() + "\\maxTemplate.max", strTmp + $"\\MODEL\\{Props[i].ToUpper()}_MODEL_01.max");
                    Directory.CreateDirectory(strTmp + "\\TEXT");
                    Directory.CreateDirectory(strTmp + "\\MARI");
                }
                /******SCAN******/
                Directory.CreateDirectory(directorybase + "\\SCAN");
                /******FORG******/
                Directory.CreateDirectory(directorybase + "\\FORG");

                return;
            }
        }

        private void BAddCharacter_Click(object sender, EventArgs e)
        {
            if (tbNewCharacter.Text == "") errorEmpty();
            else
            {
                Characters.Add(tbNewCharacter.Text);
                lvCharacters.Items.Add(new ListViewItem(tbNewCharacter.Text));
                tbNewCharacter.Text = "";
            }
        }

        private void BAddProp_Click(object sender, EventArgs e)
        {
            if (tbNewProp.Text == "") errorEmpty();
            else
            {
                Props.Add(tbNewProp.Text);
                lvProps.Items.Add(new ListViewItem(tbNewProp.Text));
                tbNewProp.Text = "";
            }
        }

        private void BDeleteCharacter_Click(object sender, EventArgs e)
        {
            if (lvCharacters.SelectedItems.Count == 0) errorSelect();
            else
            {
                Characters.Remove(lvCharacters.SelectedItems[0].Text);
                lvCharacters.Items.Remove(lvCharacters.SelectedItems[0]); 
            }
        }

        private void BDeleteProp_Click(object sender, EventArgs e)
        {
            if (lvProps.SelectedItems.Count == 0) errorSelect();
            else
            {
                Props.Remove(lvProps.SelectedItems[0].Text);
                lvProps.Items.Remove(lvProps.SelectedItems[0]); 
            }
        }

        private void errorEmpty()
        {
            MessageBox.Show("Empty fields!");
        }

        private void errorSelect()
        {
            MessageBox.Show($"Please select an item first!");
        }

        private void BBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog(); ;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result.ToString() == "OK")
            {
                tbPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
