namespace CRUD_ManagemenApp
{
    partial class productsForm
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
            panel1 = new Panel();
            priceBox = new TextBox();
            idBox = new TextBox();
            displayBox = new ListBox();
            updateButton = new Button();
            nameBox = new TextBox();
            addButton = new Button();
            readButton = new Button();
            deleteButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(priceBox);
            panel1.Controls.Add(idBox);
            panel1.Controls.Add(displayBox);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(readButton);
            panel1.Controls.Add(deleteButton);
            panel1.Location = new Point(135, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(1033, 565);
            panel1.TabIndex = 0;
            // 
            // priceBox
            // 
            priceBox.Location = new Point(28, 414);
            priceBox.Name = "priceBox";
            priceBox.PlaceholderText = "Enter Product Price";
            priceBox.Size = new Size(971, 27);
            priceBox.TabIndex = 8;
            // 
            // idBox
            // 
            idBox.Location = new Point(28, 366);
            idBox.Name = "idBox";
            idBox.PlaceholderText = "Enter Product ID";
            idBox.Size = new Size(971, 27);
            idBox.TabIndex = 7;
            // 
            // displayBox
            // 
            displayBox.FormattingEnabled = true;
            displayBox.Location = new Point(28, 40);
            displayBox.Name = "displayBox";
            displayBox.Size = new Size(971, 224);
            displayBox.TabIndex = 6;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(255, 255, 128);
            updateButton.Location = new Point(716, 477);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(187, 29);
            updateButton.TabIndex = 4;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(28, 308);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = " Enter Product Name";
            nameBox.Size = new Size(971, 27);
            nameBox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(128, 255, 255);
            addButton.Location = new Point(3, 477);
            addButton.Name = "addButton";
            addButton.Size = new Size(187, 29);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += AddButton_Click;
            // 
            // readButton
            // 
            readButton.BackColor = Color.FromArgb(255, 128, 255);
            readButton.Location = new Point(485, 477);
            readButton.Name = "readButton";
            readButton.Size = new Size(187, 29);
            readButton.TabIndex = 3;
            readButton.Text = "Read";
            readButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(255, 128, 128);
            deleteButton.Location = new Point(211, 477);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(187, 29);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += DeleteButton_Click;
            // 
            // productsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 750);
            Controls.Add(panel1);
            Name = "productsForm";
            Text = "Products";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button addButton;
        private Button deleteButton;
        private Button readButton;
        private Button updateButton;
        private TextBox nameBox;
        private ListBox displayBox;
        private TextBox priceBox;
        private TextBox idBox;
    }
}
