
namespace Miia.window
{
    partial class Popup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popup));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.border = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_yes = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.button_no = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
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
            // button_yes
            // 
            this.button_yes.AllowAnimations = true;
            this.button_yes.AllowMouseEffects = true;
            this.button_yes.AllowToggling = false;
            this.button_yes.AnimationSpeed = 200;
            this.button_yes.AutoGenerateColors = false;
            this.button_yes.AutoRoundBorders = false;
            this.button_yes.AutoSizeLeftIcon = true;
            this.button_yes.AutoSizeRightIcon = true;
            this.button_yes.BackColor = System.Drawing.Color.Transparent;
            this.button_yes.BackColor1 = System.Drawing.Color.Transparent;
            this.button_yes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_yes.BackgroundImage")));
            this.button_yes.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_yes.ButtonText = "Yes";
            this.button_yes.ButtonTextMarginLeft = 0;
            this.button_yes.ColorContrastOnClick = 45;
            this.button_yes.ColorContrastOnHover = 45;
            this.button_yes.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.button_yes.CustomizableEdges = borderEdges1;
            this.button_yes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_yes.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_yes.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_yes.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_yes.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.button_yes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_yes.ForeColor = System.Drawing.Color.White;
            this.button_yes.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_yes.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.button_yes.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.button_yes.IconMarginLeft = 11;
            this.button_yes.IconPadding = 10;
            this.button_yes.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_yes.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.button_yes.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.button_yes.IconSize = 25;
            this.button_yes.IdleBorderColor = System.Drawing.Color.White;
            this.button_yes.IdleBorderRadius = 20;
            this.button_yes.IdleBorderThickness = 1;
            this.button_yes.IdleFillColor = System.Drawing.Color.Transparent;
            this.button_yes.IdleIconLeftImage = null;
            this.button_yes.IdleIconRightImage = null;
            this.button_yes.IndicateFocus = false;
            this.button_yes.Location = new System.Drawing.Point(48, 103);
            this.button_yes.Name = "button_yes";
            this.button_yes.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_yes.OnDisabledState.BorderRadius = 20;
            this.button_yes.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_yes.OnDisabledState.BorderThickness = 1;
            this.button_yes.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_yes.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_yes.OnDisabledState.IconLeftImage = null;
            this.button_yes.OnDisabledState.IconRightImage = null;
            this.button_yes.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.button_yes.onHoverState.BorderRadius = 20;
            this.button_yes.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_yes.onHoverState.BorderThickness = 1;
            this.button_yes.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.button_yes.onHoverState.ForeColor = System.Drawing.Color.White;
            this.button_yes.onHoverState.IconLeftImage = null;
            this.button_yes.onHoverState.IconRightImage = null;
            this.button_yes.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.button_yes.OnIdleState.BorderRadius = 20;
            this.button_yes.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_yes.OnIdleState.BorderThickness = 1;
            this.button_yes.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.button_yes.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.button_yes.OnIdleState.IconLeftImage = null;
            this.button_yes.OnIdleState.IconRightImage = null;
            this.button_yes.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button_yes.OnPressedState.BorderRadius = 20;
            this.button_yes.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_yes.OnPressedState.BorderThickness = 1;
            this.button_yes.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button_yes.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.button_yes.OnPressedState.IconLeftImage = null;
            this.button_yes.OnPressedState.IconRightImage = null;
            this.button_yes.Size = new System.Drawing.Size(75, 23);
            this.button_yes.TabIndex = 24;
            this.button_yes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_yes.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_yes.TextMarginLeft = 0;
            this.button_yes.TextPadding = new System.Windows.Forms.Padding(0);
            this.button_yes.UseDefaultRadiusAndThickness = true;
            this.button_yes.Click += new System.EventHandler(this.button_yes_Click);
            // 
            // button_no
            // 
            this.button_no.AllowAnimations = true;
            this.button_no.AllowMouseEffects = true;
            this.button_no.AllowToggling = false;
            this.button_no.AnimationSpeed = 200;
            this.button_no.AutoGenerateColors = false;
            this.button_no.AutoRoundBorders = false;
            this.button_no.AutoSizeLeftIcon = true;
            this.button_no.AutoSizeRightIcon = true;
            this.button_no.BackColor = System.Drawing.Color.Transparent;
            this.button_no.BackColor1 = System.Drawing.Color.Transparent;
            this.button_no.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_no.BackgroundImage")));
            this.button_no.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_no.ButtonText = "No";
            this.button_no.ButtonTextMarginLeft = 0;
            this.button_no.ColorContrastOnClick = 45;
            this.button_no.ColorContrastOnHover = 45;
            this.button_no.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.button_no.CustomizableEdges = borderEdges2;
            this.button_no.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_no.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_no.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_no.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_no.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.button_no.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_no.ForeColor = System.Drawing.Color.White;
            this.button_no.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_no.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.button_no.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.button_no.IconMarginLeft = 11;
            this.button_no.IconPadding = 10;
            this.button_no.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_no.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.button_no.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.button_no.IconSize = 25;
            this.button_no.IdleBorderColor = System.Drawing.Color.White;
            this.button_no.IdleBorderRadius = 20;
            this.button_no.IdleBorderThickness = 1;
            this.button_no.IdleFillColor = System.Drawing.Color.Transparent;
            this.button_no.IdleIconLeftImage = null;
            this.button_no.IdleIconRightImage = null;
            this.button_no.IndicateFocus = false;
            this.button_no.Location = new System.Drawing.Point(129, 103);
            this.button_no.Name = "button_no";
            this.button_no.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_no.OnDisabledState.BorderRadius = 20;
            this.button_no.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_no.OnDisabledState.BorderThickness = 1;
            this.button_no.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_no.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_no.OnDisabledState.IconLeftImage = null;
            this.button_no.OnDisabledState.IconRightImage = null;
            this.button_no.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.button_no.onHoverState.BorderRadius = 20;
            this.button_no.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_no.onHoverState.BorderThickness = 1;
            this.button_no.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.button_no.onHoverState.ForeColor = System.Drawing.Color.White;
            this.button_no.onHoverState.IconLeftImage = null;
            this.button_no.onHoverState.IconRightImage = null;
            this.button_no.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.button_no.OnIdleState.BorderRadius = 20;
            this.button_no.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_no.OnIdleState.BorderThickness = 1;
            this.button_no.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.button_no.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.button_no.OnIdleState.IconLeftImage = null;
            this.button_no.OnIdleState.IconRightImage = null;
            this.button_no.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button_no.OnPressedState.BorderRadius = 20;
            this.button_no.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.button_no.OnPressedState.BorderThickness = 1;
            this.button_no.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button_no.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.button_no.OnPressedState.IconLeftImage = null;
            this.button_no.OnPressedState.IconRightImage = null;
            this.button_no.Size = new System.Drawing.Size(75, 23);
            this.button_no.TabIndex = 25;
            this.button_no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_no.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_no.TextMarginLeft = 0;
            this.button_no.TextPadding = new System.Windows.Forms.Padding(0);
            this.button_no.UseDefaultRadiusAndThickness = true;
            this.button_no.Click += new System.EventHandler(this.button_no_Click);
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
            this.label_question.Text = "unknown";
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(259, 138);
            this.Controls.Add(this.label_question);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_no);
            this.Controls.Add(this.button_yes);
            this.Controls.Add(this.border);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Popup";
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 button_yes;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 button_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_question;
    }
}