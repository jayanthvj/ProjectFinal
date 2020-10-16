<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Payslip Genrate.aspx.cs" Inherits="Admin_Payslip_Genrate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form id="form1" runat="server">
<table style="width: 100%">
    <tr>
        <td style="width: 35%">
            &nbsp;</td>
        <td colspan="2" 
            
            style="font-family: Algerian; font-size: x-large; font-style: italic; color: #339966; text-align: center">
            SALARY DETAILS&nbsp;</td>
        <td style="width: 38%">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 35%">
            &nbsp;</td>
        <td style="width: 14%">
            &nbsp;</td>
        <td style="width: 128px">
            &nbsp;</td>
        <td style="width: 38%">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 35%" rowspan="13">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" Height="224px" 
                ImageUrl="~/images/600673276.jpg" Width="361px" />
            &nbsp;</td>
        <td style="width: 14%">
            Email</td>
        <td style="width: 128px">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td style="width: 38%">
            <asp:Button ID="Button1" runat="server" Height="28px" onclick="Button1_Click" 
                Text="SEARCH" Width="67px" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="TextBox1" ErrorMessage="enter proper email" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 14%">
            Designation</td>
        <td style="width: 128px">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td style="width: 38%">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 14%">
            Username</td>
        <td style="width: 128px">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
        <td style="width: 38%">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 14%">
            password</td>
        <td style="width: 128px">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
        <td style="width: 38%">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 14%">
            FatherName</td>
        <td style="width: 128px">
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
        <td style="width: 38%">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 14%">
            DOB</td>
        <td style="width: 128px">
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </td>
        <td style="width: 38%">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 14%">
            Address</td>
        <td style="width: 128px">
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </td>
        <td style="width: 38%">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 14%">
            MobileNo</td>
        <td style="width: 128px">
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </td>
        <td style="width: 38%">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 14%">
            Name</td>
        <td style="width: 128px">
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        </td>
        <td style="width: 38%">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 14%">
            Basic Salary</td>
        <td style="width: 128px">
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        </td>
        <td style="width: 38%">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 14%">
            DOJ</td>
        <td style="width: 128px">
            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        </td>
        <td style="width: 38%">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 14%">
            &nbsp;</td>
        <td style="width: 128px">
            &nbsp;</td>
        <td style="width: 38%">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="text-align: center;" colspan="2">
            <asp:Button ID="Button2" runat="server" Height="29px" onclick="Button2_Click" 
                Text="SUBMIT" Width="77px" />
&nbsp;<asp:Button ID="Button3" runat="server" Height="29px" Text="CANCEL" Width="64px" />
        </td>
        <td style="width: 38%; text-align: center;">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 35%">
            &nbsp;</td>
        <td style="width: 14%">
            &nbsp;</td>
        <td style="width: 128px">
            &nbsp;</td>
        <td style="width: 38%">
            &nbsp;</td>
    </tr>
</table>
</form>

</asp:Content>

