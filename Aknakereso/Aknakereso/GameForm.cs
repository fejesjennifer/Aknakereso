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
    public partial class GameForm : Form
    {
        Aknamezo mezo;
        int height { get { return mezo.GetLength(0); } }
        int width { get { return mezo.GetLength(1); } }

        private GameForm()
        {
            InitializeComponent();
        }

        void SetTable()
        {
            this.tLP_board.ColumnStyles.Clear();
            this.tLP_board.RowStyles.Clear();
            this.tLP_board.RowCount = height;
            for (int i = 0; i < height; ++i) this.tLP_board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F / height));
            this.tLP_board.ColumnCount = width;
            for (int i = 0; i < width; ++i) this.tLP_board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F / width));
        }

        void DisplayMezo()
        {
            tLP_board.Controls.Clear();
            for (int i = 0; i < height; ++i) {
                for (int j = 0; j < width; ++j) {
                    Control c;
                    if (mezo[i, j].visible)
                    {
                        c = new Label() {
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        c.Text = mezo[i, j].value.ToString();
                    }
                    else {
                        c = new Button();
                        c.Text = mezo[i, j].flagged ? "F" : "";
                        c.Click += C_Click;
                    }
                    c.Tag = new Tuple<int, int>(i, j);
                    c.Dock = DockStyle.Fill;
                    tLP_board.Controls.Add(c, j, i);
                }
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            var pos = (Tuple<int,int>)((Button)sender).Tag;

        }

        public GameForm(Aknamezo mezo) : this()
        {
            this.mezo = mezo;
            SetTable();
            DisplayMezo();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            MenuForm mf = new MenuForm();
            
        }
    }
}
