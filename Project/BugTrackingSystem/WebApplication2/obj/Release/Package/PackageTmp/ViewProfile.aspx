<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="WebApplication8.ViewProfile" Culture="en-Us" UICulture="auto:en-US" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: 32px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div style="width:100%;text-align:center;">
            <div style="height:20px;"></div>
            <div style="height:80px;" class="auto-style1">
                
                Your Profile</div>
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
           
            <br />
            <br />
           
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           
            <asp:Button ID="Button1" runat="server" Text="Back" class="btn btn-danger" OnClick="Button1_Click" />&nbsp; &nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           
            <asp:Button ID="Button2" runat="server" class="btn btn-danger"  Text="Edit Profile" Height="37px" OnClick="Button2_Click" />
           
    </div>
</asp:Content>
