<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="AddAccount.aspx.cs" Inherits="WebApplication8.AddAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div>
    <div style="height:50px;">

    </div>
        <asp:Table ID="Table1" runat="server" style="margin-left:15%;" Width="80%" >
    <asp:TableRow>
    <asp:TableCell>

    </asp:TableCell>
    <asp:TableCell>    
     <asp:Label ID="Label6" runat="server" Text="Add Account" Font-Size="32px" style="font-family:'Times New Roman';"></asp:Label>
  
    </asp:TableCell>
    </asp:TableRow>
        <asp:TableRow class="cellHeightHead">
        <asp:TableCell>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:TextBox runat="server" ID="Name"></asp:TextBox>
        </asp:TableCell>
        </asp:TableRow>
            

             <asp:TableRow class="cellHeight">
  <asp:TableCell>
            <asp:Label ID="Label2" runat="server" Text="DOB"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:TextBox runat="server" ID="Dob"></asp:TextBox>
        </asp:TableCell>
        </asp:TableRow>

             <asp:TableRow  class="cellHeight">
      <asp:TableCell>
            <asp:Label ID="Label3" runat="server"  Text="Email"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:TextBox runat="server" ID="Email"></asp:TextBox>
          
        </asp:TableCell>
        </asp:TableRow>

             <asp:TableRow  class="cellHeight">
     <asp:TableCell>
            <asp:Label ID="Label4" runat="server" Text="UserName"></asp:Label>
        </asp:TableCell>
        <asp:TableCell> 
        <asp:TextBox runat="server" ID="Username"></asp:TextBox>
        </asp:TableCell>
        </asp:TableRow>

             <asp:TableRow  class="cellHeight"> 
     <asp:TableCell>
            <asp:Label ID="Label5" runat="server"  Text="Password"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:TextBox runat="server" ID="Password" TextMode="Password"></asp:TextBox>
        </asp:TableCell>
        </asp:TableRow>
          <asp:TableRow>
     <asp:TableCell >
         <asp:Label ID="Label7" runat="server" Text="Role"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:DropDownList ID="Role" runat="server">
         <asp:ListItem>user</asp:ListItem>
         <asp:ListItem>admin</asp:ListItem>
         <asp:ListItem>developer</asp:ListItem>
         <asp:ListItem>tester</asp:ListItem>
     </asp:DropDownList>
        </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow  class="cellHeight">
     <asp:TableCell>
        </asp:TableCell>
        <asp:TableCell>      
       <asp:Button runat="server" Text="Add" OnClick="AddAccount_Click" class="btn btn-success"/>
        </asp:TableCell>
        </asp:TableRow>


        </asp:Table>
    
    </div>
         <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
</asp:Content>
