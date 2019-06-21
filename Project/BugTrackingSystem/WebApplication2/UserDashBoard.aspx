<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="UserDashBoard.aspx.cs" Inherits="WebApplication8.UserDashBoard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <meta name="viewport" content="width=device-width, initial-scale=1"/>

     <div style="padding-top:10px">
    
  
     <div style="display:inline;
width:21%;
float:left;
margin-right:14px;
margin-top:10px;
padding-right:0px;
padding-left:10px;"  class="col-xs-12" >
      <asp:Button ID="Button1" runat="server" class="btn btn-warning" Height="38px" OnClick="NewReport_Click" Text="Add New Report" Width="100%" style="margin-top:10px;"/>   </br>
   <asp:Button ID="Button2" runat="server"  class="btn btn-warning" Height="38px" OnClick="Button2_Click" Text="Edit Report" Width="100%"  style="margin-top:10px;"/> </br>
      <asp:Button ID="Button3" class="btn btn-warning"  runat="server" Height="38px" OnClick="Button3_Click" Text="Edit Your Profile" Width="100%" style="margin-top:10px;" /> 
      <asp:Button ID="Button7"  class="btn btn-warning" runat="server" Height="38px" OnClick="Button4_Click" Text="View Report" Width="100%" style="margin-top:10px;" /> 
      <asp:Button ID="Button4" class="btn btn-warning"  runat="server" Height="38px" OnClick="LogOut_Click" Text="LogOut" Width="100%" style="margin-top:10px;" /> 
      </div>

        <div style="width:73%;height:200px;  "  class="col-xs-12">
           <asp:Label ID="NoBugReport" runat="server" Text="You Have'nt Post Any Bug Report" Visible="False" Font-Bold="True" Font-Size="30px"></asp:Label>
       <div style="width:135%;margin-bottom:10px;" >
        <div style="text-align:center; height: 37px;margin-top:6px;">
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                <asp:ListItem Selected="True">Submitted</asp:ListItem>
                <asp:ListItem>Solved</asp:ListItem>
            </asp:DropDownList>
<asp:Label ID="Label2" runat="server" Text="Search" Style="margin-right:10px;padding-top:10px;margin-bottom:30px;"></asp:Label>
    <asp:TextBox ID="SearchBox" runat="server"></asp:TextBox>
        <asp:Button ID="Button5" runat="server" Text="Search" OnClick="Search_Click" />
        <asp:Button ID="Button6" runat="server" Text="Reload" OnClick="Button5_Click" />
        
        </div>
        <div style="width:100%;" class="col-xs-12">
        <asp:GridView ID="GridView1" runat="server" Width="69%" CellPadding="4" ForeColor="#333333" Height="108px" AutoGenerateSelectButton="True" HorizontalAlign="Left" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="text-align:center;">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" HorizontalAlign="Center" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" HorizontalAlign="Center" />
        </asp:GridView>
           </div>
        </div>
    </div>
    </div>
          <br />
</asp:Content>
