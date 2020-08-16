namespace SineTable_Generator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.valCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minPeak = new System.Windows.Forms.NumericUpDown();
            this.saveC = new System.Windows.Forms.Button();
            this.generateButt = new System.Windows.Forms.Button();
            this.link = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.maxPeak = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tableCount = new System.Windows.Forms.NumericUpDown();
            this.sameArray = new System.Windows.Forms.CheckBox();
            this.cArray = new System.Windows.Forms.RichTextBox();
            this.halfTable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.valCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPeak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPeak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCount)).BeginInit();
            this.SuspendLayout();
            // 
            // valCount
            // 
            this.valCount.BackColor = System.Drawing.Color.LightYellow;
            this.valCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valCount.Location = new System.Drawing.Point(176, 14);
            this.valCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.valCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valCount.Name = "valCount";
            this.valCount.Size = new System.Drawing.Size(80, 26);
            this.valCount.TabIndex = 1;
            this.valCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Value Entries Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Min Peak Value:";
            // 
            // minPeak
            // 
            this.minPeak.BackColor = System.Drawing.Color.LightYellow;
            this.minPeak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minPeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minPeak.Location = new System.Drawing.Point(176, 46);
            this.minPeak.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.minPeak.Name = "minPeak";
            this.minPeak.Size = new System.Drawing.Size(80, 26);
            this.minPeak.TabIndex = 3;
            // 
            // saveC
            // 
            this.saveC.BackColor = System.Drawing.Color.LightYellow;
            this.saveC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveC.ForeColor = System.Drawing.Color.Black;
            this.saveC.Location = new System.Drawing.Point(493, 511);
            this.saveC.Name = "saveC";
            this.saveC.Size = new System.Drawing.Size(125, 30);
            this.saveC.TabIndex = 5;
            this.saveC.Text = "Save to File";
            this.saveC.UseVisualStyleBackColor = false;
            this.saveC.Click += new System.EventHandler(this.SaveC_Click);
            // 
            // generateButt
            // 
            this.generateButt.BackColor = System.Drawing.Color.LightYellow;
            this.generateButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButt.Location = new System.Drawing.Point(357, 511);
            this.generateButt.Name = "generateButt";
            this.generateButt.Size = new System.Drawing.Size(125, 30);
            this.generateButt.TabIndex = 7;
            this.generateButt.Text = "GENERATE";
            this.generateButt.UseVisualStyleBackColor = false;
            this.generateButt.Click += new System.EventHandler(this.generateButt_Click);
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link.Location = new System.Drawing.Point(15, 516);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(205, 20);
            this.link.TabIndex = 8;
            this.link.TabStop = true;
            this.link.Text = "Developed By Antor Ahmed";
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Max Peak Value:";
            // 
            // maxPeak
            // 
            this.maxPeak.BackColor = System.Drawing.Color.LightYellow;
            this.maxPeak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxPeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxPeak.Location = new System.Drawing.Point(399, 48);
            this.maxPeak.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.maxPeak.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxPeak.Name = "maxPeak";
            this.maxPeak.Size = new System.Drawing.Size(83, 26);
            this.maxPeak.TabIndex = 9;
            this.maxPeak.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Number of Table:";
            // 
            // tableCount
            // 
            this.tableCount.BackColor = System.Drawing.Color.LightYellow;
            this.tableCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableCount.Location = new System.Drawing.Point(399, 16);
            this.tableCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tableCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tableCount.Name = "tableCount";
            this.tableCount.Size = new System.Drawing.Size(83, 26);
            this.tableCount.TabIndex = 11;
            this.tableCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sameArray
            // 
            this.sameArray.AutoSize = true;
            this.sameArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sameArray.Location = new System.Drawing.Point(507, 18);
            this.sameArray.Name = "sameArray";
            this.sameArray.Size = new System.Drawing.Size(111, 24);
            this.sameArray.TabIndex = 13;
            this.sameArray.Text = "Same Array";
            this.sameArray.UseVisualStyleBackColor = true;
            // 
            // cArray
            // 
            this.cArray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cArray.Location = new System.Drawing.Point(22, 87);
            this.cArray.Name = "cArray";
            this.cArray.ReadOnly = true;
            this.cArray.Size = new System.Drawing.Size(596, 410);
            this.cArray.TabIndex = 14;
            this.cArray.Text = "";
            this.cArray.WordWrap = false;
            // 
            // halfTable
            // 
            this.halfTable.AutoSize = true;
            this.halfTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halfTable.Location = new System.Drawing.Point(507, 48);
            this.halfTable.Name = "halfTable";
            this.halfTable.Size = new System.Drawing.Size(100, 24);
            this.halfTable.TabIndex = 15;
            this.halfTable.Text = "Half Table";
            this.halfTable.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 554);
            this.Controls.Add(this.halfTable);
            this.Controls.Add(this.cArray);
            this.Controls.Add(this.sameArray);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxPeak);
            this.Controls.Add(this.link);
            this.Controls.Add(this.generateButt);
            this.Controls.Add(this.saveC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minPeak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SineTable Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPeak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPeak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown valCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown minPeak;
        private System.Windows.Forms.Button saveC;
        private System.Windows.Forms.Button generateButt;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown maxPeak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown tableCount;
        private System.Windows.Forms.CheckBox sameArray;
        private System.Windows.Forms.RichTextBox cArray;
        private System.Windows.Forms.CheckBox halfTable;
    }
}

