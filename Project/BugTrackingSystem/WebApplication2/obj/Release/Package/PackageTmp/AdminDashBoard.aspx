<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="AdminDashBoard.aspx.cs" Inherits="WebApplication8.AdminDashBoard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

 <div>
  
     <div style="display:inline;width:20%;float:left;margin-right:14px;margin-top:49px;"  class="dashBoardbtnDiv">
      <asp:Button ID="btnAddNewReport" runat="server" class="btn btn-warning dashBoardbtn" Height="58px" OnClick="NewReport_Click" Text="Add New Report" Width="100%" />   </br>
      <asp:Button ID="btnAddAccount" runat="server" class="btn btn-warning dashBoardbtn" Height="58px" OnClick="AddAccount_Click" Text="Add New Account" Width="100%" />   </br>
    
     <asp:Button ID="btnAssignReport" runat="server" class="btn btn-warning dashBoardbtn" Height="58px" OnClick="Assign_Click" Text="Assign Report" Width="100%" />   </br>
 
   <asp:Button ID="Button2" runat="server" class="btn btn-warning dashBoardbtn" Height="58px" OnClick="Button2_Click" Text="Edit Report" Width="100%" /> </br>
      <asp:Button ID="Button3" runat="server" class="btn btn-warning dashBoardbtn" Height="58px" OnClick="Button3_Click" Text="Edit Your Profile" Width="100%" /> 
      <asp:Button ID="Button4" runat="server" class="btn btn-warning dashBoardbtn" Height="58px" OnClick="ViewReport_Click" Text="View Report" Width="100%" /> 
      <asp:Button ID="Button6" runat="server" class="btn btn-warning dashBoardbtn" Height="58px" OnClick="LogOut_Click" Text="LogOut" Width="100%" /> 
     </div>

        <div style="width:100%;height:351px; ">
        
           
            
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <div style="width:100%;margin-bottom:10px;">
        <div style="text-align:center;">
         <asp:DropDownList ID="DropDownList1" style="text-align:center;left:0px;" runat="server" AutoPostBack="True" >
                <asp:ListItem Selected="True" Value="All"></asp:ListItem>
                <asp:ListItem>New</asp:ListItem>
                <asp:ListItem>Assigned</asp:ListItem>
                <asp:ListItem>Resolved</asp:ListItem>
                <asp:ListItem>Closed</asp:ListItem>
            </asp:DropDownList>
<asp:Label ID="Label2" runat="server" Text="Search" Style="margin-right:10px;padding-top:10px;"></asp:Label>
    <asp:TextBox ID="SearchBox" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Search_Click" class="btn btn-default"/>
        <asp:Button ID="Button5" runat="server" Text="Reload" OnClick="Button5_Click" class="btn btn-default" />
        
        </div>
        
        </div>
    <asp:GridView ID="GridView1" runat="server" Width="71%" CellPadding="4" ForeColor="#333333" Height="384px" AutoGenerateSelectButton="True" HorizontalAlign="Center"   GridLines="None" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"  RowStyle-Wrap="false">
           
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
          <br />
</asp:Content>
