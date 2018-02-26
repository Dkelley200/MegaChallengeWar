<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MegaChallengeWar.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <h4>
              &nbsp;</h4>
        <h3>
              -<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#0000CC" Text="It's Time to Play War!"></asp:Label>
        </h3>
      
       <div>
            <asp:Button  ID="playgameButton" runat="server"  OnClick="playgameButton_Click1" Text="Play Game" />
        </div>
        
        <p >
            <asp:Label ID="resultLabel" runat="server" ></asp:Label>
        </p>
    </form>
</body>
</html>
