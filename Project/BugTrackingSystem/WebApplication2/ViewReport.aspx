<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="ViewReport.aspx.cs" Inherits="WebApplication8.ViewReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <div style="width:100%;text-align:center;">
            <div style="height:20px;"></div>
            <div style="height:80px;">
                
                <asp:Label ID="Label1" runat="server" Text="Bug Report" Font-Size="32px" style="font-family:andalus;" ></asp:Label>

            </div>
        <asp:DetailsView ID="DetailsView1" runat="server" Height="275px" Width="47%" CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center">
            <AlternatingRowStyle BackColor="White" />
            <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
            <EditRowStyle BackColor="#2461BF" />
            <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
        </asp:DetailsView>
           
    </div>

</asp:Content>
