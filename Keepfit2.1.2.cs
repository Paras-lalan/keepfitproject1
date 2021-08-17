using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keepfit2._1._2
{
    public partial class Keepfit2 : Form
    {
        private int childFormNumber = 0;

        public Keepfit2()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dashboard dash = new dashboard();
                dash.MdiParent = this;
                dash.Show();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }



        private void Keepfit2_Load(object sender, EventArgs e)
        {

        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                member member = new member();
                member.MdiParent = this;
                member.Show();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void trainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                trainer trainer = new trainer();
                trainer.MdiParent = this;
                trainer.Show();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fees fee = new fees();
                fee.MdiParent = this;
                fee.Show();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                category category = new category();
                category.MdiParent = this;
                category.Show();
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void periodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                period period = new period();
                period.MdiParent = this;
                period.Show();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void packageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                package package = new package();
                package.MdiParent = this;
                package.Show();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void memberSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                membersearch membersearch = new membersearch();
                membersearch.MdiParent = this;
                membersearch.Show();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void trainerSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                trainersearch trainersearch = new trainersearch();
                trainersearch.MdiParent = this;
                trainersearch.Show();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void feesSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                feessearch feessearch = new feessearch();
                feessearch.MdiParent = this;
                feessearch.Show();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void pTSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ptsearch ptsearch = new ptsearch();
                ptsearch.MdiParent = this;
                ptsearch.Show();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                changepassword changepassword = new changepassword();
                changepassword.MdiParent = this;
                changepassword.Show();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                login login = new login();
                login.Show();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
