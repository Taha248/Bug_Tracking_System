<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="AssignTester.aspx.cs" Inherits="WebApplication8.AssignTester" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div>
        </div>

      <div style="width:15%;float:left;padding-left:5px;padding-right:10px;">

   <br/>
          <br />
           <br />
           <br />
          
        <asp:Button ID="Button8" runat="server" OnClick="Button2_Click" Text="Back"   CssClass="btn btn-danger"  style="width:100%;"/></br/></br>
        <asp:Button ID="Button9" runat="server" OnClick="Button1_Click" Text="Assign"  CssClass="btn btn-danger"   style="width:100%;" /></br></br>
       
    </div>
   
           <div  style="width:100%;" >
               <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:GridView ID="GridView3" runat="server" CellPadding="4"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" Font-Name="Verdana" Font-Names="Verdana" ForeColor="#333333"  CellSpacing="4" GridLines="Horizontal" Height="250px" Width="77%" style="margin-left:50px;" HorizontalAlign="Center" >
           <FooterStyle ForeColor="White" 
              BackColor="#990000" Font-Bold="True"></FooterStyle>
            <PagerStyle ForeColor="#333333" 
              HorizontalAlign="Center" BackColor="#FFCC66"></PagerStyle>
            <HeaderStyle ForeColor="White" Font-Bold="True" 
              BackColor="#990000"></HeaderStyle>
                         <AlternatingRowStyle BackColor="White" />
                         <columns >
  <asp:commandfield selecttext="Select" ButtonType="Button"  showselectbutton="True"   />
             
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
    


        



      
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
