<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="WebApplication8.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div style="height:80px;">

  </div>
  <div>
    
        
    
        <asp:Table ID="Table1" runat="server" Width="100%" style="margin-left:20%;" CellPadding="20" CellSpacing="20">


            <asp:TableRow>
        <asp:TableCell>
        
        </asp:TableCell>
        <asp:TableCell>
         <asp:Label ID="Label1" runat="server" Text="User Profile" Style="font-size:32px;font-family:'Times New Roman';"></asp:Label>
  
        </asp:TableCell>
        
        </asp:TableRow>

        <asp:TableRow>
        <asp:TableCell>
        
<asp:label runat="server" text="Name"></asp:label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:textbox runat="server" ID="Name"></asp:textbox>

        </asp:TableCell>
        
        </asp:TableRow>
        
           <asp:TableRow>
        <asp:TableCell>
        
<asp:label runat="server" text="Date Of Birth"></asp:label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:textbox runat="server" ID="DOB"></asp:textbox>

        </asp:TableCell>
        
        </asp:TableRow>

         <asp:TableRow>
        <asp:TableCell>
        
<asp:label runat="server" text="Status"></asp:label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:textbox runat="server" ID="Role"></asp:textbox>

        </asp:TableCell>
        
        </asp:TableRow>







           <asp:TableRow>
        <asp:TableCell>
        
<asp:label runat="server" text="UserName"></asp:label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:textbox runat="server" ID="Username"></asp:textbox>

        </asp:TableCell>
        
        </asp:TableRow>

                   <asp:TableRow>
        <asp:TableCell>
        
<asp:label runat="server" text="Email"></asp:label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:textbox runat="server" ID="Email"></asp:textbox>

        </asp:TableCell>
        
        </asp:TableRow>




           <asp:TableRow>
        <asp:TableCell>
        
<asp:label runat="server" text="Password"></asp:label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:textbox runat="server" ID="Password" textMode="Password" style="margin-top:10px;" ></asp:textbox>
                       <asp:Button runat="server" ID="Change" class="btn btn-warning" Text="Change" OnClick="Change_Click" Height="33px" Width="91px" />
  
    
               
        </asp:TableCell>
        
        </asp:TableRow>


             <asp:TableRow>

        <asp:TableCell>
        
        </asp:TableCell>
        <asp:TableCell>
              <asp:Button ID="Button1" runat="server"  class="btn btn-default" Text="Back" OnClick="Button1_Click" /> &nbsp
                <asp:Button runat="server" ID="btnUpdate" Text="Update" class="btn btn-success" OnClick="btnUpdate_Click"  />
     
        </asp:TableCell>
        
        </asp:TableRow>

        </asp:Table>
    
    </div>
         <p>
             &nbsp;</p>
</asp:Content>
