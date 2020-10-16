<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="DesignationSalaries.aspx.cs" Inherits="Admin_DesignationSalaries" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <form id="form1" runat="server">
    <table style="width: 100%">
        <tr>
            <td rowspan="21" style="width: 420px">
                &nbsp;&nbsp;&nbsp;
                <asp:Image ID="Image1" runat="server" Height="298px" 
                    ImageUrl="~/images/hqdefault.jpg" Width="310px" />
            </td>
            <td class="section_w430" colspan="2" 
                
                style="font-family: Algerian; font-size: x-large; font-style: italic; color: #339966; text-align: center">
                Salary Calculation</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="section_w430" style="width: 175px">
                &nbsp;</td>
            <td style="width: 205px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="section_w430" style="width: 175px">
                Name</td>
            <td style="width: 205px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="section_w430" style="width: 175px">
                Designation</td>
            <td style="width: 205px">
                <a href="#" class="last">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="section_w430" style="width: 175px">
                BasicSalary</td>
            <td style="width: 205px">
                <a href="#" class="last">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="section_w430" style="width: 175px">
                SalaryPerDay</td>
            <td style="width: 205px">
                <a href="#" class="last">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="section_w430" style="width: 175px">
                HRA</td>
            <td style="width: 205px">
                <a href="#" class="last">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="section_w430" style="width: 175px">
                DA</td>
            <td style="width: 205px">
                <a href="#" class="last">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="section_w430" style="width: 175px">
                TA</td>
            <td style="width: 205px">
                <a href="#" class="last">
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="section_w430" style="width: 175px">
                MA</td>
            <td style="width: 205px">
                <a href="#" class="last">
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="section_w430" style="width: 175px">
                Month</td>
            <td style="width: 205px">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>--Select--</asp:ListItem>
                    <asp:ListItem>January</asp:ListItem>
                    <asp:ListItem>febrauary</asp:ListItem>
                    <asp:ListItem>March</asp:ListItem>
                    <asp:ListItem>April</asp:ListItem>
                    <asp:ListItem>May</asp:ListItem>
                    <asp:ListItem>June</asp:ListItem>
                    <asp:ListItem>July</asp:ListItem>
                    <asp:ListItem>August</asp:ListItem>
                    <asp:ListItem>September</asp:ListItem>
                    <asp:ListItem>October</asp:ListItem>
                    <asp:ListItem>November</asp:ListItem>
                    <asp:ListItem>December</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="DropDownList1" ErrorMessage="Select Month" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="section_w430" style="width: 175px">
                Year</td>
            <td style="width: 205px">
                <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox16" ErrorMessage="Enter Year" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="section_w430" style="width: 175px">
                ProffesionalFund*</td>
            <td style="width: 205px">
                <a href="#" class="last">
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="section_w430" style="width: 175px">
                FoodAllowance*</td>
            <td style="width: 205px">
                <a href="#" class="last">
                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="section_w430" style="width: 175px">
                NoOfLeaves*</td>
            <td style="width: 205px">
                <a href="#" class="last">
                <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="TextBox12" ErrorMessage="Enter NoOfLeaves" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="section_w430" style="width: 175px">
                Earnings</td>
            <td style="width: 205px">
                <a href="#" class="last">
                <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="section_w430" style="width: 175px">
                Deductions</td>
            <td style="width: 205px">
                <a href="#" class="last">
                <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="section_w430" style="width: 175px">
                NetSalary</td>
            <td style="width: 205px">
                <a href="#" class="last">
                <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="section_w430" style="width: 175px">
                &nbsp;</td>
            <td style="width: 205px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="section_w430" colspan="2" style="text-align: center">
                <asp:Button ID="Button1" runat="server" Height="33px" onclick="Button1_Click" 
                    Text="CALCULATE" Width="90px" />
&nbsp;
                <asp:Button ID="Button2" runat="server" Height="33px" Text="CANCEL" 
                    Width="71px" onclick="Button2_Click" />
            </td>
            <td style="text-align: center">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="section_w430" style="width: 175px">
                &nbsp;</td>
            <td style="width: 205px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>
</asp:Content>

