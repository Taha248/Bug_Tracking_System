<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Developer_Panel.aspx.cs"  Inherits="WebApplication8.Developer_Panel"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div style="height:50px;de">
        </div>

    <div style="width:15%;float:left;padding-left:5px;padding-right:10px;">

        <asp:Button ID="Button4" runat="server" Text="<%$ Resources:Resource, Extend %>" OnClick="Button4_Click"   CssClass="btn btn-danger" Width="120px" style="width:100%;" /></br></br>
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="<%$ Resources:Resource, Assign %>"   CssClass="btn btn-danger"  style="width:100%;"/></br></br>
        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="<%$ Resources:Resource, ViewProfile %>"  CssClass="btn btn-danger"   style="width:100%;" /></br></br>
        <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="<%$ Resources:Resource, ReAssign %>"  CssClass="btn btn-danger" style="width:100%;"/></br></br>
        <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="<%$ Resources:Resource, ShowDetails %>"  CssClass="btn btn-danger"   style="width:100%;" /></br></br>
         <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="<%$ Resources:Resource, Logout %>"  CssClass="btn btn-danger"   style="width:100%;" /></br></br>
       
    </div>
 
    <div  style="width:100%;" >
        <asp:GridView ID="GridView3" runat="server" CellPadding="4"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" Font-Name="Verdana" Font-Names="Verdana" ForeColor="#333333"  CellSpacing="4" GridLines="Horizontal" Height="250px" Width="77%" style="margin-left:50px;" HorizontalAlign="Center" >
           <FooterStyle ForeColor="White" 
              BackColor="#990000" Font-Bold="True"></FooterStyle>
            <PagerStyle ForeColor="#333333" 
              HorizontalAlign="Center" BackColor="#FFCC66"></PagerStyle>
            <HeaderStyle ForeColor="White" Font-Bold="True" 
              BackColor="#990000"></HeaderStyle>
                         <AlternatingRowStyle BackColor="White" />
                         <columns >
  <asp:commandfield selecttext="<%$ Resources:Resource, Select %>" ButtonType="Button"  showselectbutton="True"   />
             
</columns>
  
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
            <editrowstyle BackColor="#999999"></editrowstyle>
  
        </asp:GridView>

    </div>
</asp:Content>
