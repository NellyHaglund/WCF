<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShipperClient.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/Default.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="header">
            <h1>WCF labb 3 EC-Utbildning AB</h1>
            <span>Register Log in</span>
            <span id="naviagation">Home About Contact</span>
        </div>
        <div id="form">
            <h2>EDIT SHIPPER INFORMATION</h2>
            <label for="shipperCode">Enter Shipper Code:</label>
            <br/>
            &nbsp;<asp:TextBox ID="TextBoxShipperCode" runat="server"></asp:TextBox>
            <br/>
            <asp:Button ID="getShipperButton" runat="server" Text="Get Shipper" OnClick="getShipperButton_Click" />
            <br/>
            <label>EDIT SHIPPER DATA</label>
            <label for="shipperID">Shipper Id:</label>
            <br/>
            </input>
            &nbsp;<asp:TextBox ID="TextBoxShipperId" runat="server"></asp:TextBox>
            <br/>      
             <label for="companyName">Company name:</label>
            <br/>
            </input>
            &nbsp;<asp:TextBox ID="TextBoxCompanyName" runat="server"></asp:TextBox>
            <br/>
            <label for="phone">Phone:</label>
            <br/>
            &nbsp;<asp:TextBox ID="TextBoxPhone" runat="server" OnTextChanged="TextBoxPhone_TextChanged"></asp:TextBox>
            <br/>
            <button id="save"></button>
            <asp:Button ID="ButtonSave" runat="server" Text="Save" />
        </div>
    </form>
</body>
</html>
