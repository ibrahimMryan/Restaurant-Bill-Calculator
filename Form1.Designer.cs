namespace RestaurantBillCalculator
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
            this.groupBox_waiterInfo = new System.Windows.Forms.GroupBox();
            this.textBox_WaiterName = new System.Windows.Forms.TextBox();
            this.textBox_TableNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Table_number = new System.Windows.Forms.Label();
            this.lbl_Restaurant = new System.Windows.Forms.Label();
            this.groupBox_MenuItems = new System.Windows.Forms.GroupBox();
            this.comboBox_Dessert = new System.Windows.Forms.ComboBox();
            this.comboBox_MainCourse = new System.Windows.Forms.ComboBox();
            this.comboBox_Beverage = new System.Windows.Forms.ComboBox();
            this.lbl_Dessert = new System.Windows.Forms.Label();
            this.lbl_MainCourse = new System.Windows.Forms.Label();
            this.lbl_Appetizer = new System.Windows.Forms.Label();
            this.lbl_Beverage = new System.Windows.Forms.Label();
            this.comboBox_Appetizer = new System.Windows.Forms.ComboBox();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.lbl_Tax = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.textBox_Subtotal = new System.Windows.Forms.TextBox();
            this.textBox_Tax = new System.Windows.Forms.TextBox();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.btn_ClearBill = new System.Windows.Forms.Button();
            this.groupBox_waiterInfo.SuspendLayout();
            this.groupBox_MenuItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_waiterInfo
            // 
            this.groupBox_waiterInfo.Controls.Add(this.textBox_WaiterName);
            this.groupBox_waiterInfo.Controls.Add(this.textBox_TableNumber);
            this.groupBox_waiterInfo.Controls.Add(this.label1);
            this.groupBox_waiterInfo.Controls.Add(this.lbl_Table_number);
            this.groupBox_waiterInfo.Location = new System.Drawing.Point(12, 79);
            this.groupBox_waiterInfo.Name = "groupBox_waiterInfo";
            this.groupBox_waiterInfo.Size = new System.Drawing.Size(339, 105);
            this.groupBox_waiterInfo.TabIndex = 0;
            this.groupBox_waiterInfo.TabStop = false;
            this.groupBox_waiterInfo.Text = "Waiter Information";
            // 
            // textBox_WaiterName
            // 
            this.textBox_WaiterName.Location = new System.Drawing.Point(125, 69);
            this.textBox_WaiterName.Name = "textBox_WaiterName";
            this.textBox_WaiterName.Size = new System.Drawing.Size(174, 22);
            this.textBox_WaiterName.TabIndex = 3;
            // 
            // textBox_TableNumber
            // 
            this.textBox_TableNumber.Location = new System.Drawing.Point(125, 27);
            this.textBox_TableNumber.Name = "textBox_TableNumber";
            this.textBox_TableNumber.Size = new System.Drawing.Size(174, 22);
            this.textBox_TableNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Waiter Name";
            // 
            // lbl_Table_number
            // 
            this.lbl_Table_number.AutoSize = true;
            this.lbl_Table_number.Location = new System.Drawing.Point(6, 30);
            this.lbl_Table_number.Name = "lbl_Table_number";
            this.lbl_Table_number.Size = new System.Drawing.Size(97, 16);
            this.lbl_Table_number.TabIndex = 0;
            this.lbl_Table_number.Text = "Table Number ";
            // 
            // lbl_Restaurant
            // 
            this.lbl_Restaurant.AutoSize = true;
            this.lbl_Restaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Restaurant.Location = new System.Drawing.Point(121, 35);
            this.lbl_Restaurant.Name = "lbl_Restaurant";
            this.lbl_Restaurant.Size = new System.Drawing.Size(116, 25);
            this.lbl_Restaurant.TabIndex = 1;
            this.lbl_Restaurant.Text = "Restaurant";
            // 
            // groupBox_MenuItems
            // 
            this.groupBox_MenuItems.Controls.Add(this.comboBox_Appetizer);
            this.groupBox_MenuItems.Controls.Add(this.comboBox_Dessert);
            this.groupBox_MenuItems.Controls.Add(this.comboBox_MainCourse);
            this.groupBox_MenuItems.Controls.Add(this.comboBox_Beverage);
            this.groupBox_MenuItems.Controls.Add(this.lbl_Dessert);
            this.groupBox_MenuItems.Controls.Add(this.lbl_MainCourse);
            this.groupBox_MenuItems.Controls.Add(this.lbl_Appetizer);
            this.groupBox_MenuItems.Controls.Add(this.lbl_Beverage);
            this.groupBox_MenuItems.Location = new System.Drawing.Point(12, 200);
            this.groupBox_MenuItems.Name = "groupBox_MenuItems";
            this.groupBox_MenuItems.Size = new System.Drawing.Size(339, 191);
            this.groupBox_MenuItems.TabIndex = 2;
            this.groupBox_MenuItems.TabStop = false;
            this.groupBox_MenuItems.Text = "Menu Items";
            // 
            // comboBox_Dessert
            // 
            this.comboBox_Dessert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Dessert.FormattingEnabled = true;
            this.comboBox_Dessert.Items.AddRange(new object[] {
            "Apple Pie",
            "Sundae",
            "Carrot Cake",
            "Mud Pie",
            "Apple Crisp"});
            this.comboBox_Dessert.Location = new System.Drawing.Point(104, 151);
            this.comboBox_Dessert.Name = "comboBox_Dessert";
            this.comboBox_Dessert.Size = new System.Drawing.Size(195, 24);
            this.comboBox_Dessert.TabIndex = 7;
            this.comboBox_Dessert.SelectedIndexChanged += new System.EventHandler(this.comboBox_Dessert_SelectedIndexChanged);
            // 
            // comboBox_MainCourse
            // 
            this.comboBox_MainCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MainCourse.FormattingEnabled = true;
            this.comboBox_MainCourse.Items.AddRange(new object[] {
            "Chicken Alfredo",
            "Chicken Picatta",
            "Turkey Club",
            "Lobster Pie",
            "Prime Rib",
            "Shrimp Scampi",
            "Turkey Dinner",
            "Stuffed Chicken"});
            this.comboBox_MainCourse.Location = new System.Drawing.Point(104, 110);
            this.comboBox_MainCourse.Name = "comboBox_MainCourse";
            this.comboBox_MainCourse.Size = new System.Drawing.Size(195, 24);
            this.comboBox_MainCourse.TabIndex = 6;
            this.comboBox_MainCourse.SelectedIndexChanged += new System.EventHandler(this.comboBox_MainCourse_SelectedIndexChanged);
            // 
            // comboBox_Beverage
            // 
            this.comboBox_Beverage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Beverage.FormattingEnabled = true;
            this.comboBox_Beverage.Items.AddRange(new object[] {
            "Coffee",
            "Juice",
            "Milk",
            "Mineral Water",
            "Soda",
            "Tea"});
            this.comboBox_Beverage.Location = new System.Drawing.Point(104, 30);
            this.comboBox_Beverage.Name = "comboBox_Beverage";
            this.comboBox_Beverage.Size = new System.Drawing.Size(195, 24);
            this.comboBox_Beverage.Sorted = true;
            this.comboBox_Beverage.TabIndex = 4;
            this.comboBox_Beverage.SelectedIndexChanged += new System.EventHandler(this.comboBox_Beverage_SelectedIndexChanged);
            // 
            // lbl_Dessert
            // 
            this.lbl_Dessert.AutoSize = true;
            this.lbl_Dessert.Location = new System.Drawing.Point(25, 151);
            this.lbl_Dessert.Name = "lbl_Dessert";
            this.lbl_Dessert.Size = new System.Drawing.Size(54, 16);
            this.lbl_Dessert.TabIndex = 3;
            this.lbl_Dessert.Text = "Dessert";
            // 
            // lbl_MainCourse
            // 
            this.lbl_MainCourse.AutoSize = true;
            this.lbl_MainCourse.Location = new System.Drawing.Point(16, 110);
            this.lbl_MainCourse.Name = "lbl_MainCourse";
            this.lbl_MainCourse.Size = new System.Drawing.Size(82, 16);
            this.lbl_MainCourse.TabIndex = 2;
            this.lbl_MainCourse.Text = "Main Course";
            // 
            // lbl_Appetizer
            // 
            this.lbl_Appetizer.AutoSize = true;
            this.lbl_Appetizer.Location = new System.Drawing.Point(25, 67);
            this.lbl_Appetizer.Name = "lbl_Appetizer";
            this.lbl_Appetizer.Size = new System.Drawing.Size(64, 16);
            this.lbl_Appetizer.TabIndex = 1;
            this.lbl_Appetizer.Text = "Appetizer";
            // 
            // lbl_Beverage
            // 
            this.lbl_Beverage.AutoSize = true;
            this.lbl_Beverage.Location = new System.Drawing.Point(25, 33);
            this.lbl_Beverage.Name = "lbl_Beverage";
            this.lbl_Beverage.Size = new System.Drawing.Size(67, 16);
            this.lbl_Beverage.TabIndex = 0;
            this.lbl_Beverage.Text = "Beverage";
            // 
            // comboBox_Appetizer
            // 
            this.comboBox_Appetizer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Appetizer.FormattingEnabled = true;
            this.comboBox_Appetizer.Items.AddRange(new object[] {
            "Buffalo Wings",
            "Buffalo Fingers",
            "Potato Skins",
            "Nachos",
            "Mushroom Caps",
            "Shrimp Cocktail",
            "Chips and Salsa"});
            this.comboBox_Appetizer.Location = new System.Drawing.Point(104, 67);
            this.comboBox_Appetizer.Name = "comboBox_Appetizer";
            this.comboBox_Appetizer.Size = new System.Drawing.Size(195, 24);
            this.comboBox_Appetizer.TabIndex = 8;
            this.comboBox_Appetizer.SelectedIndexChanged += new System.EventHandler(this.comboBox_Appetizer_SelectedIndexChanged);
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.Location = new System.Drawing.Point(90, 471);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(62, 16);
            this.lbl_Subtotal.TabIndex = 4;
            this.lbl_Subtotal.Text = "Subtotal :";
            // 
            // lbl_Tax
            // 
            this.lbl_Tax.AutoSize = true;
            this.lbl_Tax.Location = new System.Drawing.Point(90, 517);
            this.lbl_Tax.Name = "lbl_Tax";
            this.lbl_Tax.Size = new System.Drawing.Size(39, 16);
            this.lbl_Tax.TabIndex = 5;
            this.lbl_Tax.Text = "Tax : ";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(90, 562);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(38, 16);
            this.lbl_Total.TabIndex = 6;
            this.lbl_Total.Text = "Total";
            // 
            // textBox_Subtotal
            // 
            this.textBox_Subtotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Subtotal.Enabled = false;
            this.textBox_Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Subtotal.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_Subtotal.Location = new System.Drawing.Point(158, 461);
            this.textBox_Subtotal.Name = "textBox_Subtotal";
            this.textBox_Subtotal.ReadOnly = true;
            this.textBox_Subtotal.Size = new System.Drawing.Size(100, 30);
            this.textBox_Subtotal.TabIndex = 7;
            // 
            // textBox_Tax
            // 
            this.textBox_Tax.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Tax.Enabled = false;
            this.textBox_Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Tax.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_Tax.Location = new System.Drawing.Point(158, 507);
            this.textBox_Tax.Name = "textBox_Tax";
            this.textBox_Tax.ReadOnly = true;
            this.textBox_Tax.Size = new System.Drawing.Size(100, 30);
            this.textBox_Tax.TabIndex = 8;
            // 
            // textBox_Total
            // 
            this.textBox_Total.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_Total.Enabled = false;
            this.textBox_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Total.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_Total.Location = new System.Drawing.Point(158, 552);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.ReadOnly = true;
            this.textBox_Total.Size = new System.Drawing.Size(100, 30);
            this.textBox_Total.TabIndex = 9;
            // 
            // btn_ClearBill
            // 
            this.btn_ClearBill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ClearBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ClearBill.Location = new System.Drawing.Point(137, 408);
            this.btn_ClearBill.Name = "btn_ClearBill";
            this.btn_ClearBill.Size = new System.Drawing.Size(114, 36);
            this.btn_ClearBill.TabIndex = 10;
            this.btn_ClearBill.Text = "Clear Bill";
            this.btn_ClearBill.UseVisualStyleBackColor = false;
            this.btn_ClearBill.Click += new System.EventHandler(this.btn_ClearBill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 604);
            this.Controls.Add(this.btn_ClearBill);
            this.Controls.Add(this.textBox_Total);
            this.Controls.Add(this.textBox_Tax);
            this.Controls.Add(this.textBox_Subtotal);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Tax);
            this.Controls.Add(this.lbl_Subtotal);
            this.Controls.Add(this.groupBox_MenuItems);
            this.Controls.Add(this.lbl_Restaurant);
            this.Controls.Add(this.groupBox_waiterInfo);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Bill Calculator";
            this.groupBox_waiterInfo.ResumeLayout(false);
            this.groupBox_waiterInfo.PerformLayout();
            this.groupBox_MenuItems.ResumeLayout(false);
            this.groupBox_MenuItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_waiterInfo;
        private System.Windows.Forms.Label lbl_Restaurant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Table_number;
        private System.Windows.Forms.TextBox textBox_WaiterName;
        private System.Windows.Forms.TextBox textBox_TableNumber;
        private System.Windows.Forms.GroupBox groupBox_MenuItems;
        private System.Windows.Forms.ComboBox comboBox_Dessert;
        private System.Windows.Forms.ComboBox comboBox_MainCourse;
        private System.Windows.Forms.ComboBox comboBox_Beverage;
        private System.Windows.Forms.Label lbl_Dessert;
        private System.Windows.Forms.Label lbl_MainCourse;
        private System.Windows.Forms.Label lbl_Appetizer;
        private System.Windows.Forms.Label lbl_Beverage;
        private System.Windows.Forms.ComboBox comboBox_Appetizer;
        private System.Windows.Forms.Label lbl_Subtotal;
        private System.Windows.Forms.Label lbl_Tax;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox textBox_Subtotal;
        private System.Windows.Forms.TextBox textBox_Tax;
        private System.Windows.Forms.TextBox textBox_Total;
        private System.Windows.Forms.Button btn_ClearBill;
    }
}

