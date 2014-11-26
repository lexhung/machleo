<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Login</title>
</head>
<body>

    <% using (Html.BeginForm("HandleLogin", "MachLeo", FormMethod.Post))
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
            <td colspan="2">
                <input type="submit" value="Login" />
            </td>
        </tr>
    </table>

    <% } %>
</body>
</html>
