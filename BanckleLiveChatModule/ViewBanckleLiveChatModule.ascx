<%@ Control language="C#" Inherits="Philip.Modules.BanckleLiveChatModule.ViewBanckleLiveChatModule" CodeFile="ViewBanckleLiveChatModule.ascx.cs" AutoEventWireup="true"%>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<meta http-equiv="refresh" content="600">
 <script type="text/javascript">
     function CallMe(src, url) {
         window.location = url;
     } 
  </script>
<style type="text/css">
    .style1
    {
        height: 23px;
    }
    .style2
    {
        height: 26px;
    }
    .style3
    {
        height: 23px;
        }
    
    h1{
	padding:0px;
	margin:0px;
	font:bold 14px/18px Arial, Helvetica, sans-serif;
	color:#333;
	text-shadow: 1px 1px 1px #fff;
	filter: dropshadow(color=#fff, offx=1, offy=); 
	}
	
	.top-bg{
	padding:5px;
	height:20px;
	background: #eaf4fe; /* Old browsers */
	background: -moz-linear-gradient(top,  #eaf4fe 0%, #86c0fb 100%); /* FF3.6+ */
	background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,#eaf4fe), color-stop(100%,#86c0fb)); /* Chrome,Safari4+ */
	background: -webkit-linear-gradient(top,  #eaf4fe 0%,#86c0fb 100%); /* Chrome10+,Safari5.1+ */
	background: -o-linear-gradient(top,  #eaf4fe 0%,#86c0fb 100%); /* Opera 11.10+ */
	background: -ms-linear-gradient(top,  #eaf4fe 0%,#86c0fb 100%); /* IE10+ */
	background: linear-gradient(top,  #eaf4fe 0%,#86c0fb 100%); /* W3C */
	filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#eaf4fe', endColorstr='#86c0fb',GradientType=0 ); /* IE6-9 */
	border:1px solid #86c0fb;
	}
	
	.content-area{
	background: #ffffff; /* Old browsers */
	background: -moz-linear-gradient(top,  #ffffff 0%, #f2f2f2 100%); /* FF3.6+ */
	background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,#ffffff), color-stop(100%,#f2f2f2)); /* Chrome,Safari4+ */
	background: -webkit-linear-gradient(top,  #ffffff 0%,#f2f2f2 100%); /* Chrome10+,Safari5.1+ */
	background: -o-linear-gradient(top,  #ffffff 0%,#f2f2f2 100%); /* Opera 11.10+ */
	background: -ms-linear-gradient(top,  #ffffff 0%,#f2f2f2 100%); /* IE10+ */
	background: linear-gradient(top,  #ffffff 0%,#f2f2f2 100%); /* W3C */
	filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#ffffff', endColorstr='#f2f2f2',GradientType=0 ); /* IE6-9 */
	border:1px solid #cccccc;
	-webkit-box-shadow: inset 0px 0px 4px 4px rgba(255, 255, 255, 1);
	box-shadow: inset 0px 0px 4px 4px rgba(255, 255, 255, 1); 
	font:12px/18px Arial, Helvetica, sans-serif;
	}
	
	.default-textarea{
	background:#fff;
	border:1px solid #ccc;
	font:12px/18px Arial, Helvetica, sans-serif;
	width:60%;
		 }
	
	
	.default-select{
	background:#fff;
	border:1px solid #ccc;
	font:12px/18px Arial, Helvetica, sans-serif;

	height:20px;
	margin-left:10px;
	}
	
	.default-input{
	background:#fff;
	border:1px solid #ccc;
	font:12px/18px Arial, Helvetica, sans-serif;
	padding:3px;
	height:20px;
	margin-left:10px;
	}
	
	.default-input:focus{
	background:fff;
	border:1px solid #ccc;
	font:12px/18px Arial, Helvetica, sans-serif;
	padding:3px;
	height:20px;
	 -webkit-box-shadow:  0px 0px 2px 2px rgba(85, 159, 223, 0.2);
	 box-shadow:  0px 0px 2px 2px rgba(85, 159, 223, 0.2);
	}
	
	.button-primary{
		 
		 -webkit-border-radius: 5px;
		-moz-border-radius: 5px;
		border-radius: 5px;
		cursor:pointer;
		color:#fff;
		background-image: linear-gradient(bottom, rgb(0,111,162) 35%, rgb(51,161,212) 94%);
		background-image: -o-linear-gradient(bottom, rgb(0,111,162) 35%, rgb(51,161,212) 94%);
		background-image: -moz-linear-gradient(bottom, rgb(0,111,162) 35%, rgb(51,161,212) 94%);
		background-image: -webkit-linear-gradient(bottom, rgb(0,111,162) 35%, rgb(51,161,212) 94%);
		background-image: -ms-linear-gradient(bottom, rgb(0,111,162) 35%, rgb(51,161,212) 94%);
		background-image: -webkit-gradient(	linear,	left bottom, left top,
											color-stop(0.35, rgb(0,111,162)),
											color-stop(0.94, rgb(51,161,212)));

		
		font:12px/18px Arial, Helvetica, sans-serif;
		color:#FFFFFF;
		height:30px;
		border:none;
		text-align:center;
		 }
		 
		 
		.button-primary a{
		 
		 -webkit-border-radius: 5px;
		-moz-border-radius: 5px;
		border-radius: 5px;
		cursor:pointer;
		color:#fff;
		font:12px arial;
		padding:2px;
		font-weight:bold;
		text-align:center;
		background-image: linear-gradient(bottom, rgb(0,111,162) 35%, rgb(51,161,212) 94%);
		background-image: -o-linear-gradient(bottom, rgb(0,111,162) 35%, rgb(51,161,212) 94%);
		background-image: -moz-linear-gradient(bottom, rgb(0,111,162) 35%, rgb(51,161,212) 94%);
		background-image: -webkit-linear-gradient(bottom, rgb(0,111,162) 35%, rgb(51,161,212) 94%);
		background-image: -ms-linear-gradient(bottom, rgb(0,111,162) 35%, rgb(51,161,212) 94%);
		background-image: -webkit-gradient(	linear,	left bottom, left top,
											color-stop(0.35, rgb(0,111,162)),
											color-stop(0.94, rgb(51,161,212)));


		text-decoration:none;
		height:30px;
		border:none;
		text-align:center;
		 } 
		 
		.button-primary-cancle{
		 display:block;
		 -webkit-border-radius: 5px;
		-moz-border-radius: 5px;
		border-radius: 5px;
		cursor:pointer;
		color:#fff;
		background-image: linear-gradient(bottom, rgb(0,111,162) 35%, rgb(51,161,212) 94%);
		background-image: -o-linear-gradient(bottom, rgb(0,111,162) 35%, rgb(51,161,212) 94%);
		background-image: -moz-linear-gradient(bottom, rgb(0,111,162) 35%, rgb(51,161,212) 94%);
		background-image: -webkit-linear-gradient(bottom, rgb(0,111,162) 35%, rgb(51,161,212) 94%);
		background-image: -ms-linear-gradient(bottom, rgb(0,111,162) 35%, rgb(51,161,212) 94%);
		background-image: -webkit-gradient(	linear,	left bottom, left top,
											color-stop(0.35, rgb(0,111,162)),
											color-stop(0.94, rgb(51,161,212)));

		-webkit-box-shadow: inset 1px 1px 1px 1px rgba(255, 255, 255, 0.8);
		-moz-box-shadow: inset 1px 1px 1px 1px rgba(255, 255, 255, 0.8);
		box-shadow: inset 1px 1px 1px 1px rgba(255, 255, 255, 0.4); 
		border:1px solid #ffffff;
		width:150px;
		 }
		 
		 .bottom-content{
		 background:#e9e9e9;
		 height:30px;
		 text-align:center;
		 font:11px/18px Arial, Helvetica, sans-serif;
		 color:#333333;		
		 }
		 
		 .bottom-content a{
		 color:#0c4784;
		 text-decoration:none;	
		 }
		 
		 .bottom-content a:hover{
		 color:#0c4784;
		 text-decoration:underline;	
		 }
        u{
            cursor:pointer;
        }
    
</style>
<asp:Panel ID="PanelIframe" runat="server" Visible="False">

    <asp:Label ID="lblMsg" runat="server" Text="Banckle Live Chat is disabled, Please go to the <font color=blue><u>page</u></font> to enable it."   ></asp:Label>

    &nbsp;<asp:Button ID="btnLoggedInSetting" runat="server" Font-Names="Arial" 
        Font-Size="10px" Height="19px" onclick="btnLoggedInSetting_Click" 
        Text="Setting" Visible="False" class="button-primary" />

  <div align="center">
            <iframe title="BLC Dashboard" src="https://apps.banckle.com/livechat/" 
                    style="height: 800px; width: 912px"></iframe>
            </div>
</asp:Panel>
<asp:Panel ID="PanelSignIn" runat="server" Visible="False">
    <table style="width:58%;" align="center" bgcolor="#F7F7F7" class="content-area">
        <tr>
            <td bgcolor="#99CCFF" colspan="2" class="top-bg">
                SignIn</td>
        </tr>
        <tr>
            <td class="style1" align="center" colspan="2">
                <asp:Label ID="lblWrongPass" runat="server" Font-Bold="True" Font-Names="Arial" 
                    Font-Size="10px" ForeColor="Red" 
                    Text="Wrong LoginID or Password Please try again!" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style1">
                Banckle Login-ID</td>
            <td class="style1">
                <asp:TextBox ID="txtLogin" runat="server" class="default-input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Password</td>
            <td class="style2">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" class="default-input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="btnContinue" runat="server" Text="Continue" 
                    onclick="btnContinue_Click" class="button-primary" />
            </td>
        </tr>
        <tr>
            <td align="center" class="bottom-content" colspan="2">
                Don&#39;t have Banckle Account? Please <a href="http://banckle.com/action/signup" target="_blank">Signup</a></td>
        </tr>
    </table>

</asp:Panel>
<asp:Panel ID="PanelDeployment" runat="server" Visible="False">
    <table align="center" bgcolor="#F7F7F7" 
    style="width:58%;" class="content-area">
        <tr>
            <td bgcolor="#99CCFF" colspan="2" class="top-bg">
                Deployment</td>
        </tr>
        <tr>
            <td class="style3">
                Select Deployment</td>
            <td class="style1">
                <asp:DropDownList ID="ddlDeployment" runat="server" class="default-select">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="btnActivate" runat="server" 
                Text="Activate live chat" onclick="btnActivate_Click" class="button-primary" />
            </td>
        </tr>
    </table>
</asp:Panel>
<asp:Panel ID="PanelDeactivation" runat="server" Visible="False">
    <table align="center" bgcolor="#F7F7F7" 
    style="width:58%;" class="content-area">
        <tr>
            <td bgcolor="#99CCFF" colspan="2" class="top-bg">
                Deactivation</td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Button ID="btnDeactivate" runat="server" Text="Deactivate live chat" 
                    onclick="btnDeactivate_Click" class="button-primary" />
            </td>
            <td class="style1">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" colspan="2" style="text-align: left">
                &nbsp;</td>
        </tr>
    </table>
</asp:Panel>
<asp:Panel ID="PanelActivated" runat="server" Visible="False">
    <table align="center" bgcolor="#F7F7F7" 
    style="width:58%;" class="content-area">
        <tr>
            <td bgcolor="#99CCFF" colspan="2" class="top-bg">
                Status</td>
            <td bgcolor="#99CCFF" colspan="2" style="text-align: center">
                <asp:Button ID="btnSetting" runat="server" Font-Names="Arial" Font-Size="10px" 
                    Height="19px" onclick="btnSetting_Click" Text="Setting" class="button-primary" />
            </td>
        </tr>
        <tr>
            <td class="style3" style="padding-top:10px; padding-left:10px;">
                Activated Successfully! </td>
            <td class="style3" colspan="2">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style3" colspan="2">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3" colspan="4" style="padding-top:10px; padding-left:10px;">
                Please use the following deployment code in the footer of your web portal.</td>
        </tr>
        <tr>
            <td align="center" colspan="4" style="text-align: left" bgcolor="#FFCCFF" style="padding-top:5px; padding-left:10px;">
                <asp:TextBox ID="txtContent" runat="server" Height="116px" 
                    style="margin-left: 0px" TextMode="MultiLine" Width="598px" class="default-textarea"></asp:TextBox>
            </td>
        </tr>
    </table>
</asp:Panel>

<asp:Panel ID="PanelDeactivateCode" runat="server" Visible="False">
    <table align="center" bgcolor="#F7F7F7" 
    style="width:58%;" class="content-area">
        <tr>
            <td bgcolor="#99CCFF" class="top-bg">
                Code</td>
            <td bgcolor="#99CCFF" style="text-align: center">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3" colspan="2" style="padding-top:10px; padding-left:10px;">
                <asp:Button ID="btnDeactivate0" runat="server" onclick="btnDeactivate_Click" 
                    Text="Deactivate live chat" class="button-primary" />
            </td>
        </tr>
        <tr>
            <td class="style3" colspan="2" style="padding-top:5px; padding-left:10px;"> 
                Generated Code Please Copy it and Paste it to the footer of your web portal</td>
        </tr>
        <tr>
            <td align="center" bgcolor="#FFCCFF" colspan="2" style="padding-top:5px; padding-left:10px;">
                <asp:TextBox ID="txtOldContent" runat="server" Height="116px" 
                    style="margin-left: 0px" TextMode="MultiLine" Width="598px"></asp:TextBox>
            </td>
        </tr>
    </table>
</asp:Panel>

