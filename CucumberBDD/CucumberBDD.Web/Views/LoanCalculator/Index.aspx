<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<CucumberBDD.Web.Models.LoanRepaymentQueryViewModel>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title><%:Model.Title %></title>
</head>
<body>
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.RepaymentTerm) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.RepaymentTerm) %>                
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.LoanAmount) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.LoanAmount, String.Format("{0:F}", Model.LoanAmount)) %>                
            </div>

            <div class="editor-label">
                <%: Html.LabelFor(model => model.InterestRate) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.InterestRate, String.Format("{0:F}", Model.LoanAmount))%>                
            </div>
                                                  
            <div class="editor-label">
                <%: Html.LabelFor(model => model.MonthlyRepaymentAmount) %>
            </div>
            <div id="MonthlyRepaymentAmount" class="editor-field"><%: Model.MonthlyRepaymentAmount%></div>
                        
            <p>
                <input type="submit" id="bCalcRepayments" value="Calculate Repayments" />
            </p>
        </fieldset>

    <% } %>   
</body>
</html>

