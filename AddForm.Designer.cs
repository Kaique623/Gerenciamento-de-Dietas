namespace Gerenciamento_de_Dietas
{
    partial class AddForm
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.CancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.ConfirmButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // CancelButton
            // 
            this.CancelButton.Animated = true;
            this.CancelButton.AutoRoundedCorners = true;
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.BorderRadius = 21;
            this.CancelButton.CustomizableEdges = customizableEdges1;
            this.guna2Transition1.SetDecoration(this.CancelButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelButton.FillColor = System.Drawing.Color.Gray;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.CancelButton.HoverState.FillColor = System.Drawing.Color.Red;
            this.CancelButton.Location = new System.Drawing.Point(227, 543);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.PressedColor = System.Drawing.Color.Gray;
            this.CancelButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.CancelButton.Size = new System.Drawing.Size(157, 45);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CancelButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Animated = true;
            this.ConfirmButton.AutoRoundedCorners = true;
            this.ConfirmButton.BorderRadius = 21;
            this.ConfirmButton.CustomizableEdges = customizableEdges3;
            this.guna2Transition1.SetDecoration(this.ConfirmButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ConfirmButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ConfirmButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ConfirmButton.FillColor = System.Drawing.Color.Gray;
            this.ConfirmButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConfirmButton.ForeColor = System.Drawing.Color.LightGreen;
            this.ConfirmButton.HoverState.FillColor = System.Drawing.Color.Green;
            this.ConfirmButton.Location = new System.Drawing.Point(27, 543);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.PressedColor = System.Drawing.Color.Gray;
            this.ConfirmButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.ConfirmButton.Size = new System.Drawing.Size(157, 45);
            this.ConfirmButton.TabIndex = 1;
            this.ConfirmButton.Text = "Confirmar";
            this.ConfirmButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(403, 607);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.CancelButton);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Button CancelButton;
        private Guna.UI2.WinForms.Guna2Button ConfirmButton;
        private Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1;
        private Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2;
        private Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3;
        private Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4;
        private Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5;
        private Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6;
    }
}