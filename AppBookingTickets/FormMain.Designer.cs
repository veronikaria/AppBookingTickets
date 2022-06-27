namespace AppBookingTickets
{
    partial class FormMain
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
            this.buttonAdministration = new System.Windows.Forms.Button();
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.buttonListByDate = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMyTickets = new System.Windows.Forms.Button();
            this.buttonPrices = new System.Windows.Forms.Button();
            this.buttonListByData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdministration
            // 
            this.buttonAdministration.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonAdministration.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdministration.Location = new System.Drawing.Point(124, 31);
            this.buttonAdministration.Name = "buttonAdministration";
            this.buttonAdministration.Size = new System.Drawing.Size(615, 50);
            this.buttonAdministration.TabIndex = 0;
            this.buttonAdministration.Text = "Адміністрування";
            this.buttonAdministration.UseVisualStyleBackColor = false;
            this.buttonAdministration.Click += new System.EventHandler(this.buttonAdministration_Click);
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonSchedule.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSchedule.Location = new System.Drawing.Point(124, 96);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(615, 50);
            this.buttonSchedule.TabIndex = 1;
            this.buttonSchedule.Text = "Розклад фільмів та покупка білетів";
            this.buttonSchedule.UseVisualStyleBackColor = false;
            this.buttonSchedule.Click += new System.EventHandler(this.buttonSchedule_Click);
            // 
            // buttonListByDate
            // 
            this.buttonListByDate.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonListByDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListByDate.Location = new System.Drawing.Point(124, 163);
            this.buttonListByDate.Name = "buttonListByDate";
            this.buttonListByDate.Size = new System.Drawing.Size(615, 50);
            this.buttonListByDate.TabIndex = 3;
            this.buttonListByDate.Text = "Список фільмів за часом і днем тижня";
            this.buttonListByDate.UseVisualStyleBackColor = false;
            this.buttonListByDate.Click += new System.EventHandler(this.buttonListByDate_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonClose.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(124, 424);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(615, 50);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Вихід із програми";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonMyTickets
            // 
            this.buttonMyTickets.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonMyTickets.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMyTickets.Location = new System.Drawing.Point(124, 359);
            this.buttonMyTickets.Name = "buttonMyTickets";
            this.buttonMyTickets.Size = new System.Drawing.Size(615, 50);
            this.buttonMyTickets.TabIndex = 6;
            this.buttonMyTickets.Text = "Керування моїми білетами";
            this.buttonMyTickets.UseVisualStyleBackColor = false;
            this.buttonMyTickets.Click += new System.EventHandler(this.buttonMyTickets_Click);
            // 
            // buttonPrices
            // 
            this.buttonPrices.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonPrices.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrices.Location = new System.Drawing.Point(124, 292);
            this.buttonPrices.Name = "buttonPrices";
            this.buttonPrices.Size = new System.Drawing.Size(615, 50);
            this.buttonPrices.TabIndex = 5;
            this.buttonPrices.Text = "Список цін для фільму";
            this.buttonPrices.UseVisualStyleBackColor = false;
            this.buttonPrices.Click += new System.EventHandler(this.buttonPrices_Click);
            // 
            // buttonListByData
            // 
            this.buttonListByData.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonListByData.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListByData.Location = new System.Drawing.Point(124, 227);
            this.buttonListByData.Name = "buttonListByData";
            this.buttonListByData.Size = new System.Drawing.Size(615, 50);
            this.buttonListByData.TabIndex = 4;
            this.buttonListByData.Text = "Список фільмів за їх даними";
            this.buttonListByData.UseVisualStyleBackColor = false;
            this.buttonListByData.Click += new System.EventHandler(this.buttonListByData_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 507);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonMyTickets);
            this.Controls.Add(this.buttonPrices);
            this.Controls.Add(this.buttonListByData);
            this.Controls.Add(this.buttonListByDate);
            this.Controls.Add(this.buttonSchedule);
            this.Controls.Add(this.buttonAdministration);
            this.Name = "FormMain";
            this.Text = "Booking Tickets";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdministration;
        private System.Windows.Forms.Button buttonSchedule;
        private System.Windows.Forms.Button buttonListByDate;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMyTickets;
        private System.Windows.Forms.Button buttonPrices;
        private System.Windows.Forms.Button buttonListByData;
    }
}

