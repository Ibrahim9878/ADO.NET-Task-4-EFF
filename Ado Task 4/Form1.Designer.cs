namespace Ado_Task_4
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
            CarBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            makeBox = new TextBox();
            modelBox = new TextBox();
            yearBox = new TextBox();
            numberBox1 = new TextBox();
            addButton = new Button();
            UpdateButton = new Button();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // CarBox
            // 
            CarBox.FormattingEnabled = true;
            CarBox.Location = new Point(12, 12);
            CarBox.Name = "CarBox";
            CarBox.Size = new Size(333, 264);
            CarBox.TabIndex = 0;
            CarBox.SelectedIndexChanged += CarBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(370, 34);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 1;
            label1.Text = "Make";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(370, 89);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 2;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(370, 194);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 3;
            label3.Text = "St.Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(370, 142);
            label4.Name = "label4";
            label4.Size = new Size(48, 25);
            label4.TabIndex = 4;
            label4.Text = "Year";
            // 
            // makeBox
            // 
            makeBox.Location = new Point(476, 32);
            makeBox.Name = "makeBox";
            makeBox.Size = new Size(236, 27);
            makeBox.TabIndex = 5;
            // 
            // modelBox
            // 
            modelBox.Location = new Point(476, 87);
            modelBox.Name = "modelBox";
            modelBox.Size = new Size(236, 27);
            modelBox.TabIndex = 6;
            // 
            // yearBox
            // 
            yearBox.Location = new Point(476, 142);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(236, 27);
            yearBox.TabIndex = 7;
            // 
            // numberBox1
            // 
            numberBox1.Location = new Point(476, 192);
            numberBox1.Name = "numberBox1";
            numberBox1.Size = new Size(236, 27);
            numberBox1.TabIndex = 8;
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.AppWorkspace;
            addButton.ForeColor = Color.Black;
            addButton.Location = new Point(376, 240);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 36);
            addButton.TabIndex = 9;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = SystemColors.AppWorkspace;
            UpdateButton.ForeColor = Color.Black;
            UpdateButton.Location = new Point(516, 240);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(94, 36);
            UpdateButton.TabIndex = 10;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = SystemColors.AppWorkspace;
            deleteButton.ForeColor = Color.Black;
            deleteButton.Location = new Point(651, 240);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 36);
            deleteButton.TabIndex = 11;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 298);
            Controls.Add(deleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(addButton);
            Controls.Add(numberBox1);
            Controls.Add(yearBox);
            Controls.Add(modelBox);
            Controls.Add(makeBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CarBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox CarBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox makeBox;
        private TextBox modelBox;
        private TextBox yearBox;
        private TextBox numberBox1;
        private Button addButton;
        private Button UpdateButton;
        private Button deleteButton;
    }
}
