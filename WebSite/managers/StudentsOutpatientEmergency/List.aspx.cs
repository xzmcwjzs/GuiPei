﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Common;


public partial class managers_StudentsOutpatientEmergency_List : System.Web.UI.Page
{
    LoginModel loginModel = null;
    protected string StudentsRealName = string.Empty;
    protected string TeachersName = string.Empty;
    protected string TrainingBaseCode = string.Empty;
    protected string ProfessionalBaseCode = string.Empty;
    protected string DeptCode = string.Empty;
    protected string RecordType = string.Empty;
    protected string DiseaseName = string.Empty;
    protected string DiseaseNum = string.Empty;

    protected string DeptName = string.Empty;
    protected string TeachersRealName = string.Empty; protected string ProfessionalBaseName = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["loginModel"] == null)
        {
            ShowMessageBox.Showmessagebox(this, "请重新登录", "../../Default.aspx");
            return;
        }

        if (!IsPostBack)
        {
            loginModel = new LoginModel();
            loginModel = (LoginModel)Session["loginModel"];
            TrainingBaseCode = CommonFunc.SafeGetStringFromObj(loginModel.training_base_code);

        }
        StudentsRealName = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["StudentsRealName"]));
        RecordType = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["RecordType"]).Trim());
        DiseaseName = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["DiseaseName"]).Trim());
        DiseaseNum = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["DiseaseNum"]).Trim());
        DeptName = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["DeptName"]).Trim());
        TeachersRealName = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["TeachersRealName"]).Trim());
        ProfessionalBaseName = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["ProfessionalBaseName"]).Trim());
  
    }
}