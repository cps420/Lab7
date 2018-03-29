<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="Lab7AspNetDisplay.Books" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblBooks" runat="server">No books to show right now.</asp:Label>
            <asp:Button ID="btnPopulateBooks" runat="server" Text="Get Books" OnClick="btnPopulateBooks_Click" />
            <br />
            <asp:Button ID="btnJoin" runat="server" Text="Join Books and Sales Data" OnClick="btnJoin_Click"></asp:Button>
            <br />
            <asp:Label ID="lblJoin" runat="server"></asp:Label>
            <br />
            <asp:GridView ID="lstBooks" runat="server"></asp:GridView>
            <br />
            <asp:ListView ID="lstRealBooks" runat="server">
                <ItemTemplate>
                    <p runat="server">
                        <asp:Label ID="NameLabel" runat="server" 
                                    Text='<%#Eval("Title") %>' />
                    </p>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </form>
</body>
</html>
