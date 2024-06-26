// See https://aka.ms/new-console-template for more information
using Design.Patterns.Console.Behavioral.Patterns.Interpreter;
using Design.Patterns.Console.Creational.Patterns.Builder;
using Design.Patterns.Console.Creational.Patterns.Builder.AuxiliaresParaDemonstracao;





Console.WriteLine("Execute Interpreter");
ExecuteInterpreter();

void ExecuteInterpreter()
{
    var context = new Dictionary<string, int>();
    context["a"] = 10;
    context["b"] = 20;
    context["c"] = 30;

    // Construção da expressão: a + b * 2
    Expression expression = new AddExpression(
        new VariableExpression("a"),
        new AddExpression(
            new VariableExpression("b"),
            new AddExpression(new VariableExpression("c"),
            new NumberExpression(2)
        ))
    );

    // Interpretando a expressão
    int result = expression.Interpret(context);
    Console.WriteLine("Resultado: " + result);  // Saída esperada: 62
}

void ExecuteBuilder()
{
    EmailBuilder emailBuilder = new EmailBuilder();
    emailBuilder.BuildRemetente("tati@tati.com");
    emailBuilder.BuildDestinatario("joao@joao.com");
    emailBuilder.BuildAssunto("Cronograma de implatação do Projeto");
    emailBuilder.BuildAddLinhaAoConteudo("Prezado Cliente,");
    emailBuilder.BuildAddLinhaAoConteudo("Segue anexo o cronograma do projeto");
    emailBuilder.BuildAddLinhaAoConteudo("Atenciosamente");
    emailBuilder.BuildAddLinhaAoConteudo("Tati");
    emailBuilder.AddAnexo(new Anexo
    {
        Nome = "Documento.pdf",
        Conteudo = new byte[] { /* Conteúdo do anexo */ }
    });

    var email = emailBuilder.GetEmail;
}