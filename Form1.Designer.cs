namespace TT_Final_Project
{
    partial class mainForm
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
            this.listBVehicles = new System.Windows.Forms.ListBox();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.txtMilage = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtTrans = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rbCar = new System.Windows.Forms.RadioButton();
            this.rbTruck = new System.Windows.Forms.RadioButton();
            this.rbSuv = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBVehicles
            // 
            this.listBVehicles.FormattingEnabled = true;
            this.listBVehicles.Location = new System.Drawing.Point(409, 12);
            this.listBVehicles.Name = "listBVehicles";
            this.listBVehicles.Size = new System.Drawing.Size(309, 251);
            this.listBVehicles.TabIndex = 0;
            // 
            // txtVin
            // 
            this.txtVin.Location = new System.Drawing.Point(138, 38);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(189, 20);
            this.txtVin.TabIndex = 1;
            // 
            // txtMilage
            // 
            this.txtMilage.Location = new System.Drawing.Point(138, 64);
            this.txtMilage.Name = "txtMilage";
            this.txtMilage.Size = new System.Drawing.Size(189, 20);
            this.txtMilage.TabIndex = 2;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(138, 90);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(189, 20);
            this.txtYear.TabIndex = 3;
            // 
            // txtTrans
            // 
            this.txtTrans.Location = new System.Drawing.Point(138, 116);
            this.txtTrans.Name = "txtTrans";
            this.txtTrans.Size = new System.Drawing.Size(189, 20);
            this.txtTrans.TabIndex = 4;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(138, 142);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(189, 20);
            this.txtColor.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(173, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(191, 334);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(173, 30);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(366, 334);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(173, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(545, 334);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 30);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rbCar
            // 
            this.rbCar.AutoSize = true;
            this.rbCar.Location = new System.Drawing.Point(52, 19);
            this.rbCar.Name = "rbCar";
            this.rbCar.Size = new System.Drawing.Size(41, 17);
            this.rbCar.TabIndex = 10;
            this.rbCar.TabStop = true;
            this.rbCar.Text = "Car";
            this.rbCar.UseVisualStyleBackColor = true;
            // 
            // rbTruck
            // 
            this.rbTruck.AutoSize = true;
            this.rbTruck.Location = new System.Drawing.Point(116, 19);
            this.rbTruck.Name = "rbTruck";
            this.rbTruck.Size = new System.Drawing.Size(53, 17);
            this.rbTruck.TabIndex = 11;
            this.rbTruck.TabStop = true;
            this.rbTruck.Text = "Truck";
            this.rbTruck.UseVisualStyleBackColor = true;
            // 
            // rbSuv
            // 
            this.rbSuv.AutoSize = true;
            this.rbSuv.Location = new System.Drawing.Point(192, 19);
            this.rbSuv.Name = "rbSuv";
            this.rbSuv.Size = new System.Drawing.Size(44, 17);
            this.rbSuv.TabIndex = 12;
            this.rbSuv.TabStop = true;
            this.rbSuv.Text = "Suv";
            this.rbSuv.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCar);
            this.groupBox1.Controls.Add(this.rbSuv);
            this.groupBox1.Controls.Add(this.rbTruck);
            this.groupBox1.Location = new System.Drawing.Point(52, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 55);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMilage);
            this.groupBox2.Controls.Add(this.txtVin);
            this.groupBox2.Controls.Add(this.txtYear);
            this.groupBox2.Controls.Add(this.txtTrans);
            this.groupBox2.Controls.Add(this.txtColor);
            this.groupBox2.Location = new System.Drawing.Point(16, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 204);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehicle Properties";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Transmission:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Milage:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vin Number:";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(462, 284);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(206, 25);
            this.btnInfo.TabIndex = 16;
            this.btnInfo.Text = "Show Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 386);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBVehicles);
            this.Name = "mainForm";
            this.Text = "Vehicle List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBVehicles;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.TextBox txtMilage;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtTrans;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbCar;
        private System.Windows.Forms.RadioButton rbTruck;
        private System.Windows.Forms.RadioButton rbSuv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInfo;
    }
}

