<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Electronic_Store.aspx.cs" Inherits="ASP_Assignment2.Electronic_Store" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Select one Item :<br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" Height="59px" ValidationGroup="vg" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="91px">
                

            </asp:DropDownList>
            <br />
            <asp:Image ID="Image1" runat="server" Height="458px" style="margin-right: 448px" Width="365px" />
        </div>

        <p>
            Cost of selected Item: <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="vg" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <asp:Button ID="submit" runat="server" OnClick="Button1_Click" Text="submit" Width="121px" />

    </form>
</body>
</html>
