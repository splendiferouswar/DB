namespace DB
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
            this.animalInput = new System.Windows.Forms.TextBox();
            this.idInput = new System.Windows.Forms.TextBox();
            this.animalType = new System.Windows.Forms.Label();
            this.animalID = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // animalInput
            // 
            this.animalInput.Location = new System.Drawing.Point(189, 60);
            this.animalInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.animalInput.Name = "animalInput";
            this.animalInput.Size = new System.Drawing.Size(130, 20);
            this.animalInput.TabIndex = 0;
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(189, 106);
            this.idInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(130, 20);
            this.idInput.TabIndex = 2;
            // 
            // animalType
            // 
            this.animalType.AutoSize = true;
            this.animalType.Location = new System.Drawing.Point(72, 60);
            this.animalType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.animalType.Name = "animalType";
            this.animalType.Size = new System.Drawing.Size(65, 13);
            this.animalType.TabIndex = 4;
            this.animalType.Text = "Animal Type";
            // 
            // animalID
            // 
            this.animalID.AutoSize = true;
            this.animalID.Location = new System.Drawing.Point(74, 110);
            this.animalID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.animalID.Name = "animalID";
            this.animalID.Size = new System.Drawing.Size(52, 13);
            this.animalID.TabIndex = 5;
            this.animalID.Text = "Animal ID";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(399, 106);
            this.button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(64, 24);
            this.button.TabIndex = 6;
            this.button.Text = "Search";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 154);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(832, 221);
            this.dataGridView1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 399);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.animalID);
            this.Controls.Add(this.animalType);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.animalInput);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox animalInput;
        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.Label animalType;
        private System.Windows.Forms.Label animalID;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

