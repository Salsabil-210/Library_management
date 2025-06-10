namespace Library_Management_System
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimiz = new System.Windows.Forms.Label();
            this.maximiz = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logout_label = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.returnBooks_btn = new System.Windows.Forms.Button();
            this.issueBooks_btn = new System.Windows.Forms.Button();
            this.addBooks_btn = new System.Windows.Forms.Button();
            this.addMember_btn = new System.Windows.Forms.Button();
            this.greet_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.returnedBooksCount_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.booksCount_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.issuedBooksCount_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.membersCount_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.minimiz);
            this.panel1.Controls.Add(this.maximiz);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1650, 53);
            this.panel1.TabIndex = 1;
            // 
            // minimiz
            // 
            this.minimiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimiz.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimiz.ForeColor = System.Drawing.SystemColors.Window;
            this.minimiz.Image = global::Library_Management_System.Properties.Resources.minimize;
            this.minimiz.Location = new System.Drawing.Point(1489, 9);
            this.minimiz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minimiz.Name = "minimiz";
            this.minimiz.Size = new System.Drawing.Size(35, 34);
            this.minimiz.TabIndex = 3;
            this.minimiz.Click += new System.EventHandler(this.minimiz_Click);
            // 
            // maximiz
            // 
            this.maximiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximiz.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximiz.ForeColor = System.Drawing.SystemColors.Window;
            this.maximiz.Image = global::Library_Management_System.Properties.Resources.maximize;
            this.maximiz.Location = new System.Drawing.Point(1544, 9);
            this.maximiz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maximiz.Name = "maximiz";
            this.maximiz.Size = new System.Drawing.Size(35, 37);
            this.maximiz.TabIndex = 2;
            this.maximiz.Click += new System.EventHandler(this.maximiz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Library Management System | Main Form";
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.Window;
            this.Exit.Image = global::Library_Management_System.Properties.Resources.close;
            this.Exit.Location = new System.Drawing.Point(1601, 14);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(35, 28);
            this.Exit.TabIndex = 0;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Logout_label);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.returnBooks_btn);
            this.panel2.Controls.Add(this.issueBooks_btn);
            this.panel2.Controls.Add(this.addBooks_btn);
            this.panel2.Controls.Add(this.addMember_btn);
            this.panel2.Controls.Add(this.greet_label);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 870);
            this.panel2.TabIndex = 2;
            // 
            // Logout_label
            // 
            this.Logout_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Logout_label.AutoSize = true;
            this.Logout_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_label.ForeColor = System.Drawing.Color.White;
            this.Logout_label.Location = new System.Drawing.Point(62, 817);
            this.Logout_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Logout_label.Name = "Logout_label";
            this.Logout_label.Size = new System.Drawing.Size(93, 29);
            this.Logout_label.TabIndex = 7;
            this.Logout_label.Text = "Log out";
            // 
            // logout_btn
            // 
            this.logout_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(5)))), ((int)(((byte)(24)))));
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(5)))), ((int)(((byte)(24)))));
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = global::Library_Management_System.Properties.Resources.logout;
            this.logout_btn.Location = new System.Drawing.Point(12, 811);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(44, 44);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // returnBooks_btn
            // 
            this.returnBooks_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.returnBooks_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(137)))), ((int)(((byte)(125)))));
            this.returnBooks_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBooks_btn.FlatAppearance.BorderSize = 0;
            this.returnBooks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(196)))), ((int)(((byte)(207)))));
            this.returnBooks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(196)))), ((int)(((byte)(207)))));
            this.returnBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBooks_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooks_btn.ForeColor = System.Drawing.Color.White;
            this.returnBooks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBooks_btn.Location = new System.Drawing.Point(12, 520);
            this.returnBooks_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.returnBooks_btn.Name = "returnBooks_btn";
            this.returnBooks_btn.Size = new System.Drawing.Size(300, 69);
            this.returnBooks_btn.TabIndex = 5;
            this.returnBooks_btn.Text = "RETURN BOOKS";
            this.returnBooks_btn.UseVisualStyleBackColor = false;
            this.returnBooks_btn.Click += new System.EventHandler(this.returnBooks_btn_Click);
            // 
            // issueBooks_btn
            // 
            this.issueBooks_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.issueBooks_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(137)))), ((int)(((byte)(125)))));
            this.issueBooks_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issueBooks_btn.FlatAppearance.BorderSize = 0;
            this.issueBooks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(196)))), ((int)(((byte)(207)))));
            this.issueBooks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(196)))), ((int)(((byte)(207)))));
            this.issueBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueBooks_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueBooks_btn.ForeColor = System.Drawing.Color.White;
            this.issueBooks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issueBooks_btn.Location = new System.Drawing.Point(12, 442);
            this.issueBooks_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.issueBooks_btn.Name = "issueBooks_btn";
            this.issueBooks_btn.Size = new System.Drawing.Size(300, 69);
            this.issueBooks_btn.TabIndex = 4;
            this.issueBooks_btn.Text = "ISSUE BOOKS";
            this.issueBooks_btn.UseVisualStyleBackColor = false;
            this.issueBooks_btn.Click += new System.EventHandler(this.issueBooks_btn_Click);
            // 
            // addBooks_btn
            // 
            this.addBooks_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addBooks_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(137)))), ((int)(((byte)(125)))));
            this.addBooks_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBooks_btn.FlatAppearance.BorderSize = 0;
            this.addBooks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(196)))), ((int)(((byte)(207)))));
            this.addBooks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(196)))), ((int)(((byte)(207)))));
            this.addBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBooks_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_btn.ForeColor = System.Drawing.Color.White;
            this.addBooks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBooks_btn.Location = new System.Drawing.Point(12, 363);
            this.addBooks_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBooks_btn.Name = "addBooks_btn";
            this.addBooks_btn.Size = new System.Drawing.Size(300, 69);
            this.addBooks_btn.TabIndex = 3;
            this.addBooks_btn.Text = "BOOKS";
            this.addBooks_btn.UseVisualStyleBackColor = false;
            this.addBooks_btn.Click += new System.EventHandler(this.addBooks_btn_Click);
            // 
            // addMember_btn
            // 
            this.addMember_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addMember_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(137)))), ((int)(((byte)(125)))));
            this.addMember_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMember_btn.FlatAppearance.BorderSize = 0;
            this.addMember_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(196)))), ((int)(((byte)(207)))));
            this.addMember_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(196)))), ((int)(((byte)(207)))));
            this.addMember_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMember_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMember_btn.ForeColor = System.Drawing.Color.White;
            this.addMember_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addMember_btn.Location = new System.Drawing.Point(12, 285);
            this.addMember_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addMember_btn.Name = "addMember_btn";
            this.addMember_btn.Size = new System.Drawing.Size(300, 69);
            this.addMember_btn.TabIndex = 2;
            this.addMember_btn.Text = "MEMBERS";
            this.addMember_btn.UseVisualStyleBackColor = false;
            this.addMember_btn.Click += new System.EventHandler(this.addMember_btn_Click);
            // 
            // greet_label
            // 
            this.greet_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.greet_label.AutoSize = true;
            this.greet_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_label.ForeColor = System.Drawing.Color.White;
            this.greet_label.Location = new System.Drawing.Point(62, 202);
            this.greet_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greet_label.Name = "greet_label";
            this.greet_label.Size = new System.Drawing.Size(190, 29);
            this.greet_label.TabIndex = 1;
            this.greet_label.Text = "Welcome, Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::Library_Management_System.Properties.Resources.library;
            this.pictureBox1.Location = new System.Drawing.Point(102, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(329, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1321, 870);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Library_Management_System.Properties.Resources.home_library;
            this.pictureBox2.Location = new System.Drawing.Point(20, 327);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1280, 531);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(20, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1280, 283);
            this.panel4.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Controls.Add(this.returnedBooksCount_label);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(963, 29);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(290, 220);
            this.panel6.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Library_Management_System.Properties.Resources._return;
            this.pictureBox4.Location = new System.Drawing.Point(36, 100);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 86);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // returnedBooksCount_label
            // 
            this.returnedBooksCount_label.AutoSize = true;
            this.returnedBooksCount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnedBooksCount_label.ForeColor = System.Drawing.Color.Black;
            this.returnedBooksCount_label.Location = new System.Drawing.Point(230, 174);
            this.returnedBooksCount_label.Name = "returnedBooksCount_label";
            this.returnedBooksCount_label.Size = new System.Drawing.Size(36, 37);
            this.returnedBooksCount_label.TabIndex = 7;
            this.returnedBooksCount_label.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(40, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 32);
            this.label7.TabIndex = 3;
            this.label7.Text = "Returned Books";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel8.Controls.Add(this.pictureBox6);
            this.panel8.Controls.Add(this.booksCount_label);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(343, 29);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(290, 220);
            this.panel8.TabIndex = 1;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Library_Management_System.Properties.Resources.Avaliable_book;
            this.pictureBox6.Location = new System.Drawing.Point(31, 90);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 86);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // booksCount_label
            // 
            this.booksCount_label.AutoSize = true;
            this.booksCount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksCount_label.ForeColor = System.Drawing.Color.Black;
            this.booksCount_label.Location = new System.Drawing.Point(234, 174);
            this.booksCount_label.Name = "booksCount_label";
            this.booksCount_label.Size = new System.Drawing.Size(36, 37);
            this.booksCount_label.TabIndex = 6;
            this.booksCount_label.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(42, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Availabe Books";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Controls.Add(this.issuedBooksCount_label);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(653, 29);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(290, 220);
            this.panel7.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Library_Management_System.Properties.Resources.borrowing;
            this.pictureBox5.Location = new System.Drawing.Point(29, 90);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(103, 96);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // issuedBooksCount_label
            // 
            this.issuedBooksCount_label.AutoSize = true;
            this.issuedBooksCount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedBooksCount_label.ForeColor = System.Drawing.Color.Black;
            this.issuedBooksCount_label.Location = new System.Drawing.Point(227, 174);
            this.issuedBooksCount_label.Name = "issuedBooksCount_label";
            this.issuedBooksCount_label.Size = new System.Drawing.Size(36, 37);
            this.issuedBooksCount_label.TabIndex = 5;
            this.issuedBooksCount_label.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(53, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Issued Books";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.membersCount_label);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(33, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(290, 220);
            this.panel5.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Library_Management_System.Properties.Resources.Members;
            this.pictureBox3.Location = new System.Drawing.Point(37, 90);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 107);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // membersCount_label
            // 
            this.membersCount_label.AutoSize = true;
            this.membersCount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersCount_label.ForeColor = System.Drawing.Color.Black;
            this.membersCount_label.Location = new System.Drawing.Point(231, 174);
            this.membersCount_label.Name = "membersCount_label";
            this.membersCount_label.Size = new System.Drawing.Size(36, 37);
            this.membersCount_label.TabIndex = 4;
            this.membersCount_label.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(73, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Members";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 923);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Logout_label;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button returnBooks_btn;
        private System.Windows.Forms.Button issueBooks_btn;
        private System.Windows.Forms.Button addBooks_btn;
        private System.Windows.Forms.Button addMember_btn;
        private System.Windows.Forms.Label greet_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label returnedBooksCount_label;
        private System.Windows.Forms.Label booksCount_label;
        private System.Windows.Forms.Label issuedBooksCount_label;
        private System.Windows.Forms.Label membersCount_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label minimiz;
        private System.Windows.Forms.Label maximiz;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}