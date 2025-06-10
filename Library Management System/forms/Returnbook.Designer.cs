namespace Library_Management_System
{
    partial class Returnbook
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
            this.returnBooks_close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.returnBooks_author = new System.Windows.Forms.TextBox();
            this.returnBooks_bookTitle = new System.Windows.Forms.TextBox();
            this.returnBooks_phone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.returnBooks_email = new System.Windows.Forms.TextBox();
            this.returnBooks_name = new System.Windows.Forms.TextBox();
            this.returnBooks_issueID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.returnBooks_clearBtn = new System.Windows.Forms.Button();
            this.returnBooks_returnBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.returnBooks_issueDate = new System.Windows.Forms.DateTimePicker();
            this.returnBooks_picture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnBooks_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.returnBooks_close);
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
            this.label2.Size = new System.Drawing.Size(391, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Library Mangement System | Return Books";
            // 
            // returnBooks_close
            // 
            this.returnBooks_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBooks_close.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooks_close.Image = global::Library_Management_System.Properties.Resources.close;
            this.returnBooks_close.Location = new System.Drawing.Point(1163, 12);
            this.returnBooks_close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.returnBooks_close.Name = "returnBooks_close";
            this.returnBooks_close.Size = new System.Drawing.Size(24, 24);
            this.returnBooks_close.TabIndex = 0;
            this.returnBooks_close.Click += new System.EventHandler(this.returnBooks_close_Click);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.returnBooks_picture);
            this.panel3.Controls.Add(this.returnBooks_issueDate);
            this.panel3.Controls.Add(this.returnBooks_author);
            this.panel3.Controls.Add(this.returnBooks_bookTitle);
            this.panel3.Controls.Add(this.returnBooks_phone);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.returnBooks_email);
            this.panel3.Controls.Add(this.returnBooks_name);
            this.panel3.Controls.Add(this.returnBooks_issueID);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.returnBooks_clearBtn);
            this.panel3.Controls.Add(this.returnBooks_returnBtn);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(18, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 631);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.dataGridView);
            this.panel4.Location = new System.Drawing.Point(460, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(727, 631);
            this.panel4.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 34);
            this.label7.TabIndex = 16;
            this.label7.Text = "Books Info";
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
            this.dataGridView.Location = new System.Drawing.Point(26, 71);
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
            this.dataGridView.Size = new System.Drawing.Size(679, 537);
            this.dataGridView.TabIndex = 15;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // returnBooks_author
            // 
            this.returnBooks_author.Location = new System.Drawing.Point(139, 448);
            this.returnBooks_author.Name = "returnBooks_author";
            this.returnBooks_author.Size = new System.Drawing.Size(264, 26);
            this.returnBooks_author.TabIndex = 44;
            // 
            // returnBooks_bookTitle
            // 
            this.returnBooks_bookTitle.Location = new System.Drawing.Point(139, 397);
            this.returnBooks_bookTitle.Name = "returnBooks_bookTitle";
            this.returnBooks_bookTitle.Size = new System.Drawing.Size(264, 26);
            this.returnBooks_bookTitle.TabIndex = 43;
            // 
            // returnBooks_phone
            // 
            this.returnBooks_phone.Location = new System.Drawing.Point(139, 346);
            this.returnBooks_phone.Name = "returnBooks_phone";
            this.returnBooks_phone.Size = new System.Drawing.Size(264, 26);
            this.returnBooks_phone.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(55, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 24);
            this.label11.TabIndex = 41;
            this.label11.Text = "IssueID";
            // 
            // returnBooks_email
            // 
            this.returnBooks_email.Location = new System.Drawing.Point(139, 295);
            this.returnBooks_email.Name = "returnBooks_email";
            this.returnBooks_email.Size = new System.Drawing.Size(264, 26);
            this.returnBooks_email.TabIndex = 40;
            // 
            // returnBooks_name
            // 
            this.returnBooks_name.Location = new System.Drawing.Point(139, 244);
            this.returnBooks_name.Name = "returnBooks_name";
            this.returnBooks_name.Size = new System.Drawing.Size(264, 26);
            this.returnBooks_name.TabIndex = 39;
            // 
            // returnBooks_issueID
            // 
            this.returnBooks_issueID.Location = new System.Drawing.Point(139, 193);
            this.returnBooks_issueID.Name = "returnBooks_issueID";
            this.returnBooks_issueID.Size = new System.Drawing.Size(264, 26);
            this.returnBooks_issueID.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 24);
            this.label8.TabIndex = 37;
            this.label8.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(74, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 24);
            this.label9.TabIndex = 36;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(71, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 24);
            this.label10.TabIndex = 35;
            this.label10.Text = "Name";
            // 
            // returnBooks_clearBtn
            // 
            this.returnBooks_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(137)))), ((int)(((byte)(125)))));
            this.returnBooks_clearBtn.FlatAppearance.BorderSize = 0;
            this.returnBooks_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnBooks_clearBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooks_clearBtn.ForeColor = System.Drawing.Color.White;
            this.returnBooks_clearBtn.Location = new System.Drawing.Point(221, 577);
            this.returnBooks_clearBtn.Name = "returnBooks_clearBtn";
            this.returnBooks_clearBtn.Size = new System.Drawing.Size(139, 31);
            this.returnBooks_clearBtn.TabIndex = 34;
            this.returnBooks_clearBtn.Text = "Clear";
            this.returnBooks_clearBtn.UseVisualStyleBackColor = false;
            this.returnBooks_clearBtn.Click += new System.EventHandler(this.returnBooks_clearBtn_Click);
            // 
            // returnBooks_returnBtn
            // 
            this.returnBooks_returnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(137)))), ((int)(((byte)(125)))));
            this.returnBooks_returnBtn.FlatAppearance.BorderSize = 0;
            this.returnBooks_returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnBooks_returnBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooks_returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBooks_returnBtn.Location = new System.Drawing.Point(48, 577);
            this.returnBooks_returnBtn.Name = "returnBooks_returnBtn";
            this.returnBooks_returnBtn.Size = new System.Drawing.Size(139, 31);
            this.returnBooks_returnBtn.TabIndex = 33;
            this.returnBooks_returnBtn.Text = "Return";
            this.returnBooks_returnBtn.UseVisualStyleBackColor = false;
            this.returnBooks_returnBtn.Click += new System.EventHandler(this.returnBooks_returnBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Book Issued";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Book Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Book Title";
            // 
            // returnBooks_issueDate
            // 
            this.returnBooks_issueDate.Location = new System.Drawing.Point(139, 496);
            this.returnBooks_issueDate.Name = "returnBooks_issueDate";
            this.returnBooks_issueDate.Size = new System.Drawing.Size(264, 26);
            this.returnBooks_issueDate.TabIndex = 46;
            // 
            // returnBooks_picture
            // 
            this.returnBooks_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.returnBooks_picture.Location = new System.Drawing.Point(139, 24);
            this.returnBooks_picture.Name = "returnBooks_picture";
            this.returnBooks_picture.Size = new System.Drawing.Size(138, 136);
            this.returnBooks_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnBooks_picture.TabIndex = 47;
            this.returnBooks_picture.TabStop = false;
            // 
            // Returnbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Returnbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return_Book";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnBooks_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label returnBooks_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox returnBooks_author;
        private System.Windows.Forms.TextBox returnBooks_bookTitle;
        private System.Windows.Forms.TextBox returnBooks_phone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox returnBooks_email;
        private System.Windows.Forms.TextBox returnBooks_name;
        private System.Windows.Forms.TextBox returnBooks_issueID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button returnBooks_clearBtn;
        private System.Windows.Forms.Button returnBooks_returnBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker returnBooks_issueDate;
        private System.Windows.Forms.PictureBox returnBooks_picture;
    }
}