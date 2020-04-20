<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Procesoria.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Login</title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <link href="Scripts/sb-admin-2.css" rel="stylesheet" />
</head>
    <body class="bg-gradient-primary">
<form runat="server" class="user">
  <div class="container">

    <!-- Outer Row -->
    <div class="row justify-content-center">

      <div class="col-xl-10 col-lg-12 col-md-9">

        <div class="card o-hidden border-0 shadow-lg my-5">
          <div class="card-body p-0">
            <!-- Nested Row within Card Body -->
            <div class="row">
              <div class="col-lg-6 d-none d-lg-block bg-login-image"></div>
              <div class="col-lg-6">
                <div class="p-5">
                  <div class="text-center">
                    <h1 class="h4 text-gray-900 mb-4">Bem vindo!</h1>
                  </div>
                  <div class="user">
                    <div class="form-group">
                      <input runat="server" type="text" class="form-control form-control-user" id="txtLoginUsuario" aria-describedby="idhelp" placeholder="Usuário"/>
                    </div>
                    <div class="form-group">
                      <input runat="server" type="password" class="form-control form-control-user" id="txtLoginSenha" placeholder="Senha"/>
                    </div>
                    <div class="form-group">
                      <div class="custom-control custom-checkbox small">
                        <input type="checkbox" class="custom-control-input" id="customCheck"/>
                        <label class="custom-control-label" for="customCheck">Lembrar-me</label>
                      </div>
                    </div>
                      <asp:Button ID="Button1" CssClass="btn btn-primary btn-user btn-block" runat="server" Text="Acessar" UseSubmitBehavior="true" OnClick="btnLoginAcessar_Click" />
                    <hr/>
                  </div>
                  <hr/>
                  <div class="text-center">
                    <a class="small" href="forgot-password.html">Esqueceu a senha?</a>
                  </div>
                  <div class="text-center">
                    <a class="small" href="Registrar.aspx">Primeiro Acesso? Clique aqui!</a>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
    </form>
</body>

</html>
