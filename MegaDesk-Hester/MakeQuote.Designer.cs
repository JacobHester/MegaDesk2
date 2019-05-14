namespace MegaDesk_Hester
{
    partial class MakeQuote
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
            this.CancelNewForm = new System.Windows.Forms.Button();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.WidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DepthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.DrawersLabel = new System.Windows.Forms.Label();
            this.DrawersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RushLabel = new System.Windows.Forms.Label();
            this.SampleLabel = new System.Windows.Forms.Label();
            this.SamplePic = new System.Windows.Forms.PictureBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.PlaceOrder = new System.Windows.Forms.Button();
            this.QuoteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawersNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamplePic)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelNewForm
            // 
            this.CancelNewForm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CancelNewForm.Location = new System.Drawing.Point(12, 12);
            this.CancelNewForm.Name = "CancelNewForm";
            this.CancelNewForm.Size = new System.Drawing.Size(75, 23);
            this.CancelNewForm.TabIndex = 0;
            this.CancelNewForm.Text = "Cancel";
            this.CancelNewForm.UseVisualStyleBackColor = false;
            this.CancelNewForm.Click += new System.EventHandler(this.CancelNewForm_Click);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(12, 69);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(48, 17);
            this.WidthLabel.TabIndex = 1;
            this.WidthLabel.Text = "Width:";
            // 
            // WidthNumericUpDown
            // 
            this.WidthNumericUpDown.Location = new System.Drawing.Point(155, 64);
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
            this.WidthNumericUpDown.TabIndex = 2;
            this.WidthNumericUpDown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // DepthNumericUpDown
            // 
            this.DepthNumericUpDown.Location = new System.Drawing.Point(155, 108);
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
            this.DepthNumericUpDown.TabIndex = 4;
            this.DepthNumericUpDown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Location = new System.Drawing.Point(12, 113);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(50, 17);
            this.DepthLabel.TabIndex = 3;
            this.DepthLabel.Text = "Depth:";
            // 
            // DrawersLabel
            // 
            this.DrawersLabel.AutoSize = true;
            this.DrawersLabel.Location = new System.Drawing.Point(12, 153);
            this.DrawersLabel.Name = "DrawersLabel";
            this.DrawersLabel.Size = new System.Drawing.Size(133, 17);
            this.DrawersLabel.TabIndex = 5;
            this.DrawersLabel.Text = "Number Of Drawers";
            // 
            // DrawersNumericUpDown
            // 
            this.DrawersNumericUpDown.Location = new System.Drawing.Point(155, 153);
            this.DrawersNumericUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.DrawersNumericUpDown.Name = "DrawersNumericUpDown";
            this.DrawersNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.DrawersNumericUpDown.TabIndex = 6;
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Location = new System.Drawing.Point(12, 194);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(111, 17);
            this.MaterialLabel.TabIndex = 7;
            this.MaterialLabel.Text = "Surface Material";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Rosewood",
            "Pine",
            "Veneer"});
            this.listBox1.Location = new System.Drawing.Point(155, 194);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "No Rush 14 Day",
            "3 Day Rush",
            "5 Day Rush",
            "7 Day Rush"});
            this.comboBox1.Location = new System.Drawing.Point(155, 297);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // RushLabel
            // 
            this.RushLabel.AutoSize = true;
            this.RushLabel.Location = new System.Drawing.Point(12, 297);
            this.RushLabel.Name = "RushLabel";
            this.RushLabel.Size = new System.Drawing.Size(100, 17);
            this.RushLabel.TabIndex = 10;
            this.RushLabel.Text = "Rush Shipping";
            // 
            // SampleLabel
            // 
            this.SampleLabel.AutoSize = true;
            this.SampleLabel.Location = new System.Drawing.Point(345, 64);
            this.SampleLabel.Name = "SampleLabel";
            this.SampleLabel.Size = new System.Drawing.Size(204, 17);
            this.SampleLabel.TabIndex = 11;
            this.SampleLabel.Text = "Pick a material to see a sample";
            // 
            // SamplePic
            // 
            this.SamplePic.Location = new System.Drawing.Point(348, 124);
            this.SamplePic.Name = "SamplePic";
            this.SamplePic.Size = new System.Drawing.Size(215, 197);
            this.SamplePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SamplePic.TabIndex = 12;
            this.SamplePic.TabStop = false;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(630, 108);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(141, 29);
            this.CostLabel.TabIndex = 13;
            this.CostLabel.Text = "Total Price:";
            // 
            // PlaceOrder
            // 
            this.PlaceOrder.Location = new System.Drawing.Point(645, 268);
            this.PlaceOrder.Name = "PlaceOrder";
            this.PlaceOrder.Size = new System.Drawing.Size(126, 53);
            this.PlaceOrder.TabIndex = 14;
            this.PlaceOrder.Text = "Place Order";
            this.PlaceOrder.UseVisualStyleBackColor = true;
            this.PlaceOrder.Click += new System.EventHandler(this.PlaceOrder_Click);
            // 
            // QuoteLabel
            // 
            this.QuoteLabel.AutoSize = true;
            this.QuoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteLabel.Location = new System.Drawing.Point(695, 153);
            this.QuoteLabel.Name = "QuoteLabel";
            this.QuoteLabel.Size = new System.Drawing.Size(76, 29);
            this.QuoteLabel.TabIndex = 15;
            this.QuoteLabel.Text = "quote";
            // 
            // MakeQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuoteLabel);
            this.Controls.Add(this.PlaceOrder);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.SamplePic);
            this.Controls.Add(this.SampleLabel);
            this.Controls.Add(this.RushLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.DrawersNumericUpDown);
            this.Controls.Add(this.DrawersLabel);
            this.Controls.Add(this.DepthNumericUpDown);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.WidthNumericUpDown);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.CancelNewForm);
            this.Name = "MakeQuote";
            this.Text = "MakeQuote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MakeQuote_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawersNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamplePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelNewForm;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.NumericUpDown WidthNumericUpDown;
        private System.Windows.Forms.NumericUpDown DepthNumericUpDown;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.Label DrawersLabel;
        private System.Windows.Forms.NumericUpDown DrawersNumericUpDown;
        private System.Windows.Forms.Label MaterialLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label RushLabel;
        private System.Windows.Forms.Label SampleLabel;
        private System.Windows.Forms.PictureBox SamplePic;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Button PlaceOrder;
        private System.Windows.Forms.Label QuoteLabel;
    }
}