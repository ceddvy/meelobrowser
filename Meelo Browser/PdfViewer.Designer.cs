
namespace Meelo_Browser
{
    partial class PdfViewer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClear = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSelect = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pdfPanel = new System.Windows.Forms.Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Tomato;
            this.guna2Panel1.Controls.Add(this.btnClear);
            this.guna2Panel1.Controls.Add(this.btnSelect);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(944, 46);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Animated = true;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderColor = System.Drawing.Color.Crimson;
            this.btnClear.BorderRadius = 15;
            this.btnClear.BorderThickness = 2;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomBorderColor = System.Drawing.Color.Black;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.FillColor = System.Drawing.Color.Empty;
            this.btnClear.FillColor2 = System.Drawing.Color.Empty;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.FillColor = System.Drawing.Color.Crimson;
            this.btnClear.HoverState.FillColor2 = System.Drawing.Color.Red;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Location = new System.Drawing.Point(690, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(144, 35);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear Pdf Screen";
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Animated = true;
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSelect.BorderRadius = 15;
            this.btnSelect.BorderThickness = 2;
            this.btnSelect.CheckedState.Parent = this.btnSelect;
            this.btnSelect.CustomBorderColor = System.Drawing.Color.Black;
            this.btnSelect.CustomImages.Parent = this.btnSelect;
            this.btnSelect.FillColor = System.Drawing.Color.Empty;
            this.btnSelect.FillColor2 = System.Drawing.Color.Empty;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.HoverState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSelect.HoverState.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.btnSelect.HoverState.Parent = this.btnSelect;
            this.btnSelect.Location = new System.Drawing.Point(840, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.ShadowDecoration.Parent = this.btnSelect;
            this.btnSelect.Size = new System.Drawing.Size(90, 35);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select File";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pdfPanel
            // 
            this.pdfPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfPanel.Location = new System.Drawing.Point(0, 44);
            this.pdfPanel.Name = "pdfPanel";
            this.pdfPanel.Size = new System.Drawing.Size(944, 481);
            this.pdfPanel.TabIndex = 1;
            // 
            // PdfViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pdfPanel);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "PdfViewer";
            this.Size = new System.Drawing.Size(944, 525);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSelect;
        private System.Windows.Forms.Panel pdfPanel;
        private Guna.UI2.WinForms.Guna2GradientButton btnClear;
    }
}
