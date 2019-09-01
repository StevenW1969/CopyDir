namespace CopyDir
{
    partial class FrmMain_Treeview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain_Treeview));
            this.txt_sDir = new System.Windows.Forms.TextBox();
            this.txt_dDir = new System.Windows.Forms.TextBox();
            this.fbd_sDir = new System.Windows.Forms.FolderBrowserDialog();
            this.fbd_dDir = new System.Windows.Forms.FolderBrowserDialog();
            this.lblCurFN = new System.Windows.Forms.Label();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPaths = new System.Windows.Forms.TableLayoutPanel();
            this.btn_sDir = new System.Windows.Forms.Button();
            this.btn_dDir = new System.Windows.Forms.Button();
            this.tlpDecide = new System.Windows.Forms.TableLayoutPanel();
            this.rbMov = new System.Windows.Forms.RadioButton();
            this.rbTV = new System.Windows.Forms.RadioButton();
            this.rbTV_Mov = new System.Windows.Forms.RadioButton();
            this.gbFoundMov = new System.Windows.Forms.GroupBox();
            this.tvMovies = new System.Windows.Forms.TreeView();
            this.tlpFS_Button = new System.Windows.Forms.TableLayoutPanel();
            this.lblDDFS = new System.Windows.Forms.Label();
            this.lblTSN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartCopy = new System.Windows.Forms.Button();
            this.lblCFS = new System.Windows.Forms.Label();
            this.gbFoundTVS = new System.Windows.Forms.GroupBox();
            this.tvTVShows = new System.Windows.Forms.TreeView();
            this.tlpMain.SuspendLayout();
            this.tlpPaths.SuspendLayout();
            this.tlpDecide.SuspendLayout();
            this.gbFoundMov.SuspendLayout();
            this.tlpFS_Button.SuspendLayout();
            this.gbFoundTVS.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_sDir
            // 
            this.txt_sDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txt_sDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_sDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sDir.ForeColor = System.Drawing.Color.Silver;
            this.txt_sDir.Location = new System.Drawing.Point(181, 16);
            this.txt_sDir.Margin = new System.Windows.Forms.Padding(7, 16, 7, 7);
            this.txt_sDir.Name = "txt_sDir";
            this.txt_sDir.Size = new System.Drawing.Size(378, 15);
            this.txt_sDir.TabIndex = 2;
            this.txt_sDir.TextChanged += new System.EventHandler(this.Txt_sDir_TextChanged);
            // 
            // txt_dDir
            // 
            this.txt_dDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txt_dDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_dDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dDir.ForeColor = System.Drawing.Color.Silver;
            this.txt_dDir.Location = new System.Drawing.Point(181, 62);
            this.txt_dDir.Margin = new System.Windows.Forms.Padding(7, 16, 7, 7);
            this.txt_dDir.Name = "txt_dDir";
            this.txt_dDir.Size = new System.Drawing.Size(378, 15);
            this.txt_dDir.TabIndex = 3;
            this.txt_dDir.TextChanged += new System.EventHandler(this.Txt_dDir_TextChanged);
            // 
            // lblCurFN
            // 
            this.lblCurFN.AutoSize = true;
            this.tlpMain.SetColumnSpan(this.lblCurFN, 2);
            this.lblCurFN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurFN.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCurFN.Location = new System.Drawing.Point(3, 565);
            this.lblCurFN.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.lblCurFN.Name = "lblCurFN";
            this.lblCurFN.Size = new System.Drawing.Size(876, 40);
            this.lblCurFN.TabIndex = 8;
            this.lblCurFN.Text = "-";
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.tlpPaths, 0, 0);
            this.tlpMain.Controls.Add(this.gbFoundMov, 0, 1);
            this.tlpMain.Controls.Add(this.lblCurFN, 0, 4);
            this.tlpMain.Controls.Add(this.tlpFS_Button, 1, 2);
            this.tlpMain.Controls.Add(this.gbFoundTVS, 1, 1);
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.Size = new System.Drawing.Size(882, 605);
            this.tlpMain.TabIndex = 10;
            // 
            // tlpPaths
            // 
            this.tlpPaths.ColumnCount = 3;
            this.tlpMain.SetColumnSpan(this.tlpPaths, 2);
            this.tlpPaths.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.83624F));
            this.tlpPaths.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.16376F));
            this.tlpPaths.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 309F));
            this.tlpPaths.Controls.Add(this.btn_sDir, 0, 0);
            this.tlpPaths.Controls.Add(this.btn_dDir, 0, 1);
            this.tlpPaths.Controls.Add(this.txt_sDir, 1, 0);
            this.tlpPaths.Controls.Add(this.txt_dDir, 1, 1);
            this.tlpPaths.Controls.Add(this.tlpDecide, 2, 0);
            this.tlpPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPaths.Location = new System.Drawing.Point(3, 3);
            this.tlpPaths.Name = "tlpPaths";
            this.tlpPaths.RowCount = 2;
            this.tlpPaths.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.95833F));
            this.tlpPaths.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.04167F));
            this.tlpPaths.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPaths.Size = new System.Drawing.Size(876, 96);
            this.tlpPaths.TabIndex = 10;
            // 
            // btn_sDir
            // 
            this.btn_sDir.BackgroundImage = global::CopyDir.Properties.Resources.button_source;
            this.btn_sDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_sDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sDir.FlatAppearance.BorderSize = 0;
            this.btn_sDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sDir.Location = new System.Drawing.Point(7, 7);
            this.btn_sDir.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btn_sDir.Name = "btn_sDir";
            this.btn_sDir.Size = new System.Drawing.Size(160, 32);
            this.btn_sDir.TabIndex = 0;
            this.btn_sDir.UseVisualStyleBackColor = true;
            this.btn_sDir.Click += new System.EventHandler(this.btn_sDir_Click);
            // 
            // btn_dDir
            // 
            this.btn_dDir.BackgroundImage = global::CopyDir.Properties.Resources.button_destination;
            this.btn_dDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_dDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_dDir.FlatAppearance.BorderSize = 0;
            this.btn_dDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dDir.Location = new System.Drawing.Point(7, 53);
            this.btn_dDir.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btn_dDir.Name = "btn_dDir";
            this.btn_dDir.Size = new System.Drawing.Size(160, 36);
            this.btn_dDir.TabIndex = 1;
            this.btn_dDir.UseVisualStyleBackColor = true;
            this.btn_dDir.Click += new System.EventHandler(this.btn_dDir_Click);
            // 
            // tlpDecide
            // 
            this.tlpDecide.ColumnCount = 2;
            this.tlpDecide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpDecide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDecide.Controls.Add(this.rbMov, 1, 2);
            this.tlpDecide.Controls.Add(this.rbTV, 1, 1);
            this.tlpDecide.Controls.Add(this.rbTV_Mov, 1, 0);
            this.tlpDecide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDecide.Location = new System.Drawing.Point(569, 3);
            this.tlpDecide.Name = "tlpDecide";
            this.tlpDecide.RowCount = 3;
            this.tlpPaths.SetRowSpan(this.tlpDecide, 2);
            this.tlpDecide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDecide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDecide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDecide.Size = new System.Drawing.Size(304, 90);
            this.tlpDecide.TabIndex = 4;
            // 
            // rbMov
            // 
            this.rbMov.AutoSize = true;
            this.rbMov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbMov.ForeColor = System.Drawing.Color.Silver;
            this.rbMov.Location = new System.Drawing.Point(133, 63);
            this.rbMov.Name = "rbMov";
            this.rbMov.Size = new System.Drawing.Size(168, 24);
            this.rbMov.TabIndex = 1;
            this.rbMov.TabStop = true;
            this.rbMov.Text = "Movies Only";
            this.rbMov.UseVisualStyleBackColor = true;
            this.rbMov.Click += new System.EventHandler(this.RbMov_Click);
            // 
            // rbTV
            // 
            this.rbTV.AutoSize = true;
            this.rbTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbTV.ForeColor = System.Drawing.Color.Silver;
            this.rbTV.Location = new System.Drawing.Point(133, 33);
            this.rbTV.Name = "rbTV";
            this.rbTV.Size = new System.Drawing.Size(168, 24);
            this.rbTV.TabIndex = 0;
            this.rbTV.TabStop = true;
            this.rbTV.Text = "TV Shows Only";
            this.rbTV.UseVisualStyleBackColor = true;
            this.rbTV.Click += new System.EventHandler(this.RbTV_Click);
            // 
            // rbTV_Mov
            // 
            this.rbTV_Mov.AutoSize = true;
            this.rbTV_Mov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbTV_Mov.ForeColor = System.Drawing.Color.Silver;
            this.rbTV_Mov.Location = new System.Drawing.Point(133, 3);
            this.rbTV_Mov.Name = "rbTV_Mov";
            this.rbTV_Mov.Size = new System.Drawing.Size(168, 24);
            this.rbTV_Mov.TabIndex = 2;
            this.rbTV_Mov.TabStop = true;
            this.rbTV_Mov.Text = "TV Shows and Movies";
            this.rbTV_Mov.UseVisualStyleBackColor = true;
            this.rbTV_Mov.Click += new System.EventHandler(this.RbTV_Mov_Click);
            // 
            // gbFoundMov
            // 
            this.gbFoundMov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbFoundMov.Controls.Add(this.tvMovies);
            this.gbFoundMov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFoundMov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbFoundMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFoundMov.ForeColor = System.Drawing.Color.Yellow;
            this.gbFoundMov.Location = new System.Drawing.Point(20, 105);
            this.gbFoundMov.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.gbFoundMov.Name = "gbFoundMov";
            this.gbFoundMov.Size = new System.Drawing.Size(401, 382);
            this.gbFoundMov.TabIndex = 13;
            this.gbFoundMov.TabStop = false;
            this.gbFoundMov.Text = "Movies";
            // 
            // tvMovies
            // 
            this.tvMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tvMovies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMovies.ForeColor = System.Drawing.Color.Silver;
            this.tvMovies.Location = new System.Drawing.Point(3, 18);
            this.tvMovies.Name = "tvMovies";
            this.tvMovies.Size = new System.Drawing.Size(395, 361);
            this.tvMovies.TabIndex = 0;
            // 
            // tlpFS_Button
            // 
            this.tlpFS_Button.ColumnCount = 7;
            this.tlpMain.SetColumnSpan(this.tlpFS_Button, 2);
            this.tlpFS_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.931507F));
            this.tlpFS_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.04566F));
            this.tlpFS_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.67123F));
            this.tlpFS_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.9863F));
            this.tlpFS_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.03653F));
            this.tlpFS_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.990868F));
            this.tlpFS_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.22374F));
            this.tlpFS_Button.Controls.Add(this.lblDDFS, 5, 0);
            this.tlpFS_Button.Controls.Add(this.lblTSN, 3, 0);
            this.tlpFS_Button.Controls.Add(this.label3, 4, 0);
            this.tlpFS_Button.Controls.Add(this.label2, 2, 0);
            this.tlpFS_Button.Controls.Add(this.label1, 0, 0);
            this.tlpFS_Button.Controls.Add(this.btnStartCopy, 6, 0);
            this.tlpFS_Button.Controls.Add(this.lblCFS, 1, 0);
            this.tlpFS_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFS_Button.Location = new System.Drawing.Point(3, 508);
            this.tlpFS_Button.Name = "tlpFS_Button";
            this.tlpFS_Button.RowCount = 1;
            this.tlpFS_Button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFS_Button.Size = new System.Drawing.Size(876, 34);
            this.tlpFS_Button.TabIndex = 15;
            // 
            // lblDDFS
            // 
            this.lblDDFS.AutoSize = true;
            this.lblDDFS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDDFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDDFS.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblDDFS.Location = new System.Drawing.Point(552, 0);
            this.lblDDFS.Name = "lblDDFS";
            this.lblDDFS.Size = new System.Drawing.Size(64, 34);
            this.lblDDFS.TabIndex = 12;
            this.lblDDFS.Text = "-";
            this.lblDDFS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTSN
            // 
            this.lblTSN.AutoSize = true;
            this.lblTSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSN.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblTSN.Location = new System.Drawing.Point(289, 0);
            this.lblTSN.Name = "lblTSN";
            this.lblTSN.Size = new System.Drawing.Size(99, 34);
            this.lblTSN.TabIndex = 11;
            this.lblTSN.Text = "-";
            this.lblTSN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(394, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Destination Drive Free Space :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(178, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Space Needed:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Current File Size: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStartCopy
            // 
            this.btnStartCopy.BackgroundImage = global::CopyDir.Properties.Resources.button_start_copy;
            this.btnStartCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStartCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartCopy.FlatAppearance.BorderSize = 0;
            this.btnStartCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCopy.Location = new System.Drawing.Point(619, 0);
            this.btnStartCopy.Margin = new System.Windows.Forms.Padding(0);
            this.btnStartCopy.Name = "btnStartCopy";
            this.btnStartCopy.Size = new System.Drawing.Size(257, 34);
            this.btnStartCopy.TabIndex = 6;
            this.btnStartCopy.UseVisualStyleBackColor = true;
            this.btnStartCopy.Click += new System.EventHandler(this.BtnStartCopy_Click);
            // 
            // lblCFS
            // 
            this.lblCFS.AutoSize = true;
            this.lblCFS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCFS.ForeColor = System.Drawing.Color.Yellow;
            this.lblCFS.Location = new System.Drawing.Point(90, 0);
            this.lblCFS.Name = "lblCFS";
            this.lblCFS.Size = new System.Drawing.Size(82, 34);
            this.lblCFS.TabIndex = 10;
            this.lblCFS.Text = "-";
            this.lblCFS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbFoundTVS
            // 
            this.gbFoundTVS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbFoundTVS.Controls.Add(this.tvTVShows);
            this.gbFoundTVS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFoundTVS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbFoundTVS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFoundTVS.ForeColor = System.Drawing.Color.Yellow;
            this.gbFoundTVS.Location = new System.Drawing.Point(461, 105);
            this.gbFoundTVS.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.gbFoundTVS.Name = "gbFoundTVS";
            this.gbFoundTVS.Size = new System.Drawing.Size(401, 382);
            this.gbFoundTVS.TabIndex = 16;
            this.gbFoundTVS.TabStop = false;
            this.gbFoundTVS.Text = "TV Shows";
            // 
            // tvTVShows
            // 
            this.tvTVShows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tvTVShows.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvTVShows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTVShows.ForeColor = System.Drawing.Color.Silver;
            this.tvTVShows.Location = new System.Drawing.Point(3, 18);
            this.tvTVShows.Name = "tvTVShows";
            this.tvTVShows.Size = new System.Drawing.Size(395, 361);
            this.tvTVShows.TabIndex = 0;
            // 
            // FrmMain_Treeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(878, 593);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(894, 800);
            this.MinimumSize = new System.Drawing.Size(894, 632);
            this.Name = "FrmMain_Treeview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Copy Directory Tool";
            this.Load += new System.EventHandler(this.frmMain_Treeview_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpPaths.ResumeLayout(false);
            this.tlpPaths.PerformLayout();
            this.tlpDecide.ResumeLayout(false);
            this.tlpDecide.PerformLayout();
            this.gbFoundMov.ResumeLayout(false);
            this.tlpFS_Button.ResumeLayout(false);
            this.tlpFS_Button.PerformLayout();
            this.gbFoundTVS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sDir;
        private System.Windows.Forms.Button btn_dDir;
        private System.Windows.Forms.TextBox txt_sDir;
        private System.Windows.Forms.TextBox txt_dDir;
        private System.Windows.Forms.Button btnStartCopy;
        private System.Windows.Forms.FolderBrowserDialog fbd_sDir;
        private System.Windows.Forms.FolderBrowserDialog fbd_dDir;
        public System.Windows.Forms.Label lblCurFN;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpPaths;
        private System.Windows.Forms.GroupBox gbFoundMov;
        private System.Windows.Forms.TableLayoutPanel tlpFS_Button;
        private System.Windows.Forms.GroupBox gbFoundTVS;
        private System.Windows.Forms.TreeView tvMovies;
        private System.Windows.Forms.TreeView tvTVShows;
        private System.Windows.Forms.TableLayoutPanel tlpDecide;
        private System.Windows.Forms.RadioButton rbMov;
        private System.Windows.Forms.RadioButton rbTV;
        private System.Windows.Forms.RadioButton rbTV_Mov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDDFS;
        private System.Windows.Forms.Label lblTSN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCFS;
    }
}

