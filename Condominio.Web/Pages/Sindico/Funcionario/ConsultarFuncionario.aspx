﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultarFuncionario.aspx.cs" Inherits="Condominio.Web.Pages.Sindico.Funcionario.ConsultarFuncionario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <script src="<%=ResolveClientUrl("~/Scripts/pages/sindico/funcionario/funcionario-consulta-validacao.js")%>"></script>
    
    <script>
        var btnDeletarFuncionario ="#<%=btnDeletarFuncionario.ClientID%>";
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager runat="server" EnablePageMethods="True"></asp:ScriptManager>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="container">
                <div class="row">
                    <div class="col-md-12 well formulario">
                        <fieldset>
                            <legend><b>Consultar</b> Funcionário
                                <asp:LinkButton runat="server" ID="lkbInserir" OnClick="LkbInserir_OnClick"
                                    Text="<span class='btn-label'></span><b>Inserir</b>"
                                    CssClass="btn btn-default"></asp:LinkButton>
                            </legend>
                        </fieldset>
                        <div class="row">
                            <div class="col-md-8">
                                <div class="col-md-5">
                                    <asp:Label runat="server" for="txtEventoTipoNomeGrid" class="control-label"><b>Nome: </b></asp:Label>
                                    <asp:TextBox runat="server" ID="txtNomeFuncionario" CssClass="form-control" placeholder="Insira o nome do funcionário"></asp:TextBox>
                                </div>

                                <div class="col-md-4" style="margin-top: 15px">
                                    <asp:LinkButton runat="server" ID="lkbPesquisar" OnClick="LkbPesquisar_OnClick" Text="<span class='btn-label'><i class='glyphicon glyphicon-search'></i></span><b>Pesquisar</b>"
                                        CssClass="btn btn-labeled btn-primary"></asp:LinkButton>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="table-responsive col-xs-12 col-sm-12 col-md-12">
                                <asp:UpdatePanel runat="server">
                                    <ContentTemplate>
                                        <asp:GridView ID="grvFuncionario" runat="server" DataKeyNames="IdFuncionario" CssClass="table table-responsive bs-pagination"
                                            PagerSettings-Mode="NumericFirstLast" PagerSettings-FirstPageText="Primeira" PagerSettings-LastPageText="Última"
                                            GridLines="None" AutoGenerateColumns="False" AllowPaging="True" PageSize="5" OnPageIndexChanging="GrvFuncionario_PageIndexChanging">
                                            <Columns>
                                                <asp:BoundField DataField="IdFuncionario" HeaderText="Código">
                                                    <ItemStyle CssClass="HideColumnGridView"></ItemStyle>
                                                    <HeaderStyle CssClass="HideColumnGridView"></HeaderStyle>
                                                </asp:BoundField>
                                                <asp:BoundField DataField="Nome" HeaderText="Nome" />
                                                <asp:BoundField DataField="Cargo" HeaderText="Cargo" />
                                                <asp:BoundField DataField="DataDeNascimento" HeaderText="Nascimento" DataFormatString="{0:dd/MM/yyyy}" />
                                                <asp:BoundField DataField="Telefone" HeaderText="Telefone" />
                                                <asp:BoundField DataField="Celular" HeaderText="Celular" />
                                                <asp:BoundField DataField="Email" HeaderText="E-mail" />
                                                <asp:BoundField DataField="Ativo" HeaderText="Ativo" />

                                                <asp:TemplateField>
                                                    <ItemStyle Width="20px"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:LinkButton runat="server" ID="lbtnEditar" title="Editar" OnClick="LbtnEditar_Click" Text="<span class='btn-label-'><i class='fa fa-pencil' aria-hidden='true'></i></i></span>"></asp:LinkButton>
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <ItemStyle Width="20px"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:LinkButton runat="server" ID="lbtnExcluir" title="Excluir" OnClick="LbtnExcluir_OnClick" Text="<span class='btn-label-'><i class='fa fa-times'></i></span>"></asp:LinkButton>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>

                                            <EmptyDataTemplate>
                                                <div>
                                                    <div class="row">
                                                        <h2 class="text-muted"><i><b>Nenhum</b> resultado</i></h2>
                                                    </div>
                                                </div>
                                            </EmptyDataTemplate>
                                        </asp:GridView>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </div>
                        <asp:UpdateProgress ID="UpdateProgress1" runat="server" DynamicLayout="false" DisplayAfter="1">
                            <ProgressTemplate>
                                <div class="text-muted navbar-fixed-bottom" style="margin-bottom: 50px; margin-left: 10px">
                                    <h2><i class="fa fa-cog fa-spin fa-2x"></i>&nbsp; Processando ...</h2>
                                </div>
                            </ProgressTemplate>
                        </asp:UpdateProgress>
                    </div>
                </div>
            </div>
            
            <div class="hidden">
                <asp:Button runat="server" ID="btnDeletarFuncionario" OnClick="DeletarFuncionario" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

