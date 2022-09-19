namespace antlr_csharp_simple;

public class MySimpleVisitor : SimpleBaseVisitor<object?>
{
    Dictionary<string, object?> _variables = new Dictionary<string, object?>();

    public override object? VisitProgram(SimpleParser.ProgramContext context)
    {
        return VisitChildren(context);
    }

    public override object? VisitAssignement(SimpleParser.AssignementContext context)
    {
        var variableName = context.IDENTIFIER().GetText();
        
        var variableValue = Visit(context.expression());
        
        _variables[variableName] = variableValue;

        return null;
    }

    public override object? VisitConstant(SimpleParser.ConstantContext context)
    {
        if (context.INTEGER() is {} anInteger)
        {
            return int.Parse(anInteger.GetText());
        }
        if(context.STRING() is {} aString)
        {
            return aString.GetText()[1..^1];
        }
        if(context.FLOAT() is {} aFloat)
        {
            return float.Parse(aFloat.GetText());
        }
        
        return base.VisitConstant(context);
    }
}