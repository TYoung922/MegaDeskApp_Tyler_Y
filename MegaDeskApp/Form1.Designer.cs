namespace MegaDeskApp
{
    partial class MainMenu
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
            this.newQuoteBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newQuoteBtn
            // 
            this.newQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuoteBtn.Location = new System.Drawing.Point(16, 15);
            this.newQuoteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newQuoteBtn.Name = "newQuoteBtn";
            this.newQuoteBtn.Size = new System.Drawing.Size(264, 64);
            this.newQuoteBtn.TabIndex = 0;
            this.newQuoteBtn.Text = "Add New Quote";
            this.newQuoteBtn.UseVisualStyleBackColor = true;
            this.newQuoteBtn.Click += new System.EventHandler(this.OpenNewQuote);
            // 
            // viewBtn
            // 
            this.viewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.Location = new System.Drawing.Point(16, 86);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(264, 64);
            this.viewBtn.TabIndex = 1;
            this.viewBtn.Text = "View Quotes";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.OpenViewQ);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(16, 158);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(264, 64);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search Quotes";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.OpenSearch);
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(16, 229);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(264, 64);
            this.exitbtn.TabIndex = 3;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MegaDeskApp.Properties.Resources.deskArt;
            this.pictureBox1.Location = new System.Drawing.Point(288, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 304);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.newQuoteBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newQuoteBtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

