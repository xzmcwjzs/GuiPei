﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Left.aspx.cs" Inherits="students_RescuePatientRecords_Left" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
    <title>左侧页</title>
    <script src="../../js/global.js"></script>
    <script src="../../js/My97DatePicker/WdatePicker.js"></script>
    <link href="../../css/global.css" rel="stylesheet" />
</head>
<body style="background-color:#F1F3F5;">
    <form id="form1" runat="server" target="frmright" method="post">
    <div>
        <table cellpadding="1" cellspacing="1" class="qryTable">
          
            <tr>
                <td>轮转科室：</td>
            </tr>
            <tr>
                <td>
                    <input type="text" id="DeptName" name="DeptName" size="25" />                
                </td>
            </tr>
             <tr>
                <td>病人姓名：</td>
            </tr>
            <tr>
                <td>
                    <input type="text" id="PatientName" name="PatientName" size="25" />                
                </td>
            </tr>
            <tr>
                <td>病历号：</td>
            </tr>
            <tr>
                <td>
                    <input type="text" id="CaseId" name="CaseId" size="25" />                
                </td>
            </tr>
            <tr>
                <td>疾病名称：</td>
            </tr>
            <tr>
                <td>
                    <input type="text" id="DiseaseName" name="DiseaseName" size="25" />                
                </td>
            </tr>
            <tr>
                <td>转归情况：</td>
            </tr>
            <tr>
                <td>
                    <input type="text" id="Condition" name="Condition" size="25" />                
                </td>
            </tr>
                        
            <tr>
                <td>
                    <div style="text-align:center;">     
                        <asp:Button ID="Button1" runat="server" Text="查询" CssClass="button" PostBackUrl="~/students/RescuePatientRecords/List.aspx" Height="25px" Width="50px" />
                        <input type="button" name="Submit2" value="重置"class="button" onClick="form1.reset();" style="width:50px;height:25px;"/>
                    </div>                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

