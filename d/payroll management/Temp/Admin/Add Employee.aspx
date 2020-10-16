<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Add Employee.aspx.cs" Inherits="Admin_Add_Employee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <form id="form1" runat="server">
 <table style="width: 100%">
        <tr>
            <td rowspan="15" style="width: 443px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Image ID="Image1" runat="server" Height="293px" 
                    ImageUrl="~/images/images (6).jpg" Width="365px" />
                &nbsp;</td>
            <td colspan="2" 
                style="font-family: Algerian; font-size: x-large; font-style: italic; color: #00FFFF; text-align: center">
                ADD Employee</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 28px; width: 146px">
                &nbsp;</td>
            <td style="height: 28px; width: 42px">
                &nbsp;</td>
            <td style="height: 28px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 28px; width: 146px">
                Name</td>
            <td style="height: 28px; width: 42px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td style="height: 28px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="Enter name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 146px">
                Designation</td>
            <td style="width: 42px">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="TextBox2" ErrorMessage="Enter Designation" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 146px">
                Username</td>
            <td style="width: 42px">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="TextBox3" ErrorMessage="Enter username" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 146px">
                Password</td>
            <td style="width: 42px">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                    ControlToValidate="TextBox4" ErrorMessage="Enter password" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 146px">
                FatherName</td>
            <td style="width: 42px">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 146px">
                DOB</td>
            <td style="width: 42px">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 146px; height: 28px">
                Address</td>
            <td style="height: 28px; width: 42px">
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
            <td style="height: 28px">
            </td>
        </tr>
        <tr>
            <td style="width: 146px">
                MobileNo</td>
            <td style="width: 42px">
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="TextBox8" ErrorMessage="Enter Correct No" ForeColor="Red" 
                    ValidationExpression="^([7-9]{1})([0-9]{9})"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 146px">
                Email</td>
            <td style="width: 42px">
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox9" ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="TextBox9" ErrorMessage="Enter Proper Email" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 146px">
                BasicSalary</td>
            <td style="width: 42px">
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                    ControlToValidate="TextBox10" ErrorMessage="Enter Basicsalary" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 146px">
                DOJ</td>
            <td style="width: 42px">
                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 146px; height: 28px">
            </td>
            <td style="height: 28px; width: 42px">
            </td>
            <td style="height: 28px">
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Add Employee" Height="38px" Width="104px" />
                <a href="#" class="last">
                <asp:Button ID="Button2" runat="server" style="margin-left: 16px" Text="Cancel" 
                    Width="71px" onclick="Button2_Click" Height="38px" />
            </td>
            <td style="text-align: center">
                &nbsp;</td>
        </tr>
    </table>

</form>

</asp:Content>

