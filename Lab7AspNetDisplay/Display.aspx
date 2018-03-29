<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="Lab7AspNetDisplay.Display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="grdStudents" runat="server"></asp:GridView>
        </div>
        <div>
            <asp:Button ID="btnAll" runat="server" Text="All Students" OnClick="btnAll_Click" />
            <asp:Button ID="btnHighAvgs" runat="server" Text="Students with average > 90%." OnClick="btnHighAvgs_Click" />
            <asp:Button ID="btnLowAvg" runat="server" Text="Students with average < 90%." OnClick="btnLowAvg_Click" />
            <asp:Button ID="btnPerfects" runat="server" Text="Students who scored 100 on a test." OnClick="btnPerfects_Click" />
        </div>
    </form>
</body>
</html>
