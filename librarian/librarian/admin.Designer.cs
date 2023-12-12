namespace librarian
{
    partial class admin
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
            this.btn_refresh = new System.Windows.Forms.Button();
            this.bnt_Delete = new System.Windows.Forms.Button();
            this.bnt_Update = new System.Windows.Forms.Button();
            this.bnt_Logout = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.dgv_Books = new System.Windows.Forms.DataGridView();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.librarianDataSet = new librarian.librarianDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new librarian.librarianDataSetTableAdapters.BookTableAdapter();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_BookID = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarianDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_refresh.Location = new System.Drawing.Point(875, 53);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 39);
            this.btn_refresh.TabIndex = 29;
            this.btn_refresh.Text = "refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // bnt_Delete
            // 
            this.bnt_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bnt_Delete.Location = new System.Drawing.Point(286, 58);
            this.bnt_Delete.Name = "bnt_Delete";
            this.bnt_Delete.Size = new System.Drawing.Size(75, 27);
            this.bnt_Delete.TabIndex = 28;
            this.bnt_Delete.Text = "Delete";
            this.bnt_Delete.UseVisualStyleBackColor = false;
            this.bnt_Delete.Click += new System.EventHandler(this.bnt_Delete_Click);
            // 
            // bnt_Update
            // 
            this.bnt_Update.BackColor = System.Drawing.Color.Fuchsia;
            this.bnt_Update.Location = new System.Drawing.Point(87, 55);
            this.bnt_Update.Name = "bnt_Update";
            this.bnt_Update.Size = new System.Drawing.Size(75, 32);
            this.bnt_Update.TabIndex = 27;
            this.bnt_Update.Text = "Update";
            this.bnt_Update.UseVisualStyleBackColor = false;
            this.bnt_Update.Click += new System.EventHandler(this.bnt_Update_Click);
            // 
            // bnt_Logout
            // 
            this.bnt_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bnt_Logout.Location = new System.Drawing.Point(12, 22);
            this.bnt_Logout.Name = "bnt_Logout";
            this.bnt_Logout.Size = new System.Drawing.Size(75, 23);
            this.bnt_Logout.TabIndex = 26;
            this.bnt_Logout.Text = "Logout";
            this.bnt_Logout.UseVisualStyleBackColor = false;
            this.bnt_Logout.Click += new System.EventHandler(this.bnt_Logout_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Insert.Location = new System.Drawing.Point(189, 58);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(73, 27);
            this.btn_Insert.TabIndex = 25;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // dgv_Books
            // 
            this.dgv_Books.AutoGenerateColumns = false;
            this.dgv_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.Title,
            this.Author,
            this.Genre});
            this.dgv_Books.DataSource = this.bookBindingSource;
            this.dgv_Books.Location = new System.Drawing.Point(232, 116);
            this.dgv_Books.Name = "dgv_Books";
            this.dgv_Books.RowHeadersWidth = 51;
            this.dgv_Books.RowTemplate.Height = 24;
            this.dgv_Books.Size = new System.Drawing.Size(739, 336);
            this.dgv_Books.TabIndex = 30;
            this.dgv_Books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(23, 392);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(185, 22);
            this.txtGenre.TabIndex = 31;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(23, 234);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(185, 22);
            this.txtTitle.TabIndex = 36;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(23, 319);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(185, 22);
            this.txtAuthor.TabIndex = 35;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(23, 151);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(185, 22);
            this.txtBookID.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "BookID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Genre";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Purple;
            this.btn_search.Location = new System.Drawing.Point(792, 53);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 38);
            this.btn_search.TabIndex = 42;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(383, 61);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(403, 22);
            this.txt_search.TabIndex = 41;
            // 
            // librarianDataSet
            // 
            this.librarianDataSet.DataSetName = "librarianDataSet";
            this.librarianDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.librarianDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "BookID";
            this.BookID.MinimumWidth = 6;
            this.BookID.Name = "BookID";
            this.BookID.Width = 125;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 125;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.Width = 125;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 6;
            this.Genre.Name = "Genre";
            this.Genre.Width = 125;
            // 
            // lbl_BookID
            // 
            this.lbl_BookID.AutoSize = true;
            this.lbl_BookID.Location = new System.Drawing.Point(23, 180);
            this.lbl_BookID.Name = "lbl_BookID";
            this.lbl_BookID.Size = new System.Drawing.Size(0, 16);
            this.lbl_BookID.TabIndex = 43;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(23, 263);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(0, 16);
            this.lbl_Title.TabIndex = 44;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Location = new System.Drawing.Point(29, 179);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 16);
            this.lbl_Error.TabIndex = 45;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 450);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_BookID);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.dgv_Books);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.bnt_Delete);
            this.Controls.Add(this.bnt_Update);
            this.Controls.Add(this.bnt_Logout);
            this.Controls.Add(this.btn_Insert);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarianDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button bnt_Delete;
        private System.Windows.Forms.Button bnt_Update;
        private System.Windows.Forms.Button bnt_Logout;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.DataGridView dgv_Books;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private librarianDataSet librarianDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private librarianDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.Label lbl_BookID;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Error;
    }
}