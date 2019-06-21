<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="ShowDetails_Dev.aspx.cs" Inherits="WebApplication8.ShowDetails_Dev" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div>
        </div>
       &nbsp;&nbsp;&nbsp;
        </br>
      &nbsp; &nbsp; </br>
        </br>
      &nbsp; &nbsp; </br>
        </br>
       &nbsp;&nbsp;&nbsp; 
        <div style="text-align:center;">
        <asp:DetailsView ID="DetailsView1" runat="server" CellPadding="4"  ForeColor="#333333" GridLines="None" CellSpacing="4">
            <AlternatingRowStyle BackColor="White" />
            <CommandRowStyle BackColor="#C5BBAF" Font-Bold="True" />
            <EditRowStyle BackColor="#7C6F57" />
            <FieldHeaderStyle BackColor="#D0D0D0" Font-Bold="True" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
        </asp:DetailsView> </div>
        </br>
        </br>
      &nbsp;&nbsp;&nbsp;  </br>

        <asp:Button ID="Button1" runat="server" CssClass="auto-style3 btn btn-danger" OnClick="Button1_Click" Text="Back" style="left: 180px; top: -373px; width: 90px; height: 34px"  />
        
        </br>
       &nbsp;&nbsp;&nbsp; 
        <br />
        <br />
</asp:Content>
