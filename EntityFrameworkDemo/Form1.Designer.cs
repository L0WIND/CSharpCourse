namespace EntityFrameworkDemo
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
            components = new System.ComponentModel.Container();
            btnRemove = new Button();
            btnAdd = new Button();
            tbxNameAdd = new TextBox();
            tbxUnitePriceAdd = new TextBox();
            tbxStockAmountAdd = new TextBox();
            gbxAdd = new GroupBox();
            lblUnitePriceAdd = new Label();
            lblStockAmountAdd = new Label();
            lblNameAdd = new Label();
            dgwProducts = new DataGridView();
            gbxUpdate = new GroupBox();
            lblUnitePriceUpdate = new Label();
            lblStockAmountUpdate = new Label();
            lblNameUpdate = new Label();
            tbxNameUpdate = new TextBox();
            tbxUnitePriceUpdate = new TextBox();
            tbxStockAmountUpdate = new TextBox();
            btnUpdate = new Button();
            tbxSearch = new TextBox();
            lblSearch = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            gbxUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Crimson;
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.FlatStyle = FlatStyle.Popup;
            btnRemove.Font = new Font("Segoe UI", 9F);
            btnRemove.Location = new Point(713, 12);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 26);
            btnRemove.TabIndex = 0;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Location = new Point(140, 156);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 31);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbxNameAdd
            // 
            tbxNameAdd.Location = new Point(95, 22);
            tbxNameAdd.Name = "tbxNameAdd";
            tbxNameAdd.Size = new Size(137, 23);
            tbxNameAdd.TabIndex = 3;
            // 
            // tbxUnitePriceAdd
            // 
            tbxUnitePriceAdd.Location = new Point(95, 69);
            tbxUnitePriceAdd.Name = "tbxUnitePriceAdd";
            tbxUnitePriceAdd.Size = new Size(137, 23);
            tbxUnitePriceAdd.TabIndex = 4;
            // 
            // tbxStockAmountAdd
            // 
            tbxStockAmountAdd.Location = new Point(95, 111);
            tbxStockAmountAdd.Name = "tbxStockAmountAdd";
            tbxStockAmountAdd.Size = new Size(137, 23);
            tbxStockAmountAdd.TabIndex = 6;
            // 
            // gbxAdd
            // 
            gbxAdd.Controls.Add(lblUnitePriceAdd);
            gbxAdd.Controls.Add(lblStockAmountAdd);
            gbxAdd.Controls.Add(lblNameAdd);
            gbxAdd.Controls.Add(tbxNameAdd);
            gbxAdd.Controls.Add(tbxUnitePriceAdd);
            gbxAdd.Controls.Add(tbxStockAmountAdd);
            gbxAdd.Controls.Add(btnAdd);
            gbxAdd.Location = new Point(12, 219);
            gbxAdd.Name = "gbxAdd";
            gbxAdd.Size = new Size(301, 202);
            gbxAdd.TabIndex = 9;
            gbxAdd.TabStop = false;
            gbxAdd.Text = "Add a product";
            // 
            // lblUnitePriceAdd
            // 
            lblUnitePriceAdd.AutoSize = true;
            lblUnitePriceAdd.Location = new Point(6, 72);
            lblUnitePriceAdd.Name = "lblUnitePriceAdd";
            lblUnitePriceAdd.Size = new Size(64, 15);
            lblUnitePriceAdd.TabIndex = 13;
            lblUnitePriceAdd.Text = "Unite Price";
            // 
            // lblStockAmountAdd
            // 
            lblStockAmountAdd.AutoSize = true;
            lblStockAmountAdd.Location = new Point(6, 114);
            lblStockAmountAdd.Name = "lblStockAmountAdd";
            lblStockAmountAdd.Size = new Size(83, 15);
            lblStockAmountAdd.TabIndex = 14;
            lblStockAmountAdd.Text = "Stock Amount";
            // 
            // lblNameAdd
            // 
            lblNameAdd.AutoSize = true;
            lblNameAdd.Location = new Point(6, 25);
            lblNameAdd.Name = "lblNameAdd";
            lblNameAdd.Size = new Size(39, 15);
            lblNameAdd.TabIndex = 12;
            lblNameAdd.Text = "Name";
            // 
            // dgwProducts
            // 
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Location = new Point(12, 44);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.Size = new Size(776, 155);
            dgwProducts.TabIndex = 11;
            dgwProducts.CellClick += dgwProducts_CellClick;
            // 
            // gbxUpdate
            // 
            gbxUpdate.Controls.Add(lblUnitePriceUpdate);
            gbxUpdate.Controls.Add(lblStockAmountUpdate);
            gbxUpdate.Controls.Add(lblNameUpdate);
            gbxUpdate.Controls.Add(tbxNameUpdate);
            gbxUpdate.Controls.Add(tbxUnitePriceUpdate);
            gbxUpdate.Controls.Add(tbxStockAmountUpdate);
            gbxUpdate.Controls.Add(btnUpdate);
            gbxUpdate.Location = new Point(487, 219);
            gbxUpdate.Name = "gbxUpdate";
            gbxUpdate.Size = new Size(301, 202);
            gbxUpdate.TabIndex = 12;
            gbxUpdate.TabStop = false;
            gbxUpdate.Text = "Update a product";
            // 
            // lblUnitePriceUpdate
            // 
            lblUnitePriceUpdate.AutoSize = true;
            lblUnitePriceUpdate.Location = new Point(6, 72);
            lblUnitePriceUpdate.Name = "lblUnitePriceUpdate";
            lblUnitePriceUpdate.Size = new Size(64, 15);
            lblUnitePriceUpdate.TabIndex = 13;
            lblUnitePriceUpdate.Text = "Unite Price";
            // 
            // lblStockAmountUpdate
            // 
            lblStockAmountUpdate.AutoSize = true;
            lblStockAmountUpdate.Location = new Point(6, 114);
            lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            lblStockAmountUpdate.Size = new Size(83, 15);
            lblStockAmountUpdate.TabIndex = 14;
            lblStockAmountUpdate.Text = "Stock Amount";
            // 
            // lblNameUpdate
            // 
            lblNameUpdate.AutoSize = true;
            lblNameUpdate.Location = new Point(6, 25);
            lblNameUpdate.Name = "lblNameUpdate";
            lblNameUpdate.Size = new Size(39, 15);
            lblNameUpdate.TabIndex = 12;
            lblNameUpdate.Text = "Name";
            // 
            // tbxNameUpdate
            // 
            tbxNameUpdate.Location = new Point(95, 22);
            tbxNameUpdate.Name = "tbxNameUpdate";
            tbxNameUpdate.Size = new Size(137, 23);
            tbxNameUpdate.TabIndex = 3;
            // 
            // tbxUnitePriceUpdate
            // 
            tbxUnitePriceUpdate.Location = new Point(95, 69);
            tbxUnitePriceUpdate.Name = "tbxUnitePriceUpdate";
            tbxUnitePriceUpdate.Size = new Size(137, 23);
            tbxUnitePriceUpdate.TabIndex = 4;
            // 
            // tbxStockAmountUpdate
            // 
            tbxStockAmountUpdate.Location = new Point(95, 111);
            tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            tbxStockAmountUpdate.Size = new Size(137, 23);
            tbxStockAmountUpdate.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LimeGreen;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Location = new Point(140, 156);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 31);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(67, 12);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(188, 23);
            tbxSearch.TabIndex = 13;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(19, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(42, 15);
            lblSearch.TabIndex = 14;
            lblSearch.Text = "Search";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSearch);
            Controls.Add(tbxSearch);
            Controls.Add(gbxUpdate);
            Controls.Add(dgwProducts);
            Controls.Add(gbxAdd);
            Controls.Add(btnRemove);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbxAdd.ResumeLayout(false);
            gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).EndInit();
            gbxUpdate.ResumeLayout(false);
            gbxUpdate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemove;
        private Button btnAdd;
        private TextBox tbxNameAdd;
        private TextBox tbxUnitePriceAdd;
        private TextBox tbxStockAmountAdd;
        private GroupBox gbxAdd;
        private DataGridView dgwProducts;
        private Label lblUnitePriceAdd;
        private Label lblStockAmountAdd;
        private Label lblNameAdd;
        private GroupBox gbxUpdate;
        private Label lblUnitePriceUpdate;
        private Label lblStockAmountUpdate;
        private Label lblNameUpdate;
        private TextBox tbxNameUpdate;
        private TextBox tbxUnitePriceUpdate;
        private TextBox tbxStockAmountUpdate;
        private Button btnUpdate;
        private TextBox tbxSearch;
        private Label lblSearch;
        private ContextMenuStrip contextMenuStrip1;
    }
}
