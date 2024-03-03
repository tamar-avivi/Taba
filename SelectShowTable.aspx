<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectShowTable.aspx.cs" Inherits="Taba.Views.SelectShowTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>



            <%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master"
            AutoEventWireup="true" CodeFile="selectShowTable.aspx.cs"
            Inherits="selectShowTable" %>

            <asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
            </asp:Content>
            <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1"
            Runat="Server">
                <H1> users table</H1>
                <h2><%=sqlSelect %></h2>

                <table style ="  border: 1px solid black; margin: 0px auto;">

                    <%= st %>

                </table>
                
                <h3><%=mag%></h3>
            </asp:Content>

        </div>
    </form>
</body>
</html>
