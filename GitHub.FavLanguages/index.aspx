<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="GitHub.FavLanguages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="text-align: center;">
            </div>
            <div class="container-fluid">
                <div class="row">
                    <div class="col-md-4">
                    </div>
                    <div class="col-md-4 div-border">
                        <div>
                            <img class="img-margin" id="githublogo" src="Images/github.jfif">
                        </div>
                        <div class="row">
                        </div>
                        <div class="form-group">
                            <label>Github Username</label>
                            <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Username Required" ForeColor="Red" ControlToValidate="txtUsername"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            &nbsp;<asp:Button ID="Button1" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="Validateuser" />
                        </div>
                        <br />
                        <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
                    <div class="col-md-4">
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
