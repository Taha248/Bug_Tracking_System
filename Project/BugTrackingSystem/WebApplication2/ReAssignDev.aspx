<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="ReAssignDev.aspx.cs" Inherits="WebApplication8.ReAssignDev" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div>
        </div>
    <div style="text-align:center">
        <asp:GridView ID="GridView3" runat="server" CellPadding="4"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" Font-Name="Verdana" Font-Names="Verdana" ForeColor="#333333" GridLines="None" CssClass="auto-style1" CellSpacing="4" style="position: relative; left: 321px; top: 23px; width: 264px; height: 189px"  >
           <FooterStyle ForeColor="White" 
              BackColor="#990000" Font-Bold="True"></FooterStyle>
            <PagerStyle ForeColor="#333333" 
              HorizontalAlign="Center" BackColor="#FFCC66"></PagerStyle>
            <HeaderStyle ForeColor="White" Font-Bold="True" 
              BackColor="#990000"></HeaderStyle>
                         <AlternatingRowStyle BackColor="White" />
                         <columns >
  <asp:commandfield selecttext="Select" showselectbutton="True"   />
               
</columns>
  
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
  
        </asp:GridView>
    </div>


        



        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ReAssign" cssClass="btn btn-danger" style="position: relative; left: 398px; top: 84px; height: 36px; width: 103px"/>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" CssClass="btn btn-danger" style="position: relative; left: 2px; top: -131px" />
    
</asp:Content>
