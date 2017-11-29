namespace Aknakereso
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_new = new System.Windows.Forms.Button();
            this.bt_load = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_play = new System.Windows.Forms.Button();
            this.bt_options = new System.Windows.Forms.Button();
            this.la_height = new System.Windows.Forms.Label();
            this.la_mines = new System.Windows.Forms.Label();
            this.nUD_mines = new System.Windows.Forms.NumericUpDown();
            this.nUD_width = new System.Windows.Forms.NumericUpDown();
            this.nUD_height = new System.Windows.Forms.NumericUpDown();
            this.la_width = new System.Windows.Forms.Label();
            this.bt_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_mines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_height)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_new
            // 
            this.bt_new.FlatAppearance.BorderSize = 2;
            this.bt_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_new.Location = new System.Drawing.Point(183, 96);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(120, 70);
            this.bt_new.TabIndex = 0;
            this.bt_new.Text = "New Game";
            this.bt_new.UseVisualStyleBackColor = true;
            this.bt_new.Click += new System.EventHandler(this.bt_new_Click);
            // 
            // bt_load
            // 
            this.bt_load.FlatAppearance.BorderSize = 2;
            this.bt_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_load.Location = new System.Drawing.Point(183, 193);
            this.bt_load.Name = "bt_load";
            this.bt_load.Size = new System.Drawing.Size(120, 70);
            this.bt_load.TabIndex = 1;
            this.bt_load.Text = "Load Game";
            this.bt_load.UseVisualStyleBackColor = true;
            this.bt_load.Click += new System.EventHandler(this.bt_load_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.FlatAppearance.BorderSize = 2;
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_exit.Location = new System.Drawing.Point(183, 292);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(120, 70);
            this.bt_exit.TabIndex = 2;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_play
            // 
            this.bt_play.FlatAppearance.BorderSize = 2;
            this.bt_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_play.Location = new System.Drawing.Point(183, 193);
            this.bt_play.Name = "bt_play";
            this.bt_play.Size = new System.Drawing.Size(120, 70);
            this.bt_play.TabIndex = 3;
            this.bt_play.Text = "Play";
            this.bt_play.UseVisualStyleBackColor = true;
            this.bt_play.Click += new System.EventHandler(this.bt_play_Click);
            // 
            // bt_options
            // 
            this.bt_options.Enabled = false;
            this.bt_options.FlatAppearance.BorderSize = 2;
            this.bt_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_options.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_options.Location = new System.Drawing.Point(36, 193);
            this.bt_options.Name = "bt_options";
            this.bt_options.Size = new System.Drawing.Size(120, 70);
            this.bt_options.TabIndex = 26;
            this.bt_options.UseVisualStyleBackColor = true;
            // 
            // la_height
            // 
            this.la_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.la_height.Location = new System.Drawing.Point(38, 195);
            this.la_height.Name = "la_height";
            this.la_height.Size = new System.Drawing.Size(49, 23);
            this.la_height.TabIndex = 27;
            this.la_height.Text = "Height";
            this.la_height.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // la_mines
            // 
            this.la_mines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.la_mines.Location = new System.Drawing.Point(38, 237);
            this.la_mines.Name = "la_mines";
            this.la_mines.Size = new System.Drawing.Size(49, 23);
            this.la_mines.TabIndex = 29;
            this.la_mines.Text = "Mines";
            this.la_mines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nUD_mines
            // 
            this.nUD_mines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nUD_mines.Location = new System.Drawing.Point(107, 238);
            this.nUD_mines.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUD_mines.Name = "nUD_mines";
            this.nUD_mines.Size = new System.Drawing.Size(47, 23);
            this.nUD_mines.TabIndex = 32;
            this.nUD_mines.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nUD_width
            // 
            this.nUD_width.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nUD_width.Location = new System.Drawing.Point(107, 217);
            this.nUD_width.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nUD_width.Name = "nUD_width";
            this.nUD_width.Size = new System.Drawing.Size(47, 23);
            this.nUD_width.TabIndex = 31;
            this.nUD_width.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // nUD_height
            // 
            this.nUD_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nUD_height.Location = new System.Drawing.Point(107, 195);
            this.nUD_height.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nUD_height.Name = "nUD_height";
            this.nUD_height.Size = new System.Drawing.Size(47, 23);
            this.nUD_height.TabIndex = 30;
            this.nUD_height.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // la_width
            // 
            this.la_width.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.la_width.Location = new System.Drawing.Point(38, 217);
            this.la_width.Name = "la_width";
            this.la_width.Size = new System.Drawing.Size(49, 23);
            this.la_width.TabIndex = 28;
            this.la_width.Text = "Width";
            this.la_width.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_back
            // 
            this.bt_back.FlatAppearance.BorderSize = 2;
            this.bt_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_back.Location = new System.Drawing.Point(330, 193);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(120, 70);
            this.bt_back.TabIndex = 33;
            this.bt_back.Text = "Back";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.la_height);
            this.Controls.Add(this.la_mines);
            this.Controls.Add(this.nUD_mines);
            this.Controls.Add(this.nUD_width);
            this.Controls.Add(this.nUD_height);
            this.Controls.Add(this.la_width);
            this.Controls.Add(this.bt_options);
            this.Controls.Add(this.bt_play);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_load);
            this.Controls.Add(this.bt_new);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aknakereső";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_mines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_height)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_new;
        private System.Windows.Forms.Button bt_load;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_play;
        private System.Windows.Forms.Button bt_options;
        private System.Windows.Forms.Label la_height;
        private System.Windows.Forms.Label la_mines;
        private System.Windows.Forms.NumericUpDown nUD_mines;
        private System.Windows.Forms.NumericUpDown nUD_width;
        private System.Windows.Forms.NumericUpDown nUD_height;
        private System.Windows.Forms.Label la_width;
        private System.Windows.Forms.Button bt_back;
    }
}

