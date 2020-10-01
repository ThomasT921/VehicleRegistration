namespace TT_Final_Project
{
    partial class carForm
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
            this.txtCarMake = new System.Windows.Forms.TextBox();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtCarDrive = new System.Windows.Forms.TextBox();
            this.txtCarEngine = new System.Windows.Forms.TextBox();
            this.txtCarStyle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCarMake
            // 
            this.txtCarMake.Location = new System.Drawing.Point(103, 30);
            this.txtCarMake.Name = "txtCarMake";
            this.txtCarMake.Size = new System.Drawing.Size(135, 20);
            this.txtCarMake.TabIndex = 0;
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(103, 56);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(135, 20);
            this.txtCarModel.TabIndex = 1;
            // 
            // txtCarDrive
            // 
            this.txtCarDrive.Location = new System.Drawing.Point(103, 82);
            this.txtCarDrive.Name = "txtCarDrive";
            this.txtCarDrive.Size = new System.Drawing.Size(135, 20);
            this.txtCarDrive.TabIndex = 2;
            // 
            // txtCarEngine
            // 
            this.txtCarEngine.Location = new System.Drawing.Point(103, 108);
            this.txtCarEngine.Name = "txtCarEngine";
            this.txtCarEngine.Size = new System.Drawing.Size(135, 20);
            this.txtCarEngine.TabIndex = 3;
            // 
            // txtCarStyle
            // 
            this.txtCarStyle.Location = new System.Drawing.Point(103, 134);
            this.txtCarStyle.Name = "txtCarStyle";
            this.txtCarStyle.Size = new System.Drawing.Size(135, 20);
            this.txtCarStyle.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCarDrive);
            this.groupBox1.Controls.Add(this.txtCarStyle);
            this.groupBox1.Controls.Add(this.txtCarMake);
            this.groupBox1.Controls.Add(this.txtCarEngine);
            this.groupBox1.Controls.Add(this.txtCarModel);
            this.groupBox1.Location = new System.Drawing.Point(26, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 179);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Properties";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(64, 213);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Make:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Drivetrain:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Engine:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bodystyle:";
            // 
            // carForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 255);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "carForm";
            this.Text = "Add Car";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox txtCarMake;
        public System.Windows.Forms.TextBox txtCarModel;
        public System.Windows.Forms.TextBox txtCarDrive;
        public System.Windows.Forms.TextBox txtCarEngine;
        public System.Windows.Forms.TextBox txtCarStyle;
    }
}