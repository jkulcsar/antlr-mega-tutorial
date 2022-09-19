// See https://aka.ms/new-console-template for more information

using System.Net.Mime;
using antlr_csharp_simple;
using Antlr4.Runtime;

var file = new FileStream(@".\Content\test.ss", FileMode.Open);

AntlrInputStream inputStream = new AntlrInputStream(file);
SimpleLexer simpleScriptLexer = new SimpleLexer(inputStream);            
CommonTokenStream commonTokenStream = new CommonTokenStream(simpleScriptLexer);
SimpleParser simpleScriptParser = new SimpleParser(commonTokenStream);

var parserConetxt = simpleScriptParser.program();
var visitor = new MySimpleVisitor();
visitor.Visit(parserConetxt);