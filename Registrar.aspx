<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="Procesoria.Registrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Registrar</title>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content=""/>
    <meta name="author" content=""/>
    <!-- Custom styles for this template-->
    <link href="Scripts/sb-admin-2.css" rel="stylesheet" />
</head>
<body class="bg-gradient-primary">
    <form runat="server" class="user">
    <div class="container">
        <div class="card o-hidden border-0 shadow-lg my-5">
            <div class="card-body p-0">
                <!-- Nested Row within Card Body -->
                <div class="row">
                    <div class="col-lg-5 d-none d-lg-block bg-register-image"></div>
                    <div class="col-lg-7">
                        <div class="p-5">
                            <div class="text-center">
                                <h1 class="h4 text-gray-900 mb-4">Cadastro de Usuario!</h1>
                            </div>
                            <div class="user">
                                <div class="form-group">
                                    <input runat="server" type="text" class="form-control form-control-user" id="txtCadastrarUsuario" placeholder="Usuário" />
                                </div>
                                <div class="form-group">
                                    <input runat="server" type="email" class="form-control form-control-user" id="txtCadastrarEmailConfirmado" placeholder="E-mail" />
                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                        <input runat="server" type="password" class="form-control form-control-user" id="txtCadastrarSenha" placeholder="Senha" />
                                    </div>
                                    <div class="col-sm-6">
                                        <input runat="server" type="password" class="form-control form-control-user" id="txtCadastrarSenhaConfirmada" placeholder="Confirmar Senha" />
                                    </div>
                                </div>
                                <asp:Button ID="btnCadastrar" CssClass="btn btn-primary btn-user btn-block" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />
                                <hr />
                            </div>
                            <hr />
                            <div class="text-center">
                                <a class="small" href="Login.aspx">Já possui cadastro?</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <asp:ScriptManager runat="server" />
    </form>
</body>
</html>
