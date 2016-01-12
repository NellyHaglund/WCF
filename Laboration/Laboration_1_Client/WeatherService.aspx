<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeatherService.aspx.cs" Inherits="Laboration_1_Client.WeatherService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="#1"></asp:Label>
        <asp:Button ID="generateWeather" runat="server" Text="Show me the weather for tomorrow" OnClick="generateWeather_Click" />
        <asp:Label ID="weatherResult" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="#2"></asp:Label>
        What numbers do you want to add?
        <asp:TextBox ID="inputX_2" runat="server"></asp:TextBox>
        +<asp:TextBox ID="inputY_2" runat="server"></asp:TextBox>
        =<asp:Label ID="AddTwoNumbersLabelResult" runat="server"></asp:Label>
        <asp:Button ID="AddTwoNumbersResult_button" runat="server" OnClick="AddTwoNumbersResult_button_Click" Text="Give me the result" />
        <br />
        #3What numbers do you want to add?
        <asp:TextBox ID="inputX_3" runat="server"></asp:TextBox>
        +<asp:TextBox ID="inputY_3" runat="server"></asp:TextBox>
        +<asp:TextBox ID="inputZ_3" runat="server"></asp:TextBox>
        =<asp:Label ID="AddThreeNumbersLabelResult" runat="server"></asp:Label>
        <asp:Button ID="AddThreeNumbersButton" runat="server" OnClick="AddThreeNumbersButton_Click" Text="Give me the result" />
        <br />
        #4What numbers do you want to subtract?
        <asp:TextBox ID="inputX_4" runat="server"></asp:TextBox>
        -<asp:TextBox ID="inputY_4" runat="server"></asp:TextBox>
        =<asp:Label ID="SubtractTwoNumbersResult" runat="server"></asp:Label>
        <asp:Button ID="SubtractTwoNumbersButton" runat="server" Text="Give me the result" />
    </div>
    </form>
</body>
</html>
