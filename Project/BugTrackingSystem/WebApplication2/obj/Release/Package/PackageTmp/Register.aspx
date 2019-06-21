<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication8.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div style="height:50px;">

</div>
<asp:Label ID="Label5" runat="server" Text="Registration Form" Width="100%" style="text-align:center;font-size:32px;font-family:'Times New Roman';" ></asp:Label>
      <div style="height:20px;">

</div>   
            <asp:Table ID="Table1" runat="server" Height="355px" Width="80%" style="margin-left:20%;">
        <asp:TableRow>
        <asp:TableCell>
        <asp:Label ID="Label1" runat="server" Text="Name">

        </asp:Label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:TextBox ID="Name" runat="server"></asp:TextBox>
      
        </asp:TableCell>
                </asp:TableRow>
        
        <asp:TableRow>
        <asp:TableCell>
        
        <asp:Label ID="Label2" runat="server" Text="DOB"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
              <asp:TextBox ID="Dob" runat="server"></asp:TextBox>
  
        </asp:TableCell>
        
        </asp:TableRow>
        
        <asp:TableRow>
        <asp:TableCell>
        
        <asp:Label ID="Label3" runat="server" Text="UserName"></asp:Label>
        </asp:TableCell>

        <asp:TableCell>
        
              <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
        </asp:TableCell>
        
        </asp:TableRow>
        
        <asp:TableRow>
         <asp:TableCell>
         
        <asp:Label ID="Label4" runat="server" Text="Password"   ></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
        
              <asp:TextBox ID="Password"   TextMode="Password" runat="server"></asp:TextBox>
        </asp:TableCell>
       
        </asp:TableRow>
        
           <asp:TableRow>
         <asp:TableCell>
         
        <asp:Label ID="Label6" runat="server" Text="Email"   ></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
        
              <asp:TextBox ID="Email"    runat="server"></asp:TextBox> <br /> 
             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
         ErrorMessage="your Error message" ControlToValidate="Email"
         Display="Dynamic" ForeColor="#FF3300" SetFocusOnError="True"
         ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </asp:TableCell>
       
        </asp:TableRow>
        
        <asp:TableRow>
         <asp:TableCell>
         
        </asp:TableCell>
        <asp:TableCell>
        <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click1" class="btn btn-success" />
        </asp:TableCell>
       
        </asp:TableRow>


        </asp:Table>
    <asp:label runat="server" ID="lbl" text="Label"></asp:label>
</asp:Content>
