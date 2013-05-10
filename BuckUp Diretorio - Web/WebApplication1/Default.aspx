<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="clear">
        <h2>
            Faça seu backup
        </h2>
    </div>
    <div class="clear">
        <asp:Label ID="lblOrigem" runat="server" Text="Origem: "></asp:Label>
        <asp:TextBox ID="txtOrigem" runat="server" AutoCompleteType="Search" CausesValidation="True"
            MaxLength="250" TabIndex="1" ToolTip="Caminho de origem" Height="24px" Style="margin-top: 0px"
            Width="248px"></asp:TextBox>
        <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        <div>
            <asp:Label ID="lblDestino" runat="server" Text="Destino: "></asp:Label>
            <asp:TextBox ID="txtDestino" runat="server" AutoCompleteType="Search" CausesValidation="True"
                MaxLength="250" TabIndex="1" ToolTip="Caminho de destino" Height="24px" Width="248px"></asp:TextBox>
        </div>
        <div class="fieldset">
            <asp:Button ID="btnBackup" runat="server" Text="Backup" 
                onclick="btnBackup_Click"/>
        </div>
    </div>
</asp:Content>
