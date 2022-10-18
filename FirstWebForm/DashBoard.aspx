<%@Page MasterPageFile="~/Site.Master"  Language="C#" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="FirstWebForm.DashBoard" %>

<asp:Content ContentPlaceHolderID="Pages" runat="server">
    <form id="form1" runat="server">
        <div style="font-size: large; font-weight: bold; font-style: italic; background-image: url('Images/bg2.jpg');">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="NAME" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="View Cookie data" />
            <br />
            <br />
            <br />
            Databound Items from Session<br />
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
            <br />
            <br />
            <br />
            Manually Added Items<br />
            <asp:ListBox ID="ListBox2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox2_SelectedIndexChanged">
                <asp:ListItem Value="1001">Item 1</asp:ListItem>
                <asp:ListItem Value="1002">Item 2</asp:ListItem>
                <asp:ListItem Value="1003">Item 3</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Selected Value ="></asp:Label>
            <hr />
            <br />
            Working&nbsp; with ViewState and GridView<br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="View Data" />
            <br />
            <br />
        </div>
    </form>
</asp:Content>
