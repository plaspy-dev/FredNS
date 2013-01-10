<%@ Page Title="Eliminar dominio" Language="C#" MasterPageFile="~/ingreso.master" AutoEventWireup="true" CodeFile="eliminar.aspx.cs" Inherits="eliminar" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <table style="width:100%;">
            <tr>
                <td align="center">
                    <asp:Label ID="Label1" runat="server" 
                        Text="Esta seguro de eliminar el dominio " meta:resourcekey="Label1Resource1"></asp:Label>
                    <asp:Label ID="LDominio" runat="server" meta:resourcekey="LDominioResource1"></asp:Label>
                    <asp:Label ID="Label2" runat="server" 
                        Text=", esta acción no se puede deshacer." meta:resourcekey="Label2Resource1"></asp:Label></td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="BAceptar" runat="server" onclick="BAceptar_Click" 
                        Text="Aceptar" meta:resourcekey="BAceptarResource1" />
                    <asp:Button ID="BCancelar" runat="server" onclick="BCancelar_Click" 
                        Text="Cancelar" meta:resourcekey="BCancelarResource1" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </p>
</asp:Content>

