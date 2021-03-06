﻿#pragma checksum "D:\Github\SakerProgrammering\App_Code\EmployeeDB.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E3373129B1F112072C43BACD4BC588B388C484B1"

#line 1 "D:\Github\SakerProgrammering\App_Code\EmployeeDB.cs"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Transactions;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for EmployeeDB
/// </summary>
public class EmployeeDB
{
    public EmployeeDB()
    {
    }
    public void AddSickDays(User user)
    {
        using (TransactionScope ts = new TransactionScope())
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                Illness illness = new Illness();
                illness.Start = user.IllnessStart[user.IllnessStart.Count-1];
                illness.MedicalCertificate = user.MedicalCertificate[user.MedicalCertificate.Count - 1];
                illness.ChildIllness = user.ChildIllness[user.ChildIllness.Count-1];
                illness.Expires = user.MedicalCertificateExpires[user.MedicalCertificateExpires.Count-1];
                illness.SocialSecurity = user.SocialSecurityNumberChild[user.SocialSecurityNumberChild.Count-1];
                illness.AnstalldId = user.UserId;

                db.Illnesses.InsertOnSubmit(illness);
                db.SubmitChanges();
            }
            ts.Complete();
        }
    }

    public Users GetUserData(int useerId)
    {
        List<Users> user = new List<Users>(){null};
        DataClassesDataContext db = new DataClassesDataContext();
        
        var userData = from u in db.Users
                    where u.Id == userId
                    select u;

        if (userData.Count() > 0)
            user = userData.ToList();

        return user[0];
    }
}

#line default
#line hidden
