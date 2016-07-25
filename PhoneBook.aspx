<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PhoneBook.aspx.cs" Inherits="PhoneBook" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 21%;
        }
        .auto-style2 {
            width: 116px;
        }
        .auto-style4 {
            width: 112px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        <h1>Phone Book</h1>

        <p>Add an entry to the phone book:</p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Last name:</td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">First name:</td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Phone number:</td>
                <td>
                    <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Button ID="btnAddEntry" runat="server" Text="Add Phone Book Entry" Width="273px" OnClick="btnAddEntry_Click" />
        
        <p>
            Locate entries in the phone book:

        </p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">Last name:</td>
                <td>
                    <asp:TextBox ID="txtFindLastName" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Button ID="btnFind" runat="server" Text="Find Entries by Last Name" Width="269px" OnClick="btnFind_Click"/>

        <p>
            Results:<br />
        
            <asp:TextBox ID="txtResult" runat="server" Height="150px" TextMode="MultiLine" Width="344px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
