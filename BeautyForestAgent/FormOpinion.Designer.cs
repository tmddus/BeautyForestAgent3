namespace BeautyForestAgent
{
    partial class FormOpinion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpinion));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontBtn = new System.Windows.Forms.ToolStripButton();
            this.colorBtn = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontBtn,
            this.colorBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(731, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fontBtn
            // 
            this.fontBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontBtn.Image = ((System.Drawing.Image)(resources.GetObject("fontBtn.Image")));
            this.fontBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontBtn.Name = "fontBtn";
            this.fontBtn.Size = new System.Drawing.Size(23, 22);
            this.fontBtn.Text = "toolStripButton1";
            this.fontBtn.Click += new System.EventHandler(this.FontBtn_Click);
            // 
            // colorBtn
            // 
            this.colorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorBtn.Image = ((System.Drawing.Image)(resources.GetObject("colorBtn.Image")));
            this.colorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(23, 22);
            this.colorBtn.Text = "toolStripButton2";
            this.colorBtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(703, 383);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // FormOpinion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 449);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormOpinion";
            this.Text = "FormOpinion";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton fontBtn;
        private System.Windows.Forms.ToolStripButton colorBtn;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}