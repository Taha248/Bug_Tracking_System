<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="AssignDeveloper.aspx.cs" Inherits="WebApplication8.AssignDeveloper" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div style="margin-left: 160px">
        <div style="height:30px;">

        </div> 
         
            <asp:Label ID="Label3" runat="server" Font-Size="32px" Text="Assing Developer " CssClass="heading" style="margin-bottom:26px;margin-left:40px;"></asp:Label>
            <br />
            <div style="width:100%;">
        <asp:Table runat="server" Width="316px">
        <asp:TableRow  class="cellHeight">
        <asp:TableCell >
        
            <asp:Label ID="Label2" runat="server" Text="BugId:   " ></asp:Label>
        </asp:TableCell>
        
        <asp:TableCell>
        
            <asp:Label ID="bugId" runat="server" Text="Label" style="margin-left:10px;"> </asp:Label>
        </asp:TableCell>
        </asp:TableRow >
                <asp:TableRow class="cellHeight">
        <asp:TableCell>
         <asp:Label ID="Label1" runat="server" Text="Developers"></asp:Label>
        </asp:TableCell>
        
        <asp:TableCell>
              <asp:ListBox ID="ListBox1" runat="server" Height="176px" Width="248px" style="margin-left:10px;"></asp:ListBox>
     
        </asp:TableCell>

        </asp:TableRow>
               <asp:TableRow  class="cellHeight">
        <asp:TableCell>

        </asp:TableCell>
        
        <asp:TableCell>
          <asp:Button ID="Button1" runat="server" Text="Assign" class="btn btn-success" OnClick="Button1_Click" />
        </asp:TableCell>

        </asp:TableRow>
        </asp:Table>

        
            
    
   
        </div>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </p>

        </div>
            
</asp:Content>
