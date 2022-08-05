namespace EntityDesktop
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pbCategory = new System.Windows.Forms.PictureBox();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.pbStatistics = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCategory
            // 
            this.pbCategory.BackColor = System.Drawing.Color.Transparent;
            this.pbCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCategory.Image = global::EntityDesktop.Properties.Resources.icons8_categorize_128px;
            this.pbCategory.Location = new System.Drawing.Point(258, 213);
            this.pbCategory.Name = "pbCategory";
            this.pbCategory.Size = new System.Drawing.Size(120, 120);
            this.pbCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCategory.TabIndex = 0;
            this.pbCategory.TabStop = false;
            this.pbCategory.Click += new System.EventHandler(this.pbCategory_Click);
            // 
            // pbProduct
            // 
            this.pbProduct.BackColor = System.Drawing.Color.Transparent;
            this.pbProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProduct.Image = global::EntityDesktop.Properties.Resources.icons8_product_128px;
            this.pbProduct.Location = new System.Drawing.Point(384, 213);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(120, 120);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProduct.TabIndex = 1;
            this.pbProduct.TabStop = false;
            this.pbProduct.Click += new System.EventHandler(this.pbProduct_Click);
            // 
            // pbStatistics
            // 
            this.pbStatistics.BackColor = System.Drawing.Color.Transparent;
            this.pbStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStatistics.Image = global::EntityDesktop.Properties.Resources.icons8_statistics_128px;
            this.pbStatistics.Location = new System.Drawing.Point(510, 213);
            this.pbStatistics.Name = "pbStatistics";
            this.pbStatistics.Size = new System.Drawing.Size(120, 120);
            this.pbStatistics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStatistics.TabIndex = 2;
            this.pbStatistics.TabStop = false;
            this.pbStatistics.Click += new System.EventHandler(this.pbStatistics_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(276, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(408, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(529, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Statistics";
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = global::EntityDesktop.Properties.Resources.icons8_close_48px;
            this.pbExit.Location = new System.Drawing.Point(844, 12);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(32, 32);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 6;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orchid;
            this.label4.Location = new System.Drawing.Point(339, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 46);
            this.label4.TabIndex = 32;
            this.label4.Text = "Main Menu";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EntityDesktop.Properties.Resources.purple_white_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 546);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbStatistics);
            this.Controls.Add(this.pbProduct);
            this.Controls.Add(this.pbCategory);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.pbCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCategory;
        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.PictureBox pbStatistics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Label label4;
    }
}