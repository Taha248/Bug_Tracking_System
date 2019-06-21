<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="ReassignDeveloper.aspx.cs" Inherits="WebApplication8.ReassignDeveloper" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div style="margin-left: 130px">
        <div style="height:30px;">

        </div> 
         
            <asp:Label ID="Label3" runat="server" Font-Size="32px" Text="Reassing Developer " CssClass="heading" style="margin-bottom:26px;text-align:center;margin-left:40px;" Width="100%"></asp:Label>
            <br />
            <div style="width:100%;">
                <div style="height:60px;">
                </div>
                <asp:Table ID="Table1" runat="server" Height="328px" style="margin-left:44px;" Width="94%">
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
    <asp:Label ID="Label5" runat="server" Text="ProjectUrl"></asp:Label>

</asp:TableCell>
                        <asp:TableCell>
    <asp:TextBox ID="ProjectFiles" runat="server"></asp:TextBox>
</asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
    <asp:Label ID="Label6" runat="server" Text="Comment"></asp:Label>

</asp:TableCell>
                        <asp:TableCell>
<asp:TextBox ID="Comment" runat="server" Height="59px" Rows="3" TextMode="MultiLine" Width="80%"></asp:TextBox>
</asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
 
</asp:TableCell>
                        <asp:TableCell>
    
<asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" class="btn btn-success"/>
</asp:TableCell>
                    </asp:TableRow>
                </asp:Table>

        
            
    
   
        </div>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </p>

        </div>
</asp:Content>
