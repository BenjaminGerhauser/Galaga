namespace Galaga
{
    partial class informacion
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
            components = new System.ComponentModel.Container();
            panelHijo = new Panel();
            lblPunto = new Label();
            lblTiempo = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // panelHijo
            // 
            panelHijo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panelHijo.Location = new Point(233, 0);
            panelHijo.Name = "panelHijo";
            panelHijo.Size = new Size(514, 765);
            panelHijo.TabIndex = 0;
            // 
            // lblPunto
            // 
            lblPunto.Anchor = AnchorStyles.Top;
            lblPunto.BorderStyle = BorderStyle.Fixed3D;
            lblPunto.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblPunto.ForeColor = Color.White;
            lblPunto.Location = new Point(49, 45);
            lblPunto.Name = "lblPunto";
            lblPunto.Size = new Size(123, 45);
            lblPunto.TabIndex = 1;
            lblPunto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTiempo
            // 
            lblTiempo.Anchor = AnchorStyles.Top;
            lblTiempo.BorderStyle = BorderStyle.Fixed3D;
            lblTiempo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTiempo.ForeColor = Color.White;
            lblTiempo.Location = new Point(801, 45);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(123, 45);
            lblTiempo.TabIndex = 2;
            lblTiempo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // informacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 16, 43);
            ClientSize = new Size(975, 764);
            Controls.Add(lblTiempo);
            Controls.Add(lblPunto);
            Controls.Add(panelHijo);
            Name = "informacion";
            Text = "informacion";
            WindowState = FormWindowState.Maximized;
            Load += informacion_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHijo;
        public Label lblPunto;
        public Label lblTiempo;
        private System.Windows.Forms.Timer timer1;
    }
}