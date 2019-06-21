<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="SubmitSolveReport.aspx.cs" Inherits="WebApplication8.SubmitSolveReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<asp:Table runat="server" Height="266px" Width="100%">
<asp:TableRow>
<asp:TableCell>
    <asp:Label ID="Label1" runat="server" Text="BugId"></asp:Label>

</asp:TableCell>

<asp:TableCell>
    <asp:TextBox ID="BugId" runat="server"></asp:TextBox>
</asp:TableCell>
</asp:TableRow>

<asp:TableRow>
<asp:TableCell>
    <asp:Label ID="Label4" runat="server" Text="ProjectUrl"></asp:Label>

</asp:TableCell>

<asp:TableCell>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
</asp:TableCell>
</asp:TableRow>


<asp:TableRow>
<asp:TableCell>
    <asp:Label ID="Label3" runat="server" Text="Comment"></asp:Label>

</asp:TableCell>

<asp:TableCell>
<asp:TextBox ID="TextBox3" runat="server" Height="59px" Rows="3" TextMode="MultiLine" Width="174px"></asp:TextBox>
</asp:TableCell>
</asp:TableRow>

<asp:TableRow>
<asp:TableCell>
 
</asp:TableCell>

<asp:TableCell>
    
<asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click"/>
</asp:TableCell>
</asp:TableRow>
</asp:Table>
    
</asp:Content>
