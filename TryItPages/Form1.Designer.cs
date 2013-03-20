namespace TryItPages
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
            this.label1 = new System.Windows.Forms.Label();
            this.topTenUrl = new System.Windows.Forms.TextBox();
            this.urlResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.getTopTen = new System.Windows.Forms.Button();
            this.getWordFilter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter url to return top 10 used words or get filtered words:";
            // 
            // topTenUrl
            // 
            this.topTenUrl.Location = new System.Drawing.Point(22, 252);
            this.topTenUrl.Name = "topTenUrl";
            this.topTenUrl.Size = new System.Drawing.Size(515, 20);
            this.topTenUrl.TabIndex = 1;
            this.topTenUrl.Text = "http://";
            // 
            // urlResult
            // 
            this.urlResult.Location = new System.Drawing.Point(22, 291);
            this.urlResult.Multiline = true;
            this.urlResult.Name = "urlResult";
            this.urlResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.urlResult.Size = new System.Drawing.Size(674, 312);
            this.urlResult.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result:";
            // 
            // getTopTen
            // 
            this.getTopTen.Location = new System.Drawing.Point(543, 249);
            this.getTopTen.Name = "getTopTen";
            this.getTopTen.Size = new System.Drawing.Size(75, 23);
            this.getTopTen.TabIndex = 4;
            this.getTopTen.Text = "Top Ten";
            this.getTopTen.UseVisualStyleBackColor = true;
            this.getTopTen.Click += new System.EventHandler(this.getTopTen_Click);
            // 
            // getWordFilter
            // 
            this.getWordFilter.Location = new System.Drawing.Point(624, 249);
            this.getWordFilter.Name = "getWordFilter";
            this.getWordFilter.Size = new System.Drawing.Size(75, 23);
            this.getWordFilter.TabIndex = 5;
            this.getWordFilter.Text = "Word FIlter";
            this.getWordFilter.UseVisualStyleBackColor = true;
            this.getWordFilter.Click += new System.EventHandler(this.getWordFilter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 208);
            this.label3.TabIndex = 6;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 182);
            this.label4.TabIndex = 7;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 615);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.getWordFilter);
            this.Controls.Add(this.getTopTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.urlResult);
            this.Controls.Add(this.topTenUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox topTenUrl;
        private System.Windows.Forms.TextBox urlResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button getTopTen;
        private System.Windows.Forms.Button getWordFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

