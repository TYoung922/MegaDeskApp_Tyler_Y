﻿namespace MegaDeskApp
{
    partial class AddQuote
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
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toDay = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.widthLabl = new System.Windows.Forms.Label();
            this.depthLabl = new System.Windows.Forms.Label();
            this.drawrsLabl = new System.Windows.Forms.Label();
            this.materialLabl = new System.Windows.Forms.Label();
            this.shipingLabl = new System.Windows.Forms.Label();
            this.currentDate = new System.Windows.Forms.Label();
            this.widthDisclaim = new System.Windows.Forms.Label();
            this.depthDisclaim = new System.Windows.Forms.Label();
            this.shipDiscalim = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.DepthBox = new System.Windows.Forms.TextBox();
            this.DrawerInput = new System.Windows.Forms.ComboBox();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.ShippingComboBox = new System.Windows.Forms.ComboBox();
            this.widthError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.widthError)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn.Location = new System.Drawing.Point(31, 428);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(198, 52);
            this.mainMenuBtn.TabIndex = 0;
            this.mainMenuBtn.Text = "Go Back";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.GoBack);
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(255, 428);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(198, 52);
            this.Submit.TabIndex = 1;
            this.Submit.Text = "Submint Order";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Order);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "MegaDesk";
            // 
            // toDay
            // 
            this.toDay.AutoSize = true;
            this.toDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDay.Location = new System.Drawing.Point(34, 84);
            this.toDay.Name = "toDay";
            this.toDay.Size = new System.Drawing.Size(119, 24);
            this.toDay.TabIndex = 3;
            this.toDay.Text = "Today\'s Date";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(36, 137);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(215, 24);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Please enter your name:";
            // 
            // widthLabl
            // 
            this.widthLabl.AutoSize = true;
            this.widthLabl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabl.Location = new System.Drawing.Point(36, 172);
            this.widthLabl.Name = "widthLabl";
            this.widthLabl.Size = new System.Drawing.Size(105, 24);
            this.widthLabl.TabIndex = 5;
            this.widthLabl.Text = "DeskWidth:";
            // 
            // depthLabl
            // 
            this.depthLabl.AutoSize = true;
            this.depthLabl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabl.Location = new System.Drawing.Point(36, 221);
            this.depthLabl.Name = "depthLabl";
            this.depthLabl.Size = new System.Drawing.Size(112, 24);
            this.depthLabl.TabIndex = 6;
            this.depthLabl.Text = "Desk Depth:";
            // 
            // drawrsLabl
            // 
            this.drawrsLabl.AutoSize = true;
            this.drawrsLabl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawrsLabl.Location = new System.Drawing.Point(36, 267);
            this.drawrsLabl.Name = "drawrsLabl";
            this.drawrsLabl.Size = new System.Drawing.Size(193, 24);
            this.drawrsLabl.TabIndex = 7;
            this.drawrsLabl.Text = "Desk Drawer Amount:";
            // 
            // materialLabl
            // 
            this.materialLabl.AutoSize = true;
            this.materialLabl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabl.Location = new System.Drawing.Point(36, 309);
            this.materialLabl.Name = "materialLabl";
            this.materialLabl.Size = new System.Drawing.Size(128, 24);
            this.materialLabl.TabIndex = 8;
            this.materialLabl.Text = "Material Type:";
            // 
            // shipingLabl
            // 
            this.shipingLabl.AutoSize = true;
            this.shipingLabl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipingLabl.Location = new System.Drawing.Point(36, 349);
            this.shipingLabl.Name = "shipingLabl";
            this.shipingLabl.Size = new System.Drawing.Size(185, 24);
            this.shipingLabl.TabIndex = 9;
            this.shipingLabl.Text = "Shipping Timeframe:";
            // 
            // currentDate
            // 
            this.currentDate.AutoSize = true;
            this.currentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDate.Location = new System.Drawing.Point(297, 84);
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(119, 24);
            this.currentDate.TabIndex = 10;
            this.currentDate.Text = "Today\'s Date";
            // 
            // widthDisclaim
            // 
            this.widthDisclaim.AutoSize = true;
            this.widthDisclaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthDisclaim.Location = new System.Drawing.Point(37, 196);
            this.widthDisclaim.Name = "widthDisclaim";
            this.widthDisclaim.Size = new System.Drawing.Size(118, 13);
            this.widthDisclaim.TabIndex = 11;
            this.widthDisclaim.Text = "min 24 in and max 96 in";
            // 
            // depthDisclaim
            // 
            this.depthDisclaim.AutoSize = true;
            this.depthDisclaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthDisclaim.Location = new System.Drawing.Point(37, 245);
            this.depthDisclaim.Name = "depthDisclaim";
            this.depthDisclaim.Size = new System.Drawing.Size(118, 13);
            this.depthDisclaim.TabIndex = 12;
            this.depthDisclaim.Text = "min 12 in and max 48 in";
            // 
            // shipDiscalim
            // 
            this.shipDiscalim.AutoSize = true;
            this.shipDiscalim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipDiscalim.Location = new System.Drawing.Point(37, 373);
            this.shipDiscalim.Name = "shipDiscalim";
            this.shipDiscalim.Size = new System.Drawing.Size(168, 13);
            this.shipDiscalim.TabIndex = 13;
            this.shipDiscalim.Text = "Express 3 days to standard 7 days";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(301, 137);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(143, 20);
            this.NameBox.TabIndex = 14;
            this.NameBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameBox_Validation);
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(301, 177);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(143, 20);
            this.WidthBox.TabIndex = 15;
            this.WidthBox.Validating += new System.ComponentModel.CancelEventHandler(this.WidthBox_Validating);
            // 
            // DepthBox
            // 
            this.DepthBox.Location = new System.Drawing.Point(301, 226);
            this.DepthBox.Name = "DepthBox";
            this.DepthBox.Size = new System.Drawing.Size(143, 20);
            this.DepthBox.TabIndex = 16;
            this.DepthBox.Validating += new System.ComponentModel.CancelEventHandler(this.Depth_validation);
            // 
            // DrawerInput
            // 
            this.DrawerInput.FormattingEnabled = true;
            this.DrawerInput.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.DrawerInput.Location = new System.Drawing.Point(301, 272);
            this.DrawerInput.Name = "DrawerInput";
            this.DrawerInput.Size = new System.Drawing.Size(143, 21);
            this.DrawerInput.TabIndex = 17;
            this.DrawerInput.Validating += new System.ComponentModel.CancelEventHandler(this.Drawer_Validation);
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Items.AddRange(new object[] {
            "Pine",
            "Laminate",
            "Veneer",
            "Oak",
            "Rosewood"});
            this.MaterialComboBox.Location = new System.Drawing.Point(301, 314);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(143, 21);
            this.MaterialComboBox.TabIndex = 18;
            this.MaterialComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.Material_Validation);
            // 
            // ShippingComboBox
            // 
            this.ShippingComboBox.FormattingEnabled = true;
            this.ShippingComboBox.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "14"});
            this.ShippingComboBox.Location = new System.Drawing.Point(301, 354);
            this.ShippingComboBox.Name = "ShippingComboBox";
            this.ShippingComboBox.Size = new System.Drawing.Size(143, 21);
            this.ShippingComboBox.TabIndex = 19;
            this.ShippingComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.Shipping_validation);
            // 
            // widthError
            // 
            this.widthError.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 506);
            this.Controls.Add(this.ShippingComboBox);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.DrawerInput);
            this.Controls.Add(this.DepthBox);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.shipDiscalim);
            this.Controls.Add(this.depthDisclaim);
            this.Controls.Add(this.widthDisclaim);
            this.Controls.Add(this.currentDate);
            this.Controls.Add(this.shipingLabl);
            this.Controls.Add(this.materialLabl);
            this.Controls.Add(this.drawrsLabl);
            this.Controls.Add(this.depthLabl);
            this.Controls.Add(this.widthLabl);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.toDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.mainMenuBtn);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.widthError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label toDay;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label widthLabl;
        private System.Windows.Forms.Label depthLabl;
        private System.Windows.Forms.Label drawrsLabl;
        private System.Windows.Forms.Label materialLabl;
        private System.Windows.Forms.Label shipingLabl;
        private System.Windows.Forms.Label currentDate;
        private System.Windows.Forms.Label widthDisclaim;
        private System.Windows.Forms.Label depthDisclaim;
        private System.Windows.Forms.Label shipDiscalim;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.TextBox DepthBox;
        private System.Windows.Forms.ComboBox DrawerInput;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.ComboBox ShippingComboBox;
        private System.Windows.Forms.ErrorProvider widthError;
    }
}