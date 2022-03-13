<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="ASP_Assignment.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 57%;
        }
        .auto-style3 {
            width: 236px;
        }
        .auto-style6 {
            width: 192px;
        }
        .auto-style7 {
            width: 78px;
        }
        .auto-style8 {
            width: 192px;
            height: 26px;
        }
        .auto-style9 {
            width: 78px;
            height: 26px;
        }
        .auto-style10 {
            width: 236px;
            height: 26px;
        }
        .auto-style11 {
            width: 192px;
            height: 42px;
        }
        .auto-style12 {
            width: 78px;
            height: 42px;
        }
        .auto-style13 {
            width: 236px;
            height: 42px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style6">Name:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="name" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name" ErrorMessage="RequiredField" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">family Name:</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="Fname" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Fname" ControlToValidate="name" ErrorMessage="Differs from name" ForeColor="Red" Operator="NotEqual"></asp:CompareValidator>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Fname" ErrorMessage="Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Address:</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="address" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="address" ErrorMessage="Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="address" ErrorMessage="atleast 2 character" ForeColor="Red" MaximumValue="40" MinimumValue="2"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">City:</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="city" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="city" ErrorMessage="atleast 2 character" ForeColor="Red" MaximumValue="25" MinimumValue="2"></asp:RangeValidator>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="city" ErrorMessage="Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Zip Code:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="zipcode" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="zipcode" ErrorMessage="Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="zipcode" ErrorMessage="Zip Code 5 digits" ForeColor="Red" MaximumValue="5" MinimumValue="5"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">Phone:</td>
                    <td class="auto-style12">
                        <asp:TextBox ID="phno" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style13">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="phno" ErrorMessage="Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="phno" ErrorMessage="Phone number of 10 digits" ForeColor="Red" MaximumValue="10" MinimumValue="10"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">E-mail</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="email" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="email" ErrorMessage="Email is required " ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" ErrorMessage="Enter Valid Email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
            </table>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Check" Width="110px" />
    </form>
</body>
</html>
