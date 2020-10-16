<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Payslips.aspx.cs" Inherits="Admin_Payslips" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<form id="form1" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="width: 412px" rowspan="16">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;<asp:Image ID="Image1" runat="server" Height="220px" 
                    ImageUrl="~/images/600673276.jpg" Width="287px" />
                </td>
            <td colspan="2" 
                style="font-family: Algerian; font-size: x-large; font-style: italic; color: #FF00FF; text-align: center">
                PAYSLIPS GENERATE</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 173px">
                &nbsp;</td>
            <td style="width: 25px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="color: #000000; width: 173px">
                Employee Name</td>
            <td style="width: 25px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="color: #000000; width: 173px">
                Designation</td>
            <td style="width: 25px">
                <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="color: #000000; width: 173px">
                Month</td>
            <td style="width: 25px">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <a href="#" class="last">
            <td style="color: #333333; width: 173px">
                Year</td>
            <a href="#" class="last" style="text-decoration: none">
            <td style="width: 25px">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <a href="#" class="last">
            <td style="color: #333333; width: 173px">
                NoOfWorkingDays</td>
            <td style="width: 25px">
                <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True">31</asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <a href="#" class="last">
            <td style="color: #333333; width: 173px">
                BasicSalary</td>
            <td style="width: 25px">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <a href="#" class="last">
            <td style="color: #333333; width: 173px">
                SalaryPerDay</td>
            <td style="width: 25px">
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <a href="#" class="last">
            <td style="color: #333333; width: 173px">
                Earnings</td>
            <td style="width: 25px">
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <a href="#" class="last">
            <td style="color: #333333; width: 173px">
                NoOfLeaves</td>
            <td style="width: 25px">
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <a href="#" class="last">
            <td style="color: #333333; width: 173px">
                Deductions</td>
            <td style="width: 25px">
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <a href="#" class="last">
            <td style="color: #333333; width: 173px">
                NetSalary</td>
            <td style="width: 25px">
                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="color: #333333; width: 173px">
                &nbsp;</td>
            <td style="width: 25px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" style="color: #333333; text-align: center">
                <asp:Button ID="Button1" runat="server" Height="30px" Text="SUBMIT" 
                    Width="87px" onclick="Button1_Click" />
&nbsp;
                <asp:Button ID="Button2" runat="server" Height="29px" Text="CANCEL" 
                    Width="76px" onclick="Button2_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="color: #333333; width: 173px">
                &nbsp;</td>
            <td style="width: 25px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</a>
    </form>
</asp:Content>

