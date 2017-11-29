using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aknakereso
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();

            //numericUpDown1.Parent = nudLabel;
            //nUD_height.Location = Point.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Not visible
            bt_options.Visible = false;
            la_height.Visible = false;
            la_width.Visible = false;
            la_mines.Visible = false;
            nUD_height.Visible = false;
            nUD_width.Visible = false;
            nUD_mines.Visible = false;
            bt_play.Visible = false;
            bt_back.Visible = false;
            #endregion
        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            bt_load.Visible = false;
            bt_options.Visible = true;
            la_height.Visible = true;
            la_width.Visible = true;
            la_mines.Visible = true;
            nUD_height.Visible = true;
            nUD_width.Visible = true;
            nUD_mines.Visible = true;
            bt_play.Visible = true;
            bt_back.Visible = true;
            bt_new.Enabled = false;
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            bt_options.Visible = false;
            la_height.Visible = false;
            la_width.Visible = false;
            la_mines.Visible = false;
            nUD_height.Visible = false;
            nUD_width.Visible = false;
            nUD_mines.Visible = false;
            bt_play.Visible = false;
            bt_back.Visible = false;
            bt_load.Visible = true;
            bt_new.Enabled = true;
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_play_Click(object sender, EventArgs e)
        {
            GameForm gf = new GameForm();
            this.Hide();
            gf.ShowDialog();
            this.Show();
        }

        private void bt_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File | *.txt";
            ofd.InitialDirectory = @"C:\Users\Suli\Desktop";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                GameForm gf = new GameForm();
                this.Hide();
                gf.ShowDialog();
                this.Show();
            }
        }
    }
}
