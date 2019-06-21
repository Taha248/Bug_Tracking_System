<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="TesterDashBoard.aspx.cs" Inherits="WebApplication8.TesterDashBoard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <div class="container">
         <div  style="width:20%;display:inline;
float:left;
margin-right:14px;
margin-top:10px;
padding-right:0px;
padding-left:10px;"  class="col-xs-12" >
    <br />
        <br />
        <asp:Button ID="Button1" runat="server"  Text="Submit Solved Report" Height="58px" Width="100%" OnClick="Button1_Click"  class="btn btn-warning"/>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Edit Profile" Height="58px"  Width="100%" OnClick="Button2_Click"  class="btn btn-warning"/>
        <br />
        <br />
      
             <asp:Button ID="Button4" runat="server" Text="View Report" Height="58px" Width="100%"   class="btn btn-warning" onClick="Button4_Click"/>
     <br />
             <br />
      <asp:Button ID="Button3" runat="server" Text="Reassign" Height="58px" Width="100%"  onclick="Button3_Click" class="btn btn-warning" />

            <br />
             <br />
      <asp:Button ID="Button5" runat="server" Text="LogOut" Height="58px" Width="100%"   class="btn btn-warning" onClick="Button5_Click"/>

    
    </div >
    <div style="height:50px;">

    </div>
    <div class="col-xs-12" style="width:50%;">
       <asp:GridView ID="GridView1" runat="server" Width="111%" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" CellSpacing="4" Height="198px" >
           <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" HorizontalAlign="Center" />
            <SortedDescendingHeaderStyle BackColor="#820000" HorizontalAlign="Center" />
       </asp:GridView>

       </div>

    </div>
   
</asp:Content>
