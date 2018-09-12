namespace Ado.Net_IceShops
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SellerBox = new System.Windows.Forms.ComboBox();
            this.BuyerBox = new System.Windows.Forms.ComboBox();
            this.TicketBox = new System.Windows.Forms.ComboBox();
            this.QuantityBox = new System.Windows.Forms.ComboBox();
            this.BuyBut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seller";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(243, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buyer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(422, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ticket";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(559, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // SellerBox
            // 
            this.SellerBox.FormattingEnabled = true;
            this.SellerBox.Location = new System.Drawing.Point(23, 136);
            this.SellerBox.Name = "SellerBox";
            this.SellerBox.Size = new System.Drawing.Size(121, 21);
            this.SellerBox.TabIndex = 4;
            // 
            // BuyerBox
            // 
            this.BuyerBox.FormattingEnabled = true;
            this.BuyerBox.Location = new System.Drawing.Point(215, 136);
            this.BuyerBox.Name = "BuyerBox";
            this.BuyerBox.Size = new System.Drawing.Size(121, 21);
            this.BuyerBox.TabIndex = 5;
            // 
            // TicketBox
            // 
            this.TicketBox.FormattingEnabled = true;
            this.TicketBox.Location = new System.Drawing.Point(396, 136);
            this.TicketBox.Name = "TicketBox";
            this.TicketBox.Size = new System.Drawing.Size(121, 21);
            this.TicketBox.TabIndex = 6;
            // 
            // QuantityBox
            // 
            this.QuantityBox.FormattingEnabled = true;
            this.QuantityBox.Location = new System.Drawing.Point(563, 136);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(84, 21);
            this.QuantityBox.TabIndex = 7;
            // 
            // BuyBut
            // 
            this.BuyBut.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyBut.Location = new System.Drawing.Point(702, 125);
            this.BuyBut.Name = "BuyBut";
            this.BuyBut.Size = new System.Drawing.Size(82, 32);
            this.BuyBut.TabIndex = 8;
            this.BuyBut.Text = "Buy";
            this.BuyBut.UseVisualStyleBackColor = true;
            this.BuyBut.Click += new System.EventHandler(this.BuyBut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(772, 127);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(796, 398);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BuyBut);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.TicketBox);
            this.Controls.Add(this.BuyerBox);
            this.Controls.Add(this.SellerBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SellerBox;
        private System.Windows.Forms.ComboBox BuyerBox;
        private System.Windows.Forms.ComboBox TicketBox;
        private System.Windows.Forms.ComboBox QuantityBox;
        private System.Windows.Forms.Button BuyBut;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

