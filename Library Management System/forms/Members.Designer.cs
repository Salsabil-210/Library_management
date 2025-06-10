namespace Library_Management_System
{
    partial class Members
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.addMembers_closeBtn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addBooks_picture = new System.Windows.Forms.PictureBox();
            this.addMembers_gender = new System.Windows.Forms.ComboBox();
            this.addMembers_phone = new System.Windows.Forms.TextBox();
            this.addMembers_clearBtn = new System.Windows.Forms.Button();
            this.addMembers_deleteBtn = new System.Windows.Forms.Button();
            this.addMembers_updateBtn = new System.Windows.Forms.Button();
            this.addMembers_addBtn = new System.Windows.Forms.Button();
            this.addMembers_email = new System.Windows.Forms.TextBox();
            this.addMembers_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBooks_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addMembers_closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 46);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Library Mangement System | Members";
            // 
            // addMembers_closeBtn
            // 
            this.addMembers_closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMembers_closeBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMembers_closeBtn.Image = global::Library_Management_System.Properties.Resources.close;
            this.addMembers_closeBtn.Location = new System.Drawing.Point(1163, 12);
            this.addMembers_closeBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addMembers_closeBtn.Name = "addMembers_closeBtn";
            this.addMembers_closeBtn.Size = new System.Drawing.Size(24, 24);
            this.addMembers_closeBtn.TabIndex = 0;
            this.addMembers_closeBtn.Click += new System.EventHandler(this.addMembers_closeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 754);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.dataGridView);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(439, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(748, 631);
            this.panel4.TabIndex = 8;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(137)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 34;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(23, 71);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(703, 537);
            this.dataGridView.TabIndex = 17;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 34);
            this.label7.TabIndex = 16;
            this.label7.Text = "Members Info";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.addBooks_picture);
            this.panel3.Controls.Add(this.addMembers_gender);
            this.panel3.Controls.Add(this.addMembers_phone);
            this.panel3.Controls.Add(this.addMembers_clearBtn);
            this.panel3.Controls.Add(this.addMembers_deleteBtn);
            this.panel3.Controls.Add(this.addMembers_updateBtn);
            this.panel3.Controls.Add(this.addMembers_addBtn);
            this.panel3.Controls.Add(this.addMembers_email);
            this.panel3.Controls.Add(this.addMembers_name);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(19, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 631);
            this.panel3.TabIndex = 7;
            // 
            // addBooks_picture
            // 
            this.addBooks_picture.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addBooks_picture.Image = global::Library_Management_System.Properties.Resources.add;
            this.addBooks_picture.Location = new System.Drawing.Point(149, 54);
            this.addBooks_picture.Name = "addBooks_picture";
            this.addBooks_picture.Size = new System.Drawing.Size(115, 107);
            this.addBooks_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addBooks_picture.TabIndex = 18;
            this.addBooks_picture.TabStop = false;
            // 
            // addMembers_gender
            // 
            this.addMembers_gender.FormattingEnabled = true;
            this.addMembers_gender.Items.AddRange(new object[] {
            "Male",
            "Fmale"});
            this.addMembers_gender.Location = new System.Drawing.Point(115, 349);
            this.addMembers_gender.Name = "addMembers_gender";
            this.addMembers_gender.Size = new System.Drawing.Size(269, 28);
            this.addMembers_gender.TabIndex = 17;
            // 
            // addMembers_phone
            // 
            this.addMembers_phone.Location = new System.Drawing.Point(115, 303);
            this.addMembers_phone.Name = "addMembers_phone";
            this.addMembers_phone.Size = new System.Drawing.Size(269, 26);
            this.addMembers_phone.TabIndex = 15;
            // 
            // addMembers_clearBtn
            // 
            this.addMembers_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(137)))), ((int)(((byte)(125)))));
            this.addMembers_clearBtn.FlatAppearance.BorderSize = 0;
            this.addMembers_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addMembers_clearBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMembers_clearBtn.ForeColor = System.Drawing.Color.White;
            this.addMembers_clearBtn.Location = new System.Drawing.Point(222, 501);
            this.addMembers_clearBtn.Name = "addMembers_clearBtn";
            this.addMembers_clearBtn.Size = new System.Drawing.Size(139, 36);
            this.addMembers_clearBtn.TabIndex = 14;
            this.addMembers_clearBtn.Text = "Clear";
            this.addMembers_clearBtn.UseVisualStyleBackColor = false;
            this.addMembers_clearBtn.Click += new System.EventHandler(this.addMembers_clearBtn_Click);
            // 
            // addMembers_deleteBtn
            // 
            this.addMembers_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(137)))), ((int)(((byte)(125)))));
            this.addMembers_deleteBtn.FlatAppearance.BorderSize = 0;
            this.addMembers_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addMembers_deleteBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMembers_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.addMembers_deleteBtn.Location = new System.Drawing.Point(61, 501);
            this.addMembers_deleteBtn.Name = "addMembers_deleteBtn";
            this.addMembers_deleteBtn.Size = new System.Drawing.Size(139, 36);
            this.addMembers_deleteBtn.TabIndex = 13;
            this.addMembers_deleteBtn.Text = "Delete";
            this.addMembers_deleteBtn.UseVisualStyleBackColor = false;
            this.addMembers_deleteBtn.Click += new System.EventHandler(this.addMembers_deleteBtn_Click);
            // 
            // addMembers_updateBtn
            // 
            this.addMembers_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(137)))), ((int)(((byte)(125)))));
            this.addMembers_updateBtn.FlatAppearance.BorderSize = 0;
            this.addMembers_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addMembers_updateBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMembers_updateBtn.ForeColor = System.Drawing.Color.White;
            this.addMembers_updateBtn.Location = new System.Drawing.Point(222, 444);
            this.addMembers_updateBtn.Name = "addMembers_updateBtn";
            this.addMembers_updateBtn.Size = new System.Drawing.Size(139, 36);
            this.addMembers_updateBtn.TabIndex = 12;
            this.addMembers_updateBtn.Text = "Update";
            this.addMembers_updateBtn.UseVisualStyleBackColor = false;
            this.addMembers_updateBtn.Click += new System.EventHandler(this.addMembers_updateBtn_Click);
            // 
            // addMembers_addBtn
            // 
            this.addMembers_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(137)))), ((int)(((byte)(125)))));
            this.addMembers_addBtn.FlatAppearance.BorderSize = 0;
            this.addMembers_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addMembers_addBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMembers_addBtn.ForeColor = System.Drawing.Color.White;
            this.addMembers_addBtn.Location = new System.Drawing.Point(61, 444);
            this.addMembers_addBtn.Name = "addMembers_addBtn";
            this.addMembers_addBtn.Size = new System.Drawing.Size(139, 36);
            this.addMembers_addBtn.TabIndex = 11;
            this.addMembers_addBtn.Text = "Add";
            this.addMembers_addBtn.UseVisualStyleBackColor = false;
            this.addMembers_addBtn.Click += new System.EventHandler(this.addMembers_addBtn_Click);
            // 
            // addMembers_email
            // 
            this.addMembers_email.Location = new System.Drawing.Point(115, 255);
            this.addMembers_email.Name = "addMembers_email";
            this.addMembers_email.Size = new System.Drawing.Size(269, 26);
            this.addMembers_email.TabIndex = 7;
            // 
            // addMembers_name
            // 
            this.addMembers_name.Location = new System.Drawing.Point(115, 203);
            this.addMembers_name.Name = "addMembers_name";
            this.addMembers_name.Size = new System.Drawing.Size(269, 26);
            this.addMembers_name.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Members";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBooks_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label addMembers_closeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addMembers_clearBtn;
        private System.Windows.Forms.Button addMembers_deleteBtn;
        private System.Windows.Forms.Button addMembers_updateBtn;
        private System.Windows.Forms.Button addMembers_addBtn;
        private System.Windows.Forms.TextBox addMembers_email;
        private System.Windows.Forms.TextBox addMembers_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addMembers_phone;
        private System.Windows.Forms.ComboBox addMembers_gender;
        private System.Windows.Forms.PictureBox addBooks_picture;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}