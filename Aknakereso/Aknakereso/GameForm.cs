using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            DoubleBuffered = true;
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
            Controls.Remove(tLP_board);
            tLP_board.Controls.Clear();
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    Control c;
                    if (mezo[i, j].visible)
                    {
                        c = new Label()
                        {
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        c.Text = mezo[i, j].value == -1 ? "B" : mezo[i, j].value.ToString();
                    }
                    else
                    {
                        c = new Button();
                        c.Text = mezo[i, j].flagged ? "F" : "";
                        c.MouseUp += C_MouseUp;
                    }
                    c.Tag = new Tuple<int, int>(i, j);
                    c.Dock = DockStyle.Fill;
                    tLP_board.Controls.Add(c, j, i);
                }
            }
            Controls.Add(tLP_board);
        }

        void PosClicked(Tuple<int, int> pos, bool right)
        {
            mezo.MezoFelfed(pos, right);
            if (InvokeRequired) Invoke(new MethodInvoker(() => DisplayMezo())); else DisplayMezo();
            bool close = false;
            switch (mezo.WhatIsGameState())
            {
                case Aknamezo.gameState.inProgress:
                    break;
                case Aknamezo.gameState.won:
                    MessageBox.Show("Nyertél!");
                    close = true;
                    break;
                case Aknamezo.gameState.lose:
                    MessageBox.Show("Vesztettél");
                    close = true;
                    break;
                case Aknamezo.gameState.gavenUp:
                    close = true;
                    break;
                default:
                    break;
            }
            if (close)
                if (InvokeRequired) Invoke(new MethodInvoker(() => Close())); else Close();
        }

        private void C_MouseUp(object sender, MouseEventArgs e)
        {
            var pos = (Tuple<int, int>)((Button)sender).Tag;
            PosClicked(pos, e.Button == MouseButtons.Right);
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

        private void button1_Click(object sender, EventArgs e)
        {
            solveStep();
        }

        private void Solve_btn_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(solveIt));
            t.Start();
        }

        private void solveStep()
        {
            IAI ai = new Basa_Budahazy_FeketeAI();
            Tuple<int, int> pos;
            var left = ai.choice(mezo.GetAknamForAI(), out pos);
            PosClicked(pos, !left);
        }

        private void solveIt()
        {
            while (mezo.WhatIsGameState() == Aknamezo.gameState.inProgress)
            {
                //Thread.Sleep(1);
                solveStep();
            }
        }

    }
}
