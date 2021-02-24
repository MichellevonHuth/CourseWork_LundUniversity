﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name = "Assignment6Service1Soap", Namespace = "http://tempuri.org/")]
public partial class Assignment6Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol
{

    private System.Threading.SendOrPostCallback MetaDataForEmployeeTableOperationCompleted;

    private System.Threading.SendOrPostCallback EmployeeRelativesOperationCompleted;

    private System.Threading.SendOrPostCallback EmployeeAbsent2004OperationCompleted;

    private System.Threading.SendOrPostCallback EmployeeAbsentTheMostOperationCompleted;

    private System.Threading.SendOrPostCallback AllKeysOperationCompleted;

    private System.Threading.SendOrPostCallback AllIndexesOperationCompleted;

    private System.Threading.SendOrPostCallback AllTableConstraintsOperationCompleted;

    private System.Threading.SendOrPostCallback AllTables1OperationCompleted;

    private System.Threading.SendOrPostCallback AllTables2OperationCompleted;

    private System.Threading.SendOrPostCallback AllColumns1OperationCompleted;

    private System.Threading.SendOrPostCallback AllColumns2OperationCompleted;

    /// <remarks/>
    public Assignment6Service1()
    {
        this.Url = "http://localhost/WSAssignment_6/Assignment6Service.asmx";
    }

    /// <remarks/>
    public event MetaDataForEmployeeTableCompletedEventHandler MetaDataForEmployeeTableCompleted;

    /// <remarks/>
    public event EmployeeRelativesCompletedEventHandler EmployeeRelativesCompleted;

    /// <remarks/>
    public event EmployeeAbsent2004CompletedEventHandler EmployeeAbsent2004Completed;

    /// <remarks/>
    public event EmployeeAbsentTheMostCompletedEventHandler EmployeeAbsentTheMostCompleted;

    /// <remarks/>
    public event AllKeysCompletedEventHandler AllKeysCompleted;

    /// <remarks/>
    public event AllIndexesCompletedEventHandler AllIndexesCompleted;

    /// <remarks/>
    public event AllTableConstraintsCompletedEventHandler AllTableConstraintsCompleted;

    /// <remarks/>
    public event AllTables1CompletedEventHandler AllTables1Completed;

    /// <remarks/>
    public event AllTables2CompletedEventHandler AllTables2Completed;

    /// <remarks/>
    public event AllColumns1CompletedEventHandler AllColumns1Completed;

