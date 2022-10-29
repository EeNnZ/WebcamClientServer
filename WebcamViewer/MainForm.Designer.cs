namespace WebcamViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.splitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.connectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showIPAddressesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1342, 721);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.splitButton,
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 695);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1342, 26);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // splitButton
            // 
            this.splitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.splitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectMenuItem,
            this.showIPAddressesMenuItem});
            this.splitButton.Image = ((System.Drawing.Image)(resources.GetObject("splitButton.Image")));
            this.splitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.splitButton.Name = "splitButton";
            this.splitButton.Size = new System.Drawing.Size(65, 24);
            this.splitButton.Text = "Menu";
            // 
            // connectMenuItem
            // 
            this.connectMenuItem.Name = "connectMenuItem";
            this.connectMenuItem.Size = new System.Drawing.Size(224, 26);
            this.connectMenuItem.Text = "Connect";
            // 
            // showIPAddressesMenuItem
            // 
            this.showIPAddressesMenuItem.Name = "showIPAddressesMenuItem";
            this.showIPAddressesMenuItem.Size = new System.Drawing.Size(224, 26);
            this.showIPAddressesMenuItem.Text = "Show IP Addresses";
            this.showIPAddressesMenuItem.Click += new System.EventHandler(this.ShowIPAddressesMenuItemClick);
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(151, 20);
            this.statusLabel.Text = "toolStripStatusLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 721);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripSplitButton splitButton;
        private System.Windows.Forms.ToolStripMenuItem connectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showIPAddressesMenuItem;
    }
}

