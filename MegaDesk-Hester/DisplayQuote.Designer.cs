namespace MegaDesk_Hester
{
    partial class DisplayQuote
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.QuoteLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.RushLabel = new System.Windows.Forms.Label();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.DrawersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DrawersLabel = new System.Windows.Forms.Label();
            this.DepthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.WidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.MaterialText = new System.Windows.Forms.TextBox();
            this.RushText = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DrawersNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(163, 66);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(121, 22);
            this.NameTextBox.TabIndex = 34;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(24, 72);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(113, 17);
            this.NameLabel.TabIndex = 33;
            this.NameLabel.Text = "Customer Name:";
            this.NameLabel.UseMnemonic = false;
            // 
            // QuoteLabel
            // 
            this.QuoteLabel.AutoSize = true;
            this.QuoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteLabel.Location = new System.Drawing.Point(454, 112);
            this.QuoteLabel.Name = "QuoteLabel";
            this.QuoteLabel.Size = new System.Drawing.Size(102, 39);
            this.QuoteLabel.TabIndex = 32;
            this.QuoteLabel.Text = "quote";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(454, 66);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(141, 29);
            this.CostLabel.TabIndex = 30;
            this.CostLabel.Text = "Total Price:";
            // 
            // RushLabel
            // 
            this.RushLabel.AutoSize = true;
            this.RushLabel.Location = new System.Drawing.Point(21, 300);
            this.RushLabel.Name = "RushLabel";
            this.RushLabel.Size = new System.Drawing.Size(100, 17);
            this.RushLabel.TabIndex = 27;
            this.RushLabel.Text = "Rush Shipping";
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Location = new System.Drawing.Point(21, 256);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(111, 17);
            this.MaterialLabel.TabIndex = 24;
            this.MaterialLabel.Text = "Surface Material";
            // 
            // DrawersNumericUpDown
            // 
            this.DrawersNumericUpDown.Location = new System.Drawing.Point(164, 205);
            this.DrawersNumericUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.DrawersNumericUpDown.Name = "DrawersNumericUpDown";
            this.DrawersNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.DrawersNumericUpDown.TabIndex = 23;
            // 
            // DrawersLabel
            // 
            this.DrawersLabel.AutoSize = true;
            this.DrawersLabel.Location = new System.Drawing.Point(21, 207);
            this.DrawersLabel.Name = "DrawersLabel";
            this.DrawersLabel.Size = new System.Drawing.Size(133, 17);
            this.DrawersLabel.TabIndex = 22;
            this.DrawersLabel.Text = "Number Of Drawers";
            // 
            // DepthNumericUpDown
            // 
            this.DepthNumericUpDown.Location = new System.Drawing.Point(164, 157);
            this.DepthNumericUpDown.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.DepthNumericUpDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DepthNumericUpDown.Name = "DepthNumericUpDown";
            this.DepthNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.DepthNumericUpDown.TabIndex = 21;
            this.DepthNumericUpDown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Location = new System.Drawing.Point(21, 162);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(50, 17);
            this.DepthLabel.TabIndex = 20;
            this.DepthLabel.Text = "Depth:";
            // 
            // WidthNumericUpDown
            // 
            this.WidthNumericUpDown.Location = new System.Drawing.Point(164, 112);
            this.WidthNumericUpDown.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.WidthNumericUpDown.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.WidthNumericUpDown.Name = "WidthNumericUpDown";
            this.WidthNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.WidthNumericUpDown.TabIndex = 19;
            this.WidthNumericUpDown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(21, 117);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(48, 17);
            this.WidthLabel.TabIndex = 18;
            this.WidthLabel.Text = "Width:";
            // 
            // MaterialText
            // 
            this.MaterialText.Location = new System.Drawing.Point(163, 256);
            this.MaterialText.Name = "MaterialText";
            this.MaterialText.Size = new System.Drawing.Size(121, 22);
            this.MaterialText.TabIndex = 35;
            // 
            // RushText
            // 
            this.RushText.Location = new System.Drawing.Point(163, 300);
            this.RushText.Name = "RushText";
            this.RushText.Size = new System.Drawing.Size(121, 22);
            this.RushText.TabIndex = 36;
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(459, 205);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(134, 68);
            this.CloseButton.TabIndex = 37;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RushText);
            this.Controls.Add(this.MaterialText);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.QuoteLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.RushLabel);
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.DrawersNumericUpDown);
            this.Controls.Add(this.DrawersLabel);
            this.Controls.Add(this.DepthNumericUpDown);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.WidthNumericUpDown);
            this.Controls.Add(this.WidthLabel);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DisplayQuote_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DrawersNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label QuoteLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label RushLabel;
        private System.Windows.Forms.Label MaterialLabel;
        private System.Windows.Forms.NumericUpDown DrawersNumericUpDown;
        private System.Windows.Forms.Label DrawersLabel;
        private System.Windows.Forms.NumericUpDown DepthNumericUpDown;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.NumericUpDown WidthNumericUpDown;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox MaterialText;
        private System.Windows.Forms.TextBox RushText;
        private System.Windows.Forms.Button CloseButton;
    }
}