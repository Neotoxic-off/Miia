
namespace Miia.window
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.border = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.label_version = new System.Windows.Forms.Label();
            this.textBox_root = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.browse_root = new System.Windows.Forms.FolderBrowserDialog();
            this.button_browse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rich_extensions = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_cleanner = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.border.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.border.Size = new System.Drawing.Size(406, 25);
            this.border.TabIndex = 8;
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
            this.label1.Text = "Settings";
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
            this.button_close.Location = new System.Drawing.Point(381, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(25, 25);
            this.button_close.TabIndex = 2;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.ForeColor = System.Drawing.Color.White;
            this.label_version.Location = new System.Drawing.Point(12, 140);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(51, 13);
            this.label_version.TabIndex = 8;
            this.label_version.Text = "unknown";
            // 
            // textBox_root
            // 
            this.textBox_root.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.textBox_root.ForeColor = System.Drawing.Color.White;
            this.textBox_root.Location = new System.Drawing.Point(78, 44);
            this.textBox_root.Name = "textBox_root";
            this.textBox_root.ReadOnly = true;
            this.textBox_root.Size = new System.Drawing.Size(290, 20);
            this.textBox_root.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Root:";
            // 
            // browse_root
            // 
            this.browse_root.Description = "Select library path root";
            // 
            // button_browse
            // 
            this.button_browse.BackColor = System.Drawing.Color.Transparent;
            this.button_browse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_browse.BackgroundImage")));
            this.button_browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_browse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.button_browse.FlatAppearance.BorderSize = 0;
            this.button_browse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.button_browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.button_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_browse.ForeColor = System.Drawing.Color.Transparent;
            this.button_browse.Location = new System.Drawing.Point(374, 43);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(20, 20);
            this.button_browse.TabIndex = 15;
            this.button_browse.UseVisualStyleBackColor = false;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Author:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(59, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "neo";
            // 
            // rich_extensions
            // 
            this.rich_extensions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.rich_extensions.ForeColor = System.Drawing.Color.White;
            this.rich_extensions.Location = new System.Drawing.Point(78, 70);
            this.rich_extensions.Name = "rich_extensions";
            this.rich_extensions.ReadOnly = true;
            this.rich_extensions.Size = new System.Drawing.Size(290, 50);
            this.rich_extensions.TabIndex = 18;
            this.rich_extensions.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Extensions:";
            // 
            // button_cleanner
            // 
            this.button_cleanner.AllowAnimations = true;
            this.button_cleanner.AllowMouseEffects = true;
            this.button_cleanner.AllowToggling = false;
            this.button_cleanner.AnimationSpeed = 200;
            this.button_cleanner.AutoGenerateColors = false;
            this.button_cleanner.AutoRoundBorders = false;
            this.button_cleanner.AutoSizeLeftIcon = true;
            this.button_cleanner.AutoSizeRightIcon = true;
            this.button_cleanner.BackColor = System.Drawing.Color.Transparent;
            this.button_cleanner.BackColor1 = System.Drawing.Color.Transparent;
            this.button_cleanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_cleanner.BackgroundImage")));
            this.button_cleanner.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_cleanner.ButtonText = "Cleanner";
            this.button_cleanner.ButtonTextMarginLeft = 0;
            this.button_cleanner.ColorContrastOnClick = 45;
            this.button_cleanner.ColorContrastOnHover = 45;
            this.button_cleanner.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.button_cleanner.CustomizableEdges = borderEdges1;
            this.button_cleanner.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_cleanner.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_cleanner.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_cleanner.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_cleanner.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.button_cleanner.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_cleanner.ForeColor = System.Drawing.Color.White;
            this.button_cleanner.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cleanner.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.button_cleanner.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.button_cleanner.IconMarginLeft = 11;
            this.button_cleanner.IconPadding = 10;
            this.button_cleanner.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_cleanner.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.button_cleanner.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.button_cleanner.IconSize = 25;
            this.button_cleanner.IdleBorderColor = System.Drawing.Color.White;
            this.button_cleanner.IdleBorderRadius = 20;
            this.button_cleanner.IdleBorderThickness = 1;
            this.button_cleanner.IdleFillColor = System.Drawing.Color.Transparent;
            this.button_cleanner.IdleIconLeftImage = null;
            this.button_cleanner.IdleIconRightImage = null;
            this.button_cleanner.IndicateFocus = false;
            this.button_cleanner.Location = new System.Drawing.Point(293, 133);
            this.button_cleanner.Name = "button_cleanner";
            this.button_cleanner.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_cleanner.OnDisabledState.BorderRadius = 20;
            this.button_cleanner.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_cleanner.OnDisabledState.BorderThickness = 1;
            this.button_cleanner.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_cleanner.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_cleanner.OnDisabledState.IconLeftImage = null;
            this.button_cleanner.OnDisabledState.IconRightImage = null;
            this.button_cleanner.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.button_cleanner.onHoverState.BorderRadius = 20;
            this.button_cleanner.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_cleanner.onHoverState.BorderThickness = 1;
            this.button_cleanner.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.button_cleanner.onHoverState.ForeColor = System.Drawing.Color.White;
            this.button_cleanner.onHoverState.IconLeftImage = null;
            this.button_cleanner.onHoverState.IconRightImage = null;
            this.button_cleanner.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.button_cleanner.OnIdleState.BorderRadius = 20;
            this.button_cleanner.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_cleanner.OnIdleState.BorderThickness = 1;
            this.button_cleanner.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.button_cleanner.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.button_cleanner.OnIdleState.IconLeftImage = null;
            this.button_cleanner.OnIdleState.IconRightImage = null;
            this.button_cleanner.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button_cleanner.OnPressedState.BorderRadius = 20;
            this.button_cleanner.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_cleanner.OnPressedState.BorderThickness = 1;
            this.button_cleanner.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button_cleanner.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.button_cleanner.OnPressedState.IconLeftImage = null;
            this.button_cleanner.OnPressedState.IconRightImage = null;
            this.button_cleanner.Size = new System.Drawing.Size(75, 23);
            this.button_cleanner.TabIndex = 24;
            this.button_cleanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_cleanner.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_cleanner.TextMarginLeft = 0;
            this.button_cleanner.TextPadding = new System.Windows.Forms.Padding(0);
            this.button_cleanner.UseDefaultRadiusAndThickness = true;
            this.button_cleanner.Click += new System.EventHandler(this.button_cleanner_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(406, 165);
            this.Controls.Add(this.button_cleanner);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rich_extensions);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_root);
            this.Controls.Add(this.border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.TextBox textBox_root;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog browse_root;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rich_extensions;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 button_cleanner;
    }
}