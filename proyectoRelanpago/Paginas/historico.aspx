﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="historico.aspx.cs" Inherits="proyectoRelanpago.Paginas.historico" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Estilos/historico.css" rel="stylesheet" />
    <div class="contenedor_historico">

        <div class="historico_resumen">
            <div class="divTitulo">
                <h1>Históricos</h1>
            </div>


            <div class="table-responsive">
                <asp:GridView ID="grdHistorico" runat="server" BackColor="White" BorderColor="Black" BorderWidth="1px" ForeColor="Black" GridLines="Horizontal" class="tablaFactores" AutoGenerateColumns="False" DataKeyNames="id_hoja_resultados" OnSelectedIndexChanged="grdHistorico_SelectedIndexChanged" OnRowCommand="grdHistorico_RowCommand1">
                    <Columns>

                        <asp:BoundField DataField="id_hoja_resultados" HeaderText="Numero Análisis" ReadOnly="True" />
                        <asp:BoundField DataField="usuario" HeaderText="Usuario" ReadOnly="True" />
                        <asp:BoundField DataField="Fecha_registro" HeaderText="Fecha Análisis " ReadOnly="True" />

                        <asp:TemplateField ShowHeader="true">
                            <ItemTemplate>

                                <asp:Button CssClass="btn_reporte" runat="server" Text="Ver Reporte" CommandName="Reporte" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />



                            </ItemTemplate>
                        </asp:TemplateField>

                    </Columns>
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <HeaderStyle BackColor="#000" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#242121" />
                </asp:GridView>
            </div>

        </div>
    </div>

</asp:Content>
