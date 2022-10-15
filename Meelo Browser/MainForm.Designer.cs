
namespace Meelo_Browser
{
    partial class MainForm
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
            this.addBtn = new MetroFramework.Controls.MetroLink();
            this.removeBtn = new MetroFramework.Controls.MetroLink();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackgroundImage = global::Meelo_Browser.Properties.Resources.add_64px;
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addBtn.Location = new System.Drawing.Point(19, 13);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(32, 32);
            this.addBtn.TabIndex = 1;
            this.addBtn.UseSelectable = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
            this.addBtn.MouseLeave += new System.EventHandler(this.addBtn_MouseLeave);
            this.addBtn.MouseHover += new System.EventHandler(this.addBtn_MouseHover);
            // 
            // removeBtn
            // 
            this.removeBtn.BackgroundImage = global::Meelo_Browser.Properties.Resources.close;
            this.removeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeBtn.Location = new System.Drawing.Point(57, 13);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(32, 32);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.UseSelectable = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            this.removeBtn.MouseLeave += new System.EventHandler(this.removeBtn_MouseLeave);
            this.removeBtn.MouseHover += new System.EventHandler(this.removeBtn_MouseHover);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Location = new System.Drawing.Point(4, 48);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.Size = new System.Drawing.Size(1081, 482);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 530);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "eelo";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLink addBtn;
        private MetroFramework.Controls.MetroLink removeBtn;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
    }
}

