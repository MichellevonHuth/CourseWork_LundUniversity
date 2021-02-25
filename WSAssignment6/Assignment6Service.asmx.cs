﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WSAssignment6
{
    /// <summary>
    /// Summary description for Assignment6Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Assignment6Service : System.Web.Services.WebService
    {
        DataAccessLayer dal;

        public Assignment6Service()
        {
            dal = new DataAccessLayer();
        }

        [WebMethod]
        public DataTable MetaDataForEmployeeTable()
        {
            DataTable dt = dal.MetaDataForEmployeeTable();
            dt.TableName = "MyDt";
            return dt;
        }

        [WebMethod]
        public DataTable EmployeeRelatives()
        {
            DataTable dt = dal.EmployeeRelatives();
            dt.TableName = "MyDt";
            return dt;
        }

        [WebMethod]
        public DataTable EmployeeAbsent2004()
        {
            DataTable dt = dal.EmployeeAbsent2004();
            dt.TableName = "MyDt";
            return dt;
        }

        [WebMethod]
        public DataTable EmployeeAbsentTheMost()
        {
            DataTable dt = dal.EmployeeAbsentTheMost();
            dt.TableName = "MyDt";
            return dt;
        }

        [WebMethod]
        public DataTable AllKeys()
        {
            DataTable dt = dal.AllKeys();
            dt.TableName = "MyDt";
            return dt;
        }

        [WebMethod]
        public DataTable AllIndexes()
        {
            DataTable dt = dal.AllIndexes();
            dt.TableName = "MyDt";
            return dt;
        }

        [WebMethod]
        public DataTable AllTableConstraints()
        {
            DataTable dt = dal.AllTableConstraints();
            dt.TableName = "MyDt";
            return dt;
        }

        [WebMethod]
        public DataTable AllTables1()
        {
            DataTable dt = dal.AllTables1();
            dt.TableName = "MyDt";
            return dt;
        }

        [WebMethod]
        public DataTable AllTables2()
        {
            DataTable dt = dal.AllTables2();
            dt.TableName = "MyDt";
            return dt;
        }

        [WebMethod]
        public DataTable AllColumns1()
        {
            DataTable dt = dal.AllColumns1();
            dt.TableName = "MyDt";
            return dt;
        }

        [WebMethod]
        public DataTable AllColumns2()
        {
            DataTable dt = dal.AllColumns2();
            dt.TableName = "MyDt";
            return dt;
        }
    }
}
