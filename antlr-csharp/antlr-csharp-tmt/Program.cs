// See https://aka.ms/new-console-template for more information

using antlr_csharp_tmt;
using Antlr4.Runtime;

var file = new FileStream(@".\Content\test.ss", FileMode.Open);
//var file = new FileStream(@".\Content\00-Abnahmetest.tmts", FileMode.Open);

AntlrInputStream inputStream = new AntlrInputStream(file);
TruMarkTestScriptLexer truMarkTestScriptLexer = new TruMarkTestScriptLexer(inputStream);            
CommonTokenStream commonTokenStream = new CommonTokenStream(truMarkTestScriptLexer);
TruMarkTestScriptParser truMarkTestScriptParser = new TruMarkTestScriptParser(commonTokenStream);

var parserConetxt = truMarkTestScriptParser.program();
var visitor = new MyTruMarkTestScriptVisitor();
visitor.Visit(parserConetxt);