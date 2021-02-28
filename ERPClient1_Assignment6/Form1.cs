﻿using ERPClient1_Assignment6.Assignment6Reference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPClient1_Assignment6
{
    public partial class Form1 : Form
    {
        

        Assignment6Reference.Assignment6ServiceSoapClient proxy = new Assignment6Reference.Assignment6ServiceSoapClient();

        public Form1()
        {
            InitializeComponent();
        }

        static DataTable ConvertListToDataTable(List<ArrayOfString> list)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int columns = 0;
            foreach (var array in list)
            {
                if (array.Length > columns)
                {
                    columns = array.Length;
                }
            }

            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();
            }

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }

            return table;
        }

        private void buttonAllKeys_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = this.ConvertListToDataTable(proxy.AllKeys());
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
            }

        }

        private DataTable ConvertListToDataTable(ArrayOfString[] arrayOfString)
        {
            throw new NotImplementedException();
        }

        private void buttonAllIndexes_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = proxy.AllIndexes();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
            }
        }

        private void buttonAllConstraints_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = proxy.AllTableConstraints();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
            }
        }

        private void buttonAllTables1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = proxy.AllTables1();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
            }
        }

        private void buttonAllTables2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = proxy.AllTables2();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
            }
        }

        private void buttonGetColumns1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = proxy.AllColumns1();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
            }

        }

        private void buttonGetColumns2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = proxy.AllColumns2();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
            }

        }

        private void buttonEmployeeMetadata_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataTable dt = proxy.MetaDataForEmployeeTable();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;

            }

        }

        private void buttonEmployeeRelatives_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = proxy.EmployeeRelatives();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
            }
        }

        private void buttonEmployeeAbsent2004_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = proxy.EmployeeAbsent2004();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
            }
        }

        private void buttonEmployeeAbsentMost_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = proxy.EmployeeAbsentTheMost();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelGetInformation_Click(object sender, EventArgs e)
        {

        }

        private void labelMetadata_Click(object sender, EventArgs e)
        {

        }

        private void errorMessageLbl_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
