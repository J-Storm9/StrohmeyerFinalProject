namespace StrohmeyerFinalProject
{
    partial class editForm
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
            this.title = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonHighEdit = new System.Windows.Forms.RadioButton();
            this.radioButtonMedEdit = new System.Windows.Forms.RadioButton();
            this.radioButtonLowEdit = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDue = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(5, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(29, 15);
            this.title.TabIndex = 0;
            this.title.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(56, 6);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(176, 23);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Priority";
            // 
            // radioButtonHighEdit
            // 
            this.radioButtonHighEdit.AutoSize = true;
            this.radioButtonHighEdit.Location = new System.Drawing.Point(56, 35);
            this.radioButtonHighEdit.Name = "radioButtonHighEdit";
            this.radioButtonHighEdit.Size = new System.Drawing.Size(51, 19);
            this.radioButtonHighEdit.TabIndex = 3;
            this.radioButtonHighEdit.TabStop = true;
            this.radioButtonHighEdit.Text = "High";
            this.radioButtonHighEdit.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedEdit
            // 
            this.radioButtonMedEdit.AutoSize = true;
            this.radioButtonMedEdit.Location = new System.Drawing.Point(113, 35);
            this.radioButtonMedEdit.Name = "radioButtonMedEdit";
            this.radioButtonMedEdit.Size = new System.Drawing.Size(70, 19);
            this.radioButtonMedEdit.TabIndex = 4;
            this.radioButtonMedEdit.TabStop = true;
            this.radioButtonMedEdit.Text = "Medium";
            this.radioButtonMedEdit.UseVisualStyleBackColor = true;
            // 
            // radioButtonLowEdit
            // 
            this.radioButtonLowEdit.AutoSize = true;
            this.radioButtonLowEdit.Location = new System.Drawing.Point(185, 35);
            this.radioButtonLowEdit.Name = "radioButtonLowEdit";
            this.radioButtonLowEdit.Size = new System.Drawing.Size(47, 19);
            this.radioButtonLowEdit.TabIndex = 5;
            this.radioButtonLowEdit.TabStop = true;
            this.radioButtonLowEdit.Text = "Low";
            this.radioButtonLowEdit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Due Date";
            // 
            // dateTimePickerDue
            // 
            this.dateTimePickerDue.Location = new System.Drawing.Point(73, 59);
            this.dateTimePickerDue.Name = "dateTimePickerDue";
            this.dateTimePickerDue.Size = new System.Drawing.Size(159, 23);
            this.dateTimePickerDue.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(30, 99);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(83, 32);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(127, 99);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 32);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 142);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateTimePickerDue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonLowEdit);
            this.Controls.Add(this.radioButtonMedEdit);
            this.Controls.Add(this.radioButtonHighEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.title);
            this.Name = "editForm";
            this.Text = "Edit Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public string id;
        private Label title;
        public TextBox textBoxTitle;
        private Label label2;
        public RadioButton radioButtonHighEdit;
        public RadioButton radioButtonMedEdit;
        public RadioButton radioButtonLowEdit;
        private Label label3;
        public DateTimePicker dateTimePickerDue;
        private Button buttonSave;
        private Button buttonCancel;
    }
}