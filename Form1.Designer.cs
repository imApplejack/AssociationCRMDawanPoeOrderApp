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
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.textBoxOrderName = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxlignesvues = new System.Windows.Forms.TextBox();
            this.textBoxlignescachees = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPaiement
            // 
            this.BtnPaiement.Location = new System.Drawing.Point(596, 342);
            this.BtnPaiement.Name = "BtnPaiement";
            this.BtnPaiement.Size = new System.Drawing.Size(75, 23);
            this.BtnPaiement.TabIndex = 1;
            this.BtnPaiement.Text = "BoutonTest";
            this.BtnPaiement.UseVisualStyleBackColor = true;
            this.BtnPaiement.Click += new System.EventHandler(this.BtnPaiement_Click);
            // 
            // listOrder
            // 
            this.listOrder.FormattingEnabled = true;
            this.listOrder.ItemHeight = 15;
            this.listOrder.Location = new System.Drawing.Point(325, 63);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(138, 244);
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
            this.ListProduit.Size = new System.Drawing.Size(123, 244);
            this.ListProduit.TabIndex = 3;
            this.ListProduit.SelectedIndexChanged += new System.EventHandler(this.ListProduit_SelectedIndexChanged);
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.Location = new System.Drawing.Point(523, 90);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.RowTemplate.Height = 25;
            this.dataGridOrder.Size = new System.Drawing.Size(240, 217);
            this.dataGridOrder.TabIndex = 4;
            // 
            // textBoxOrderName
            // 
            this.textBoxOrderName.Location = new System.Drawing.Point(523, 63);
            this.textBoxOrderName.Name = "textBoxOrderName";
            this.textBoxOrderName.Size = new System.Drawing.Size(240, 23);
            this.textBoxOrderName.TabIndex = 5;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(523, 313);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(240, 23);
            this.textBoxTotal.TabIndex = 5;
            // 
            // textBoxlignesvues
            // 
            this.textBoxlignesvues.Location = new System.Drawing.Point(486, 343);
            this.textBoxlignesvues.Name = "textBoxlignesvues";
            this.textBoxlignesvues.Size = new System.Drawing.Size(46, 23);
            this.textBoxlignesvues.TabIndex = 5;
            // 
            // textBoxlignescachees
            // 
            this.textBoxlignescachees.Location = new System.Drawing.Point(486, 372);
            this.textBoxlignescachees.Name = "textBoxlignescachees";
            this.textBoxlignescachees.Size = new System.Drawing.Size(46, 23);
            this.textBoxlignescachees.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxlignescachees);
            this.Controls.Add(this.textBoxlignesvues);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxOrderName);
            this.Controls.Add(this.dataGridOrder);
            this.Controls.Add(this.ListCategory);
            this.Controls.Add(this.ListProduit);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.BtnPaiement);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnPaiement;
        private ListBox listOrder;
        private ListBox ListCategory;
        private ListBox ListProduit;
        private TextBox textBoxOrderName;
        private TextBox textBoxTotal;
        public DataGridView dataGridOrder;
        private TextBox textBoxlignesvues;
        private TextBox textBoxlignescachees;
    }
}