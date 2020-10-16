<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="view Payslips.aspx.cs" Inherits="Admin_Payslips" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form id="form1" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="width: 128px">
                &nbsp;</td>
            <td style="font-family: Algerian; font-size: x-large; font-style: italic; color: #FF00FF; text-align: center; width: 1077px;">
                VIEW PAYSLIPS</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 128px">
                &nbsp;</td>
            <td style="width: 1077px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 128px">
                &nbsp;</td>
            <td style="width: 1077px">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="PaySlipId" DataSourceID="SqlDataSource1" Width="1066px">
                    <Columns>
                        <asp:BoundField DataField="PaySlipId" HeaderText="PaySlipId" 
                            InsertVisible="False" ReadOnly="True" SortExpression="PaySlipId" />
                        <asp:BoundField DataField="EmpName" HeaderText="EmpName" 
                            SortExpression="EmpName" />
                        <asp:BoundField DataField="Designation" HeaderText="Designation" 
                            SortExpression="Designation" />
                        <asp:BoundField DataField="Month" HeaderText="Month" SortExpression="Month" />
                        <asp:BoundField DataField="Year" HeaderText="Year" SortExpression="Year" />
                        <asp:BoundField DataField="NoOfWorkingDays" HeaderText="NoOfWorkingDays" 
                            SortExpression="NoOfWorkingDays" />
                        <asp:BoundField DataField="GeneratedDate" HeaderText="GeneratedDate" 
                            SortExpression="GeneratedDate" />
                        <asp:BoundField DataField="BasicSalary" HeaderText="BasicSalary" 
                            SortExpression="BasicSalary" />
                        <asp:BoundField DataField="SalaryPerDay" HeaderText="SalaryPerDay" 
                            SortExpression="SalaryPerDay" />
                        <asp:BoundField DataField="Earnings" HeaderText="Earnings" 
                            SortExpression="Earnings" />
                        <asp:BoundField DataField="NoOfLeaves" HeaderText="NoOfLeaves" 
                            SortExpression="NoOfLeaves" />
                        <asp:BoundField DataField="Deductions" HeaderText="Deductions" 
                            SortExpression="Deductions" />
                        <asp:BoundField DataField="NetSalary" HeaderText="NetSalary" 
                            SortExpression="NetSalary" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:PayrollConnectionString %>" 
                    SelectCommand="SELECT * FROM [payslip] ORDER BY [EmpName], [NoOfLeaves], [NetSalary]">
                </asp:SqlDataSource>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 128px">
                &nbsp;</td>
            <td style="width: 1077px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>

</asp:Content>

