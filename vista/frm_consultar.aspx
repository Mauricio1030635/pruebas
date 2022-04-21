<%@ Page Title="" Language="C#" MasterPageFile="~/vista/Site.Master" AutoEventWireup="true" CodeBehind="frm_consultar.aspx.cs" Inherits="Ejercicio.vista.frm_consultar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .valor {
            margin:auto;
            font-size:20px;
            font-weight:bold
                
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <h2 class="text-primary text-center">Consulta</h2>
     <div class="container mt-1 col-3">              
        <asp:Label ID="Label1" runat="server" Text="Cedula"  CssClass="negrita"></asp:Label>
        <asp:TextBox ID="txtconsulta"   runat ="server" CssClass="form-control " autocomplete="off"></asp:TextBox>
        <div class="mt-4 d-grid gap-2">
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="btnBuscar_Click"   />
        </div>     

         <div class="mt-5">
            <asp:Label ID="lbtextoInfo" runat="server"  CssClass="valor"></asp:Label>
        </div>     
         

    </div>

    <div class="container mb-3 mt-4 "  runat="server" ID="dvcontenido">
            <asp:GridView ID="gvConsulta" runat="server" CellPadding="4"
                 CssClass="center"
             ForeColor="#333333" GridLines="None" Height="227px" Width="336px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>                                  
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        </div>
   

</asp:Content>