    /// <remarks/>
    public event AllColumns2CompletedEventHandler AllColumns2Completed;

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/MetaDataForEmployeeTable", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public System.Data.DataTable MetaDataForEmployeeTable()
    {
        object[] results = this.Invoke("MetaDataForEmployeeTable", new object[0]);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginMetaDataForEmployeeTable(System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("MetaDataForEmployeeTable", new object[0], callback, asyncState);
    }

    /// <remarks/>
    public System.Data.DataTable EndMetaDataForEmployeeTable(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public void MetaDataForEmployeeTableAsync()
    {
        this.MetaDataForEmployeeTableAsync(null);
    }

    /// <remarks/>
    public void MetaDataForEmployeeTableAsync(object userState)
    {
        if ((this.MetaDataForEmployeeTableOperationCompleted == null))
        {
            this.MetaDataForEmployeeTableOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMetaDataForEmployeeTableOperationCompleted);
        }
        this.InvokeAsync("MetaDataForEmployeeTable", new object[0], this.MetaDataForEmployeeTableOperationCompleted, userState);
    }

    private void OnMetaDataForEmployeeTableOperationCompleted(object arg)
    {
        if ((this.MetaDataForEmployeeTableCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.MetaDataForEmployeeTableCompleted(this, new MetaDataForEmployeeTableCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/EmployeeRelatives", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public System.Data.DataTable EmployeeRelatives()
    {
        object[] results = this.Invoke("EmployeeRelatives", new object[0]);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginEmployeeRelatives(System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("EmployeeRelatives", new object[0], callback, asyncState);
    }

    /// <remarks/>
    public System.Data.DataTable EndEmployeeRelatives(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public void EmployeeRelativesAsync()
    {
        this.EmployeeRelativesAsync(null);
    }

    /// <remarks/>
    public void EmployeeRelativesAsync(object userState)
    {
        if ((this.EmployeeRelativesOperationCompleted == null))
        {
            this.EmployeeRelativesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEmployeeRelativesOperationCompleted);
        }
        this.InvokeAsync("EmployeeRelatives", new object[0], this.EmployeeRelativesOperationCompleted, userState);
    }

    private void OnEmployeeRelativesOperationCompleted(object arg)
    {
        if ((this.EmployeeRelativesCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.EmployeeRelativesCompleted(this, new EmployeeRelativesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/EmployeeAbsent2004", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public System.Data.DataTable EmployeeAbsent2004()
    {
        object[] results = this.Invoke("EmployeeAbsent2004", new object[0]);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginEmployeeAbsent2004(System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("EmployeeAbsent2004", new object[0], callback, asyncState);
    }

    /// <remarks/>
    public System.Data.DataTable EndEmployeeAbsent2004(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public void EmployeeAbsent2004Async()
    {
        this.EmployeeAbsent2004Async(null);
    }

    /// <remarks/>
    public void EmployeeAbsent2004Async(object userState)
    {
        if ((this.EmployeeAbsent2004OperationCompleted == null))
        {
            this.EmployeeAbsent2004OperationCompleted = new System.Threading.SendOrPostCallback(this.OnEmployeeAbsent2004OperationCompleted);
        }
        this.InvokeAsync("EmployeeAbsent2004", new object[0], this.EmployeeAbsent2004OperationCompleted, userState);
    }

    private void OnEmployeeAbsent2004OperationCompleted(object arg)
    {
        if ((this.EmployeeAbsent2004Completed != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.EmployeeAbsent2004Completed(this, new EmployeeAbsent2004CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/EmployeeAbsentTheMost", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public System.Data.DataTable EmployeeAbsentTheMost()
    {
        object[] results = this.Invoke("EmployeeAbsentTheMost", new object[0]);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginEmployeeAbsentTheMost(System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("EmployeeAbsentTheMost", new object[0], callback, asyncState);
    }

    /// <remarks/>
    public System.Data.DataTable EndEmployeeAbsentTheMost(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public void EmployeeAbsentTheMostAsync()
    {
        this.EmployeeAbsentTheMostAsync(null);
    }

    /// <remarks/>
    public void EmployeeAbsentTheMostAsync(object userState)
    {
        if ((this.EmployeeAbsentTheMostOperationCompleted == null))
        {
            this.EmployeeAbsentTheMostOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEmployeeAbsentTheMostOperationCompleted);
        }
        this.InvokeAsync("EmployeeAbsentTheMost", new object[0], this.EmployeeAbsentTheMostOperationCompleted, userState);
    }

    private void OnEmployeeAbsentTheMostOperationCompleted(object arg)
    {
        if ((this.EmployeeAbsentTheMostCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.EmployeeAbsentTheMostCompleted(this, new EmployeeAbsentTheMostCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AllKeys", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public System.Data.DataTable AllKeys()
    {
        object[] results = this.Invoke("AllKeys", new object[0]);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginAllKeys(System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("AllKeys", new object[0], callback, asyncState);
    }

    /// <remarks/>
    public System.Data.DataTable EndAllKeys(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public void AllKeysAsync()
    {
        this.AllKeysAsync(null);
    }

    /// <remarks/>
    public void AllKeysAsync(object userState)
    {
        if ((this.AllKeysOperationCompleted == null))
        {
            this.AllKeysOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAllKeysOperationCompleted);
        }
        this.InvokeAsync("AllKeys", new object[0], this.AllKeysOperationCompleted, userState);
    }

    private void OnAllKeysOperationCompleted(object arg)
    {
        if ((this.AllKeysCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.AllKeysCompleted(this, new AllKeysCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AllIndexes", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public System.Data.DataTable AllIndexes()
    {
        object[] results = this.Invoke("AllIndexes", new object[0]);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginAllIndexes(System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("AllIndexes", new object[0], callback, asyncState);
    }

    /// <remarks/>
    public System.Data.DataTable EndAllIndexes(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public void AllIndexesAsync()
    {
        this.AllIndexesAsync(null);
    }

    /// <remarks/>
    public void AllIndexesAsync(object userState)
    {
        if ((this.AllIndexesOperationCompleted == null))
        {
            this.AllIndexesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAllIndexesOperationCompleted);
        }
        this.InvokeAsync("AllIndexes", new object[0], this.AllIndexesOperationCompleted, userState);
    }

    private void OnAllIndexesOperationCompleted(object arg)
    {
        if ((this.AllIndexesCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.AllIndexesCompleted(this, new AllIndexesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AllTableConstraints", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public System.Data.DataTable AllTableConstraints()
    {
        object[] results = this.Invoke("AllTableConstraints", new object[0]);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginAllTableConstraints(System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("AllTableConstraints", new object[0], callback, asyncState);
    }

    /// <remarks/>
    public System.Data.DataTable EndAllTableConstraints(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public void AllTableConstraintsAsync()
    {
        this.AllTableConstraintsAsync(null);
    }

    /// <remarks/>
    public void AllTableConstraintsAsync(object userState)
    {
        if ((this.AllTableConstraintsOperationCompleted == null))
        {
            this.AllTableConstraintsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAllTableConstraintsOperationCompleted);
        }
        this.InvokeAsync("AllTableConstraints", new object[0], this.AllTableConstraintsOperationCompleted, userState);
    }

    private void OnAllTableConstraintsOperationCompleted(object arg)
    {
        if ((this.AllTableConstraintsCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.AllTableConstraintsCompleted(this, new AllTableConstraintsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AllTables1", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public System.Data.DataTable AllTables1()
    {
        object[] results = this.Invoke("AllTables1", new object[0]);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginAllTables1(System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("AllTables1", new object[0], callback, asyncState);
    }

    /// <remarks/>
    public System.Data.DataTable EndAllTables1(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public void AllTables1Async()
    {
        this.AllTables1Async(null);
    }

    /// <remarks/>
    public void AllTables1Async(object userState)
    {
        if ((this.AllTables1OperationCompleted == null))
        {
            this.AllTables1OperationCompleted = new System.Threading.SendOrPostCallback(this.OnAllTables1OperationCompleted);
        }
        this.InvokeAsync("AllTables1", new object[0], this.AllTables1OperationCompleted, userState);
    }

    private void OnAllTables1OperationCompleted(object arg)
    {
        if ((this.AllTables1Completed != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.AllTables1Completed(this, new AllTables1CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AllTables2", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public System.Data.DataTable AllTables2()
    {
        object[] results = this.Invoke("AllTables2", new object[0]);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginAllTables2(System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("AllTables2", new object[0], callback, asyncState);
    }

    /// <remarks/>
    public System.Data.DataTable EndAllTables2(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public void AllTables2Async()
    {
        this.AllTables2Async(null);
    }

    /// <remarks/>
    public void AllTables2Async(object userState)
    {
        if ((this.AllTables2OperationCompleted == null))
        {
            this.AllTables2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnAllTables2OperationCompleted);
        }
        this.InvokeAsync("AllTables2", new object[0], this.AllTables2OperationCompleted, userState);
    }

    private void OnAllTables2OperationCompleted(object arg)
    {
        if ((this.AllTables2Completed != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.AllTables2Completed(this, new AllTables2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AllColumns1", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public System.Data.DataTable AllColumns1()
    {
        object[] results = this.Invoke("AllColumns1", new object[0]);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginAllColumns1(System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("AllColumns1", new object[0], callback, asyncState);
    }

    /// <remarks/>
    public System.Data.DataTable EndAllColumns1(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public void AllColumns1Async()
    {
        this.AllColumns1Async(null);
    }

    /// <remarks/>
    public void AllColumns1Async(object userState)
    {
        if ((this.AllColumns1OperationCompleted == null))
        {
            this.AllColumns1OperationCompleted = new System.Threading.SendOrPostCallback(this.OnAllColumns1OperationCompleted);
        }
        this.InvokeAsync("AllColumns1", new object[0], this.AllColumns1OperationCompleted, userState);
    }

    private void OnAllColumns1OperationCompleted(object arg)
    {
        if ((this.AllColumns1Completed != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.AllColumns1Completed(this, new AllColumns1CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AllColumns2", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public System.Data.DataTable AllColumns2()
    {
        object[] results = this.Invoke("AllColumns2", new object[0]);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginAllColumns2(System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("AllColumns2", new object[0], callback, asyncState);
    }

    /// <remarks/>
    public System.Data.DataTable EndAllColumns2(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Data.DataTable)(results[0]));
    }

    /// <remarks/>
    public void AllColumns2Async()
    {
        this.AllColumns2Async(null);
    }

    /// <remarks/>
    public void AllColumns2Async(object userState)
    {
        if ((this.AllColumns2OperationCompleted == null))
        {
            this.AllColumns2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnAllColumns2OperationCompleted);
        }
        this.InvokeAsync("AllColumns2", new object[0], this.AllColumns2OperationCompleted, userState);
    }

    private void OnAllColumns2OperationCompleted(object arg)
    {
        if ((this.AllColumns2Completed != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.AllColumns2Completed(this, new AllColumns2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    public new void CancelAsync(object userState)
    {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void MetaDataForEmployeeTableCompletedEventHandler(object sender, MetaDataForEmployeeTableCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class MetaDataForEmployeeTableCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal MetaDataForEmployeeTableCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public System.Data.DataTable Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((System.Data.DataTable)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void EmployeeRelativesCompletedEventHandler(object sender, EmployeeRelativesCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class EmployeeRelativesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal EmployeeRelativesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public System.Data.DataTable Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((System.Data.DataTable)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void EmployeeAbsent2004CompletedEventHandler(object sender, EmployeeAbsent2004CompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class EmployeeAbsent2004CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal EmployeeAbsent2004CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public System.Data.DataTable Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((System.Data.DataTable)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void EmployeeAbsentTheMostCompletedEventHandler(object sender, EmployeeAbsentTheMostCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class EmployeeAbsentTheMostCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal EmployeeAbsentTheMostCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public System.Data.DataTable Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((System.Data.DataTable)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void AllKeysCompletedEventHandler(object sender, AllKeysCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AllKeysCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal AllKeysCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public System.Data.DataTable Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((System.Data.DataTable)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void AllIndexesCompletedEventHandler(object sender, AllIndexesCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AllIndexesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal AllIndexesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public System.Data.DataTable Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((System.Data.DataTable)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void AllTableConstraintsCompletedEventHandler(object sender, AllTableConstraintsCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AllTableConstraintsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal AllTableConstraintsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public System.Data.DataTable Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((System.Data.DataTable)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void AllTables1CompletedEventHandler(object sender, AllTables1CompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AllTables1CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal AllTables1CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public System.Data.DataTable Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((System.Data.DataTable)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void AllTables2CompletedEventHandler(object sender, AllTables2CompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AllTables2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal AllTables2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public System.Data.DataTable Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((System.Data.DataTable)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void AllColumns1CompletedEventHandler(object sender, AllColumns1CompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AllColumns1CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal AllColumns1CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public System.Data.DataTable Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((System.Data.DataTable)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void AllColumns2CompletedEventHandler(object sender, AllColumns2CompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AllColumns2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal AllColumns2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public System.Data.DataTable Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((System.Data.DataTable)(this.results[0]));
        }
    }
}