﻿#pragma checksum "D:\Github\SakerProgrammering\Employee.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97094A27D4F88C81BC30DA5596E8C0E16557A650"

#line 1 "D:\Github\SakerProgrammering\Employee.aspx.cs"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Employee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        User user = new User();
        if (!user.Auth())
        {
            Response.Redirect("~/Default.aspx");
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid) 
        {
            User user = new User();
            int userId = user.GetUserId();
            DateTime fromDate = Convert.ToDateTime(txtFromDate.Text);

            // Anger vilken typ som är vald i radiobutton-listan. 
            int sicknessType = RadioButtonList1.SelectedIndex;

            Log log = new Log();

            user.GetUserData();
            switch (sicknessType)
            {
                case 0: // "Första sjukdagen"

                    // TODO Vart hämtar jag användarnamnet ifrån? Sessionen kanske?
                    log.LogMessage("Användare: " + userId + " anmälde sjukskrivning, från IP adress: " + Request.UserHostAddress);
                    
                    // TODO add to database..
                    user.IllnessStart.Add(Convert.ToDateTime(txtFromDate.Text));
                    user.MedicalCertificateExpires.Add(Convert.ToDateTime(txtToDate.Text));
                    user.MedicalCertificate.Add(false);
                    user.ChildIllness.Add(false);
                    user.SocialSecurityNumberChild.Add(string.Empty);
                    user.AddSickDays();
                    break;

                case 1: // "Sjukskriven av läkare"
                    
                    DateTime toDate = Convert.ToDateTime(txtToDate.Text);

                    // TODO Vart hämtar jag användarnamnet ifrån? Sessionen kanske?
                    log.LogMessage("Användare: " + userId + " anmälde sjukskrivning av läkare, från IP adress: " + Request.UserHostAddress);

                    // TODO add to database..
                    user.IllnessStart.Add(Convert.ToDateTime(txtFromDate.Text));
                    user.MedicalCertificateExpires.Add(Convert.ToDateTime(txtToDate.Text));
                    user.MedicalCertificate.Add(true);
                    user.ChildIllness.Add(false);
                    user.SocialSecurityNumberChild.Add(string.Empty);
                    user.AddSickDays();
                    break;

                case 2: // "Vård av barn"
                    
                    string ssn = txtChild.Text;

                    // TODO Vart hämtar jag användarnamnet ifrån? Sessionen kanske?
                    log.LogMessage("Användare: " + userId + " anmälde vård av barn, från IP adress: " + Request.UserHostAddress);

                    // TODO add to database..
                    user.IllnessStart.Add(Convert.ToDateTime(txtFromDate.Text));
                    user.MedicalCertificateExpires.Add(Convert.ToDateTime(txtToDate.Text));
                    user.MedicalCertificate.Add(false);
                    user.ChildIllness.Add(true);
                    user.SocialSecurityNumberChild.Add(ssn);
                    user.AddSickDays();
                    break;
            }
        }
    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        User user = new User();
        user.Logout();
        Response.Redirect("Default.aspx");
    }
}

#line default
#line hidden
