<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <%= Html.ActionLink("Register", "register", "machleo") %>
    <%= Html.ActionLink("Login", "login", "machleo") %>


</body>
</html>
