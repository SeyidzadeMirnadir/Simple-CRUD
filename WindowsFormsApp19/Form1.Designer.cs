namespace WindowsFormsApp19
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
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.Client = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.TextBox();
            this.FinishDate = new System.Windows.Forms.TextBox();
            this.AddDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CategoryID = new System.Windows.Forms.ComboBox();
            this.CreateGallery = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TableID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RTitle = new System.Windows.Forms.Label();
            this.RAddDate = new System.Windows.Forms.Label();
            this.RFinishDate = new System.Windows.Forms.Label();
            this.RStartDate = new System.Windows.Forms.Label();
            this.RClient = new System.Windows.Forms.Label();
            this.UTableID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UUpdate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.UAddDate = new System.Windows.Forms.TextBox();
            this.UFinishDate = new System.Windows.Forms.TextBox();
            this.UStartDate = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.UClient = new System.Windows.Forms.TextBox();
            this.UTitle = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectName
            // 
            this.ProjectName.Location = new System.Drawing.Point(9, 66);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(104, 20);
            this.ProjectName.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(9, 159);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(107, 20);
            this.Title.TabIndex = 1;
            // 
            // Client
            // 
            this.Client.Location = new System.Drawing.Point(9, 185);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(107, 20);
            this.Client.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Simple CRUD for Gallery Project";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(9, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(122, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(122, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Title";
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(9, 211);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(107, 20);
            this.StartDate.TabIndex = 16;
            // 
            // FinishDate
            // 
            this.FinishDate.Location = new System.Drawing.Point(9, 237);
            this.FinishDate.Name = "FinishDate";
            this.FinishDate.Size = new System.Drawing.Size(107, 20);
            this.FinishDate.TabIndex = 17;
            // 
            // AddDate
            // 
            this.AddDate.Location = new System.Drawing.Point(9, 263);
            this.AddDate.Name = "AddDate";
            this.AddDate.Size = new System.Drawing.Size(107, 20);
            this.AddDate.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(122, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Start Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(122, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Add Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(122, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Finish Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(122, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Category ID";
            // 
            // CategoryID
            // 
            this.CategoryID.FormattingEnabled = true;
            this.CategoryID.Location = new System.Drawing.Point(9, 289);
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.Size = new System.Drawing.Size(107, 21);
            this.CategoryID.TabIndex = 26;
            // 
            // CreateGallery
            // 
            this.CreateGallery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateGallery.Location = new System.Drawing.Point(9, 326);
            this.CreateGallery.Name = "CreateGallery";
            this.CreateGallery.Size = new System.Drawing.Size(107, 27);
            this.CreateGallery.TabIndex = 27;
            this.CreateGallery.Text = "Create";
            this.CreateGallery.UseVisualStyleBackColor = true;
            this.CreateGallery.Click += new System.EventHandler(this.CreateGallery_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Create Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Create your Tables";
            // 
            // TableID
            // 
            this.TableID.FormattingEnabled = true;
            this.TableID.Location = new System.Drawing.Point(267, 92);
            this.TableID.Name = "TableID";
            this.TableID.Size = new System.Drawing.Size(107, 21);
            this.TableID.TabIndex = 30;
            this.TableID.SelectedIndexChanged += new System.EventHandler(this.TableName_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(263, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Select your table";
            // 
            // RTitle
            // 
            this.RTitle.AutoSize = true;
            this.RTitle.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RTitle.Location = new System.Drawing.Point(263, 157);
            this.RTitle.Name = "RTitle";
            this.RTitle.Size = new System.Drawing.Size(37, 20);
            this.RTitle.TabIndex = 34;
            this.RTitle.Text = "Text";
            // 
            // RAddDate
            // 
            this.RAddDate.AutoSize = true;
            this.RAddDate.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RAddDate.Location = new System.Drawing.Point(263, 263);
            this.RAddDate.Name = "RAddDate";
            this.RAddDate.Size = new System.Drawing.Size(37, 20);
            this.RAddDate.TabIndex = 36;
            this.RAddDate.Text = "Text";
            // 
            // RFinishDate
            // 
            this.RFinishDate.AutoSize = true;
            this.RFinishDate.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RFinishDate.Location = new System.Drawing.Point(263, 237);
            this.RFinishDate.Name = "RFinishDate";
            this.RFinishDate.Size = new System.Drawing.Size(37, 20);
            this.RFinishDate.TabIndex = 37;
            this.RFinishDate.Text = "Text";
            // 
            // RStartDate
            // 
            this.RStartDate.AutoSize = true;
            this.RStartDate.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RStartDate.Location = new System.Drawing.Point(263, 211);
            this.RStartDate.Name = "RStartDate";
            this.RStartDate.Size = new System.Drawing.Size(37, 20);
            this.RStartDate.TabIndex = 38;
            this.RStartDate.Text = "Text";
            // 
            // RClient
            // 
            this.RClient.AutoSize = true;
            this.RClient.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RClient.Location = new System.Drawing.Point(263, 185);
            this.RClient.Name = "RClient";
            this.RClient.Size = new System.Drawing.Size(37, 20);
            this.RClient.TabIndex = 39;
            this.RClient.Text = "Text";
            // 
            // UTableID
            // 
            this.UTableID.FormattingEnabled = true;
            this.UTableID.Location = new System.Drawing.Point(436, 92);
            this.UTableID.Name = "UTableID";
            this.UTableID.Size = new System.Drawing.Size(107, 21);
            this.UTableID.TabIndex = 40;
            this.UTableID.SelectedIndexChanged += new System.EventHandler(this.UTableID_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(432, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Update or Delete your Tables";
            // 
            // UUpdate
            // 
            this.UUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UUpdate.Location = new System.Drawing.Point(436, 300);
            this.UUpdate.Name = "UUpdate";
            this.UUpdate.Size = new System.Drawing.Size(107, 27);
            this.UUpdate.TabIndex = 53;
            this.UUpdate.Text = "Update";
            this.UUpdate.UseVisualStyleBackColor = true;
            this.UUpdate.Click += new System.EventHandler(this.UUpdate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(549, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 50;
            this.label13.Text = "Finish Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(549, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 20);
            this.label14.TabIndex = 49;
            this.label14.Text = "Add Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(549, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 20);
            this.label15.TabIndex = 48;
            this.label15.Text = "Start Date";
            // 
            // UAddDate
            // 
            this.UAddDate.Location = new System.Drawing.Point(436, 263);
            this.UAddDate.Name = "UAddDate";
            this.UAddDate.Size = new System.Drawing.Size(107, 20);
            this.UAddDate.TabIndex = 47;
            // 
            // UFinishDate
            // 
            this.UFinishDate.Location = new System.Drawing.Point(436, 237);
            this.UFinishDate.Name = "UFinishDate";
            this.UFinishDate.Size = new System.Drawing.Size(107, 20);
            this.UFinishDate.TabIndex = 46;
            // 
            // UStartDate
            // 
            this.UStartDate.Location = new System.Drawing.Point(436, 211);
            this.UStartDate.Name = "UStartDate";
            this.UStartDate.Size = new System.Drawing.Size(107, 20);
            this.UStartDate.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(549, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 20);
            this.label16.TabIndex = 44;
            this.label16.Text = "Title";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(549, 185);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 20);
            this.label17.TabIndex = 43;
            this.label17.Text = "Client";
            // 
            // UClient
            // 
            this.UClient.Location = new System.Drawing.Point(436, 185);
            this.UClient.Name = "UClient";
            this.UClient.Size = new System.Drawing.Size(107, 20);
            this.UClient.TabIndex = 42;
            // 
            // UTitle
            // 
            this.UTitle.Location = new System.Drawing.Point(436, 159);
            this.UTitle.Name = "UTitle";
            this.UTitle.Size = new System.Drawing.Size(107, 20);
            this.UTitle.TabIndex = 41;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(432, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(125, 20);
            this.label18.TabIndex = 55;
            this.label18.Text = "Select your tables";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(263, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 20);
            this.label19.TabIndex = 56;
            this.label19.Text = "and Read";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(432, 64);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(151, 20);
            this.label20.TabIndex = 57;
            this.label20.Text = "and Update or Delete";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(263, 136);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(122, 20);
            this.label21.TabIndex = 58;
            this.label21.Text = "Read your Tables";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(436, 333);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(107, 27);
            this.Delete.TabIndex = 59;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 441);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UUpdate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.UAddDate);
            this.Controls.Add(this.UFinishDate);
            this.Controls.Add(this.UStartDate);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.UClient);
            this.Controls.Add(this.UTitle);
            this.Controls.Add(this.UTableID);
            this.Controls.Add(this.RClient);
            this.Controls.Add(this.RStartDate);
            this.Controls.Add(this.RFinishDate);
            this.Controls.Add(this.RAddDate);
            this.Controls.Add(this.RTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TableID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CreateGallery);
            this.Controls.Add(this.CategoryID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddDate);
            this.Controls.Add(this.FinishDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ProjectName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProjectName;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StartDate;
        private System.Windows.Forms.TextBox FinishDate;
        private System.Windows.Forms.TextBox AddDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CategoryID;
        private System.Windows.Forms.Button CreateGallery;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TableID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label RTitle;
        private System.Windows.Forms.Label RAddDate;
        private System.Windows.Forms.Label RFinishDate;
        private System.Windows.Forms.Label RStartDate;
        private System.Windows.Forms.Label RClient;
        private System.Windows.Forms.ComboBox UTableID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button UUpdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox UAddDate;
        private System.Windows.Forms.TextBox UFinishDate;
        private System.Windows.Forms.TextBox UStartDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox UClient;
        private System.Windows.Forms.TextBox UTitle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button Delete;
    }
}

