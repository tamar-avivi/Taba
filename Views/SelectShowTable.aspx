  <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectShowTable.aspx.cs" Inherits="Taba.Views.SelectShowTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <meta charset="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <title></title>
        <meta name="description" content="" />
        <meta name="viewport" content="width=device-width, innitial-scale=1" />
        <style>
            table {
                border: 1px solid black; 
                margin: 100px auto; 
                border-collapse: collapse;
            }

            th, td {
                border: 1px solid black; 
                text-align: center; 
                border-collapse: collapse;
            }

        </style>
    </head>
<body>
    <h1>user table</h1>
    <table>
            <%= st %>
    </table>

         <h3><%= msg %></h3>
    
</body>

</html>
