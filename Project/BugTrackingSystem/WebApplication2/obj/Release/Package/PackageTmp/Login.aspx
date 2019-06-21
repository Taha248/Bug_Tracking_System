<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication8.Login" Culture="en-US" UICulture="auto:en-US" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="scripts/jquery-1.10.2.min.js"></script>
    <script src="scripts/JavaScript.js"></script>
            <div id="ok">
                 <br />
                 &nbsp; &nbsp;
               
            <strong>
               
            <asp:Label ID="output" runat="server" Text="Select Theme" BackColor="Red" ForeColor="White"></asp:Label> 
                 </strong>&nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <strong>
                <asp:Label ID="Label5" runat="server" Text="Select Language" BackColor="Red" ForeColor="White"></asp:Label>

                 </strong>

            </div>
            <br/>
              <div style="height:20px;">
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged" >
                      <asp:ListItem Value="Theme1">Theme1</asp:ListItem>
                      <asp:ListItem Value="Theme2">Theme2</asp:ListItem>
                      <asp:ListItem>Theme3</asp:ListItem>
                  </asp:DropDownList>
                 &nbsp; &nbsp; &nbsp;   &nbsp; &nbsp; &nbsp;  &nbsp; &nbsp;
         &nbsp;<asp:DropDownList class="DropDownList15" ID="DropDownList15" runat="server" AutoPostBack="True" >
            <asp:ListItem Value="en-US">English</asp:ListItem>
            <asp:ListItem Value="ur">Urdu</asp:ListItem>
        </asp:DropDownList>

         </div>
    <div style="text-align:center;">  
        <asp:Label ID="Label4" runat="server" Text="Login System" Font-Size="32px" Height="54px" Width="100%" style="font-family:'Times New Roman';"></asp:Label>
         <div style="height:20px;">

         </div>
              <asp:Table ID="Table1" runat="server" Width="80%" style="margin-left:15%" >
    
                <asp:TableRow>
                    
                 
                    
                    <asp:TableCell Style="width: 30%;">

                        <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
                    </asp:TableCell>
                       <asp:TableCell Style="width: 30%; " >
                           
                        <asp:TextBox ID="userName" runat="server" class="form-group" style="width:91%;"></asp:TextBox>
                          
                    </asp:TableCell>
                    <asp:TableCell style="text-align:left;">
                        

                    </asp:TableCell>
                    <asp:TableCell>
        
                    </asp:TableCell>
                </asp:TableRow>



                <asp:TableRow style="margin-top:2px;">
                    <asp:TableCell>

                        <asp:Label ID="Label2" runat="server" Text="Password" ></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>

                        <asp:TextBox ID="password" runat="server" class="form-group" TextMode="Password" style="width:91%;"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                    <asp:TableRow>
                    <asp:TableCell>

                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList runat="server" OnSelectedIndexChanged="Unnamed1_SelectedIndexChanged" ID="Select" style="width:75%;" >
                            <asp:ListItem>User</asp:ListItem>
                            <asp:ListItem>Admin</asp:ListItem>
                            <asp:ListItem>Developer</asp:ListItem>
                            <asp:ListItem>Tester</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                       
                    </asp:TableCell>
                    
                    <asp:TableCell>
                        <br />
            <a href="Register.aspx" id="anchor" style="color:black;">Dont Have Account? Register Now</a>
                    </asp:TableCell>
                </asp:TableRow>


                <asp:TableRow>
                    <asp:TableCell>

                    </asp:TableCell>
                    <asp:TableCell>
                        <br />
                        <asp:Button ID="BtnLogin" runat="server" Height="32px" OnClick="Button1_Click" class="btn btn-success" Text="Login" Width="63px" />
                    </asp:TableCell>
                </asp:TableRow>

            </asp:Table>
            <asp:Label ID="Label3" runat="server"></asp:Label>
   </div>

</asp:Content>
