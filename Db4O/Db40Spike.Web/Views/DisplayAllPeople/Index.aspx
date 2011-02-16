<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<System.Collections.Generic.IEnumerable<Db40Spike.Domain.Person>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1><%:TempData["Message"] %></h1>
    <p>
    All my people right here, right now...
    </p>
    <ul>    
    <% foreach(var person in Model) { %>        
        <li><%:person.ToString() %> <%:Html.ActionLink("Edit?", "Edit", "EditPerson", new { id = person.id }, null)%></li>
    <%  }%>
    </ul>

    <%:Html.ActionLink("Add a Person", "Create", "AddPerson")%>
</body>
</html>
