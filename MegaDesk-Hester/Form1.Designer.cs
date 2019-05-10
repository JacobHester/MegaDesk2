namespace MegaDesk_Hester
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.NewQuote = new System.Windows.Forms.Button();
            this.ViewAll = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewQuote
            // 
            this.NewQuote.Location = new System.Drawing.Point(58, 32);
            this.NewQuote.Name = "NewQuote";
            this.NewQuote.Size = new System.Drawing.Size(122, 69);
            this.NewQuote.TabIndex = 0;
            this.NewQuote.Text = "&New Quote (n)";
            this.NewQuote.UseVisualStyleBackColor = true;
            this.NewQuote.Click += new System.EventHandler(this.NewQuote_Click);
            // 
            // ViewAll
            // 
            this.ViewAll.Location = new System.Drawing.Point(58, 135);
            this.ViewAll.Name = "ViewAll";
            this.ViewAll.Size = new System.Drawing.Size(122, 69);
            this.ViewAll.TabIndex = 1;
            this.ViewAll.Text = "&View All Quotes (v)";
            this.ViewAll.UseVisualStyleBackColor = true;
            this.ViewAll.Click += new System.EventHandler(this.ViewAll_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(58, 236);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(122, 69);
            this.Search.TabIndex = 2;
            this.Search.Text = "&Search Quotes (s)";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(58, 338);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(122, 69);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "E&xit (x)";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(290, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ViewAll);
            this.Controls.Add(this.NewQuote);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "HomeForm";
            this.Text = "MegaDesk-Hester";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewQuote;
        private System.Windows.Forms.Button ViewAll;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

