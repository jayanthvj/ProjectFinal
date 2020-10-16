<%@ Page Title="" Language="C#" MasterPageFile="~/employee/MasterPage.master" AutoEventWireup="true" CodeFile="changepassword.aspx.cs" Inherits="employee_changepassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<form id="form1" runat="server">
<div>
<table class="style1">
        <tr>
            <td style="width: 438px">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </td>
            <td style="width: 208px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 438px">
                &nbsp;</td>
            <td colspan="2" 
                
                style="font-family: Algerian; font-style: italic; font-size: x-large; color: #339966; text-align: center">
                &nbsp;&nbsp;
                Change Password</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 438px" rowspan="8">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Image ID="Image1" runat="server" Height="100px" 
                    ImageUrl="~/images/change-your-password-written-yellow-notepad-thumbtack-white-background-43577003.jpg" 
                    Width="274px" />
                &nbsp;</td>
            <td style="width: 208px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 208px">
                <asp:Label ID="Label2" runat="server" Text="OldPassword:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" ForeColor="Black"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 208px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 208px; height: 2px;">
                <asp:Label ID="Label3" runat="server" Text="New Password:"></asp:Label>
            </td>
            <td style="height: 2px">
                <asp:TextBox ID="TextBox2" runat="server" ForeColor="Black"></asp:TextBox>
            </td>
            <td style="height: 2px">
                </td>
        </tr>
        <tr>
            <td style="width: 208px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 208px">
                <asp:Label ID="Label4" runat="server" Text="Conform Password:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" ForeColor="Black"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="TextBox2" ControlToValidate="TextBox3" 
                    ErrorMessage="Enter Matched Password" ForeColor="Red"></asp:CompareValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 208px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 208px">
                &nbsp;</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Text="Change" onclick="Button1_Click" 
                    ForeColor="Black" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 438px">
                &nbsp;</td>
            <td style="width: 208px">
                &nbsp;</td>
            <td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</div>
    </form>
</asp:Content>

