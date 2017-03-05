namespace TipApp
{
    partial class AddWorkerForm
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
            this.FirstName = new System.Windows.Forms.TextBox();
            this.VehicleNumber = new System.Windows.Forms.TextBox();
            this.EmptySlot = new System.Windows.Forms.TextBox();
            this.AddWorkerConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(12, 12);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 20);
            this.FirstName.TabIndex = 0;
            // 
            // VehicleNumber
            // 
            this.VehicleNumber.Location = new System.Drawing.Point(12, 64);
            this.VehicleNumber.Name = "VehicleNumber";
            this.VehicleNumber.Size = new System.Drawing.Size(100, 20);
            this.VehicleNumber.TabIndex = 1;
            // 
            // EmptySlot
            // 
            this.EmptySlot.Location = new System.Drawing.Point(12, 92);
            this.EmptySlot.Name = "EmptySlot";
            this.EmptySlot.Size = new System.Drawing.Size(100, 20);
            this.EmptySlot.TabIndex = 2;
            // 
            // AddWorkerConfirm
            // 
            this.AddWorkerConfirm.Location = new System.Drawing.Point(229, 12);
            this.AddWorkerConfirm.Name = "AddWorkerConfirm";
            this.AddWorkerConfirm.Size = new System.Drawing.Size(111, 72);
            this.AddWorkerConfirm.TabIndex = 3;
            this.AddWorkerConfirm.Text = "Dodaj";
            this.AddWorkerConfirm.UseVisualStyleBackColor = true;
            this.AddWorkerConfirm.Click += new System.EventHandler(this.AddWorkerConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "nr rejestracyjny";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "emptyslot";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(12, 38);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 20);
            this.LastName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nazwisko";
            // 
            // AddWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 124);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddWorkerConfirm);
            this.Controls.Add(this.EmptySlot);
            this.Controls.Add(this.VehicleNumber);
            this.Controls.Add(this.FirstName);
            this.Name = "AddWorkerForm";
            this.Text = "AddWorkerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox VehicleNumber;
        private System.Windows.Forms.TextBox EmptySlot;
        private System.Windows.Forms.Button AddWorkerConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label4;
    }
}