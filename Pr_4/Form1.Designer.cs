namespace Pr_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            labelListPartners = new Label();
            panelFill = new Panel();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelListPartners);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(800, 77);
            panelTop.TabIndex = 0;
            // 
            // labelListPartners
            // 
            labelListPartners.Dock = DockStyle.Fill;
            labelListPartners.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelListPartners.Location = new Point(10, 10);
            labelListPartners.Name = "labelListPartners";
            labelListPartners.Size = new Size(780, 57);
            labelListPartners.TabIndex = 0;
            labelListPartners.Text = "Список партнеров:";
            labelListPartners.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFill
            // 
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 77);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(800, 373);
            panelFill.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFill);
            Controls.Add(panelTop);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelListPartners;
        private Panel panelFill;
    }
}
