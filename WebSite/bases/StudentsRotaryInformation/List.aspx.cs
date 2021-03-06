﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;
using Model;
using BLL;

public partial class bases_StudentsRotaryInformation_List : System.Web.UI.Page
{
    LoginModel loginModel = null;
    protected string TrainingBaseCode = string.Empty;
    protected string ProfessionalBaseCode = string.Empty;
    protected string StudentsRealName, Sex, MinZu, HighEducation, HighSchool, IdentityType, SendUnit,
        CollaborativeUnit, TrainingTime, PlanTrainingTime,
        DeptName, TeachersRealName, RotaryBeginTime, RotaryEndTime, OutdeptStatus;
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
            TrainingBaseCode = loginModel.training_base_code == null ? "" : loginModel.training_base_code.ToString();
            ProfessionalBaseCode = loginModel.professional_base_code == null ? "" : loginModel.professional_base_code.ToString();
        }
        StudentsRealName = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["StudentsRealName"]).Trim());
        Sex = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["Sex"]).Trim());

        MinZu = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["MinZu"]).Trim());
        HighEducation = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["HighEducation"]).Trim());
        HighSchool = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["HighSchool"]).Trim());
        IdentityType = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["IdentityType"]).Trim());
        SendUnit = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["SendUnit"]).Trim());
        CollaborativeUnit = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["CollaborativeUnit"]).Trim());
        TrainingTime = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["TrainingTime"]).Trim());
        PlanTrainingTime = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["PlanTrainingTime"]).Trim());
        DeptName = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["DeptName"]).Trim());
        TeachersRealName = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["TeachersRealName"]).Trim());
        RotaryBeginTime = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["RotaryBeginTime"]).Trim());
        RotaryEndTime = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["RotaryEndTime"]).Trim());
        OutdeptStatus = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["OutdeptStatus"]).Trim());
       
    }
}