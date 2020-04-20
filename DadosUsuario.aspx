<%@ Page Title="" Language="C#" MasterPageFile="~/MasterSistema.Master" AutoEventWireup="true" CodeBehind="DadosUsuario.aspx.cs" Inherits="Procesoria.DadosUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenthead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <div class="container">
          <div class="card shadow mb-4">
            <div class="card-header py-3">
              <h6 class="m-0 font-weight-bold text-primary">Dados de Usuario</h6>
            </div>
            <div class="container">
                <div class="form-row">
                  <div class="col-md-4 mb-3">
                    <label for="validationDefault01">Nome:</label>
                    <input type="text" class="form-control" id="inputDefault04" required>
                  </div>
                  <div class="col-md-3 mb-3">
                    <label for="validationDefault02">Sobre nome:</label>
                    <input type="text" class="form-control" id="inputDefault02" required>
                  </div>
                  <div class="col-md-2 mb-3">
                    <label for="validationDefault05">Data Nascimento:</label>
                    <input type="text" class="form-control" id="inputDefault03" required>
                  </div>
                  <div class="col-md-2 mb-3">
                    <label class="validationDefault02" for="inlineFormCustomSelect">Sexo</label>
                    <select class="custom-select mr-sm-2" id="inlineFormCustomSelect">
                      <option selected>Opção</option>
                      <option value="1">Feminino</option>
                      <option value="2">Masculino</option>
                      <option value="3">Outros</option>
                    </select>
                  </div>                  
                </div>
                  <div class="form-row">
                    <div class="col-md-3 mb-3">
                      <label for="validationDefault01">RG:</label>
                      <input type="text" class="form-control" id="validationDefault01" required>
                    </div>
                    <div class="col-md-3 mb-3">
                      <label for="validationDefault02">CPF:</label>
                      <input type="text" class="form-control" id="validationDefault02" required>
                    </div>
                    <div class="col-md-2 mb-3">
                      <label for="validationDefault05">Inscrição OAB:</label>
                      <input type="text" class="form-control" id="validationDefault05" required>
                    </div>            
                    <div class="col-md-3 mb-3">
                      <label for="validationDefaultEmail">Email:</label>
                      <div class="input-group">
                        <div class="input-group-prepend">
                          <span class="input-group-text" id="inputGroupPrepend2">@</span>
                        </div>
                        <input type="text" class="form-control" id="validationDefaultEmail" placeholder="Email" aria-describedby="inputGroupPrepend2" required>
                      </div>
                    </div>      
                  </div>
                <div class="form-row">                  
                  <div class="col-md-3 mb-3">
                    <label for="validationDefault03">Endereço:</label>
                    <input type="text" class="form-control" id="validationDefault09" required>
                  </div>
                  <div class="col-md-3 mb-3">
                    <label for="validationDefault04">Estado:</label>
                    <input type="text" class="form-control" id="validationDefault10" required>                    
                  </div>
                  <div class="col-md-2 mb-3">
                    <label for="validationDefault04">CEP:</label>
                    <input type="text" class="form-control" id="validationDefault11" required>                    
                  </div>
                  <div class="col-md-3 mb-3">
                    <label for="validationDefault04">Cidade:</label>
                    <input type="text" class="form-control" id="validationDefault12" required>                    
                  </div>
                  <div class="input-group mb-3">
                  </div>
                </div>
                <div class="form-group row">
                  <div class="col-sm-2">Area de Atuação:</div>
                    <div class="form-check form-check-inline">
                      <input class="form-check-input" type="checkbox" id="gridCheck1">
                      <label class="form-check-label" for="gridCheck2">
                        Trabalhista 
                      </label>
                    </div>
                    <div class="form-check form-check-inline">
                      <input class="form-check-input" type="checkbox" id="gridCheck3">
                      <label class="form-check-label" for="gridCheck2">
                        Previdenciaria
                      </label>
                    </div>
                    <div class="form-check form-check-inline">
                      <input class="form-check-input" type="checkbox" id="gridCheck4">
                      <label class="form-check-label" for="gridCheck2">
                        Habitação 
                      </label>
                    </div>
                    <div class="form-check form-check-inline">
                      <input class="form-check-input" type="checkbox" id="gridCheck5">
                      <label class="form-check-label" for="gridCheck2">
                        Civil 
                      </label>
                    </div>
                    <div class="form-check form-check-inline">
                      <input class="form-check-input" type="checkbox" id="gridCheck6">
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
                <a href="#" class="btn btn-warning btn-icon-split">
                  <span class="icon text-white-50">
                    <i class="fas fa-exclamation-triangle"></i>
                  </span>
                  <span class="text">Editar</span>
                </a>
                <a href="#" class="btn btn-danger btn-icon-split">
                  <span class="icon text-white-50">
                    <i class="fas fa-trash"></i>
                  </span>
                  <span class="text">Exlucir</span>
                </a>
              <p></p>
            </div>
          </div> 
        </div>
</asp:Content>
