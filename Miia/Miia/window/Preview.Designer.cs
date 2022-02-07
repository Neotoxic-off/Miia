﻿
namespace Miia.window
{
    partial class Preview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preview));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.border = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.preview_box = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_seasons = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.last_watched = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button_play = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.border.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview_box)).BeginInit();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.border.Controls.Add(this.pictureBox1);
            this.border.Controls.Add(this.label1);
            this.border.Controls.Add(this.button_close);
            this.border.Dock = System.Windows.Forms.DockStyle.Top;
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(413, 25);
            this.border.TabIndex = 9;
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
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Preview";
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
            this.button_close.Location = new System.Drawing.Point(388, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(25, 25);
            this.button_close.TabIndex = 2;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // preview_box
            // 
            this.preview_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.preview_box.Location = new System.Drawing.Point(12, 31);
            this.preview_box.Name = "preview_box";
            this.preview_box.Size = new System.Drawing.Size(128, 192);
            this.preview_box.TabIndex = 10;
            this.preview_box.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Seasons: ";
            // 
            // label_name
            // 
            this.label_name.Location = new System.Drawing.Point(146, 44);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(255, 13);
            this.label_name.TabIndex = 13;
            this.label_name.Text = "name";
            // 
            // label_seasons
            // 
            this.label_seasons.AutoSize = true;
            this.label_seasons.Location = new System.Drawing.Point(226, 57);
            this.label_seasons.Name = "label_seasons";
            this.label_seasons.Size = new System.Drawing.Size(41, 13);
            this.label_seasons.TabIndex = 14;
            this.label_seasons.Text = "season";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Last watched:";
            // 
            // last_watched
            // 
            this.last_watched.Location = new System.Drawing.Point(226, 70);
            this.last_watched.Name = "last_watched";
            this.last_watched.Size = new System.Drawing.Size(171, 13);
            this.last_watched.TabIndex = 17;
            this.last_watched.Text = "episode";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(198, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Season:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(146, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Episode:";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(200, 127);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(201, 21);
            this.comboBox2.TabIndex = 21;
            // 
            // button_play
            // 
            this.button_play.AllowAnimations = true;
            this.button_play.AllowMouseEffects = true;
            this.button_play.AllowToggling = false;
            this.button_play.AnimationSpeed = 200;
            this.button_play.AutoGenerateColors = false;
            this.button_play.AutoRoundBorders = false;
            this.button_play.AutoSizeLeftIcon = true;
            this.button_play.AutoSizeRightIcon = true;
            this.button_play.BackColor = System.Drawing.Color.Transparent;
            this.button_play.BackColor1 = System.Drawing.Color.Transparent;
            this.button_play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_play.BackgroundImage")));
            this.button_play.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_play.ButtonText = "Play";
            this.button_play.ButtonTextMarginLeft = 0;
            this.button_play.ColorContrastOnClick = 45;
            this.button_play.ColorContrastOnHover = 45;
            this.button_play.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.button_play.CustomizableEdges = borderEdges5;
            this.button_play.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_play.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_play.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_play.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_play.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.button_play.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_play.ForeColor = System.Drawing.Color.White;
            this.button_play.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_play.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.button_play.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.button_play.IconMarginLeft = 11;
            this.button_play.IconPadding = 10;
            this.button_play.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_play.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.button_play.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.button_play.IconSize = 25;
            this.button_play.IdleBorderColor = System.Drawing.Color.White;
            this.button_play.IdleBorderRadius = 20;
            this.button_play.IdleBorderThickness = 1;
            this.button_play.IdleFillColor = System.Drawing.Color.Transparent;
            this.button_play.IdleIconLeftImage = null;
            this.button_play.IdleIconRightImage = null;
            this.button_play.IndicateFocus = false;
            this.button_play.Location = new System.Drawing.Point(326, 200);
            this.button_play.Name = "button_play";
            this.button_play.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_play.OnDisabledState.BorderRadius = 20;
            this.button_play.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_play.OnDisabledState.BorderThickness = 1;
            this.button_play.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_play.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_play.OnDisabledState.IconLeftImage = null;
            this.button_play.OnDisabledState.IconRightImage = null;
            this.button_play.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.button_play.onHoverState.BorderRadius = 20;
            this.button_play.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_play.onHoverState.BorderThickness = 1;
            this.button_play.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.button_play.onHoverState.ForeColor = System.Drawing.Color.White;
            this.button_play.onHoverState.IconLeftImage = null;
            this.button_play.onHoverState.IconRightImage = null;
            this.button_play.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.button_play.OnIdleState.BorderRadius = 20;
            this.button_play.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_play.OnIdleState.BorderThickness = 1;
            this.button_play.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.button_play.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.button_play.OnIdleState.IconLeftImage = null;
            this.button_play.OnIdleState.IconRightImage = null;
            this.button_play.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button_play.OnPressedState.BorderRadius = 20;
            this.button_play.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_play.OnPressedState.BorderThickness = 1;
            this.button_play.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button_play.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.button_play.OnPressedState.IconLeftImage = null;
            this.button_play.OnPressedState.IconRightImage = null;
            this.button_play.Size = new System.Drawing.Size(75, 23);
            this.button_play.TabIndex = 23;
            this.button_play.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_play.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_play.TextMarginLeft = 0;
            this.button_play.TextPadding = new System.Windows.Forms.Padding(0);
            this.button_play.UseDefaultRadiusAndThickness = true;
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(413, 236);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.last_watched);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_seasons);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.preview_box);
            this.Controls.Add(this.border);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview";
            this.Load += new System.EventHandler(this.Preview_Load);
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.PictureBox preview_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_seasons;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label last_watched;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 button_play;
    }
}