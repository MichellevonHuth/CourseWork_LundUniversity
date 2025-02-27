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

        static DataTable ConvertListToDataTable(List<ArrayOfString> list, List<string> columns)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int column = columns.Count;


            // Add columns.
            for (int i = 0; i < column; i++)
            {
                table.Columns.Add(columns[i]);
            }


            // Add rows.
            foreach (var array in list)
            {

                string[] myList = new string[column];
                int i = 0;

                foreach (string a in array)
                {
                    myList[i] = a;
                    i++;
                }

                table.Rows.Add(myList);
            }

  
            return table;
            
        }

        private void buttonAllKeys_Click(object sender, EventArgs e)
        {
            try
            { 
                List<string> columns = new List<string>();
                columns.Add("Column_name");
                columns.Add("Constraint_name");
                columns.Add("Key_type");
                columns.Add("Type_desc");
                columns.Add("Object_id");
                DataTable dt = ConvertListToDataTable(proxy.AllKeys(), columns);
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
                MessageBox.Show(ex.Message);
            }

        }


        private void buttonAllIndexes_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> columns = new List<string>();
                columns.Add("object_id");
                columns.Add("name");
                columns.Add("index_id");
                DataTable dt = ConvertListToDataTable(proxy.AllIndexes(), columns);
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
                List<string> columns = new List<string>();
                columns.Add("Table_Name");
                columns.Add("Column_Name");
                columns.Add("Constraint_Type");
                DataTable dt = ConvertListToDataTable(proxy.AllTableConstraints(), columns);
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
                List<string> columns = new List<string>();
                columns.Add("Tables");
                DataTable dt = ConvertListToDataTable(proxy.AllTables1(), columns);
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
                List<string> columns = new List<string>();
                columns.Add("Tables");
                DataTable dt = ConvertListToDataTable(proxy.AllTables2(), columns);
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
                List<string> columns = new List<string>();
                columns.Add("Columns");
                DataTable dt = ConvertListToDataTable(proxy.AllColumns1(), columns);
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
                List<string> columns = new List<string>();
                columns.Add("Columns");
                DataTable dt = ConvertListToDataTable(proxy.AllColumns2(), columns);
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
                List<string> columns = new List<string>();
                columns.Add("table_catalog");
                columns.Add("table_name");
                columns.Add("column_name");
                columns.Add("ordinal_position");
                columns.Add("is_nullable");
                columns.Add("data_type");
                DataTable dt = ConvertListToDataTable(proxy.MetaDataForEmployeeTable(), columns);
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
    
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
                MessageBox.Show(ex.Message);

            }

        }

        private void buttonEmployeeRelatives_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> columns = new List<string>();
                columns.Add("Employee No_");
                columns.Add("Relative Code");
                columns.Add("First Name");
                columns.Add("Last Name");
                columns.Add("Birth Date");
                
                DataTable dt = ConvertListToDataTable(proxy.EmployeeRelatives(), columns);
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEmployeeAbsent2004_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> columns = new List<string>();
                columns.Add("Employee_Number");
                DataTable dt = ConvertListToDataTable(proxy.EmployeeAbsent2004(), columns);
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
                List<string> columns = new List<string>();
                columns.Add("First Name");
                DataTable dt = ConvertListToDataTable(proxy.EmployeeAbsentTheMost(), columns);
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
