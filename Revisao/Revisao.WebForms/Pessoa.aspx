<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pessoa.aspx.cs" Inherits="Revisao.WebForms.Pessoa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div aria-autocomplete="none" style="width: 236px">
            <br />
            Nome&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            Cpf&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCpf" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <br />
            <asp:GridView ID="dgvPessoa" runat="server">
            </asp:GridView>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Salvar" Width="76px" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 3px; margin-top: 0px" Text="Limpar" Width="85px" />
        </div>
    </form>
</body>
</html>
