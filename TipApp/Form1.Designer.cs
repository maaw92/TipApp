namespace TipApp
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
            this.WorkersList = new System.Windows.Forms.ListBox();
            this.AddWorker = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WorkersList
            // 
            this.WorkersList.FormattingEnabled = true;
            this.WorkersList.Location = new System.Drawing.Point(12, 12);
            this.WorkersList.Name = "WorkersList";
            this.WorkersList.Size = new System.Drawing.Size(231, 212);
            this.WorkersList.TabIndex = 0;
            // 
            // AddWorker
            // 
            this.AddWorker.Location = new System.Drawing.Point(286, 23);
            this.AddWorker.Name = "AddWorker";
            this.AddWorker.Size = new System.Drawing.Size(129, 62);
            this.AddWorker.TabIndex = 1;
            this.AddWorker.Text = "Dodaj Pracownika";
            this.AddWorker.UseVisualStyleBackColor = true;
            this.AddWorker.Click += new System.EventHandler(this.AddWorker_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 436);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddWorker);
            this.Controls.Add(this.WorkersList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox WorkersList;
        private System.Windows.Forms.Button AddWorker;
        private System.Windows.Forms.Button button1;
    }
}

