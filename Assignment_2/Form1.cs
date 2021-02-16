﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DataAccessLayer dal = new DataAccessLayer();


        private void AllColumnNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = dal.ColumnNames();
                messageDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                this.MessageTextBox_SetText(message);
            }
        }

        private void NumberOfRowsButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = dal.NumberOfRows();
                messageDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                this.MessageTextBox_SetText(message);
            }
        }

        public void MessageTextBox_SetText(string message)
        {

            errorMessageLabel.Text = message;
        }

        private void errorMessageLabel_Click(object sender, EventArgs e)
        {
          
        }
    }
}
