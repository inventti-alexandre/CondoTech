﻿using Condominio.Controllers;
using Condominio.Web.Components;
using System;
using System.Linq;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Condominio.Web.Pages.Sindico.Informativo
{
    public partial class ConsultarInformativo : Page
    {
        private readonly InformativoControl _informativoControl;
        private readonly Mensagens _mensagens;

        public ConsultarInformativo()
        {
            _mensagens = new Mensagens();
            _informativoControl = new InformativoControl();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                PreencherGridInformativo();
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        private void PreencherGridInformativo()
        {
            grvInformativo.DataSource = _informativoControl.ObterInformativos();
            grvInformativo.DataBind();
        }

        protected void lkbPesquisar_OnClick(object sender, EventArgs e)
        {
            try
            {
                var valor = txtValorInformativo.Text;
                grvInformativo.DataSource = _informativoControl.ObterInformativoPorTitulo(valor).ToList();
                grvInformativo.DataBind();
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        protected void grvInformativo_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                grvInformativo.PageIndex = e.NewPageIndex;
                PreencherGridInformativo();
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        protected void lbtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var javascript = new JavaScriptSerializer();
                var gridViewRow = Services.ObterLinhaDeDados(sender, grvInformativo);
                var dataKey = grvInformativo.DataKeys[gridViewRow.RowIndex];

                if (dataKey != null)
                {
                    var idFuncionario = Convert.ToInt32(dataKey["IdFuncionario"]);
                    var idSerializado = javascript.Serialize(idFuncionario);

                    ViewState.Add("IdFuncionario", Convert.ToInt32(idSerializado));

                    ScriptManager.RegisterClientScriptBlock(Page, GetType(),
                        "modaldeleteFuncionario", "confirmarExcluir(\"" + idSerializado + "\")", true);
                }
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }
    }
}