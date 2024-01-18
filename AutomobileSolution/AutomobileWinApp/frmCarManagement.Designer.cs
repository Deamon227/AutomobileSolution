namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            lbCarId = new Label();
            lbCarName = new Label();
            lbManufacter = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            txtCarId = new TextBox();
            txtCarName = new TextBox();
            txtManufacter = new TextBox();
            txtPrice = new TextBox();
            txtReleaseYear = new TextBox();
            dgvCarList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.DialogResult = DialogResult.OK;
            btnLoad.Location = new Point(128, 199);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.DialogResult = DialogResult.OK;
            btnNew.Location = new Point(368, 199);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 1;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(616, 199);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(368, 415);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbCarId
            // 
            lbCarId.AutoSize = true;
            lbCarId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbCarId.Location = new Point(103, 37);
            lbCarId.Name = "lbCarId";
            lbCarId.Size = new Size(50, 20);
            lbCarId.TabIndex = 4;
            lbCarId.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbCarName.Location = new Point(103, 91);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(75, 20);
            lbCarName.TabIndex = 5;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacter
            // 
            lbManufacter.AutoSize = true;
            lbManufacter.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbManufacter.Location = new Point(103, 144);
            lbManufacter.Name = "lbManufacter";
            lbManufacter.Size = new Size(84, 20);
            lbManufacter.TabIndex = 6;
            lbManufacter.Text = "Manufacter";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbPrice.Location = new Point(434, 37);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 7;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbReleaseYear.Location = new Point(434, 91);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(92, 20);
            lbReleaseYear.TabIndex = 8;
            lbReleaseYear.Text = "Release Year";
            // 
            // txtCarId
            // 
            txtCarId.Location = new Point(204, 37);
            txtCarId.Name = "txtCarId";
            txtCarId.Size = new Size(177, 23);
            txtCarId.TabIndex = 9;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(204, 88);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(177, 23);
            txtCarName.TabIndex = 10;
            // 
            // txtManufacter
            // 
            txtManufacter.Location = new Point(204, 145);
            txtManufacter.Name = "txtManufacter";
            txtManufacter.Size = new Size(177, 23);
            txtManufacter.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(532, 38);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(177, 23);
            txtPrice.TabIndex = 12;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(532, 91);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(177, 23);
            txtReleaseYear.TabIndex = 13;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(12, 228);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowTemplate.Height = 25;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(776, 170);
            dgvCarList.TabIndex = 14;
            dgvCarList.CellDoubleClick += dgvCarList_CellDoubleClick;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCarList);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtManufacter);
            Controls.Add(txtCarName);
            Controls.Add(txtCarId);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacter);
            Controls.Add(lbCarName);
            Controls.Add(lbCarId);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarManagement";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Button btnClose;
        private Label lbCarId;
        private Label lbCarName;
        private Label lbManufacter;
        private Label lbPrice;
        private Label lbReleaseYear;
        private TextBox txtCarId;
        private TextBox txtCarName;
        private TextBox txtManufacter;
        private TextBox txtPrice;
        private TextBox txtReleaseYear;
        private DataGridView dgvCarList;
    }
}