namespace MegaDesk_Hester
{
    partial class SearchQuotes
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
            this.components = new System.ComponentModel.Container();
            this.BackButton = new System.Windows.Forms.Button();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.searchQuotesView = new System.Windows.Forms.DataGridView();
            this.deskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(10, 11);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(56, 19);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // materialComboBox
            // 
            this.materialComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deskBindingSource, "SurfaceMaterial", true));
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(363, 9);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(225, 21);
            this.materialComboBox.TabIndex = 1;
            this.materialComboBox.SelectedIndexChanged += new System.EventHandler(this.MaterialComboBox_SelectedIndexChanged);
            // 
            // searchQuotesView
            // 
            this.searchQuotesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchQuotesView.Location = new System.Drawing.Point(13, 36);
            this.searchQuotesView.Name = "searchQuotesView";
            this.searchQuotesView.Size = new System.Drawing.Size(575, 318);
            this.searchQuotesView.TabIndex = 2;
            // 
            // deskBindingSource
            // 
            this.deskBindingSource.DataSource = typeof(MegaDesk_Hester.Desk);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.searchQuotesView);
            this.Controls.Add(this.materialComboBox);
            this.Controls.Add(this.BackButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchQuotes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.BindingSource deskBindingSource;
        private System.Windows.Forms.DataGridView searchQuotesView;
    }
}