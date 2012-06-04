// 
// DotNetNuke® - http://www.dotnetnuke.com
// Copyright (c) 2002-2011
// by DotNetNuke Corporation
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
// of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.


using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Web.UI;
using System.Web.UI.WebControls;

using DotNetNuke;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using System.Data;
using System.Net;
using System.IO;
using System.Web;
using System.Xml;
using System.Text;

namespace Philip.Modules.BanckleLiveChatModule
{
    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The ViewBanckleLiveChatModule class displays the content
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <history>
    /// </history>
    /// -----------------------------------------------------------------------------
    partial class ViewBanckleLiveChatModule : PortalModuleBase, IActionable
    {

        
        #region Event Handlers
               
        protected void Page_Load(System.Object sender, System.EventArgs e)
        {
            try
            {
                
                if (!Page.IsPostBack)
                {

                    lblMsg.Attributes.Add("onclick", "javascript:CallMe('" + lblMsg.ClientID + "', '" + getURL() + "')");
                    //chk if the module is already installed or not
                    IsInstalled();

                    PanelIframe.Visible = true;
                    PanelSignIn.Visible = false;
                    PanelDeployment.Visible = false;
                    
                }
               
            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }

            if (Request.QueryString["ShowSignIn"] != "" && Request.QueryString["ShowSignIn"] != null)
            {
                PanelIframe.Visible = false;
                PanelSignIn.Visible = true;
                PanelDeployment.Visible = false;
            }
            else
            {
                PanelIframe.Visible = true;
                PanelSignIn.Visible = false;
                PanelDeployment.Visible = false;
            }

        }
        
        protected void btnContinue_Click(object sender, EventArgs e)
        {
            checkUser();
        }
       
        protected void btnActivate_Click(object sender, EventArgs e)
        {
            string token = SaveToken(ddlDeployment.SelectedItem.Value,txtLogin.Text.ToString());
            //string ActivateString = "<!--Monitoring Code--><script type=\"text/javascript\" async=\"async\" src=\"https://apps.banckle.com/livechat/visitor.do?dep=" + ddlDeployment.SelectedValue.ToString() + "\"></script><div id=\"banckleLiveChatButton1\" class=\"banckleLiveChatBottomRight\" style=\"overflow: hidden; margin: 0pt; padding: 0pt; background: none repeat scroll 0% 0% transparent; width: 264px; height: 70px; z-index: 1000000000; position: fixed; bottom: -3px; right: 20px;\"><!--Chat Link Code--><a href=\"javascript:;\" onclick=\"blc_startChat()\"><img style=border:0px; id=\"blc_chatImg\" src=\"https://apps.banckle.com/livechat/onlineImg.do?d=" + ddlDeployment.SelectedValue.ToString() + " \" /> </a></div>";
            string ActivateString = "<!--Monitoring Code--><script type=\"text/javascript\" async=\"async\" src=\"https://apps.banckle.com/livechat/visitor.do?dep=" + Session["token"].ToString() + "\"></script><!--Chat Link Code--><a href=\"javascript:;\" onclick=\"blc_startChat()\"><img style='border:0px;' id=\"blc_chatImg\" src='https://apps.banckle.com/livechat/onlineImg.do?d=" + Session["token"].ToString() + "'/></a>";
            
            txtContent.Text = ActivateString;
            
            PanelSignIn.Visible = false;
            PanelActivated.Visible = true;
            PanelDeployment.Visible = false;
            PanelIframe.Visible = false;
        }

        protected void btnSetting_Click(object sender, EventArgs e)
        {
            PanelSignIn.Visible = false;
            PanelActivated.Visible = false;
            PanelDeployment.Visible = false;
            PanelDeactivation.Visible = true;
        }

        protected void btnDeactivate_Click(object sender, EventArgs e)
        {
            string token = Session["token"].ToString();
            string userid = Session["userid"].ToString();
            
            BanckleLiveChatModuleController rwac = new BanckleLiveChatModuleController();

            if (token != "")
            {
                rwac.DeleteToken(token, userid);
            }

            IsInstalled();
         
            PanelIframe.Visible = true;
            PanelDeactivateCode.Visible = false;
            PanelDeactivation.Visible = false;
            PanelSignIn.Visible = false;

        }

