namespace AppBookingTickets
{
    partial class FormAdministration
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonFilmDelete = new System.Windows.Forms.Button();
            this.buttonFilmChange = new System.Windows.Forms.Button();
            this.buttonFilmAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonProductionDelete = new System.Windows.Forms.Button();
            this.buttonProductionChange = new System.Windows.Forms.Button();
            this.buttonProductionAdd = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonGenreDelete = new System.Windows.Forms.Button();
            this.buttonGenreChange = new System.Windows.Forms.Button();
            this.buttonGenreAdd = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonHallDelete = new System.Windows.Forms.Button();
            this.buttonHallChange = new System.Windows.Forms.Button();
            this.buttonHallAdd = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonCategoryDelete = new System.Windows.Forms.Button();
            this.buttonCategoryChange = new System.Windows.Forms.Button();
            this.buttonCategoryAdd = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.buttonPriceDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonPriceAdd = new System.Windows.Forms.Button();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.buttonCountryDelete = new System.Windows.Forms.Button();
            this.buttonCountryChange = new System.Windows.Forms.Button();
            this.buttonCountryAdd = new System.Windows.Forms.Button();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(42, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(676, 510);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonFilmDelete);
            this.tabPage1.Controls.Add(this.buttonFilmChange);
            this.tabPage1.Controls.Add(this.buttonFilmAdd);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(668, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Фільми";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonFilmDelete
            // 
            this.buttonFilmDelete.Location = new System.Drawing.Point(451, 346);
            this.buttonFilmDelete.Name = "buttonFilmDelete";
            this.buttonFilmDelete.Size = new System.Drawing.Size(154, 46);
            this.buttonFilmDelete.TabIndex = 3;
            this.buttonFilmDelete.Text = "Видалити";
            this.buttonFilmDelete.UseVisualStyleBackColor = true;
            this.buttonFilmDelete.Click += new System.EventHandler(this.buttonFilmDelete_Click);
            // 
            // buttonFilmChange
            // 
            this.buttonFilmChange.Location = new System.Drawing.Point(249, 346);
            this.buttonFilmChange.Name = "buttonFilmChange";
            this.buttonFilmChange.Size = new System.Drawing.Size(154, 46);
            this.buttonFilmChange.TabIndex = 2;
            this.buttonFilmChange.Text = "Змінити";
            this.buttonFilmChange.UseVisualStyleBackColor = true;
            this.buttonFilmChange.Click += new System.EventHandler(this.buttonFilmChange_Click);
            // 
            // buttonFilmAdd
            // 
            this.buttonFilmAdd.Location = new System.Drawing.Point(51, 346);
            this.buttonFilmAdd.Name = "buttonFilmAdd";
            this.buttonFilmAdd.Size = new System.Drawing.Size(154, 46);
            this.buttonFilmAdd.TabIndex = 1;
            this.buttonFilmAdd.Text = "Додати";
            this.buttonFilmAdd.UseVisualStyleBackColor = true;
            this.buttonFilmAdd.Click += new System.EventHandler(this.buttonFilmAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(627, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonProductionDelete);
            this.tabPage2.Controls.Add(this.buttonProductionChange);
            this.tabPage2.Controls.Add(this.buttonProductionAdd);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(668, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Виробники";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonProductionDelete
            // 
            this.buttonProductionDelete.Location = new System.Drawing.Point(446, 362);
            this.buttonProductionDelete.Name = "buttonProductionDelete";
            this.buttonProductionDelete.Size = new System.Drawing.Size(154, 46);
            this.buttonProductionDelete.TabIndex = 6;
            this.buttonProductionDelete.Text = "Видалити";
            this.buttonProductionDelete.UseVisualStyleBackColor = true;
            this.buttonProductionDelete.Click += new System.EventHandler(this.buttonProductionDelete_Click);
            // 
            // buttonProductionChange
            // 
            this.buttonProductionChange.Location = new System.Drawing.Point(244, 362);
            this.buttonProductionChange.Name = "buttonProductionChange";
            this.buttonProductionChange.Size = new System.Drawing.Size(154, 46);
            this.buttonProductionChange.TabIndex = 5;
            this.buttonProductionChange.Text = "Змінити";
            this.buttonProductionChange.UseVisualStyleBackColor = true;
            this.buttonProductionChange.Click += new System.EventHandler(this.buttonProductionChange_Click);
            // 
            // buttonProductionAdd
            // 
            this.buttonProductionAdd.Location = new System.Drawing.Point(46, 362);
            this.buttonProductionAdd.Name = "buttonProductionAdd";
            this.buttonProductionAdd.Size = new System.Drawing.Size(154, 46);
            this.buttonProductionAdd.TabIndex = 4;
            this.buttonProductionAdd.Text = "Додати";
            this.buttonProductionAdd.UseVisualStyleBackColor = true;
            this.buttonProductionAdd.Click += new System.EventHandler(this.buttonProductionAdd_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(623, 284);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonGenreDelete);
            this.tabPage3.Controls.Add(this.buttonGenreChange);
            this.tabPage3.Controls.Add(this.buttonGenreAdd);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(668, 473);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Жанри";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonGenreDelete
            // 
            this.buttonGenreDelete.Location = new System.Drawing.Point(445, 355);
            this.buttonGenreDelete.Name = "buttonGenreDelete";
            this.buttonGenreDelete.Size = new System.Drawing.Size(154, 46);
            this.buttonGenreDelete.TabIndex = 6;
            this.buttonGenreDelete.Text = "Видалити";
            this.buttonGenreDelete.UseVisualStyleBackColor = true;
            this.buttonGenreDelete.Click += new System.EventHandler(this.buttonGenreDelete_Click);
            // 
            // buttonGenreChange
            // 
            this.buttonGenreChange.Location = new System.Drawing.Point(243, 355);
            this.buttonGenreChange.Name = "buttonGenreChange";
            this.buttonGenreChange.Size = new System.Drawing.Size(154, 46);
            this.buttonGenreChange.TabIndex = 5;
            this.buttonGenreChange.Text = "Змінити";
            this.buttonGenreChange.UseVisualStyleBackColor = true;
            this.buttonGenreChange.Click += new System.EventHandler(this.buttonGenreChange_Click);
            // 
            // buttonGenreAdd
            // 
            this.buttonGenreAdd.Location = new System.Drawing.Point(45, 355);
            this.buttonGenreAdd.Name = "buttonGenreAdd";
            this.buttonGenreAdd.Size = new System.Drawing.Size(154, 46);
            this.buttonGenreAdd.TabIndex = 4;
            this.buttonGenreAdd.Text = "Додати";
            this.buttonGenreAdd.UseVisualStyleBackColor = true;
            this.buttonGenreAdd.Click += new System.EventHandler(this.buttonGenreAdd_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(18, 23);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(626, 276);
            this.dataGridView3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonHallDelete);
            this.tabPage4.Controls.Add(this.buttonHallChange);
            this.tabPage4.Controls.Add(this.buttonHallAdd);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(668, 473);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Зали";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonHallDelete
            // 
            this.buttonHallDelete.Location = new System.Drawing.Point(441, 276);
            this.buttonHallDelete.Name = "buttonHallDelete";
            this.buttonHallDelete.Size = new System.Drawing.Size(154, 46);
            this.buttonHallDelete.TabIndex = 6;
            this.buttonHallDelete.Text = "Видалити";
            this.buttonHallDelete.UseVisualStyleBackColor = true;
            this.buttonHallDelete.Click += new System.EventHandler(this.buttonHallDelete_Click);
            // 
            // buttonHallChange
            // 
            this.buttonHallChange.Location = new System.Drawing.Point(239, 276);
            this.buttonHallChange.Name = "buttonHallChange";
            this.buttonHallChange.Size = new System.Drawing.Size(154, 46);
            this.buttonHallChange.TabIndex = 5;
            this.buttonHallChange.Text = "Змінити";
            this.buttonHallChange.UseVisualStyleBackColor = true;
            this.buttonHallChange.Click += new System.EventHandler(this.buttonHallChange_Click);
            // 
            // buttonHallAdd
            // 
            this.buttonHallAdd.Location = new System.Drawing.Point(41, 276);
            this.buttonHallAdd.Name = "buttonHallAdd";
            this.buttonHallAdd.Size = new System.Drawing.Size(154, 46);
            this.buttonHallAdd.TabIndex = 4;
            this.buttonHallAdd.Text = "Додати";
            this.buttonHallAdd.UseVisualStyleBackColor = true;
            this.buttonHallAdd.Click += new System.EventHandler(this.buttonHallAdd_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(19, 24);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(631, 207);
            this.dataGridView4.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonCategoryDelete);
            this.tabPage5.Controls.Add(this.buttonCategoryChange);
            this.tabPage5.Controls.Add(this.buttonCategoryAdd);
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 33);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(668, 473);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Категорії";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonCategoryDelete
            // 
            this.buttonCategoryDelete.Location = new System.Drawing.Point(456, 325);
            this.buttonCategoryDelete.Name = "buttonCategoryDelete";
            this.buttonCategoryDelete.Size = new System.Drawing.Size(154, 46);
            this.buttonCategoryDelete.TabIndex = 6;
            this.buttonCategoryDelete.Text = "Видалити";
            this.buttonCategoryDelete.UseVisualStyleBackColor = true;
            this.buttonCategoryDelete.Click += new System.EventHandler(this.buttonCategoryDelete_Click);
            // 
            // buttonCategoryChange
            // 
            this.buttonCategoryChange.Location = new System.Drawing.Point(254, 325);
            this.buttonCategoryChange.Name = "buttonCategoryChange";
            this.buttonCategoryChange.Size = new System.Drawing.Size(154, 46);
            this.buttonCategoryChange.TabIndex = 5;
            this.buttonCategoryChange.Text = "Змінити";
            this.buttonCategoryChange.UseVisualStyleBackColor = true;
            this.buttonCategoryChange.Click += new System.EventHandler(this.buttonCategoryChange_Click);
            // 
            // buttonCategoryAdd
            // 
            this.buttonCategoryAdd.Location = new System.Drawing.Point(56, 325);
            this.buttonCategoryAdd.Name = "buttonCategoryAdd";
            this.buttonCategoryAdd.Size = new System.Drawing.Size(154, 46);
            this.buttonCategoryAdd.TabIndex = 4;
            this.buttonCategoryAdd.Text = "Додати";
            this.buttonCategoryAdd.UseVisualStyleBackColor = true;
            this.buttonCategoryAdd.Click += new System.EventHandler(this.buttonCategoryAdd_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(56, 27);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(554, 233);
            this.dataGridView5.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.buttonPriceDelete);
            this.tabPage6.Controls.Add(this.buttonChange);
            this.tabPage6.Controls.Add(this.buttonPriceAdd);
            this.tabPage6.Controls.Add(this.dataGridView6);
            this.tabPage6.Location = new System.Drawing.Point(4, 33);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(668, 473);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Ціни";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // buttonPriceDelete
            // 
            this.buttonPriceDelete.Location = new System.Drawing.Point(453, 372);
            this.buttonPriceDelete.Name = "buttonPriceDelete";
            this.buttonPriceDelete.Size = new System.Drawing.Size(154, 46);
            this.buttonPriceDelete.TabIndex = 6;
            this.buttonPriceDelete.Text = "Видалити";
            this.buttonPriceDelete.UseVisualStyleBackColor = true;
            this.buttonPriceDelete.Click += new System.EventHandler(this.buttonPriceDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(251, 372);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(154, 46);
            this.buttonChange.TabIndex = 5;
            this.buttonChange.Text = "Змінити";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonPriceAdd
            // 
            this.buttonPriceAdd.Location = new System.Drawing.Point(53, 372);
            this.buttonPriceAdd.Name = "buttonPriceAdd";
            this.buttonPriceAdd.Size = new System.Drawing.Size(154, 46);
            this.buttonPriceAdd.TabIndex = 4;
            this.buttonPriceAdd.Text = "Додати";
            this.buttonPriceAdd.UseVisualStyleBackColor = true;
            this.buttonPriceAdd.Click += new System.EventHandler(this.buttonPriceAdd_Click);
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(31, 40);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 24;
            this.dataGridView6.Size = new System.Drawing.Size(605, 293);
            this.dataGridView6.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.buttonCountryDelete);
            this.tabPage7.Controls.Add(this.buttonCountryChange);
            this.tabPage7.Controls.Add(this.buttonCountryAdd);
            this.tabPage7.Controls.Add(this.dataGridView7);
            this.tabPage7.Location = new System.Drawing.Point(4, 33);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(668, 473);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Країни";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // buttonCountryDelete
            // 
            this.buttonCountryDelete.Location = new System.Drawing.Point(452, 337);
            this.buttonCountryDelete.Name = "buttonCountryDelete";
            this.buttonCountryDelete.Size = new System.Drawing.Size(154, 46);
            this.buttonCountryDelete.TabIndex = 9;
            this.buttonCountryDelete.Text = "Видалити";
            this.buttonCountryDelete.UseVisualStyleBackColor = true;
            this.buttonCountryDelete.Click += new System.EventHandler(this.buttonCountryDelete_Click);
            // 
            // buttonCountryChange
            // 
            this.buttonCountryChange.Location = new System.Drawing.Point(250, 337);
            this.buttonCountryChange.Name = "buttonCountryChange";
            this.buttonCountryChange.Size = new System.Drawing.Size(154, 46);
            this.buttonCountryChange.TabIndex = 8;
            this.buttonCountryChange.Text = "Змінити";
            this.buttonCountryChange.UseVisualStyleBackColor = true;
            this.buttonCountryChange.Click += new System.EventHandler(this.buttonCountryChange_Click);
            // 
            // buttonCountryAdd
            // 
            this.buttonCountryAdd.Location = new System.Drawing.Point(52, 337);
            this.buttonCountryAdd.Name = "buttonCountryAdd";
            this.buttonCountryAdd.Size = new System.Drawing.Size(154, 46);
            this.buttonCountryAdd.TabIndex = 7;
            this.buttonCountryAdd.Text = "Додати";
            this.buttonCountryAdd.UseVisualStyleBackColor = true;
            this.buttonCountryAdd.Click += new System.EventHandler(this.buttonCountryAdd_Click);
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(34, 38);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.RowHeadersWidth = 51;
            this.dataGridView7.RowTemplate.Height = 24;
            this.dataGridView7.Size = new System.Drawing.Size(602, 230);
            this.dataGridView7.TabIndex = 0;
            // 
            // FormAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 584);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdministration";
            this.Text = "FormAdministration";
            this.Load += new System.EventHandler(this.FormAdministration_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.Button buttonFilmDelete;
        private System.Windows.Forms.Button buttonFilmChange;
        private System.Windows.Forms.Button buttonFilmAdd;
        private System.Windows.Forms.Button buttonProductionDelete;
        private System.Windows.Forms.Button buttonProductionAdd;
        private System.Windows.Forms.Button buttonGenreDelete;
        private System.Windows.Forms.Button buttonGenreChange;
        private System.Windows.Forms.Button buttonGenreAdd;
        private System.Windows.Forms.Button buttonHallDelete;
        private System.Windows.Forms.Button buttonHallChange;
        private System.Windows.Forms.Button buttonHallAdd;
        private System.Windows.Forms.Button buttonCategoryDelete;
        private System.Windows.Forms.Button buttonCategoryChange;
        private System.Windows.Forms.Button buttonCategoryAdd;
        private System.Windows.Forms.Button buttonPriceDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonPriceAdd;
        private System.Windows.Forms.Button buttonProductionChange;
        private System.Windows.Forms.Button buttonCountryDelete;
        private System.Windows.Forms.Button buttonCountryChange;
        private System.Windows.Forms.Button buttonCountryAdd;
    }
}