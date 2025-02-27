﻿namespace MyDesktopApp
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TotalIncome = new System.Windows.Forms.Label();
            this.TotalIncomeTextbox = new System.Windows.Forms.TextBox();
            this.FixedCosts = new System.Windows.Forms.Label();
            this.VariableCosts = new System.Windows.Forms.Label();
            this.VariableCostsTextbox = new System.Windows.Forms.TextBox();
            this.SavingGoalsLabel = new System.Windows.Forms.Label();
            this.SavingGoalLabel = new System.Windows.Forms.Label();
            this.SavingGoalTextbox = new System.Windows.Forms.TextBox();
            this.SavingDuration = new System.Windows.Forms.Label();
            this.AmountTextbox = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SureNameLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.SurenameTextbox = new System.Windows.Forms.TextBox();
            this.FixedCostTextbox = new System.Windows.Forms.TextBox();
            this.outputBOX = new System.Windows.Forms.TextBox();
            this.FindTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(18, 36);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(513, 23);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Your future saving schedule is ready in any second...";
            this.HeaderLabel.Click += new System.EventHandler(this.HeaderLabel_Click);
            // 
            // TotalIncome
            // 
            this.TotalIncome.AutoSize = true;
            this.TotalIncome.Location = new System.Drawing.Point(74, 199);
            this.TotalIncome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalIncome.Name = "TotalIncome";
            this.TotalIncome.Size = new System.Drawing.Size(92, 13);
            this.TotalIncome.TabIndex = 2;
            this.TotalIncome.Text = "Your total income:";
            this.TotalIncome.Click += new System.EventHandler(this.label3_Click);
            // 
            // TotalIncomeTextbox
            // 
            this.TotalIncomeTextbox.Location = new System.Drawing.Point(176, 197);
            this.TotalIncomeTextbox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TotalIncomeTextbox.Name = "TotalIncomeTextbox";
            this.TotalIncomeTextbox.Size = new System.Drawing.Size(112, 20);
            this.TotalIncomeTextbox.TabIndex = 3;
            this.TotalIncomeTextbox.TextChanged += new System.EventHandler(this.TotalIncomeTextbox_TextChanged);
            // 
            // FixedCosts
            // 
            this.FixedCosts.AutoSize = true;
            this.FixedCosts.Location = new System.Drawing.Point(74, 238);
            this.FixedCosts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FixedCosts.Name = "FixedCosts";
            this.FixedCosts.Size = new System.Drawing.Size(85, 13);
            this.FixedCosts.TabIndex = 4;
            this.FixedCosts.Text = "Your fixed costs:";
            this.FixedCosts.Click += new System.EventHandler(this.FixedCosts_Click);
            // 
            // VariableCosts
            // 
            this.VariableCosts.AutoSize = true;
            this.VariableCosts.Location = new System.Drawing.Point(74, 277);
            this.VariableCosts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VariableCosts.Name = "VariableCosts";
            this.VariableCosts.Size = new System.Drawing.Size(100, 13);
            this.VariableCosts.TabIndex = 6;
            this.VariableCosts.Text = "Your variable costs:";
            this.VariableCosts.Click += new System.EventHandler(this.VariableCosts_Click);
            // 
            // VariableCostsTextbox
            // 
            this.VariableCostsTextbox.Location = new System.Drawing.Point(176, 275);
            this.VariableCostsTextbox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.VariableCostsTextbox.Name = "VariableCostsTextbox";
            this.VariableCostsTextbox.Size = new System.Drawing.Size(112, 20);
            this.VariableCostsTextbox.TabIndex = 7;
            this.VariableCostsTextbox.TextChanged += new System.EventHandler(this.VariableCostsTextbox_TextChanged);
            // 
            // SavingGoalsLabel
            // 
            this.SavingGoalsLabel.AutoSize = true;
            this.SavingGoalsLabel.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingGoalsLabel.Location = new System.Drawing.Point(66, 332);
            this.SavingGoalsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SavingGoalsLabel.Name = "SavingGoalsLabel";
            this.SavingGoalsLabel.Size = new System.Drawing.Size(120, 13);
            this.SavingGoalsLabel.TabIndex = 8;
            this.SavingGoalsLabel.Text = "Future saving goals:";
            this.SavingGoalsLabel.Click += new System.EventHandler(this.SavingGoalsLabel_Click);
            // 
            // SavingGoalLabel
            // 
            this.SavingGoalLabel.AutoSize = true;
            this.SavingGoalLabel.Location = new System.Drawing.Point(74, 367);
            this.SavingGoalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SavingGoalLabel.Name = "SavingGoalLabel";
            this.SavingGoalLabel.Size = new System.Drawing.Size(89, 13);
            this.SavingGoalLabel.TabIndex = 9;
            this.SavingGoalLabel.Text = "Your saving goal:";
            this.SavingGoalLabel.Click += new System.EventHandler(this.SavingGoalLabel_Click);
            // 
            // SavingGoalTextbox
            // 
            this.SavingGoalTextbox.Location = new System.Drawing.Point(178, 367);
            this.SavingGoalTextbox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SavingGoalTextbox.Name = "SavingGoalTextbox";
            this.SavingGoalTextbox.Size = new System.Drawing.Size(110, 20);
            this.SavingGoalTextbox.TabIndex = 10;
            this.SavingGoalTextbox.TextChanged += new System.EventHandler(this.SavingGoalTextbox_TextChanged);
            // 
            // SavingDuration
            // 
            this.SavingDuration.AutoSize = true;
            this.SavingDuration.Location = new System.Drawing.Point(74, 398);
            this.SavingDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SavingDuration.Name = "SavingDuration";
            this.SavingDuration.Size = new System.Drawing.Size(84, 13);
            this.SavingDuration.TabIndex = 11;
            this.SavingDuration.Text = "Saving duration:";
            this.SavingDuration.Click += new System.EventHandler(this.SavingDuration_Click);
            // 
            // AmountTextbox
            // 
            this.AmountTextbox.Location = new System.Drawing.Point(178, 395);
            this.AmountTextbox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.AmountTextbox.Name = "AmountTextbox";
            this.AmountTextbox.Size = new System.Drawing.Size(62, 20);
            this.AmountTextbox.TabIndex = 13;
            this.AmountTextbox.TextChanged += new System.EventHandler(this.AmountTextbox_TextChanged);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(250, 399);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(36, 9);
            this.AmountLabel.TabIndex = 14;
            this.AmountLabel.Text = "(months)";
            this.AmountLabel.Click += new System.EventHandler(this.AmountLabel_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.OliveDrab;
            this.AddButton.ForeColor = System.Drawing.Color.Black;
            this.AddButton.Location = new System.Drawing.Point(342, 490);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(150, 33);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "Create schedule";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(74, 105);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.UsernameLabel.TabIndex = 16;
            this.UsernameLabel.Text = "Username:";
            this.UsernameLabel.Click += new System.EventHandler(this.UsernameLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(74, 134);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(58, 13);
            this.NameLabel.TabIndex = 18;
            this.NameLabel.Text = "First name:";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // SureNameLabel
            // 
            this.SureNameLabel.AutoSize = true;
            this.SureNameLabel.Location = new System.Drawing.Point(74, 162);
            this.SureNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SureNameLabel.Name = "SureNameLabel";
            this.SureNameLabel.Size = new System.Drawing.Size(52, 13);
            this.SureNameLabel.TabIndex = 20;
            this.SureNameLabel.Text = "Surname:";
            this.SureNameLabel.Click += new System.EventHandler(this.SureNameLabel_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.SkyBlue;
            this.UpdateButton.Location = new System.Drawing.Point(510, 490);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(150, 33);
            this.UpdateButton.TabIndex = 22;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.DeleteButton.Location = new System.Drawing.Point(678, 490);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(146, 34);
            this.DeleteButton.TabIndex = 23;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.SandyBrown;
            this.FindButton.Location = new System.Drawing.Point(602, 54);
            this.FindButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(100, 23);
            this.FindButton.TabIndex = 24;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(176, 105);
            this.UsernameTextbox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(112, 20);
            this.UsernameTextbox.TabIndex = 27;
            this.UsernameTextbox.TextChanged += new System.EventHandler(this.UsernameTextbox_TextChanged);
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(176, 132);
            this.NameTextbox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(112, 20);
            this.NameTextbox.TabIndex = 28;
            this.NameTextbox.TextChanged += new System.EventHandler(this.NameTextbox_TextChanged);
            // 
            // SurenameTextbox
            // 
            this.SurenameTextbox.Location = new System.Drawing.Point(176, 161);
            this.SurenameTextbox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SurenameTextbox.Name = "SurenameTextbox";
            this.SurenameTextbox.Size = new System.Drawing.Size(112, 20);
            this.SurenameTextbox.TabIndex = 29;
            this.SurenameTextbox.TextChanged += new System.EventHandler(this.SurenameTextbox_TextChanged);
            // 
            // FixedCostTextbox
            // 
            this.FixedCostTextbox.Location = new System.Drawing.Point(176, 237);
            this.FixedCostTextbox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.FixedCostTextbox.Name = "FixedCostTextbox";
            this.FixedCostTextbox.Size = new System.Drawing.Size(112, 20);
            this.FixedCostTextbox.TabIndex = 30;
            this.FixedCostTextbox.TextChanged += new System.EventHandler(this.FixedCostTextbox_TextChanged);
            // 
            // outputBOX
            // 
            this.outputBOX.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.outputBOX.Location = new System.Drawing.Point(342, 105);
            this.outputBOX.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.outputBOX.Multiline = true;
            this.outputBOX.Name = "outputBOX";
            this.outputBOX.Size = new System.Drawing.Size(484, 377);
            this.outputBOX.TabIndex = 31;
            this.outputBOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.outputBOX.TextChanged += new System.EventHandler(this.outputBOX_TextChanged);
            // 
            // FindTextbox
            // 
            this.FindTextbox.Location = new System.Drawing.Point(721, 54);
            this.FindTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FindTextbox.Multiline = true;
            this.FindTextbox.Name = "FindTextbox";
            this.FindTextbox.Size = new System.Drawing.Size(105, 25);
            this.FindTextbox.TabIndex = 32;
            this.FindTextbox.TextChanged += new System.EventHandler(this.FindTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(718, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Write your username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(830, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindTextbox);
            this.Controls.Add(this.outputBOX);
            this.Controls.Add(this.FixedCostTextbox);
            this.Controls.Add(this.SurenameTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SureNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.AmountTextbox);
            this.Controls.Add(this.SavingDuration);
            this.Controls.Add(this.SavingGoalTextbox);
            this.Controls.Add(this.SavingGoalLabel);
            this.Controls.Add(this.SavingGoalsLabel);
            this.Controls.Add(this.VariableCostsTextbox);
            this.Controls.Add(this.VariableCosts);
            this.Controls.Add(this.FixedCosts);
            this.Controls.Add(this.TotalIncomeTextbox);
            this.Controls.Add(this.TotalIncome);
            this.Controls.Add(this.HeaderLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.Text = "Create schedule";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label TotalIncome;
        private System.Windows.Forms.TextBox TotalIncomeTextbox;
        private System.Windows.Forms.Label FixedCosts;
        private System.Windows.Forms.Label VariableCosts;
        private System.Windows.Forms.TextBox VariableCostsTextbox;
        private System.Windows.Forms.Label SavingGoalsLabel;
        private System.Windows.Forms.Label SavingGoalLabel;
        private System.Windows.Forms.TextBox SavingGoalTextbox;
        private System.Windows.Forms.Label SavingDuration;
        private System.Windows.Forms.TextBox AmountTextbox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label NameLabel; 
        private System.Windows.Forms.Label SureNameLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button FindButton; 
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox SurenameTextbox;
        private System.Windows.Forms.TextBox FixedCostTextbox;
        private System.Windows.Forms.TextBox outputBOX;
        private System.Windows.Forms.TextBox FindTextbox;
        private System.Windows.Forms.Label label1;
    }
}