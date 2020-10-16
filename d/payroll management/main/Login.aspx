<%@ Page Title="" Language="C#" MasterPageFile="~/main/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="main_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<form id="form1">
    <table style="width: 100%">
        <tr>
            <td style="width: 518px; height: 37px">
                &nbsp;</td>
            <td style="height: 37px" colspan="2">
                &nbsp;</td>
            <td style="height: 37px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 518px; height: 37px">
                &nbsp;</td>
            <td style="height: 37px" colspan="2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="font-weight: bold; font-style: italic; color: #3399FF; font-size: x-large"><span 
                    
                    style="font-family: 'Times New Roman', Times, serif; font-size: xx-large; color: #339966;">Login</span></span></td>
            <td style="height: 37px">
                </td>
        </tr>
        <tr>
            <td style="width: 518px; " rowspan="9">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Image ID="Image1" runat="server" Height="255px" 
                    ImageUrl="~/images/intranet-login-logo-300.png" Width="267px" />
            </td>
            <td style="height: 27px" colspan="2">
                &nbsp;</td>
            <td style="height: 27px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 136px; height: 27px">
                Select type</td>
            <td style="height: 27px">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>--select--</asp:ListItem>
                     <asp:ListItem>Admin</asp:ListItem>
                    <asp:ListItem>Employee</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="DropDownList1" ErrorMessage="Select Type of Login" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td style="height: 27px">
                </td>
        </tr>
        <tr>
            <td style="width: 136px; height: 30px">
            </td>
            <td style="height: 30px">
            </td>
            <td style="height: 30px">
                </td>
        </tr>
        <tr>
            <td style="width: 136px; height: 35px;">
                <asp:Label ID="Label1" runat="server" Text="User EmaiId"></asp:Label>
            </td>
            <td style="height: 35px">
                <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="Enter proper user mailid" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td style="height: 35px">
                </td>
        </tr>
        <tr>
            <td style="width: 136px; height: 32px;">
            </td>
            <td style="height: 32px">
            </td>
            <td style="height: 32px">
                </td>
        </tr>
        <tr>
            <td style="width: 136px">
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
              
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="TextBox2" ErrorMessage="Enter correct password" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 136px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Text="LOGIN" onclick="Button1_Click" 
                    Height="35px" Width="82px" />
                &nbsp;
                <asp:Button ID="Button2" runat="server" Height="35px" onclick="Button2_Click" 
                    Text="CANCEL" Width="72px" />
                </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 136px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;</td>
            <td style="color: #0000FF">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <a href="forget Password.aspx" style="color: #339966">Forget password?</a></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 518px">
                &nbsp;</td>
            <td style="width: 136px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 518px">
                &nbsp;</td>
            <td style="width: 136px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr> 
    </table>
    </form>
</asp:Content>

