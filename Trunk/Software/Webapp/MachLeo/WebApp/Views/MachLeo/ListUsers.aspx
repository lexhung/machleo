<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<%@ Import Namespace="DBAdapter.Models" %>
<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Danh sach tai khoan</title>
</head>
<body>

    <br />
    <br />
    <table border="1">
        <tr>
            <th>Username</th>
            <th>Ho Ten</th>
            <th>Email</th>
            
        </tr>
        <% foreach (User user in (List<User>)ViewData["listusers"])
           { %>
        <tr>
            <td><%= user.Username %></td>
            <td><%= user.Fullname %></td>
            <td><%= user.Email %></td>
            
            <td>
                <%= Html.ActionLink("Cap Nhat", "capnhat/" + user.Username, "machleo") %> | <%= Html.ActionLink("Xoa", "xoa/" + user.Username, "taikhoan", null, new { onclick = "return confirm('Are you sure?')" })%>
            </td>
        </tr>
        <% } %>
    </table>

</body>
</html>
