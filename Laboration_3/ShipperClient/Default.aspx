<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShipperClient.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
            <input id="shipperCode"/>
            <br/>
            <button id="getShipperButton">Get Shipper</button>
            <br/>
            <label>EDIT SHIPPER DATA</label>
            <label for="shipperID">Shipper Id:</label>
            <br/>
            <input id="shipperID"></input>
            <br/>      
             <label for="companyName">Company name:</label>
            <br/>
            <input id="companyName"></input>
            <br/>
            <label for="phone">Phone:</label>
            <br/>
            <input id="phone"/>
            <br/>
            <button id="save">Save</button>
        </div>
    </form>
</body>
</html>
