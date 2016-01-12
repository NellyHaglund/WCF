<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeatherService.aspx.cs" Inherits="Laboration_1_Client.WeatherService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="generateWeather" runat="server" Text="Show me the weather for tomorrow" OnClick="generateWeather_Click" />
        <asp:Label ID="weatherResult" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
