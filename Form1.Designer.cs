namespace OrderForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnPaiement = new System.Windows.Forms.Button();
            this.listOrder = new System.Windows.Forms.ListBox();
            this.ListCategory = new System.Windows.Forms.ListBox();
            this.ListProduit = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnPaiement
            // 
            this.BtnPaiement.Location = new System.Drawing.Point(549, 322);
            this.BtnPaiement.Name = "BtnPaiement";
            this.BtnPaiement.Size = new System.Drawing.Size(75, 23);
            this.BtnPaiement.TabIndex = 1;
            this.BtnPaiement.Text = "button1";
            this.BtnPaiement.UseVisualStyleBackColor = true;
            // 
            // listOrder
            // 
            this.listOrder.FormattingEnabled = true;
            this.listOrder.ItemHeight = 15;
            this.listOrder.Location = new System.Drawing.Point(512, 63);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(213, 244);
            this.listOrder.TabIndex = 3;
            // 
            // ListCategory
            // 
            this.ListCategory.FormattingEnabled = true;
            this.ListCategory.ItemHeight = 15;
            this.ListCategory.Location = new System.Drawing.Point(22, 63);
            this.ListCategory.Name = "ListCategory";
            this.ListCategory.Size = new System.Drawing.Size(108, 244);
            this.ListCategory.TabIndex = 3;
            this.ListCategory.SelectedIndexChanged += new System.EventHandler(this.ListCategory_SelectedIndexChanged);
            // 
            // ListProduit
            // 
            this.ListProduit.FormattingEnabled = true;
            this.ListProduit.ItemHeight = 15;
            this.ListProduit.Location = new System.Drawing.Point(173, 63);
            this.ListProduit.Name = "ListProduit";
            this.ListProduit.Size = new System.Drawing.Size(213, 244);
            this.ListProduit.TabIndex = 3;
            this.ListProduit.SelectedIndexChanged += new System.EventHandler(this.ListProduit_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListCategory);
            this.Controls.Add(this.ListProduit);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.BtnPaiement);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnPaiement;
        private ListBox listOrder;
        private ListBox ListCategory;
        private ListBox ListProduit;
    }
}