        protected void btnLoggedInSetting_Click(object sender, EventArgs e)
        {

            //string ActivateString = "<!--Monitoring Code--><script type=\"text/javascript\" async=\"async\" src=\"https://apps.banckle.com/livechat/visitor.do?dep=" + Session["token"].ToString() + "\"></script><div id=\"banckleLiveChatButton1\" class=\"banckleLiveChatBottomRight\" style=\"overflow: hidden; margin: 0pt; padding: 0pt; background: none repeat scroll 0% 0% transparent; width: 264px; height: 70px; z-index: 1000000000; position: fixed; bottom: -3px; right: 20px;\"><!--Chat Link Code--><a href=\"javascript:;\" onclick=\"blc_startChat()\"><img style=border:0px; id=\"blc_chatImg\" src=\"https://apps.banckle.com/livechat/onlineImg.do?d=" + Session["token"].ToString() + " \" /> </a></div>";
            string ActivateString = "<!--Monitoring Code--><script type=\"text/javascript\" async=\"async\" src=\"https://apps.banckle.com/livechat/visitor.do?dep=" + Session["token"].ToString() + "\"></script><!--Chat Link Code--><a href=\"javascript:;\" onclick=\"blc_startChat()\"><img style='border:0px;' id=\"blc_chatImg\" src='https://apps.banckle.com/livechat/onlineImg.do?d=" + Session["token"].ToString() + "'/></a>";
                     

            txtOldContent.Text = ActivateString;

            PanelDeactivateCode.Visible = true;
            PanelSignIn.Visible = false;
            PanelActivated.Visible = false;
            PanelDeployment.Visible = false;
            PanelDeactivation.Visible = false;
            PanelIframe.Visible = false;
        }
        
        #endregion

        #region Private Methods

        

        private void LoadDeployments(string token)
        {
            try
            {
                string xmlResult = null;
                string url;
                url = "https://apps.banckle.com/em/api/deployments.xml?_token=" + token;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader resStream = new StreamReader(response.GetResponseStream());
                xmlResult = resStream.ReadToEnd();
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xmlResult);

                XmlNodeReader xmlReader = new XmlNodeReader(doc);
                DataSet RS = new DataSet();
                RS.ReadXml(xmlReader);

                DataView dv = RS.Tables[0].DefaultView;

                ddlDeployment.DataTextField = "name";
                ddlDeployment.DataValueField = "id";

                ddlDeployment.DataSource = dv;
                ddlDeployment.DataBind();


            }

            catch (Exception ex)
            {
                lblWrongPass.Text = "Error occoured Please call the Website Developers! " + ex.Message.ToString();
            }
        }

        private string SaveToken(string stringResult, string userid)
        {
            //int findIndex = stringResult.IndexOf("token", 0)+8;
            //string token =stringResult.Substring(findIndex, 36);
            string token = stringResult;

            Session["token"] = token;
            Session["userid"] = userid;
            
            //save to the db
            BanckleLiveChatModuleController rwac = new BanckleLiveChatModuleController();

            if (token != "")
            {
                rwac.InsertToken(token,userid);
            }
            return token;
        }

        private void checkUser()
        {
            try
            {
                string stringResult = null;
                string url;
                url = "https://apps.banckle.com/api/authenticate?userid=" + txtLogin.Text + "&password=" + txtPassword.Text + "&sourceSite=" + HttpContext.Current.Request.Url.Scheme + "://" + HttpContext.Current.Request.Url.Authority + HttpContext.Current.Request.ApplicationPath + "&platform=dnn";

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader resStream = new StreamReader(response.GetResponseStream());
                stringResult = resStream.ReadToEnd();
                int findIndex = stringResult.IndexOf("error", 0);

                if (findIndex == 2)
                {
                    lblWrongPass.Visible = true;
                }
                else
                {
                    PanelSignIn.Visible = false;
                    PanelDeployment.Visible = true;
                    PanelIframe.Visible = false;
                    
                    int findIndexx = stringResult.IndexOf("token", 0)+8;
                    string token =stringResult.Substring(findIndexx, 36);

                    //string token = SaveToken(stringResult,txtLogin.Text.ToString());

                    LoadDeployments(token);

                }

            }
            catch (Exception ex)
            {
                lblWrongPass.Text = "Error occoured Please call the Website Developers! " + ex.Message.ToString();
            }
        }
        
        private void IsInstalled()
        {
            BanckleLiveChatModuleController rwac = new BanckleLiveChatModuleController();

            DataTable InstalledDT = new DataTable();

            if (Session["token"] != null)
            {
                InstalledDT = rwac.IsInstalled(Session["token"].ToString(), Session["userid"].ToString());
            }
            

            if (InstalledDT.Rows.Count > 0)
            {
                lblMsg.Visible = false;
                btnLoggedInSetting.Visible = true;


            }
            else
            {
                lblMsg.Visible = true;
                btnLoggedInSetting.Visible = false;
            }


        }

        public string getURL()
        {
            string fullURL;
            fullURL = Request.Url.ToString() + "&ShowSignIn=1";
            return fullURL;
        }

        #endregion

        #region Optional Interfaces

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Registers the module actions required for interfacing with the portal framework
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        /// <history>
        /// </history>
        /// -----------------------------------------------------------------------------
        public ModuleActionCollection ModuleActions
        {
            get
            {
                ModuleActionCollection Actions = new ModuleActionCollection();
                Actions.Add(this.GetNextActionID(), Localization.GetString(ModuleActionType.AddContent, this.LocalResourceFile), ModuleActionType.AddContent, "", "", this.EditUrl(), false, SecurityAccessLevel.Edit, true, false);
                return Actions;
            }
        }

        #endregion




        
}
}

