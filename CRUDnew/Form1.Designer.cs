
namespace CRUDnew
{
    partial class FormEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            this.btn_dlt = new System.Windows.Forms.Button();
            this.datagv = new System.Windows.Forms.DataGridView();
            this.btn_show = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_dept = new System.Windows.Forms.TextBox();
            this.tb_ph = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(191, 16);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(252, 20);
            this.tb_name.TabIndex = 4;
            this.tb_name.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tb_name_PreviewKeyDown);
            // 
            // tb_city
            // 
            this.tb_city.Location = new System.Drawing.Point(191, 51);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(252, 20);
            this.tb_city.TabIndex = 5;
            this.tb_city.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tb_city_PreviewKeyDown);
            // 
            // cb_gender
            // 
            this.cb_gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.cb_gender.Location = new System.Drawing.Point(191, 115);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(252, 21);
            this.cb_gender.TabIndex = 7;
            this.cb_gender.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cb_gender_PreviewKeyDown);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(55, 190);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clr.Location = new System.Drawing.Point(173, 190);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(75, 23);
            this.btn_clr.TabIndex = 9;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // btn_dlt
            // 
            this.btn_dlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dlt.Location = new System.Drawing.Point(301, 190);
            this.btn_dlt.Name = "btn_dlt";
            this.btn_dlt.Size = new System.Drawing.Size(75, 23);
            this.btn_dlt.TabIndex = 10;
            this.btn_dlt.Text = "Delete";
            this.btn_dlt.UseVisualStyleBackColor = true;
            this.btn_dlt.Click += new System.EventHandler(this.btn_dlt_Click);
            // 
            // datagv
            // 
            this.datagv.AllowUserToAddRows = false;
            this.datagv.AllowUserToOrderColumns = true;
            this.datagv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv.Location = new System.Drawing.Point(14, 238);
            this.datagv.Name = "datagv";
            this.datagv.RowHeadersVisible = false;
            this.datagv.Size = new System.Drawing.Size(513, 152);
            this.datagv.TabIndex = 11;
            this.datagv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagv_CellDoubleClick);
            // 
            // btn_show
            // 
            this.btn_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.Location = new System.Drawing.Point(420, 190);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 23);
            this.btn_show.TabIndex = 12;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone no:";
            // 
            // tb_dept
            // 
            this.tb_dept.Location = new System.Drawing.Point(191, 84);
            this.tb_dept.Name = "tb_dept";
            this.tb_dept.Size = new System.Drawing.Size(252, 20);
            this.tb_dept.TabIndex = 6;
            this.tb_dept.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tb_dept_PreviewKeyDown);
            // 
            // tb_ph
            // 
            this.tb_ph.Location = new System.Drawing.Point(191, 148);
            this.tb_ph.Name = "tb_ph";
            this.tb_ph.Size = new System.Drawing.Size(252, 20);
            this.tb_ph.TabIndex = 14;
            this.tb_ph.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tb_ph_PreviewKeyDown);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.tb_ph);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.datagv);
            this.Controls.Add(this.btn_dlt);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.tb_dept);
            this.Controls.Add(this.tb_city);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.Button btn_dlt;
        private System.Windows.Forms.DataGridView datagv;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_dept;
        private System.Windows.Forms.TextBox tb_ph;
    }
}

