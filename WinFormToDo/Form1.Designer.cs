namespace WinFormToDo
{
    partial class txtAdd
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
            this.gbTaskForm = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblTaskBoxLabel = new System.Windows.Forms.Label();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.gbTaskList = new System.Windows.Forms.GroupBox();
            this.lbTaskList = new System.Windows.Forms.ListBox();
            this.gbTaskForm.SuspendLayout();
            this.gbTaskList.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTaskForm
            // 
            this.gbTaskForm.Controls.Add(this.btnClear);
            this.gbTaskForm.Controls.Add(this.btnAdd);
            this.gbTaskForm.Controls.Add(this.txtDueDate);
            this.gbTaskForm.Controls.Add(this.lblDueDate);
            this.gbTaskForm.Controls.Add(this.lblTaskBoxLabel);
            this.gbTaskForm.Controls.Add(this.txtTaskDescription);
            this.gbTaskForm.Location = new System.Drawing.Point(12, 12);
            this.gbTaskForm.Name = "gbTaskForm";
            this.gbTaskForm.Size = new System.Drawing.Size(353, 182);
            this.gbTaskForm.TabIndex = 0;
            this.gbTaskForm.TabStop = false;
            this.gbTaskForm.Text = "Task Form";
            this.gbTaskForm.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(181, 89);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(262, 90);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "AddTodo";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.SubmitForm);
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(62, 55);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(285, 20);
            this.txtDueDate.TabIndex = 3;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(6, 55);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(53, 13);
            this.lblDueDate.TabIndex = 2;
            this.lblDueDate.Text = "Due Date";
            // 
            // lblTaskBoxLabel
            // 
            this.lblTaskBoxLabel.AutoSize = true;
            this.lblTaskBoxLabel.Location = new System.Drawing.Point(6, 26);
            this.lblTaskBoxLabel.Name = "lblTaskBoxLabel";
            this.lblTaskBoxLabel.Size = new System.Drawing.Size(31, 13);
            this.lblTaskBoxLabel.TabIndex = 1;
            this.lblTaskBoxLabel.Text = "Task";
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(62, 19);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(285, 20);
            this.txtTaskDescription.TabIndex = 0;
            // 
            // gbTaskList
            // 
            this.gbTaskList.Controls.Add(this.lbTaskList);
            this.gbTaskList.Location = new System.Drawing.Point(13, 200);
            this.gbTaskList.Name = "gbTaskList";
            this.gbTaskList.Size = new System.Drawing.Size(352, 341);
            this.gbTaskList.TabIndex = 1;
            this.gbTaskList.TabStop = false;
            this.gbTaskList.Text = "Tasks To Do";
            // 
            // lbTaskList
            // 
            this.lbTaskList.FormattingEnabled = true;
            this.lbTaskList.Location = new System.Drawing.Point(7, 20);
            this.lbTaskList.Name = "lbTaskList";
            this.lbTaskList.Size = new System.Drawing.Size(339, 316);
            this.lbTaskList.TabIndex = 0;
            this.lbTaskList.SelectedIndexChanged += new System.EventHandler(this.lbTaskList_SelectedIndexChanged);
            // 
            // txtAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 550);
            this.Controls.Add(this.gbTaskList);
            this.Controls.Add(this.gbTaskForm);
            this.Name = "txtAdd";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdd_KeyPress);
            this.gbTaskForm.ResumeLayout(false);
            this.gbTaskForm.PerformLayout();
            this.gbTaskList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTaskForm;
        private System.Windows.Forms.Label lblTaskBoxLabel;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbTaskList;
        private System.Windows.Forms.ListBox lbTaskList;
    }
}

