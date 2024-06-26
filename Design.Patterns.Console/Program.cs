// See https://aka.ms/new-console-template for more information
using Design.Patterns.Console.Creational.Patterns.Builder;
using Design.Patterns.Console.Creational.Patterns.Builder.AuxiliaresParaDemonstracao;

// Toda a regra para validar se o email é valido está no builder
Console.WriteLine("Executando modelos Criacionais");

EmailBuilder emailBuilder = new EmailBuilder();
emailBuilder.BuildRemetente("tati@tati.com");
emailBuilder.BuildDestinatario("joao@joao.com");
emailBuilder.BuildAssunto("Cronograma de implatação do Projeto");
emailBuilder.BuildAddLinhaAoConteudo("Prezado Cliente,");
emailBuilder.BuildAddLinhaAoConteudo("Segue anexo o cronograma do projeto");
emailBuilder.BuildAddLinhaAoConteudo("Atenciosamente");
emailBuilder.BuildAddLinhaAoConteudo("Tati");
emailBuilder.AddAnexo(new Anexo { Nome = "Documento.pdf", 
                Conteudo = new byte[] { /* Conteúdo do anexo */ } });

var email = emailBuilder.GetEmail;
Console.WriteLine("");