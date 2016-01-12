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
        <asp:TextBox ID="inputX" runat="server"></asp:TextBox>
        +<asp:TextBox ID="inputY" runat="server"></asp:TextBox>
        <asp:Label ID="AddTwoNumbersLabelResult" runat="server"></asp:Label>
        <asp:Button ID="AddTwoNumbersResult_button" runat="server" OnClick="AddTwoNumbersResult_button_Click" Text="Give me the result" />
    </div>
    </form>
</body>
</html>
