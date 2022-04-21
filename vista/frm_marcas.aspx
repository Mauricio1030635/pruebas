<%@ Page Title="" Language="C#" MasterPageFile="~/vista/Site.Master" AutoEventWireup="true" CodeBehind="frm_marcas.aspx.cs" Inherits="Ejercicio.vista.frm_marcas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2 class="text-primary text-center">Marcas</h2>
    <div class="container mb-3 mt-4 " >
            <asp:GridView ID="gvMarcas" runat="server" CellPadding="4"
                OnRowCommand="gvMarcas_RowCommand" CssClass="center"
             ForeColor="#333333" GridLines="None" Height="227px" Width="336px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>    
                <asp:TemplateField HeaderText="Acciones">
                    <ItemTemplate>
                        <asp:ImageButton 
                            ID="btnEditar" runat="server" CommandName="Modificar"  
                            ImageUrl="~/recursos/img/editar.png"
                            CommandArgument='<%# Eval("Identificador") %>'/>  
                        <asp:ImageButton 
                            ID="btnEliminar" runat="server" CommandName="Eliminar"  
                            ImageUrl="~/recursos/img/eliminar.png"
                            CommandArgument='<%# Eval("Identificador") %>'/>  
                    </ItemTemplate>
                </asp:TemplateField>                   
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
    <div class="container mt-1 col-3">              
        <asp:Label ID="Label1" runat="server" Text="Descripcion"  CssClass="negrita"></asp:Label>
        <asp:TextBox ID="txtDescripcion"   runat ="server" CssClass="form-control " autocomplete="off"></asp:TextBox>
        <div class="mt-4 d-grid gap-2">
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-primary" OnClick="btnAgregar_Click"   />
        </div>            

    </div>

    

     
        
    
</asp:Content>
