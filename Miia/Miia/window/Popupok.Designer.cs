
namespace Miia.window
{
    partial class Popupok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popupok));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.border = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ok = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.label_question = new System.Windows.Forms.Label();
            this.border.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.border.Controls.Add(this.pictureBox1);
            this.border.Controls.Add(this.label1);
            this.border.Dock = System.Windows.Forms.DockStyle.Top;
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(259, 25);
            this.border.TabIndex = 10;
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
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Validation";
            // 
            // button_ok
            // 
            this.button_ok.AllowAnimations = true;
            this.button_ok.AllowMouseEffects = true;
            this.button_ok.AllowToggling = false;
            this.button_ok.AnimationSpeed = 200;
            this.button_ok.AutoGenerateColors = false;
            this.button_ok.AutoRoundBorders = false;
            this.button_ok.AutoSizeLeftIcon = true;
            this.button_ok.AutoSizeRightIcon = true;
            this.button_ok.BackColor = System.Drawing.Color.Transparent;
            this.button_ok.BackColor1 = System.Drawing.Color.Transparent;
            this.button_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ok.BackgroundImage")));
            this.button_ok.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_ok.ButtonText = "Ok";
            this.button_ok.ButtonTextMarginLeft = 0;
            this.button_ok.ColorContrastOnClick = 45;
            this.button_ok.ColorContrastOnHover = 45;
            this.button_ok.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.button_ok.CustomizableEdges = borderEdges1;
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_ok.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_ok.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_ok.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_ok.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.button_ok.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_ok.ForeColor = System.Drawing.Color.White;
            this.button_ok.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ok.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.button_ok.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.button_ok.IconMarginLeft = 11;
            this.button_ok.IconPadding = 10;
            this.button_ok.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_ok.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.button_ok.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.button_ok.IconSize = 25;
            this.button_ok.IdleBorderColor = System.Drawing.Color.White;
            this.button_ok.IdleBorderRadius = 20;
            this.button_ok.IdleBorderThickness = 1;
            this.button_ok.IdleFillColor = System.Drawing.Color.Transparent;
            this.button_ok.IdleIconLeftImage = null;
            this.button_ok.IdleIconRightImage = null;
            this.button_ok.IndicateFocus = false;
            this.button_ok.Location = new System.Drawing.Point(93, 103);
            this.button_ok.Name = "button_ok";
            this.button_ok.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_ok.OnDisabledState.BorderRadius = 20;
            this.button_ok.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_ok.OnDisabledState.BorderThickness = 1;
            this.button_ok.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_ok.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_ok.OnDisabledState.IconLeftImage = null;
            this.button_ok.OnDisabledState.IconRightImage = null;
            this.button_ok.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.button_ok.onHoverState.BorderRadius = 20;
            this.button_ok.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_ok.onHoverState.BorderThickness = 1;
            this.button_ok.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.button_ok.onHoverState.ForeColor = System.Drawing.Color.White;
            this.button_ok.onHoverState.IconLeftImage = null;
            this.button_ok.onHoverState.IconRightImage = null;
            this.button_ok.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.button_ok.OnIdleState.BorderRadius = 20;
            this.button_ok.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_ok.OnIdleState.BorderThickness = 1;
            this.button_ok.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.button_ok.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.button_ok.OnIdleState.IconLeftImage = null;
            this.button_ok.OnIdleState.IconRightImage = null;
            this.button_ok.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button_ok.OnPressedState.BorderRadius = 20;
            this.button_ok.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_ok.OnPressedState.BorderThickness = 1;
            this.button_ok.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button_ok.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.button_ok.OnPressedState.IconLeftImage = null;
            this.button_ok.OnPressedState.IconRightImage = null;
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 25;
            this.button_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_ok.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_ok.TextMarginLeft = 0;
            this.button_ok.TextPadding = new System.Windows.Forms.Padding(0);
            this.button_ok.UseDefaultRadiusAndThickness = true;
            this.button_ok.Click += new System.EventHandler(this.button_no_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 26;
            // 
            // label_question
            // 
            this.label_question.Location = new System.Drawing.Point(12, 43);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(235, 57);
            this.label_question.TabIndex = 27;
            this.label_question.Text = "All files have been renamed successfully";
            // 
            // Popupok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(259, 138);
            this.Controls.Add(this.label_question);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.border);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Popupok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popup";
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 button_ok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_question;
    }
}