<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeatherService.aspx.cs" Inherits="Laboration_1_Client.WeatherService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Laboration 1 - ASMX services</h1>
            <hr />
            <h2>1.1 - Weather Rapport</h2>
            <asp:Button ID="generateWeather" runat="server" Text="Show me the weather for tomorrow" OnClick="generateWeather_Click" />
            <asp:Label ID="weatherResult" runat="server" Text=""></asp:Label>
            <br />
            <h2>1.2 - Add Two Numbers</h2>
            What numbers do you want to add?
        <asp:TextBox ID="inputX_2" runat="server"></asp:TextBox>
            +<asp:TextBox ID="inputY_2" runat="server"></asp:TextBox>
            =<asp:Label ID="AddTwoNumbersLabelResult" runat="server"></asp:Label>
            <asp:Button ID="AddTwoNumbersResult_button" runat="server" OnClick="AddTwoNumbersResult_button_Click" Text="Give me the result" />
            <br />
            <h2>1.3 - Add Three Numbers</h2>
            What numbers do you want to add?
        <asp:TextBox ID="inputX_3" runat="server"></asp:TextBox>
            +<asp:TextBox ID="inputY_3" runat="server"></asp:TextBox>
            +<asp:TextBox ID="inputZ_3" runat="server"></asp:TextBox>
            =<asp:Label ID="AddThreeNumbersLabelResult" runat="server"></asp:Label>
            <asp:Button ID="AddThreeNumbersButton" runat="server" OnClick="AddThreeNumbersButton_Click" Text="Give me the result" />
            <br />
            <h2>1.4 - Subtract Two Numbers</h2>
            What numbers do you want to subtract?
        <asp:TextBox ID="inputX_4" runat="server"></asp:TextBox>
            -<asp:TextBox ID="inputY_4" runat="server"></asp:TextBox>
            =<asp:Label ID="SubtractTwoNumbersResult" runat="server"></asp:Label>
            <asp:Button ID="SubtractTwoNumbersButton" runat="server" OnClick="SubtractTwoNumbersButton_Click" Text="Give me the result" />
            <br />
            <h2>1.5 - Name Day</h2>
            Enter name to find out which date that name has nameday: 
        <asp:TextBox ID="input_name" runat="server"></asp:TextBox>
            <asp:Label ID="nameDay_result" runat="server"></asp:Label>
            <asp:Button ID="nameDay_button" runat="server" Text="Give me the result" OnClick="nameDay_button_Click" />
            <br />
            <h2>1.6.1 - Mayors In Lund</h2>
            Enter a year to find our who was mayor in Lund back then: 
        <asp:TextBox ID="input_year" runat="server"></asp:TextBox>
            <asp:Label ID="mayor_result" runat="server"></asp:Label>
            <asp:Button ID="mayor_button" runat="server" Text="Give me the result" OnClick="mayor_button_Click" />
            <br />
            <h2>1.6.2 - Indias Vice President</h2>
            Enter a year to find our who was Vice President in India:
        <asp:TextBox ID="inputIndia_year" runat="server"></asp:TextBox>
            <asp:Label ID="india_result" runat="server"></asp:Label>
            <asp:Button ID="india_button" runat="server" Text="Give me the result" OnClick="india_button_Click" />
        </div>
    </form>
</body>
</html>
