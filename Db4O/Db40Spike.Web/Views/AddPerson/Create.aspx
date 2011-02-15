<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Db40Spike.Web.Models.CreatePersonViewModel>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
                                                
            <div class="editor-label">
                <%: Html.LabelFor(model => model.first_name) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.first_name) %>
                <%: Html.ValidationMessageFor(model => model.first_name) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.last_name) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.last_name) %>
                <%: Html.ValidationMessageFor(model => model.last_name) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>
</body>
</html>
