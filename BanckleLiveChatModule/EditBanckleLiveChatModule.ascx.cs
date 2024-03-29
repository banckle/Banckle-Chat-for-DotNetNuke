// 
// DotNetNukeŽ - http://www.dotnetnuke.com
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

using DotNetNuke;
using DotNetNuke.Common;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;

namespace Philip.Modules.BanckleLiveChatModule
{
    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The EditBanckleLiveChatModule class is used to manage content
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <history>
    /// </history>
    /// -----------------------------------------------------------------------------
    partial class EditBanckleLiveChatModule : PortalModuleBase
    {

    #region Private Members

        private int ItemId = Null.NullInteger;

    #endregion

    #region Event Handlers

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Page_Load runs when the control is loaded
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <history>
        /// </history>
        /// -----------------------------------------------------------------------------
        protected void Page_Load(System.Object sender, System.EventArgs e)
        {
           // try
           // {
           //     //Determine ItemId of BanckleLiveChatModule to Update
           //     if(this.Request.QueryString["ItemId"] !=null)
           //     {
           //         ItemId = Int32.Parse(this.Request.QueryString["ItemId"]);
           //     }

           //     //If this is the first visit to the page, bind the role data to the datalist
           //     if (Page.IsPostBack == false)
           //     {
           //         cmdDelete.Attributes.Add("onClick", "javascript:return confirm('" + Localization.GetString("DeleteItem") + "');");

           //         if(ItemId != -1)
           //         {
           //             //get content
           //             BanckleLiveChatModuleController objBanckleLiveChatModules = new BanckleLiveChatModuleController();
           //             BanckleLiveChatModuleInfo objBanckleLiveChatModule = objBanckleLiveChatModules.GetBanckleLiveChatModule(ModuleId,ItemId);
           //             if (objBanckleLiveChatModule != null)
           //             {
           //                 txtContent.Text = objBanckleLiveChatModule.Content;
           //                 ctlAudit.CreatedByUser = objBanckleLiveChatModule.CreatedByUser.ToString();
           //                 ctlAudit.CreatedDate = objBanckleLiveChatModule.CreatedDate.ToString();
           //             }
           //             else
           //             {
           //                 Response.Redirect(Globals.NavigateURL(), true);
           //             }
           //         }
           //         else
           //         {
           //             cmdDelete.Visible = false;
           //             ctlAudit.Visible = false;
           //         }
           //     }
           //}
           // catch (Exception exc) //Module failed to load
           // {
           //     Exceptions.ProcessModuleLoadException(this, exc);
           // }
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// cmdCancel_Click runs when the cancel button is clicked
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <history>
        /// </history>
        /// -----------------------------------------------------------------------------
        //protected void cmdCancel_Click(System.Object sender, System.EventArgs e)
        //{
        //    try
        //    {
        //        this.Response.Redirect(Globals.NavigateURL(this.TabId), true);
        //    }
        //    catch (Exception exc) //Module failed to load
        //    {
        //        Exceptions.ProcessModuleLoadException(this, exc);
        //    }
        //}

        ///// -----------------------------------------------------------------------------
        ///// <summary>
        ///// cmdDelete_Click runs when the delete button is clicked
        ///// </summary>
        ///// <remarks>
        ///// </remarks>
        ///// <history>
        ///// </history>
        ///// -----------------------------------------------------------------------------
        //protected void cmdDelete_Click(System.Object sender, System.EventArgs e)
        //{
        //    try
        //    {
        //        //Only attempt to delete the item if it exists already
        //        if (!Null.IsNull(ItemId))
        //        {
        //            BanckleLiveChatModuleController objBanckleLiveChatModules = new BanckleLiveChatModuleController();
        //            objBanckleLiveChatModules.DeleteBanckleLiveChatModule(ModuleId,ItemId);
 
        //            //refresh cache
        //            SynchronizeModule();
        //        }

        //        this.Response.Redirect(Globals.NavigateURL(this.TabId), true);
        //    }
        //    catch (Exception exc) //Module failed to load
        //    {
        //        Exceptions.ProcessModuleLoadException(this, exc);
        //    }
        //}

        ///// -----------------------------------------------------------------------------
        ///// <summary>
        ///// cmdUpdate_Click runs when the update button is clicked
        ///// </summary>
        ///// <remarks>
        ///// </remarks>
        ///// <history>
        ///// </history>
        ///// -----------------------------------------------------------------------------
        //protected void cmdUpdate_Click(System.Object sender, System.EventArgs e)
        //{
        //    try
        //    {
        //        BanckleLiveChatModuleController objBanckleLiveChatModules = new BanckleLiveChatModuleController();
        //        BanckleLiveChatModuleInfo objBanckleLiveChatModule = new BanckleLiveChatModuleInfo();

        //        objBanckleLiveChatModule.ModuleId = ModuleId;
        //        objBanckleLiveChatModule.ItemId = ItemId;
        //        objBanckleLiveChatModule.Content = txtContent.Text;
        //        objBanckleLiveChatModule.CreatedByUser = this.UserId;

        //        //Update the content within the BanckleLiveChatModule table
        //        if(Null.IsNull(ItemId))
        //        {
        //            objBanckleLiveChatModules.AddBanckleLiveChatModule(objBanckleLiveChatModule);
        //        }
        //        else
        //        {
        //            objBanckleLiveChatModules.UpdateBanckleLiveChatModule(objBanckleLiveChatModule);
        //        }

        //        //refresh cache
        //        SynchronizeModule();

        //        //Redirect back to the portal home page
        //        this.Response.Redirect(Globals.NavigateURL(this.TabId), true);
        //     }
        //    catch (Exception exc) //Module failed to load
        //    {
        //        Exceptions.ProcessModuleLoadException(this, exc);
        //    }
        //}

    #endregion

    }
}

