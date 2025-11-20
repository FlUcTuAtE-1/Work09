namespace crud_test_solid2
{
    partial class FrmEmpployeeList
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
            this.components = new System.ComponentModel.Container();
            this.dgEmployeeList = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEmployeeList
            // 
            this.dgEmployeeList.AllowUserToAddRows = false;
            this.dgEmployeeList.AllowUserToDeleteRows = false;
            this.dgEmployeeList.AllowUserToResizeColumns = false;
            this.dgEmployeeList.AutoGenerateColumns = false;
            this.dgEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployeeList.DataSource = this.employeeBindingSource;
            this.dgEmployeeList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgEmployeeList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgEmployeeList.Location = new System.Drawing.Point(0, 82);
            this.dgEmployeeList.Name = "dgEmployeeList";
            this.dgEmployeeList.ReadOnly = true;
            this.dgEmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmployeeList.Size = new System.Drawing.Size(820, 448);
            this.dgEmployeeList.TabIndex = 0;
            this.dgEmployeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmployeeList_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(12, 55);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(289, 20);
            this.txtKey.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by ID or Lastname";
            // 
            // btnAddnew
            // 
            this.btnAddnew.Location = new System.Drawing.Point(691, 52);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(117, 23);
            this.btnAddnew.TabIndex = 4;
            this.btnAddnew.Text = "Remove Employee";
            this.btnAddnew.UseVisualStyleBackColor = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(crud_test_solid2.Models.Employee);
            // 
            // FrmEmpployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 530);
            this.Controls.Add(this.btnAddnew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgEmployeeList);
            this.Name = "FrmEmpployeeList";
            this.Text = "Empployee List";
            this.Load += new System.EventHandler(this.FrmEmpployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmployeeList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.BindingSource employeeBindingSource;
    }
}