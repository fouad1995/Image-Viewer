namespace Image_Viewer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel_main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_begin = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.btn_skip = new System.Windows.Forms.Button();
            this.numericUpDown_speed = new System.Windows.Forms.NumericUpDown();
            this.pictureBox_ImageView = new System.Windows.Forms.PictureBox();
            this.timer_viewer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel_main.SuspendLayout();
            this.tableLayoutPanel_buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImageView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newImageToolStripMenuItem,
            this.saveCurrentImageToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newImageToolStripMenuItem
            // 
            this.newImageToolStripMenuItem.Name = "newImageToolStripMenuItem";
            this.newImageToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.newImageToolStripMenuItem.Text = "New Image";
            this.newImageToolStripMenuItem.Click += new System.EventHandler(this.newImageToolStripMenuItem_Click_1);
            // 
            // saveCurrentImageToolStripMenuItem
            // 
            this.saveCurrentImageToolStripMenuItem.Name = "saveCurrentImageToolStripMenuItem";
            this.saveCurrentImageToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveCurrentImageToolStripMenuItem.Text = "Save Current Image";
            this.saveCurrentImageToolStripMenuItem.Click += new System.EventHandler(this.saveCurrentImageToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tableLayoutPanel_main
            // 
            this.tableLayoutPanel_main.ColumnCount = 1;
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_main.Controls.Add(this.tableLayoutPanel_buttons, 0, 2);
            this.tableLayoutPanel_main.Controls.Add(this.pictureBox_ImageView, 0, 0);
            this.tableLayoutPanel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_main.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel_main.Name = "tableLayoutPanel_main";
            this.tableLayoutPanel_main.RowCount = 3;
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_main.Size = new System.Drawing.Size(541, 237);
            this.tableLayoutPanel_main.TabIndex = 1;
            // 
            // tableLayoutPanel_buttons
            // 
            this.tableLayoutPanel_buttons.ColumnCount = 6;
            this.tableLayoutPanel_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_buttons.Controls.Add(this.btn_skip, 4, 0);
            this.tableLayoutPanel_buttons.Controls.Add(this.btn_end, 3, 0);
            this.tableLayoutPanel_buttons.Controls.Add(this.btn_begin, 2, 0);
            this.tableLayoutPanel_buttons.Controls.Add(this.btn_pause, 1, 0);
            this.tableLayoutPanel_buttons.Controls.Add(this.btn_start, 0, 0);
            this.tableLayoutPanel_buttons.Controls.Add(this.numericUpDown_speed, 5, 0);
            this.tableLayoutPanel_buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_buttons.Location = new System.Drawing.Point(3, 203);
            this.tableLayoutPanel_buttons.Name = "tableLayoutPanel_buttons";
            this.tableLayoutPanel_buttons.RowCount = 1;
            this.tableLayoutPanel_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_buttons.Size = new System.Drawing.Size(535, 31);
            this.tableLayoutPanel_buttons.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_start.Location = new System.Drawing.Point(3, 3);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(83, 25);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_pause.Location = new System.Drawing.Point(92, 3);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(83, 25);
            this.btn_pause.TabIndex = 1;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_begin
            // 
            this.btn_begin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_begin.Location = new System.Drawing.Point(181, 3);
            this.btn_begin.Name = "btn_begin";
            this.btn_begin.Size = new System.Drawing.Size(83, 25);
            this.btn_begin.TabIndex = 2;
            this.btn_begin.Text = "Begin";
            this.btn_begin.UseVisualStyleBackColor = true;
            this.btn_begin.Click += new System.EventHandler(this.btn_begin_Click);
            // 
            // btn_end
            // 
            this.btn_end.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_end.Location = new System.Drawing.Point(270, 3);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(83, 25);
            this.btn_end.TabIndex = 3;
            this.btn_end.Text = "End";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // btn_skip
            // 
            this.btn_skip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_skip.Location = new System.Drawing.Point(359, 3);
            this.btn_skip.Name = "btn_skip";
            this.btn_skip.Size = new System.Drawing.Size(83, 25);
            this.btn_skip.TabIndex = 4;
            this.btn_skip.Text = "Skip";
            this.btn_skip.UseVisualStyleBackColor = true;
            this.btn_skip.Click += new System.EventHandler(this.btn_skip_Click);
            // 
            // numericUpDown_speed
            // 
            this.numericUpDown_speed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown_speed.Location = new System.Drawing.Point(448, 3);
            this.numericUpDown_speed.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_speed.Name = "numericUpDown_speed";
            this.numericUpDown_speed.Size = new System.Drawing.Size(84, 20);
            this.numericUpDown_speed.TabIndex = 5;
            this.numericUpDown_speed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_speed.ValueChanged += new System.EventHandler(this.numericUpDown_speed_ValueChanged);
            // 
            // pictureBox_ImageView
            // 
            this.pictureBox_ImageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_ImageView.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_ImageView.Name = "pictureBox_ImageView";
            this.pictureBox_ImageView.Size = new System.Drawing.Size(535, 171);
            this.pictureBox_ImageView.TabIndex = 1;
            this.pictureBox_ImageView.TabStop = false;
            // 
            // timer_viewer
            // 
            this.timer_viewer.Interval = 1000;
            this.timer_viewer.Tick += new System.EventHandler(this.timer_viewer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 261);
            this.Controls.Add(this.tableLayoutPanel_main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Viewer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel_main.ResumeLayout(false);
            this.tableLayoutPanel_buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImageView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_buttons;
        private System.Windows.Forms.Button btn_skip;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Button btn_begin;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.NumericUpDown numericUpDown_speed;
        private System.Windows.Forms.PictureBox pictureBox_ImageView;
        private System.Windows.Forms.Timer timer_viewer;
    }
}

