namespace IGDB
{
    partial class CPU
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
            this.cboCPU = new System.Windows.Forms.ComboBox();
            this.btnAddCPU = new System.Windows.Forms.Button();
            this.txtAddCPU = new System.Windows.Forms.TextBox();
            this.pcbCPU = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCPU
            // 
            this.cboCPU.FormattingEnabled = true;
            this.cboCPU.Items.AddRange(new object[] {
            "Intel Core i5-6500 3.20GHz Processor",
            "Intel Core i5-6600K 3.5GHz Processor (6M Cache, up to 3.90 GHz)",
            "Intel Core i7-6700 3.40GHz Processor",
            "Intel Core i7-6700K 4.00GHz Processor (8M Cache, up to 4.20 GHz) (6M Cache, up to" +
                " 3.90 GHz)"});
            this.cboCPU.Location = new System.Drawing.Point(12, 12);
            this.cboCPU.Name = "cboCPU";
            this.cboCPU.Size = new System.Drawing.Size(260, 21);
            this.cboCPU.TabIndex = 0;
            this.cboCPU.SelectedIndexChanged += new System.EventHandler(this.cboCPU_SelectedIndexChanged);
            // 
            // btnAddCPU
            // 
            this.btnAddCPU.Location = new System.Drawing.Point(197, 228);
            this.btnAddCPU.Name = "btnAddCPU";
            this.btnAddCPU.Size = new System.Drawing.Size(75, 23);
            this.btnAddCPU.TabIndex = 1;
            this.btnAddCPU.Text = "Add CPU";
            this.btnAddCPU.UseVisualStyleBackColor = true;
            // 
            // txtAddCPU
            // 
            this.txtAddCPU.Location = new System.Drawing.Point(12, 230);
            this.txtAddCPU.Name = "txtAddCPU";
            this.txtAddCPU.Size = new System.Drawing.Size(179, 20);
            this.txtAddCPU.TabIndex = 2;
            // 
            // pcbCPU
            // 
            this.pcbCPU.Location = new System.Drawing.Point(13, 40);
            this.pcbCPU.Name = "pcbCPU";
            this.pcbCPU.Size = new System.Drawing.Size(259, 182);
            this.pcbCPU.TabIndex = 3;
            this.pcbCPU.TabStop = false;
            // 
            // CPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pcbCPU);
            this.Controls.Add(this.txtAddCPU);
            this.Controls.Add(this.btnAddCPU);
            this.Controls.Add(this.cboCPU);
            this.Name = "CPU";
            this.Text = "CPU";
            this.Load += new System.EventHandler(this.CPU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCPU;
        private System.Windows.Forms.Button btnAddCPU;
        private System.Windows.Forms.TextBox txtAddCPU;
        private System.Windows.Forms.PictureBox pcbCPU;
    }
}