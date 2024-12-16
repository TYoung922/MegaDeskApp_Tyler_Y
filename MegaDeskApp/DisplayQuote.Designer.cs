namespace MegaDeskApp
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
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.specifications = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            this.labelDrawers = new System.Windows.Forms.Label();
            this.labelTotSize = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelShip = new System.Windows.Forms.Label();
            this.cusName = new System.Windows.Forms.Label();
            this.currentDate = new System.Windows.Forms.Label();
            this.cusWidth = new System.Windows.Forms.Label();
            this.cusDepth = new System.Windows.Forms.Label();
            this.cusDrawers = new System.Windows.Forms.Label();
            this.cusTotal = new System.Windows.Forms.Label();
            this.cusMaterial = new System.Windows.Forms.Label();
            this.cusShip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn.Location = new System.Drawing.Point(12, 386);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(198, 52);
            this.mainMenuBtn.TabIndex = 3;
            this.mainMenuBtn.Text = "Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(35, 21);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(128, 20);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Customer Name:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(35, 54);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(96, 20);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "Quote Date:";
            // 
            // specifications
            // 
            this.specifications.AutoSize = true;
            this.specifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specifications.Location = new System.Drawing.Point(35, 107);
            this.specifications.Name = "specifications";
            this.specifications.Size = new System.Drawing.Size(108, 20);
            this.specifications.TabIndex = 6;
            this.specifications.Text = "Specifications";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidth.Location = new System.Drawing.Point(35, 142);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(54, 20);
            this.labelWidth.TabIndex = 7;
            this.labelWidth.Text = "Width:";
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepth.Location = new System.Drawing.Point(35, 183);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(57, 20);
            this.labelDepth.TabIndex = 8;
            this.labelDepth.Text = "Depth:";
            // 
            // labelDrawers
            // 
            this.labelDrawers.AutoSize = true;
            this.labelDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrawers.Location = new System.Drawing.Point(35, 221);
            this.labelDrawers.Name = "labelDrawers";
            this.labelDrawers.Size = new System.Drawing.Size(72, 20);
            this.labelDrawers.TabIndex = 9;
            this.labelDrawers.Text = "Drawers:";
            // 
            // labelTotSize
            // 
            this.labelTotSize.AutoSize = true;
            this.labelTotSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotSize.Location = new System.Drawing.Point(35, 263);
            this.labelTotSize.Name = "labelTotSize";
            this.labelTotSize.Size = new System.Drawing.Size(115, 20);
            this.labelTotSize.TabIndex = 10;
            this.labelTotSize.Text = "Total Size in ^2";
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterial.Location = new System.Drawing.Point(35, 304);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(107, 20);
            this.labelMaterial.TabIndex = 11;
            this.labelMaterial.Text = "Material Type:";
            // 
            // labelShip
            // 
            this.labelShip.AutoSize = true;
            this.labelShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShip.Location = new System.Drawing.Point(35, 344);
            this.labelShip.Name = "labelShip";
            this.labelShip.Size = new System.Drawing.Size(150, 20);
            this.labelShip.TabIndex = 12;
            this.labelShip.Text = "Order Delivery Time:";
            // 
            // cusName
            // 
            this.cusName.AutoSize = true;
            this.cusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusName.Location = new System.Drawing.Point(298, 21);
            this.cusName.Name = "cusName";
            this.cusName.Size = new System.Drawing.Size(78, 20);
            this.cusName.TabIndex = 13;
            this.cusName.Text = "Customer";
            // 
            // currentDate
            // 
            this.currentDate.AutoSize = true;
            this.currentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDate.Location = new System.Drawing.Point(298, 54);
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(95, 20);
            this.currentDate.TabIndex = 14;
            this.currentDate.Text = "current date";
            // 
            // cusWidth
            // 
            this.cusWidth.AutoSize = true;
            this.cusWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusWidth.Location = new System.Drawing.Point(298, 142);
            this.cusWidth.Name = "cusWidth";
            this.cusWidth.Size = new System.Drawing.Size(78, 20);
            this.cusWidth.TabIndex = 15;
            this.cusWidth.Text = "Customer";
            // 
            // cusDepth
            // 
            this.cusDepth.AutoSize = true;
            this.cusDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusDepth.Location = new System.Drawing.Point(298, 183);
            this.cusDepth.Name = "cusDepth";
            this.cusDepth.Size = new System.Drawing.Size(78, 20);
            this.cusDepth.TabIndex = 16;
            this.cusDepth.Text = "Customer";
            // 
            // cusDrawers
            // 
            this.cusDrawers.AutoSize = true;
            this.cusDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusDrawers.Location = new System.Drawing.Point(298, 221);
            this.cusDrawers.Name = "cusDrawers";
            this.cusDrawers.Size = new System.Drawing.Size(78, 20);
            this.cusDrawers.TabIndex = 17;
            this.cusDrawers.Text = "Customer";
            // 
            // cusTotal
            // 
            this.cusTotal.AutoSize = true;
            this.cusTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusTotal.Location = new System.Drawing.Point(298, 263);
            this.cusTotal.Name = "cusTotal";
            this.cusTotal.Size = new System.Drawing.Size(78, 20);
            this.cusTotal.TabIndex = 18;
            this.cusTotal.Text = "Customer";
            // 
            // cusMaterial
            // 
            this.cusMaterial.AutoSize = true;
            this.cusMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusMaterial.Location = new System.Drawing.Point(298, 304);
            this.cusMaterial.Name = "cusMaterial";
            this.cusMaterial.Size = new System.Drawing.Size(78, 20);
            this.cusMaterial.TabIndex = 19;
            this.cusMaterial.Text = "Customer";
            // 
            // cusShip
            // 
            this.cusShip.AutoSize = true;
            this.cusShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusShip.Location = new System.Drawing.Point(298, 344);
            this.cusShip.Name = "cusShip";
            this.cusShip.Size = new System.Drawing.Size(78, 20);
            this.cusShip.TabIndex = 20;
            this.cusShip.Text = "Customer";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.cusShip);
            this.Controls.Add(this.cusMaterial);
            this.Controls.Add(this.cusTotal);
            this.Controls.Add(this.cusDrawers);
            this.Controls.Add(this.cusDepth);
            this.Controls.Add(this.cusWidth);
            this.Controls.Add(this.currentDate);
            this.Controls.Add(this.cusName);
            this.Controls.Add(this.labelShip);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelTotSize);
            this.Controls.Add(this.labelDrawers);
            this.Controls.Add(this.labelDepth);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.specifications);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.mainMenuBtn);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label specifications;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.Label labelDrawers;
        private System.Windows.Forms.Label labelTotSize;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelShip;
        private System.Windows.Forms.Label cusName;
        private System.Windows.Forms.Label currentDate;
        private System.Windows.Forms.Label cusWidth;
        private System.Windows.Forms.Label cusDepth;
        private System.Windows.Forms.Label cusDrawers;
        private System.Windows.Forms.Label cusTotal;
        private System.Windows.Forms.Label cusMaterial;
        private System.Windows.Forms.Label cusShip;
    }
}