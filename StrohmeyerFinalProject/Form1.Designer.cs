namespace StrohmeyerFinalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateTask = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.title = new System.Windows.Forms.Label();
            this.pri = new System.Windows.Forms.Label();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.radioButtonHigh = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonLow = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this._title = new System.Windows.Forms.ColumnHeader();
            this._pri = new System.Windows.Forms.ColumnHeader();
            this._due = new System.Windows.Forms.ColumnHeader();
            this._created = new System.Windows.Forms.ColumnHeader();
            this.editButton = new System.Windows.Forms.Button();
            this.removeTaskBtn = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateTask
            // 
            this.CreateTask.Location = new System.Drawing.Point(190, 94);
            this.CreateTask.Name = "CreateTask";
            this.CreateTask.Size = new System.Drawing.Size(80, 29);
            this.CreateTask.TabIndex = 1;
            this.CreateTask.Text = "Create Task";
            this.CreateTask.UseVisualStyleBackColor = true;
            this.CreateTask.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(39, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 23);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(39, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(29, 15);
            this.title.TabIndex = 4;
            this.title.Text = "Title";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // pri
            // 
            this.pri.AutoSize = true;
            this.pri.Location = new System.Drawing.Point(39, 42);
            this.pri.Name = "pri";
            this.pri.Size = new System.Drawing.Size(45, 15);
            this.pri.TabIndex = 5;
            this.pri.Text = "Priority";
            this.pri.Click += new System.EventHandler(this.pri_Click);
            // 
            // titleTextbox
            // 
            this.titleTextbox.Location = new System.Drawing.Point(74, 11);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(196, 23);
            this.titleTextbox.TabIndex = 6;
            this.titleTextbox.TextChanged += new System.EventHandler(this.titleTextbox_TextChanged);
            // 
            // radioButtonHigh
            // 
            this.radioButtonHigh.AutoSize = true;
            this.radioButtonHigh.Location = new System.Drawing.Point(90, 40);
            this.radioButtonHigh.Name = "radioButtonHigh";
            this.radioButtonHigh.Size = new System.Drawing.Size(51, 19);
            this.radioButtonHigh.TabIndex = 7;
            this.radioButtonHigh.TabStop = true;
            this.radioButtonHigh.Text = "High";
            this.radioButtonHigh.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(147, 40);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(70, 19);
            this.radioButtonMedium.TabIndex = 8;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "Medium";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonLow
            // 
            this.radioButtonLow.AutoSize = true;
            this.radioButtonLow.Location = new System.Drawing.Point(223, 40);
            this.radioButtonLow.Name = "radioButtonLow";
            this.radioButtonLow.Size = new System.Drawing.Size(47, 19);
            this.radioButtonLow.TabIndex = 9;
            this.radioButtonLow.TabStop = true;
            this.radioButtonLow.Text = "Low";
            this.radioButtonLow.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this._title,
            this._pri,
            this._due,
            this._created});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.FullRowSelect = true;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listView1.Location = new System.Drawing.Point(297, 5);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(467, 282);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // id
            // 
            this.id.DisplayIndex = 4;
            this.id.Text = "Id";
            // 
            // _title
            // 
            this._title.DisplayIndex = 0;
            this._title.Text = "Title";
            this._title.Width = 100;
            // 
            // _pri
            // 
            this._pri.DisplayIndex = 1;
            this._pri.Text = "Priority";
            this._pri.Width = 50;
            // 
            // _due
            // 
            this._due.DisplayIndex = 2;
            this._due.Text = "Due date";
            this._due.Width = 110;
            // 
            // _created
            // 
            this._created.DisplayIndex = 3;
            this._created.Text = "Created";
            this._created.Width = 110;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(297, 293);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(68, 53);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeTaskBtn
            // 
            this.removeTaskBtn.Location = new System.Drawing.Point(371, 293);
            this.removeTaskBtn.Name = "removeTaskBtn";
            this.removeTaskBtn.Size = new System.Drawing.Size(166, 53);
            this.removeTaskBtn.TabIndex = 14;
            this.removeTaskBtn.Text = "Complete Selected Task";
            this.removeTaskBtn.UseMnemonic = false;
            this.removeTaskBtn.UseVisualStyleBackColor = true;
            this.removeTaskBtn.Click += new System.EventHandler(this.removeTaskBtn_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(696, 293);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(68, 53);
            this.buttonClose.TabIndex = 15;
            this.buttonClose.Text = "Exit";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 352);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.removeTaskBtn);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.radioButtonLow);
            this.Controls.Add(this.radioButtonMedium);
            this.Controls.Add(this.radioButtonHigh);
            this.Controls.Add(this.titleTextbox);
            this.Controls.Add(this.pri);
            this.Controls.Add(this.title);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CreateTask);
            this.Name = "Form1";
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CreateTask;
        private DateTimePicker dateTimePicker1;
        private Label title;
        private Label pri;
        private TextBox titleTextbox;
        private RadioButton radioButtonHigh;
        private RadioButton radioButtonMedium;
        private RadioButton radioButtonLow;
        public ListView listView1;
        private ColumnHeader _title;
        private ColumnHeader _created;
        private ColumnHeader _pri;
        private ColumnHeader _due;
        private Button editButton;
        private Button removeTaskBtn;
        private ColumnHeader id;
        private Button buttonClose;
    }
}