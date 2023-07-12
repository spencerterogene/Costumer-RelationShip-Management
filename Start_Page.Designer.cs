namespace Costumer_RelationShip_Management
{
    partial class Start_Page
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearchExit = new System.Windows.Forms.Button();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnsettings = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(239, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 58;
            this.label4.Text = "Customer not exist";
            this.label4.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(439, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "Customer not exist";
            this.label1.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(7, 205);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(178, 34);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "Add new customer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(206, 205);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(178, 34);
            this.btnExit.TabIndex = 55;
            this.btnExit.Text = "Edit exist customer";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearchExit
            // 
            this.btnSearchExit.BackColor = System.Drawing.Color.White;
            this.btnSearchExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchExit.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchExit.Location = new System.Drawing.Point(404, 205);
            this.btnSearchExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchExit.Name = "btnSearchExit";
            this.btnSearchExit.Size = new System.Drawing.Size(178, 34);
            this.btnSearchExit.TabIndex = 54;
            this.btnSearchExit.Text = "Search exist customer";
            this.btnSearchExit.UseVisualStyleBackColor = true;
            this.btnSearchExit.Click += new System.EventHandler(this.btnSearchExit_Click);
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Font = new System.Drawing.Font("Gadugi", 13F);
            this.textBoxsearch.Location = new System.Drawing.Point(7, 171);
            this.textBoxsearch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxsearch.MaxLength = 11;
            this.textBoxsearch.Multiline = true;
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(577, 28);
            this.textBoxsearch.TabIndex = 48;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(3, 138);
            this.lblsearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(190, 19);
            this.lblsearch.TabIndex = 53;
            this.lblsearch.Text = "Customer Phone Number:";
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.White;
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(421, 318);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(161, 41);
            this.btnlogout.TabIndex = 52;
            this.btnlogout.Text = "LOGOUT";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnsettings
            // 
            this.btnsettings.BackColor = System.Drawing.Color.White;
            this.btnsettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsettings.Location = new System.Drawing.Point(7, 318);
            this.btnsettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(161, 41);
            this.btnsettings.TabIndex = 51;
            this.btnsettings.Text = "SETTINGS";
            this.btnsettings.UseVisualStyleBackColor = false;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "O R I E N T A L   W E A V E R S";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 32);
            this.label2.TabIndex = 49;
            this.label2.Text = "Customer RelationShip Management \r\n";
            // 
            // Start_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 363);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearchExit);
            this.Controls.Add(this.textBoxsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnsettings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Start_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start_Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearchExit;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}