<%@ Page Language="C#" MasterPageFile="~/Toplevel.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content2" ContentPlaceHolderID="pageContent" Runat="Server">
    <table style="width:30%;">
        <tr>
            <td class="style1" style="width: 120px">
                &nbsp;Enter Name :</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1" style="width: 120px">
                &nbsp;Enter Add :</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1" style="width: 120px">
                &nbsp;Enter City :</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1" style="width: 120px">
                &nbsp;Enter State :</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="style1" colspan="2">
                <asp:Button ID="btnSend" runat="server" Text="Send" PostBackUrl="~/Default2.aspx" />
            </td>
        </tr>
    </table>
</asp:Content>

