
namespace Miia
{
    partial class Miia
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Miia));
            this.border = new System.Windows.Forms.Panel();
            this.button_queue = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_favorites = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button_reload = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_settings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_reduce = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.view_content = new System.Windows.Forms.ListView();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToFavoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsCompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.border.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.border.Controls.Add(this.button_queue);
            this.border.Controls.Add(this.panel6);
            this.border.Controls.Add(this.button_favorites);
            this.border.Controls.Add(this.panel7);
            this.border.Controls.Add(this.button_reload);
            this.border.Controls.Add(this.panel2);
            this.border.Controls.Add(this.button_settings);
            this.border.Controls.Add(this.panel1);
            this.border.Controls.Add(this.button_reduce);
            this.border.Controls.Add(this.panel3);
            this.border.Controls.Add(this.pictureBox1);
            this.border.Controls.Add(this.label1);
            this.border.Controls.Add(this.button_close);
            this.border.Dock = System.Windows.Forms.DockStyle.Top;
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(1000, 25);
            this.border.TabIndex = 5;
            this.border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_MouseDown);
            this.border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_MouseMove);
            this.border.MouseUp += new System.Windows.Forms.MouseEventHandler(this.border_MouseUp);
            // 
            // button_queue
            // 
            this.button_queue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button_queue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_queue.BackgroundImage")));
            this.button_queue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_queue.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_queue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button_queue.FlatAppearance.BorderSize = 0;
            this.button_queue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button_queue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button_queue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_queue.ForeColor = System.Drawing.Color.Transparent;
            this.button_queue.Location = new System.Drawing.Point(825, 0);
            this.button_queue.Name = "button_queue";
            this.button_queue.Size = new System.Drawing.Size(25, 25);
            this.button_queue.TabIndex = 34;
            this.button_queue.UseVisualStyleBackColor = false;
            this.button_queue.Click += new System.EventHandler(this.button_queue_Click_1);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(850, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 25);
            this.panel6.TabIndex = 33;
            // 
            // button_favorites
            // 
            this.button_favorites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button_favorites.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_favorites.BackgroundImage")));
            this.button_favorites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_favorites.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_favorites.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button_favorites.FlatAppearance.BorderSize = 0;
            this.button_favorites.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button_favorites.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button_favorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_favorites.ForeColor = System.Drawing.Color.Transparent;
            this.button_favorites.Location = new System.Drawing.Point(855, 0);
            this.button_favorites.Name = "button_favorites";
            this.button_favorites.Size = new System.Drawing.Size(25, 25);
            this.button_favorites.TabIndex = 32;
            this.button_favorites.UseVisualStyleBackColor = false;
            this.button_favorites.Click += new System.EventHandler(this.button_favorites_Click_1);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(880, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 25);
            this.panel7.TabIndex = 31;
            // 
            // button_reload
            // 
            this.button_reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button_reload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_reload.BackgroundImage")));
            this.button_reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_reload.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_reload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button_reload.FlatAppearance.BorderSize = 0;
            this.button_reload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button_reload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reload.ForeColor = System.Drawing.Color.Transparent;
            this.button_reload.Location = new System.Drawing.Point(885, 0);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(25, 25);
            this.button_reload.TabIndex = 30;
            this.button_reload.UseVisualStyleBackColor = false;
            this.button_reload.Click += new System.EventHandler(this.button_reload_Click_1);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(910, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 25);
            this.panel2.TabIndex = 29;
            // 
            // button_settings
            // 
            this.button_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button_settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_settings.BackgroundImage")));
            this.button_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_settings.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_settings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button_settings.FlatAppearance.BorderSize = 0;
            this.button_settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.ForeColor = System.Drawing.Color.Transparent;
            this.button_settings.Location = new System.Drawing.Point(915, 0);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(25, 25);
            this.button_settings.TabIndex = 28;
            this.button_settings.UseVisualStyleBackColor = false;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click_1);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(940, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 25);
            this.panel1.TabIndex = 27;
            // 
            // button_reduce
            // 
            this.button_reduce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button_reduce.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_reduce.BackgroundImage")));
            this.button_reduce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_reduce.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_reduce.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button_reduce.FlatAppearance.BorderSize = 0;
            this.button_reduce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button_reduce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button_reduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reduce.ForeColor = System.Drawing.Color.Transparent;
            this.button_reduce.Location = new System.Drawing.Point(945, 0);
            this.button_reduce.Name = "button_reduce";
            this.button_reduce.Size = new System.Drawing.Size(25, 25);
            this.button_reduce.TabIndex = 26;
            this.button_reduce.UseVisualStyleBackColor = false;
            this.button_reduce.Click += new System.EventHandler(this.button_reduce_Click_1);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(970, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 25);
            this.panel3.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Miia";
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(66)))), ((int)(((byte)(69)))));
            this.button_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_close.BackgroundImage")));
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(66)))), ((int)(((byte)(69)))));
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(66)))), ((int)(((byte)(69)))));
            this.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(66)))), ((int)(((byte)(69)))));
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.ForeColor = System.Drawing.Color.Transparent;
            this.button_close.Location = new System.Drawing.Point(975, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(25, 25);
            this.button_close.TabIndex = 2;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // view_content
            // 
            this.view_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.view_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.view_content.ContextMenuStrip = this.menu;
            this.view_content.ForeColor = System.Drawing.Color.White;
            this.view_content.HideSelection = false;
            this.view_content.Location = new System.Drawing.Point(12, 31);
            this.view_content.MultiSelect = false;
            this.view_content.Name = "view_content";
            this.view_content.Size = new System.Drawing.Size(976, 607);
            this.view_content.TabIndex = 6;
            this.view_content.UseCompatibleStateImageBehavior = false;
            this.view_content.DoubleClick += new System.EventHandler(this.view_content_DoubleClick);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addListToolStripMenuItem,
            this.addToFavoriteToolStripMenuItem,
            this.setAsCompletedToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(181, 92);
            // 
            // addListToolStripMenuItem
            // 
            this.addListToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.addListToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addListToolStripMenuItem.Image")));
            this.addListToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addListToolStripMenuItem.Name = "addListToolStripMenuItem";
            this.addListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addListToolStripMenuItem.Text = "Add to watchlist";
            this.addListToolStripMenuItem.Click += new System.EventHandler(this.addListToolStripMenuItem_Click);
            // 
            // addToFavoriteToolStripMenuItem
            // 
            this.addToFavoriteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.addToFavoriteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addToFavoriteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addToFavoriteToolStripMenuItem.Image")));
            this.addToFavoriteToolStripMenuItem.Name = "addToFavoriteToolStripMenuItem";
            this.addToFavoriteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToFavoriteToolStripMenuItem.Text = "Add to favorite";
            this.addToFavoriteToolStripMenuItem.Click += new System.EventHandler(this.addToFavoriteToolStripMenuItem_Click);
            // 
            // setAsCompletedToolStripMenuItem
            // 
            this.setAsCompletedToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.setAsCompletedToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("setAsCompletedToolStripMenuItem.Image")));
            this.setAsCompletedToolStripMenuItem.Name = "setAsCompletedToolStripMenuItem";
            this.setAsCompletedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setAsCompletedToolStripMenuItem.Text = "Set as completed";
            this.setAsCompletedToolStripMenuItem.Click += new System.EventHandler(this.setAsCompletedToolStripMenuItem_Click);
            // 
            // Miia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.view_content);
            this.Controls.Add(this.border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Miia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Miia_Load);
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.ListView view_content;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem addListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToFavoriteToolStripMenuItem;
        private System.Windows.Forms.Button button_queue;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button_favorites;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button_reload;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_reduce;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem setAsCompletedToolStripMenuItem;
    }
}

