namespace InventoryManager
{
    partial class frmInventory
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_fresh1 = new System.Windows.Forms.Button();
            this.btn_fresh3 = new System.Windows.Forms.Button();
            this.btn_fresh2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_description = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_type2 = new System.Windows.Forms.Button();
            this.btn_type5 = new System.Windows.Forms.Button();
            this.btn_type4 = new System.Windows.Forms.Button();
            this.btn_type1 = new System.Windows.Forms.Button();
            this.btn_type3 = new System.Windows.Forms.Button();
            this.btn_ouoOfStock = new System.Windows.Forms.Button();
            this.btn_inStock = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_manage = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogout.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(973, 613);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(122, 43);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(798, 453);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inventory Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(876, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "*Click the column to sort.";
            // 
            // btn_fresh1
            // 
            this.btn_fresh1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_fresh1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_fresh1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fresh1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_fresh1.Location = new System.Drawing.Point(855, 185);
            this.btn_fresh1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_fresh1.Name = "btn_fresh1";
            this.btn_fresh1.Size = new System.Drawing.Size(66, 66);
            this.btn_fresh1.TabIndex = 9;
            this.btn_fresh1.Text = "😋";
            this.btn_fresh1.UseVisualStyleBackColor = false;
            this.btn_fresh1.Click += new System.EventHandler(this.btn_fresh1_Click);
            // 
            // btn_fresh3
            // 
            this.btn_fresh3.BackColor = System.Drawing.Color.Red;
            this.btn_fresh3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fresh3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_fresh3.Location = new System.Drawing.Point(1016, 185);
            this.btn_fresh3.Margin = new System.Windows.Forms.Padding(0);
            this.btn_fresh3.Name = "btn_fresh3";
            this.btn_fresh3.Size = new System.Drawing.Size(66, 66);
            this.btn_fresh3.TabIndex = 10;
            this.btn_fresh3.Text = "☹️";
            this.btn_fresh3.UseVisualStyleBackColor = false;
            this.btn_fresh3.Click += new System.EventHandler(this.btn_fresh3_Click);
            // 
            // btn_fresh2
            // 
            this.btn_fresh2.BackColor = System.Drawing.Color.Yellow;
            this.btn_fresh2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fresh2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_fresh2.Location = new System.Drawing.Point(936, 185);
            this.btn_fresh2.Margin = new System.Windows.Forms.Padding(0);
            this.btn_fresh2.Name = "btn_fresh2";
            this.btn_fresh2.Size = new System.Drawing.Size(66, 66);
            this.btn_fresh2.TabIndex = 11;
            this.btn_fresh2.Text = "😐";
            this.btn_fresh2.UseVisualStyleBackColor = false;
            this.btn_fresh2.Click += new System.EventHandler(this.btn_fresh2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(855, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(846, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 51);
            this.label4.TabIndex = 13;
            this.label4.Text = "freshness";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.White;
            this.btn_refresh.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_refresh.Location = new System.Drawing.Point(717, 15);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(0);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(66, 66);
            this.btn_refresh.TabIndex = 15;
            this.btn_refresh.Text = "🔄";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_description.Location = new System.Drawing.Point(300, 95);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(22, 23);
            this.lbl_description.TabIndex = 16;
            this.lbl_description.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(846, 261);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 51);
            this.label5.TabIndex = 20;
            this.label5.Text = "food type";
            this.label5.UseWaitCursor = true;
            // 
            // btn_type2
            // 
            this.btn_type2.BackColor = System.Drawing.Color.IndianRed;
            this.btn_type2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_type2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_type2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_type2.Location = new System.Drawing.Point(930, 312);
            this.btn_type2.Margin = new System.Windows.Forms.Padding(0);
            this.btn_type2.Name = "btn_type2";
            this.btn_type2.Size = new System.Drawing.Size(66, 66);
            this.btn_type2.TabIndex = 17;
            this.btn_type2.Text = "🍖";
            this.btn_type2.UseVisualStyleBackColor = false;
            this.btn_type2.Click += new System.EventHandler(this.btn_type2_Click);
            // 
            // btn_type5
            // 
            this.btn_type5.BackColor = System.Drawing.Color.Orchid;
            this.btn_type5.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_type5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_type5.Location = new System.Drawing.Point(961, 387);
            this.btn_type5.Margin = new System.Windows.Forms.Padding(0);
            this.btn_type5.Name = "btn_type5";
            this.btn_type5.Size = new System.Drawing.Size(66, 66);
            this.btn_type5.TabIndex = 21;
            this.btn_type5.Text = "🍓";
            this.btn_type5.UseVisualStyleBackColor = false;
            this.btn_type5.Click += new System.EventHandler(this.btn_type5_Click);
            // 
            // btn_type4
            // 
            this.btn_type4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_type4.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_type4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_type4.Location = new System.Drawing.Point(882, 387);
            this.btn_type4.Margin = new System.Windows.Forms.Padding(0);
            this.btn_type4.Name = "btn_type4";
            this.btn_type4.Size = new System.Drawing.Size(66, 66);
            this.btn_type4.TabIndex = 22;
            this.btn_type4.Text = "🧀";
            this.btn_type4.UseVisualStyleBackColor = false;
            this.btn_type4.Click += new System.EventHandler(this.btn_type4_Click);
            // 
            // btn_type1
            // 
            this.btn_type1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_type1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_type1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_type1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_type1.Location = new System.Drawing.Point(855, 312);
            this.btn_type1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_type1.Name = "btn_type1";
            this.btn_type1.Size = new System.Drawing.Size(66, 66);
            this.btn_type1.TabIndex = 23;
            this.btn_type1.Text = "🥦";
            this.btn_type1.UseVisualStyleBackColor = false;
            this.btn_type1.Click += new System.EventHandler(this.btn_type1_Click);
            // 
            // btn_type3
            // 
            this.btn_type3.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_type3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_type3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_type3.Location = new System.Drawing.Point(1006, 312);
            this.btn_type3.Margin = new System.Windows.Forms.Padding(0);
            this.btn_type3.Name = "btn_type3";
            this.btn_type3.Size = new System.Drawing.Size(66, 66);
            this.btn_type3.TabIndex = 24;
            this.btn_type3.Text = "🌾";
            this.btn_type3.UseVisualStyleBackColor = false;
            this.btn_type3.Click += new System.EventHandler(this.btn_type3_Click);
            // 
            // btn_ouoOfStock
            // 
            this.btn_ouoOfStock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ouoOfStock.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_ouoOfStock.Location = new System.Drawing.Point(852, 516);
            this.btn_ouoOfStock.Name = "btn_ouoOfStock";
            this.btn_ouoOfStock.Size = new System.Drawing.Size(106, 61);
            this.btn_ouoOfStock.TabIndex = 25;
            this.btn_ouoOfStock.Text = "Out of stock";
            this.btn_ouoOfStock.UseVisualStyleBackColor = false;
            this.btn_ouoOfStock.Click += new System.EventHandler(this.btn_ouoOfStock_Click);
            // 
            // btn_inStock
            // 
            this.btn_inStock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_inStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_inStock.Location = new System.Drawing.Point(973, 516);
            this.btn_inStock.Name = "btn_inStock";
            this.btn_inStock.Size = new System.Drawing.Size(106, 61);
            this.btn_inStock.TabIndex = 26;
            this.btn_inStock.Text = "In Stock";
            this.btn_inStock.UseVisualStyleBackColor = false;
            this.btn_inStock.Click += new System.EventHandler(this.btn_inStock_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(846, 466);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 51);
            this.label6.TabIndex = 27;
            this.label6.Text = "quantity";
            this.label6.UseWaitCursor = true;
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.DarkGray;
            this.btn_export.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.Color.White;
            this.btn_export.Location = new System.Drawing.Point(582, 607);
            this.btn_export.Margin = new System.Windows.Forms.Padding(4);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(238, 55);
            this.btn_export.TabIndex = 28;
            this.btn_export.Text = "Export to Excel";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_manage
            // 
            this.btn_manage.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_manage.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage.ForeColor = System.Drawing.Color.White;
            this.btn_manage.Location = new System.Drawing.Point(304, 607);
            this.btn_manage.Margin = new System.Windows.Forms.Padding(4);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(238, 55);
            this.btn_manage.TabIndex = 29;
            this.btn_manage.Text = "Manage Inventory";
            this.btn_manage.UseVisualStyleBackColor = false;
            this.btn_manage.Click += new System.EventHandler(this.btn_manage_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(235, 604);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(49, 49);
            this.btn_search.TabIndex = 30;
            this.btn_search.Text = "🔍";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_search.Location = new System.Drawing.Point(42, 613);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(190, 30);
            this.txt_search.TabIndex = 31;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1143, 675);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_manage);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_inStock);
            this.Controls.Add(this.btn_ouoOfStock);
            this.Controls.Add(this.btn_type3);
            this.Controls.Add(this.btn_type1);
            this.Controls.Add(this.btn_type4);
            this.Controls.Add(this.btn_type5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_type2);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_fresh2);
            this.Controls.Add(this.btn_fresh3);
            this.Controls.Add(this.btn_fresh1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLogout);
            this.Name = "frmInventory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_fresh1;
        private System.Windows.Forms.Button btn_fresh3;
        private System.Windows.Forms.Button btn_fresh2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_type2;
        private System.Windows.Forms.Button btn_type5;
        private System.Windows.Forms.Button btn_type4;
        private System.Windows.Forms.Button btn_type1;
        private System.Windows.Forms.Button btn_type3;
        private System.Windows.Forms.Button btn_ouoOfStock;
        private System.Windows.Forms.Button btn_inStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_manage;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
    }
}

