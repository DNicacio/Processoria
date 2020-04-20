<%@ Page Title="" Language="C#" MasterPageFile="~/MasterSistema.Master" AutoEventWireup="true" CodeBehind="NovoProcesso.aspx.cs" Inherits="Procesoria.NovoProcesso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenthead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <div class="container">
          <div class="card shadow mb-4">
            <div class="card-header py-3">
              <h6 class="m-0 font-weight-bold text-primary">Nova Consulta</h6>
            </div>
            <div class="container">
                <div class="form-row">
                  <div class="col-md-4 mb-3">
                    <label for="validationDefault01">Nome Cliente:</label>
                    <input type="text" class="form-control" id="validationDefault01" required>
                  </div>
                  <div class="col-md-3 mb-3">
                    <label for="validationDefault02">Valor R$:</label>
                    <input type="text" class="form-control" id="validationDefault02" required>
                  </div>
                  <div class="col-md-2 mb-3">
                    <label for="validationDefault05">Data de Atendimento:</label>
                    <input type="text" class="form-control" id="validationDefault05" required>
                  </div>                  
                </div>
                <div class="form-group">
                  <div class="col-md-2 mb-3">
                    <label for="validationDefault05">Descrição:</label>
                    <textarea cols="60"></textarea>
                  </div>                      
                </div>
                <div class="form-group row">
                  <div class="col-sm-2">Tipo de Causa:</div>
                    <div class="form-check form-check-inline">
                      <input class="form-check-input" type="checkbox" id="gridCheck1">
                      <label class="form-check-label" for="gridCheck2">
                        Trabalhista 
                      </label>
                    </div>
                    <div class="form-check form-check-inline">
                      <input class="form-check-input" type="checkbox" id="gridCheck12">
                      <label class="form-check-label" for="gridCheck2">
                        Previdenciaria
                      </label>
                    </div>
                    <div class="form-check form-check-inline">
                      <input class="form-check-input" type="checkbox" id="gridCheck13">
                      <label class="form-check-label" for="gridCheck2">
                        Habitação 
                      </label>
                    </div>
                    <div class="form-check form-check-inline">
                      <input class="form-check-input" type="checkbox" id="gridCheck14">
                      <label class="form-check-label" for="gridCheck2">
                        Civil 
                      </label>
                    </div>
                    <div class="form-check form-check-inline">
                      <input class="form-check-input" type="checkbox" id="gridCheck15">
                      <label class="form-check-label" for="gridCheck2">
                        Criminal 
                      </label>
                    </div>                 
                </div>        
                <div class="form-group">
                </div>                
                <a href="#" class="btn btn-success btn-icon-split">
                  <span class="icon text-white-50">
                    <i class="fas fa-check"></i>
                  </span>
                  <span class="text">Salvar</span>
                </a>
                <a href="#" class="btn btn-secondary btn-icon-split">
                  <span class="icon text-white-50">
                    <i class="fas fa-arrow-right"></i>
                  </span>
                  <span class="text">Imprimir</span>
                </a>
                <a href="#" class="btn btn-info btn-icon-split">
                  <span class="icon text-white-50">
                    <i class="fas fa-trash"></i>
                  </span>
                  <span class="text">Limpar</span>
                </a>
              <p></p>
            </div>
          </div> 
        </div>
</asp:Content>
