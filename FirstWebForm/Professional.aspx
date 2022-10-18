<%@ Page MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Professional.aspx.cs" Inherits="FirstWebForm.Professional" %>

<asp:Content ContentPlaceHolderID="Pages" runat="server">

    <h2>This is a content page</h2>
    <hr />
    <form runat="server">


    <h3>Databinding with Database</h3>
        <p>Add new Employee</p>
        <p>
            <asp:TextBox ID="txtName" runat="server" Width="190px" placeholder="Enter your Name"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Employee Name is Mandatory" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:TextBox ID="txtDesignation" runat="server" Width="187px" placeholder="Enter your Designation"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtSalary" runat="server" Width="186px" TextMode="Number" placeholder="Enter your Salary"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtSalary" ErrorMessage="Invalid Range" Font-Size="Small" ForeColor="Red" MaximumValue="2500" MinimumValue="350" SetFocusOnError="True"></asp:RangeValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSalary" ErrorMessage="Salary cannot be Empty" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Employee" />
        </p>
        <p>
        </p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <p>
            &nbsp;</p>


    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmpId" DataSourceID="SqlDataSource1" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="EmpId" HeaderText="EmpId" InsertVisible="False" ReadOnly="True" SortExpression="EmpId" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Designation" HeaderText="Designation" SortExpression="Designation" />
            <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>


    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KpmgDbConnectionString %>" 
        SelectCommand="SELECT * FROM [Employees]"
        DeleteCommand="DELETE FROM [Employees] WHERE [EmpId] = @EmpId"
        InsertCommand="INSERT INTO [Employees] ([Name], [Designation], [Salary]) VALUES (@Name, @Designation, @Salary)" 
        UpdateCommand="UPDATE [Employees] SET [Name] = @Name, [Designation] = @Designation, [Salary] = @Salary WHERE [EmpId] = @EmpId">
        <DeleteParameters>
            <asp:Parameter Name="EmpId" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Designation" Type="String" />
            <asp:Parameter Name="Salary" Type="Double" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Designation" Type="String" />
            <asp:Parameter Name="Salary" Type="Double" />
            <asp:Parameter Name="EmpId" Type="Int32" />
        </UpdateParameters>
        </asp:SqlDataSource>

        </form>
</asp:Content>
