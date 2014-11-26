<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Register</title>
</head>
<body>

    <% using (Html.BeginForm("HandleRegister", "MachLeo", FormMethod.Post))
       { %>

    <table border="0">
        <tr>
            <td>Username</td>
            <td><%= Html.TextBox("username") %></td>
        </tr>
        <tr>
            <td>Password</td>
            <td><%= Html.Password("password") %></td>
        </tr>
        <tr>
            <td>Ho ten</td>
            <td><%= Html.TextBox("fullname") %></td>
        </tr>
        <tr>
            <td>Email</td>
            <td><%= Html.TextBox("email") %></td>
        </tr>
        <tr>
            <td>Dien thoai</td>
            <td><%= Html.TextBox("dienthoai") %></td>
        </tr>
        <tr>
            <td>Cong ty</td>
            <td><%= Html.TextBox("congty") %></td>
        </tr>
        <tr>
            <td>Dia chi</td>
            <td><%= Html.TextBox("diachi") %></td>
        </tr>
        <tr>
            <td colspan="2">
                <input type="submit" value="Register" />
            </td>
        </tr>
    </table>

    <% } %>
</body>
</html>
