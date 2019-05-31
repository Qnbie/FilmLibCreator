using System;
using System.Collections.Generic;
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
            for(int i = 0; i < nSceneNumber.ToString().Length; i++)
            {
                placeHolder += "0";
            }
            if (tbFilmTitle.Text == "" || tbPath.Text == "")
            {
                errorEmpty();
            }
            else
            {
                string directorybase = tbPath.Text + "\\" + tbFilmTitle.Text;
                Directory.CreateDirectory(directorybase + "\\CHR");
                for (int i = 0; i < Characters.Count(); i++)
                {
                    strTmp = directorybase + "\\CHR" + "\\" + Characters[i];
                    Directory.CreateDirectory(strTmp);
                    Directory.CreateDirectory(strTmp + "\\MODEL");
                    File.Copy(Directory.GetCurrentDirectory() + "\\maxTemplate.max", strTmp + $"\\MODEL\\{Characters[i]}_MODEL_01.max");
                    Directory.CreateDirectory(strTmp + "\\RIG");
                    File.Copy(Directory.GetCurrentDirectory() + "\\maxTemplate.max", strTmp + $"\\RIG\\{Characters[i]}_RIG_01.max");
                    Directory.CreateDirectory(strTmp + "\\TEXT");
                    Directory.CreateDirectory(strTmp + "\\HAIR");
                    File.Copy(Directory.GetCurrentDirectory() + "\\maxTemplate.max", strTmp + $"\\HAIR\\{Characters[i]}_HAIR_01.max");
                    Directory.CreateDirectory(strTmp + "\\RENDER");
                    File.Copy(Directory.GetCurrentDirectory() + "\\maxTemplate.max", strTmp + $"\\RENDER\\{Characters[i]}_RENDER_01.max");
                }

                Directory.CreateDirectory(directorybase + "\\JELENETEK");
                for (int i = 1; i <= nSceneNumber.Value; i++)
                {
                    strTmp = directorybase + "\\JELENETEK" + "\\" + i.ToString(placeHolder);
                    Directory.CreateDirectory(strTmp + "\\PREVIEWS");
                    File.Copy(Directory.GetCurrentDirectory() + "\\aviTemplate.avi", strTmp + $"\\PREVIEWS\\Preview_{i.ToString(placeHolder)}_A.avi");        //Preview A
                    File.Copy(Directory.GetCurrentDirectory() + "\\aviTemplate.avi", strTmp + $"\\PREVIEWS\\Preview_{i.ToString(placeHolder)}_B.avi");        //Preview B
                    File.Copy(Directory.GetCurrentDirectory() + "\\aviTemplate.avi", strTmp + $"\\PREVIEWS\\Preview_{i.ToString(placeHolder)}_Render.avi");   //Preview Render
                    Directory.CreateDirectory(strTmp + "\\ANIM");
                    File.Copy(Directory.GetCurrentDirectory() + "\\maxTemplate.max", strTmp + $"\\ANIM\\{i.ToString(placeHolder)}_ANIM_01.max");
                }
                Directory.CreateDirectory(directorybase + "\\VEGAS");
                Directory.CreateDirectory(directorybase + "\\BG");
                Directory.CreateDirectory(directorybase + "\\PROPS");
                for (int i = 0; i < Props.Count(); i++)
                {
                    strTmp = directorybase + "\\PROPS" + "\\" + Props[i];
                    Directory.CreateDirectory(strTmp);
                    Directory.CreateDirectory(strTmp + "\\MODEL");
                    File.Copy(Directory.GetCurrentDirectory() + "\\maxTemplate.max", strTmp + $"\\MODEL\\{Props[i]}_MODEL_01.max");
                    Directory.CreateDirectory(strTmp + "\\TEXT");
                }
                Directory.CreateDirectory(directorybase + "\\SCAN");
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
    }
}
