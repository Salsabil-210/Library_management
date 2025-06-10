namespace Library_Management_System
{
    partial class Books
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
            this.addbooks_closeBtn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addBooks_category = new System.Windows.Forms.ComboBox();
            this.addBooks_quantity = new System.Windows.Forms.TextBox();
            this.addBooks_clearBtn = new System.Windows.Forms.Button();
            this.addBooks_deleteBtn = new System.Windows.Forms.Button();
            this.addBooks_updateBtn = new System.Windows.Forms.Button();
            this.addBooks_addBtn = new System.Windows.Forms.Button();
            this.addBooks_importBtn = new System.Windows.Forms.Button();
            this.addBooks_author = new System.Windows.Forms.TextBox();
            this.addBooks_title = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addBooks_picture = new System.Windows.Forms.PictureBox();
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
            this.panel1.Controls.Add(this.addbooks_closeBtn);
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
            this.label2.Size = new System.Drawing.Size(326, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Library Mangement System | Books";
            // 
            // addbooks_closeBtn
            // 
            this.addbooks_closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addbooks_closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbooks_closeBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbooks_closeBtn.Image = global::Library_Management_System.Properties.Resources.close;
            this.addbooks_closeBtn.Location = new System.Drawing.Point(1163, 12);
            this.addbooks_closeBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addbooks_closeBtn.Name = "addbooks_closeBtn";
            this.addbooks_closeBtn.Size = new System.Drawing.Size(24, 24);
            this.addbooks_closeBtn.TabIndex = 0;
            this.addbooks_closeBtn.Click += new System.EventHandler(this.addbooks_closeBtn_Click);
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
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.dataGridView);
            this.panel4.Location = new System.Drawing.Point(439, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(748, 631);
            this.panel4.TabIndex = 6;
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
            this.dataGridView.Size = new System.Drawing.Size(703, 537);
            this.dataGridView.TabIndex = 15;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.addBooks_category);
            this.panel3.Controls.Add(this.addBooks_quantity);
            this.panel3.Controls.Add(this.addBooks_clearBtn);
            this.panel3.Controls.Add(this.addBooks_deleteBtn);
            this.panel3.Controls.Add(this.addBooks_updateBtn);
            this.panel3.Controls.Add(this.addBooks_addBtn);
            this.panel3.Controls.Add(this.addBooks_importBtn);
            this.panel3.Controls.Add(this.addBooks_author);
            this.panel3.Controls.Add(this.addBooks_title);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.addBooks_picture);
            this.panel3.Location = new System.Drawing.Point(18, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 631);
            this.panel3.TabIndex = 5;
            // 
            // addBooks_category
            // 
            this.addBooks_category.FormattingEnabled = true;
            this.addBooks_category.Items.AddRange(new object[] {
            "Literature",
            "Math",
            "Programming",
            "Pyschology",
            "Science"});
            this.addBooks_category.Location = new System.Drawing.Point(120, 357);
            this.addBooks_category.Name = "addBooks_category";
            this.addBooks_category.Size = new System.Drawing.Size(269, 28);
            this.addBooks_category.TabIndex = 18;
            // 
            // addBooks_quantity
            // 
            this.addBooks_quantity.Location = new System.Drawing.Point(120, 407);
            this.addBooks_quantity.Name = "addBooks_quantity";
            this.addBooks_quantity.Size = new System.Drawing.Size(269, 26);
            this.addBooks_quantity.TabIndex = 15;
            // 
            // addBooks_clearBtn
            // 
            this.addBooks_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(137)))), ((int)(((byte)(125)))));
            this.addBooks_clearBtn.FlatAppearance.BorderSize = 0;
            this.addBooks_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBooks_clearBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_clearBtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_clearBtn.Location = new System.Drawing.Point(212, 551);
            this.addBooks_clearBtn.Name = "addBooks_clearBtn";
            this.addBooks_clearBtn.Size = new System.Drawing.Size(139, 36);
            this.addBooks_clearBtn.TabIndex = 14;
            this.addBooks_clearBtn.Text = "Clear";
            this.addBooks_clearBtn.UseVisualStyleBackColor = false;
            this.addBooks_clearBtn.Click += new System.EventHandler(this.addBooks_clearBtn_Click);
            // 
            // addBooks_deleteBtn
            // 
            this.addBooks_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(137)))), ((int)(((byte)(125)))));
            this.addBooks_deleteBtn.FlatAppearance.BorderSize = 0;
            this.addBooks_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBooks_deleteBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_deleteBtn.Location = new System.Drawing.Point(51, 551);
            this.addBooks_deleteBtn.Name = "addBooks_deleteBtn";
            this.addBooks_deleteBtn.Size = new System.Drawing.Size(139, 36);
            this.addBooks_deleteBtn.TabIndex = 13;
            this.addBooks_deleteBtn.Text = "Delete";
            this.addBooks_deleteBtn.UseVisualStyleBackColor = false;
            this.addBooks_deleteBtn.Click += new System.EventHandler(this.addBooks_deleteBtn_Click);
            // 
            // addBooks_updateBtn
            // 
            this.addBooks_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(137)))), ((int)(((byte)(125)))));
            this.addBooks_updateBtn.FlatAppearance.BorderSize = 0;
            this.addBooks_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBooks_updateBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_updateBtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_updateBtn.Location = new System.Drawing.Point(212, 494);
            this.addBooks_updateBtn.Name = "addBooks_updateBtn";
            this.addBooks_updateBtn.Size = new System.Drawing.Size(139, 36);
            this.addBooks_updateBtn.TabIndex = 12;
            this.addBooks_updateBtn.Text = "Update";
            this.addBooks_updateBtn.UseVisualStyleBackColor = false;
            this.addBooks_updateBtn.Click += new System.EventHandler(this.addBooks_updateBtn_Click);
            // 
            // addBooks_addBtn
            // 
            this.addBooks_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(137)))), ((int)(((byte)(125)))));
            this.addBooks_addBtn.FlatAppearance.BorderSize = 0;
            this.addBooks_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBooks_addBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_addBtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_addBtn.Location = new System.Drawing.Point(51, 494);
            this.addBooks_addBtn.Name = "addBooks_addBtn";
            this.addBooks_addBtn.Size = new System.Drawing.Size(139, 36);
            this.addBooks_addBtn.TabIndex = 11;
            this.addBooks_addBtn.Text = "Add";
            this.addBooks_addBtn.UseVisualStyleBackColor = false;
            this.addBooks_addBtn.Click += new System.EventHandler(this.addBooks_addBtn_Click);
            // 
            // addBooks_importBtn
            // 
            this.addBooks_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(137)))), ((int)(((byte)(125)))));
            this.addBooks_importBtn.FlatAppearance.BorderSize = 0;
            this.addBooks_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBooks_importBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_importBtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_importBtn.Location = new System.Drawing.Point(132, 180);
            this.addBooks_importBtn.Name = "addBooks_importBtn";
            this.addBooks_importBtn.Size = new System.Drawing.Size(139, 36);
            this.addBooks_importBtn.TabIndex = 10;
            this.addBooks_importBtn.Text = "Import";
            this.addBooks_importBtn.UseVisualStyleBackColor = false;
            this.addBooks_importBtn.Click += new System.EventHandler(this.addBooks_importBtn_Click);
            // 
            // addBooks_author
            // 
            this.addBooks_author.Location = new System.Drawing.Point(120, 306);
            this.addBooks_author.Name = "addBooks_author";
            this.addBooks_author.Size = new System.Drawing.Size(269, 26);
            this.addBooks_author.TabIndex = 7;
            // 
            // addBooks_title
            // 
            this.addBooks_title.Location = new System.Drawing.Point(120, 254);
            this.addBooks_title.Name = "addBooks_title";
            this.addBooks_title.Size = new System.Drawing.Size(269, 26);
            this.addBooks_title.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Title";
            // 
            // addBooks_picture
            // 
            this.addBooks_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.addBooks_picture.Location = new System.Drawing.Point(132, 36);
            this.addBooks_picture.Name = "addBooks_picture";
            this.addBooks_picture.Size = new System.Drawing.Size(139, 148);
            this.addBooks_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addBooks_picture.TabIndex = 0;
            this.addBooks_picture.TabStop = false;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
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
        private System.Windows.Forms.Label addbooks_closeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox addBooks_picture;
        private System.Windows.Forms.TextBox addBooks_author;
        private System.Windows.Forms.TextBox addBooks_title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBooks_importBtn;
        private System.Windows.Forms.Button addBooks_clearBtn;
        private System.Windows.Forms.Button addBooks_deleteBtn;
        private System.Windows.Forms.Button addBooks_updateBtn;
        private System.Windows.Forms.Button addBooks_addBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addBooks_quantity;
        private System.Windows.Forms.ComboBox addBooks_category;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}