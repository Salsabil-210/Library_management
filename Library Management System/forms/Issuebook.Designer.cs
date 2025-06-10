namespace Library_Management_System.forms
{
    partial class Issuebook
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bookIssue_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bookIssue_returnDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.bookIssue_booktitle = new System.Windows.Forms.ComboBox();
            this.bookIssue_author = new System.Windows.Forms.ComboBox();
            this.bookIssue_phone = new System.Windows.Forms.TextBox();
            this.bookIssue_email = new System.Windows.Forms.TextBox();
            this.bookIssue_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bookIssue_clearBtn = new System.Windows.Forms.Button();
            this.bookIssue_deleteBtn = new System.Windows.Forms.Button();
            this.bookIssue_updateBtn = new System.Windows.Forms.Button();
            this.bookIssue_addBtn = new System.Windows.Forms.Button();
            this.bookIssue_issueDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookIssue_picture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookIssue_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
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
            this.label2.Size = new System.Drawing.Size(381, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Library Mangement System | Isuue Books";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Library_Management_System.Properties.Resources.close;
            this.label1.Location = new System.Drawing.Point(1163, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 0;
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
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.dataGridView);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(18, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1169, 368);
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
            this.dataGridView.Location = new System.Drawing.Point(26, 61);
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
            this.dataGridView.Size = new System.Drawing.Size(1123, 287);
            this.dataGridView.TabIndex = 18;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 34);
            this.label7.TabIndex = 16;
            this.label7.Text = "Issued Books";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.bookIssue_id);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.bookIssue_returnDate);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.bookIssue_booktitle);
            this.panel3.Controls.Add(this.bookIssue_author);
            this.panel3.Controls.Add(this.bookIssue_phone);
            this.panel3.Controls.Add(this.bookIssue_email);
            this.panel3.Controls.Add(this.bookIssue_name);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.bookIssue_clearBtn);
            this.panel3.Controls.Add(this.bookIssue_deleteBtn);
            this.panel3.Controls.Add(this.bookIssue_updateBtn);
            this.panel3.Controls.Add(this.bookIssue_addBtn);
            this.panel3.Controls.Add(this.bookIssue_issueDate);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.bookIssue_picture);
            this.panel3.Location = new System.Drawing.Point(18, 416);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1169, 246);
            this.panel3.TabIndex = 7;
            // 
            // bookIssue_id
            // 
            this.bookIssue_id.Location = new System.Drawing.Point(108, 41);
            this.bookIssue_id.Name = "bookIssue_id";
            this.bookIssue_id.Size = new System.Drawing.Size(269, 26);
            this.bookIssue_id.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 24);
            this.label11.TabIndex = 27;
            this.label11.Text = "Issue No";
            // 
            // bookIssue_returnDate
            // 
            this.bookIssue_returnDate.Location = new System.Drawing.Point(519, 181);
            this.bookIssue_returnDate.Name = "bookIssue_returnDate";
            this.bookIssue_returnDate.Size = new System.Drawing.Size(269, 26);
            this.bookIssue_returnDate.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Return Date";
            // 
            // bookIssue_booktitle
            // 
            this.bookIssue_booktitle.FormattingEnabled = true;
            this.bookIssue_booktitle.Location = new System.Drawing.Point(519, 36);
            this.bookIssue_booktitle.Name = "bookIssue_booktitle";
            this.bookIssue_booktitle.Size = new System.Drawing.Size(269, 28);
            this.bookIssue_booktitle.TabIndex = 24;
            this.bookIssue_booktitle.SelectedIndexChanged += new System.EventHandler(this.bookIssue_booktitle_SelectedIndexChanged);
            // 
            // bookIssue_author
            // 
            this.bookIssue_author.FormattingEnabled = true;
            this.bookIssue_author.Location = new System.Drawing.Point(519, 85);
            this.bookIssue_author.Name = "bookIssue_author";
            this.bookIssue_author.Size = new System.Drawing.Size(269, 28);
            this.bookIssue_author.TabIndex = 23;
            // 
            // bookIssue_phone
            // 
            this.bookIssue_phone.Location = new System.Drawing.Point(108, 182);
            this.bookIssue_phone.Name = "bookIssue_phone";
            this.bookIssue_phone.Size = new System.Drawing.Size(269, 26);
            this.bookIssue_phone.TabIndex = 21;
            // 
            // bookIssue_email
            // 
            this.bookIssue_email.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bookIssue_email.Location = new System.Drawing.Point(108, 135);
            this.bookIssue_email.Name = "bookIssue_email";
            this.bookIssue_email.Size = new System.Drawing.Size(269, 26);
            this.bookIssue_email.TabIndex = 20;
            this.bookIssue_email.TextChanged += new System.EventHandler(this.bookIssue_email_TextChanged);
            // 
            // bookIssue_name
            // 
            this.bookIssue_name.Location = new System.Drawing.Point(108, 88);
            this.bookIssue_name.Name = "bookIssue_name";
            this.bookIssue_name.Size = new System.Drawing.Size(269, 26);
            this.bookIssue_name.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Name";
            // 
            // bookIssue_clearBtn
            // 
            this.bookIssue_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(137)))), ((int)(((byte)(125)))));
            this.bookIssue_clearBtn.FlatAppearance.BorderSize = 0;
            this.bookIssue_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bookIssue_clearBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_clearBtn.ForeColor = System.Drawing.Color.White;
            this.bookIssue_clearBtn.Location = new System.Drawing.Point(1000, 170);
            this.bookIssue_clearBtn.Name = "bookIssue_clearBtn";
            this.bookIssue_clearBtn.Size = new System.Drawing.Size(139, 36);
            this.bookIssue_clearBtn.TabIndex = 14;
            this.bookIssue_clearBtn.Text = "Clear";
            this.bookIssue_clearBtn.UseVisualStyleBackColor = false;
            this.bookIssue_clearBtn.Click += new System.EventHandler(this.bookIssue_clearBtn_Click);
            // 
            // bookIssue_deleteBtn
            // 
            this.bookIssue_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(137)))), ((int)(((byte)(125)))));
            this.bookIssue_deleteBtn.FlatAppearance.BorderSize = 0;
            this.bookIssue_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bookIssue_deleteBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.bookIssue_deleteBtn.Location = new System.Drawing.Point(1000, 127);
            this.bookIssue_deleteBtn.Name = "bookIssue_deleteBtn";
            this.bookIssue_deleteBtn.Size = new System.Drawing.Size(139, 36);
            this.bookIssue_deleteBtn.TabIndex = 13;
            this.bookIssue_deleteBtn.Text = "Delete";
            this.bookIssue_deleteBtn.UseVisualStyleBackColor = false;
            this.bookIssue_deleteBtn.Click += new System.EventHandler(this.bookIssue_deleteBtn_Click);
            // 
            // bookIssue_updateBtn
            // 
            this.bookIssue_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(137)))), ((int)(((byte)(125)))));
            this.bookIssue_updateBtn.FlatAppearance.BorderSize = 0;
            this.bookIssue_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bookIssue_updateBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_updateBtn.ForeColor = System.Drawing.Color.White;
            this.bookIssue_updateBtn.Location = new System.Drawing.Point(1000, 84);
            this.bookIssue_updateBtn.Name = "bookIssue_updateBtn";
            this.bookIssue_updateBtn.Size = new System.Drawing.Size(139, 36);
            this.bookIssue_updateBtn.TabIndex = 12;
            this.bookIssue_updateBtn.Text = "Update";
            this.bookIssue_updateBtn.UseVisualStyleBackColor = false;
            this.bookIssue_updateBtn.Click += new System.EventHandler(this.bookIssue_updateBtn_Click);
            // 
            // bookIssue_addBtn
            // 
            this.bookIssue_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(137)))), ((int)(((byte)(125)))));
            this.bookIssue_addBtn.FlatAppearance.BorderSize = 0;
            this.bookIssue_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bookIssue_addBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_addBtn.ForeColor = System.Drawing.Color.White;
            this.bookIssue_addBtn.Location = new System.Drawing.Point(1000, 41);
            this.bookIssue_addBtn.Name = "bookIssue_addBtn";
            this.bookIssue_addBtn.Size = new System.Drawing.Size(139, 36);
            this.bookIssue_addBtn.TabIndex = 11;
            this.bookIssue_addBtn.Text = "Add";
            this.bookIssue_addBtn.UseVisualStyleBackColor = false;
            this.bookIssue_addBtn.Click += new System.EventHandler(this.bookIssue_addBtn_Click);
            // 
            // bookIssue_issueDate
            // 
            this.bookIssue_issueDate.Location = new System.Drawing.Point(519, 134);
            this.bookIssue_issueDate.Name = "bookIssue_issueDate";
            this.bookIssue_issueDate.Size = new System.Drawing.Size(269, 26);
            this.bookIssue_issueDate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Issue Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Title";
            // 
            // bookIssue_picture
            // 
            this.bookIssue_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.bookIssue_picture.Location = new System.Drawing.Point(829, 36);
            this.bookIssue_picture.Name = "bookIssue_picture";
            this.bookIssue_picture.Size = new System.Drawing.Size(138, 173);
            this.bookIssue_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookIssue_picture.TabIndex = 0;
            this.bookIssue_picture.TabStop = false;
            // 
            // Issuebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Issuebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookIssue_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox bookIssue_booktitle;
        private System.Windows.Forms.ComboBox bookIssue_author;
        private System.Windows.Forms.TextBox bookIssue_phone;
        private System.Windows.Forms.TextBox bookIssue_email;
        private System.Windows.Forms.TextBox bookIssue_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bookIssue_clearBtn;
        private System.Windows.Forms.Button bookIssue_deleteBtn;
        private System.Windows.Forms.Button bookIssue_updateBtn;
        private System.Windows.Forms.Button bookIssue_addBtn;
        private System.Windows.Forms.DateTimePicker bookIssue_issueDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox bookIssue_picture;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox bookIssue_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker bookIssue_returnDate;
        private System.Windows.Forms.Label label6;
    }
}