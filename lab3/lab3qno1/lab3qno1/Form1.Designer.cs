namespace lab3qno1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.user_phone = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Phone";
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(164, 92);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(100, 20);
            this.user_name.TabIndex = 4;
            // 
            // user_phone
            // 
            this.user_phone.Location = new System.Drawing.Point(164, 134);
            this.user_phone.Name = "user_phone";
            this.user_phone.Size = new System.Drawing.Size(100, 20);
            this.user_phone.TabIndex = 5;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(90, 180);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 6;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(189, 180);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 7;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(296, 180);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 8;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(409, 180);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(75, 23);
            this.select.TabIndex = 9;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tid,
            this.tname,
            this.tphone});
            this.dataGridView1.Location = new System.Drawing.Point(90, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // tid
            // 
            this.tid.HeaderText = "ID";
            this.tid.Name = "tid";
            // 
            // tname
            // 
            this.tname.HeaderText = "UserName";
            this.tname.Name = "tname";
            // 
            // tphone
            // 
            this.tphone.HeaderText = "Phone No.";
            this.tphone.Name = "tphone";
            // 
            // user_id
            // 
            this.user_id.Location = new System.Drawing.Point(164, 52);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(100, 20);
            this.user_id.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.select);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.create);
            this.Controls.Add(this.user_phone);
            this.Controls.Add(this.user_name);
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
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox user_phone;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tname;
        private System.Windows.Forms.DataGridViewTextBoxColumn tphone;
        private System.Windows.Forms.TextBox user_id;
    }
}

