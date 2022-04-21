<%@ Page Title="" Language="C#" MasterPageFile="~/vista/Site.Master" AutoEventWireup="true" CodeBehind="frm_venta.aspx.cs" Inherits="Ejercicio.vista.frm_venta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-primary text-center">ventas</h1>

<div class="container mb-3 mt-2 " >
            <asp:GridView ID="gvVentas" runat="server" CellPadding="4"
                OnRowCommand="gvVentas_RowCommand" CssClass="center"
             ForeColor="#333333" GridLines="None" Height="227px" Width="1000px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>    
                <asp:TemplateField HeaderText="&nbsp;&nbsp;&nbsp;Acciones&nbsp;&nbsp;&nbsp;">
                    <ItemTemplate >
                        <asp:ImageButton 
                            ID="btnEditar" runat="server" CommandName="Modificar"  
                            ImageUrl="~/recursos/img/editar.png"
                            CommandArgument='<%# Eval("ID") %>'/>  
                        <asp:ImageButton 
                            ID="btnEliminar" runat="server" CommandName="Eliminar"  
                            ImageUrl="~/recursos/img/eliminar.png"
                            CommandArgument='<%# Eval("ID", "{0:D}") %>' OnClientClick="return confirm('Deseas eliminar esta venta?');"/>  
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
        <%--<asp:Label ID="Label1" runat="server" Text="Cedula"  CssClass="negrita"></asp:Label>
        <asp:TextBox ID="txtcedula"   runat ="server" CssClass="form-control " autocomplete="off"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Nombre"  CssClass="negrita"></asp:Label>
        <asp:TextBox ID="txtnombre"   runat ="server" CssClass="form-control " autocomplete="off"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Apellido"  CssClass="negrita"></asp:Label>
        <asp:TextBox ID="txtapellido"   runat ="server" CssClass="form-control " autocomplete="off"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Edad"  CssClass="negrita"></asp:Label>
        <asp:TextBox ID="txtedad"   runat ="server" CssClass="form-control " autocomplete="off"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="Telefono"  CssClass="negrita"></asp:Label>
        <asp:TextBox ID="txtTelefono"   runat ="server" CssClass="form-control " autocomplete="off"></asp:TextBox>        
        <input type="hidden"   ID="txtId"   runat ="server" />
        <div class="mt-4 d-grid gap-2">
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-primary"   visible="true" />
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-warning" OnClick="btnModificar_Click"  visible="false"  />
        </div>--%>
            
    </div>

    </asp:Content>