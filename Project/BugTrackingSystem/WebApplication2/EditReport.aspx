<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="EditReport.aspx.cs" Inherits="WebApplication8.EditReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

   <div style="height:30px;"></div>
   <asp:Table ID="Table1" runat="server" Width="100%" style="margin-left:14%;">
            <asp:TableRow runat="server" style="height:47px;">
            <asp:TableCell>
           
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label6" runat="server" Font-Size="32px"  Text="Edit Report" style="  font-family:'Times New Roman';"></asp:Label>
            </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server" style="height:47px;">
            <asp:TableCell>
                <asp:Label ID="Label1" runat="server" Text="Title"></asp:Label>

            </asp:TableCell>

            <asp:TableCell>
            
            <asp:TextBox runat="server" ID="title"></asp:TextBox>
            </asp:TableCell>
            </asp:TableRow>




                   <asp:TableRow runat="server">
            <asp:TableCell>
                <asp:Label ID="Label2" runat="server" Text="Details" ></asp:Label>

            </asp:TableCell>
            <asp:TableCell>


                <asp:TextBox runat="server" ID="Detail" Rows="5" TextMode="MultiLine" style="height:107px;"></asp:TextBox>
            </asp:TableCell>
            </asp:TableRow >





                <asp:TableRow runat="server" style="height:47px;">
            <asp:TableCell>
                <asp:Label ID="Label3" runat="server" Text="Priority"></asp:Label>

            </asp:TableCell>
            <asp:TableCell>
            <asp:DropDownList runat="server" ID="Priority">
                <asp:ListItem>Critical</asp:ListItem>
                <asp:ListItem>High</asp:ListItem>
                <asp:ListItem>Medium</asp:ListItem>
                <asp:ListItem>Low</asp:ListItem>
    </asp:DropDownList>
            </asp:TableCell>
            </asp:TableRow>
                    <asp:TableRow runat="server" style="height:47px;">
            <asp:TableCell>
                <asp:Label ID="Label4" runat="server" Text="Severity"></asp:Label>

            </asp:TableCell>
            <asp:TableCell>
       <asp:DropDownList runat="server"  ID="Severity">
                <asp:ListItem>Blocker</asp:ListItem>
                <asp:ListItem>Major</asp:ListItem>
                <asp:ListItem>Moderate</asp:ListItem>
                <asp:ListItem>Low</asp:ListItem>
                </asp:DropDownList>
            </asp:TableCell>
            </asp:TableRow >
               <asp:TableRow runat="server" style="height:47px;">
            <asp:TableCell>
                <asp:Label ID="Label5" runat="server" Text="Project URL"></asp:Label>
                
            </asp:TableCell>
            <asp:TableCell>
            <asp:TextBox runat="server" ID="Project"></asp:TextBox>
            </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow >
            <asp:TableCell>

            </asp:TableCell>
            <asp:TableCell>
            

        <asp:Button ID="update" runat="server" Text="Update" OnClick="update_Click" class="btn btn-success" style="height:37px;"  />
   
            </asp:TableCell>
            </asp:TableRow>
        </asp:Table>


</asp:Content>
