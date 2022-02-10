
namespace Miia.window
{
    partial class ContentViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContentViewer));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.border = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_type = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.button_remove = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.list_content = new System.Windows.Forms.ListView();
            this.border.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.border.Controls.Add(this.pictureBox1);
            this.border.Controls.Add(this.label_type);
            this.border.Controls.Add(this.button_close);
            this.border.Dock = System.Windows.Forms.DockStyle.Top;
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(300, 25);
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
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(35, 6);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(51, 13);
            this.label_type.TabIndex = 11;
            this.label_type.Text = "unknown";
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
            this.button_close.Location = new System.Drawing.Point(275, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(25, 25);
            this.button_close.TabIndex = 2;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_remove
            // 
            this.button_remove.AllowAnimations = true;
            this.button_remove.AllowMouseEffects = true;
            this.button_remove.AllowToggling = false;
            this.button_remove.AnimationSpeed = 200;
            this.button_remove.AutoGenerateColors = false;
            this.button_remove.AutoRoundBorders = false;
            this.button_remove.AutoSizeLeftIcon = true;
            this.button_remove.AutoSizeRightIcon = true;
            this.button_remove.BackColor = System.Drawing.Color.Transparent;
            this.button_remove.BackColor1 = System.Drawing.Color.Transparent;
            this.button_remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_remove.BackgroundImage")));
            this.button_remove.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_remove.ButtonText = "Remove";
            this.button_remove.ButtonTextMarginLeft = 0;
            this.button_remove.ColorContrastOnClick = 45;
            this.button_remove.ColorContrastOnHover = 45;
            this.button_remove.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.button_remove.CustomizableEdges = borderEdges3;
            this.button_remove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_remove.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_remove.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_remove.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_remove.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.button_remove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_remove.ForeColor = System.Drawing.Color.White;
            this.button_remove.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_remove.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.button_remove.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.button_remove.IconMarginLeft = 11;
            this.button_remove.IconPadding = 10;
            this.button_remove.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_remove.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.button_remove.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.button_remove.IconSize = 25;
            this.button_remove.IdleBorderColor = System.Drawing.Color.White;
            this.button_remove.IdleBorderRadius = 20;
            this.button_remove.IdleBorderThickness = 1;
            this.button_remove.IdleFillColor = System.Drawing.Color.Transparent;
            this.button_remove.IdleIconLeftImage = null;
            this.button_remove.IdleIconRightImage = null;
            this.button_remove.IndicateFocus = false;
            this.button_remove.Location = new System.Drawing.Point(213, 165);
            this.button_remove.Name = "button_remove";
            this.button_remove.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_remove.OnDisabledState.BorderRadius = 20;
            this.button_remove.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_remove.OnDisabledState.BorderThickness = 1;
            this.button_remove.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_remove.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_remove.OnDisabledState.IconLeftImage = null;
            this.button_remove.OnDisabledState.IconRightImage = null;
            this.button_remove.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.button_remove.onHoverState.BorderRadius = 20;
            this.button_remove.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_remove.onHoverState.BorderThickness = 1;
            this.button_remove.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.button_remove.onHoverState.ForeColor = System.Drawing.Color.White;
            this.button_remove.onHoverState.IconLeftImage = null;
            this.button_remove.onHoverState.IconRightImage = null;
            this.button_remove.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.button_remove.OnIdleState.BorderRadius = 20;
            this.button_remove.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_remove.OnIdleState.BorderThickness = 1;
            this.button_remove.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.button_remove.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.button_remove.OnIdleState.IconLeftImage = null;
            this.button_remove.OnIdleState.IconRightImage = null;
            this.button_remove.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button_remove.OnPressedState.BorderRadius = 20;
            this.button_remove.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_remove.OnPressedState.BorderThickness = 1;
            this.button_remove.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button_remove.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.button_remove.OnPressedState.IconLeftImage = null;
            this.button_remove.OnPressedState.IconRightImage = null;
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 26;
            this.button_remove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_remove.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_remove.TextMarginLeft = 0;
            this.button_remove.TextPadding = new System.Windows.Forms.Padding(0);
            this.button_remove.UseDefaultRadiusAndThickness = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // list_content
            // 
            this.list_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.list_content.ForeColor = System.Drawing.Color.White;
            this.list_content.HideSelection = false;
            this.list_content.Location = new System.Drawing.Point(12, 31);
            this.list_content.MultiSelect = false;
            this.list_content.Name = "list_content";
            this.list_content.Size = new System.Drawing.Size(276, 128);
            this.list_content.TabIndex = 27;
            this.list_content.UseCompatibleStateImageBehavior = false;
            this.list_content.View = System.Windows.Forms.View.Tile;
            // 
            // ContentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.list_content);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.border);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContentViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContentViewer";
            this.Load += new System.EventHandler(this.ContentViewer_Load);
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_type;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 button_remove;
        private System.Windows.Forms.ListView list_content;
    }
}