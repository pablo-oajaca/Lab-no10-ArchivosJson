<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab_no10_ArchivosJson._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ejemplo de escritura Json</h1>
        <p class="lead">Una universidad contendra muchos alumnos.</p>
        <p class="lead">&nbsp;</p>
        <p class="lead">Universidad</p>
        <p class="lead">Ingrese la universidad
            <asp:TextBox ID="TextBoxUniversidad" runat="server" Width="235px"></asp:TextBox>
        </p>
        <p class="lead">Estudiantes </p>
        <p class="lead">Ingrese el nombre de los estudiantes
             
            <asp:TextBox ID="TextBoxAlumno" runat="server"></asp:TextBox>
             
            <asp:Button ID="ButtonGuardarEstudiante" runat="server" CssClass="bg-primary" Text="Guardar " Width="122px" OnClick="ButtonGuardarEstudiante_Click" />
        </p>
        <p class="lead">&nbsp;</p>
        <p>
            <asp:Button ID="ButtonUniversidad" runat="server" CssClass="btn btn-success btn-lg" Text="Ingresar Datos Universidad" OnClick="ButtonUniversidad_Click" />
        </p>
    </div>

    </asp:Content>
