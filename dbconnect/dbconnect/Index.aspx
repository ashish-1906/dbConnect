<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="dbconnect.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>webpage</title>
    <style>
        #GridView1 {
            height:300px;
            width:500px;
            text-align:center;
            font-size:16px;
            

        }
        body {
            background-color:#d1cf7f;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center><h2 style="color:green">Employee Details</h2></center><br />
            <center><asp:GridView ID="GridView1" runat="server"></asp:GridView></center>
        <br />
       <center> <h2 style="color:green">Enter Data</h2><br />
        <label>Name : </label> <input type="text" runat="server" name="Name" placeholder="Enter" id="Name"/><br /><br />
        <label>Email : </label> <input type="text"  runat="server" name="Email"  placeholder="Enter" id="Email" /><br /><br />
        <label>Salary : </label> <input type="text"  runat="server" name="Salary"  placeholder="Enter" id="Salary"/><br /><br />
        <label>Dept : &nbsp</label> <input type="text"  runat="server" name="Department"  placeholder="Enter" id="Department"/><br /><br /><br />
        <asp:Button ID="Insert" runat="server" Text="Insert" OnClick="Button_Insert" />&nbsp; &nbsp; 
        <asp:Button ID="Update" runat="server" Text="Update" OnClick="Button_Update" />&nbsp; &nbsp; 
        <asp:Button ID="Delete" runat="server" Text="Delete" OnClick="Button_Delete" />&nbsp; 
        </center>
    </div>
    </form>
</body>
</html>
