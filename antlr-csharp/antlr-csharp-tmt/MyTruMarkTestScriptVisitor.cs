namespace antlr_csharp_tmt;

public class MyTruMarkTestScriptVisitor : TruMarkTestScriptBaseVisitor<object?>
{
    Dictionary<string, object?> _variables = new Dictionary<string, object?>();

    public override object? VisitProgram(TruMarkTestScriptParser.ProgramContext context)
    {
        return VisitChildren(context);
    }

    public override object? VisitAssignment(TruMarkTestScriptParser.AssignmentContext context)
    {
        var variableName = context.IDENTIFIER().GetText();
        
        var variableValue = Visit(context.expression());
        
        _variables[variableName] = variableValue;

        return null;
    }

    public override object? VisitConstant(TruMarkTestScriptParser.ConstantContext context)
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
        if(context.BOOL() is {} aBool)
        {
            return aBool.GetText() == "true";
        }
        if(context.NULL() is {} aNull)
        {
            return null;
        }

        throw new NotImplementedException();
    }

    public override object? VisitIdentifierExpression(TruMarkTestScriptParser.IdentifierExpressionContext context)
    {
        var variableName = context.IDENTIFIER().GetText();

        if (!_variables.ContainsKey(variableName))
        {
           throw new Exception($"Variable {variableName} not defined.");
        }
        
        return _variables[variableName];
    }

    public override object? VisitAdditiveExpression(TruMarkTestScriptParser.AdditiveExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));

        var op = context.addOp().GetText();
        return op switch
        {
            "+" => Add(left, right),
            "-" => Substract(left, right),
            _ => throw new NotImplementedException()
        };
        
        throw new NotImplementedException();
    }
    
    public object? Add(object? left, object? right)
    {
        if (left is int leftInt && right is int rightInt)
        {
            return leftInt + rightInt;
        }
        if (left is float leftFloat && right is float rightFloat)
        {
            return leftFloat + rightFloat;
        }
        if (left is string || right is string)
        {
            return $"{left}{right}";
        }

        throw new Exception($"Cannot add values of type {left?.GetType()} and {right?.GetType()}.");
    }
    
    public object? Substract(object? left, object? right)
    {
        if (left is int leftInt && right is int rightInt)
        {
            return leftInt - rightInt;
        }
        if (left is float leftFloat && right is float rightFloat)
        {
            return leftFloat - rightFloat;
        }

        throw new NotImplementedException();
    }

    public override object? VisitWhileBlock(TruMarkTestScriptParser.WhileBlockContext context)
    {
        Func<object?, bool> condition = context.WHILE().GetText() == "while"
        ? IsTrue
        : IsFalse;
        
        // implements the purposefully defined strange  while...else loop
        if(condition(Visit(context.expression())))
        {
            do
            {
                Visit(context.block());
            } while(condition(Visit(context.expression())));
        }
        else
        {
            Visit(context.block());
        }

        return null;
    }

    public override object? VisitComparisonExpression(TruMarkTestScriptParser.ComparisonExpressionContext context)
    {

        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));

        var op = context.compareOp().GetText();
        return op switch
        {
            "==" => Equals(left, right),
            "!=" => !Equals(left, right),
            "<" => LessThan(left, right),
            ">" => GreaterThan(left, right),
            //"<=" => LessThanOrEqual(left, right),
            //">=" => GreaterThanOrEqual(left, right),
            _ => throw new NotImplementedException()
        };
    }

    private object? LessThan(object? left, object? right)
    {

        if (left is int leftInt && right is int rightInt)
        {
            return leftInt < rightInt;
        }

        if (left is float leftFloat && right is float rightFloat)
        {
            return leftFloat < rightFloat;
        }
        
        throw new NotImplementedException();
    }

    private object? GreaterThan(object? left, object? right)
    {

        if (left is int leftInt && right is int rightInt)
        {
            return leftInt > rightInt;
        }

        if (left is float leftFloat && right is float rightFloat)
        {
            return leftFloat > rightFloat;
        }
        
        throw new NotImplementedException();
    }

    private bool IsTrue(object? value)
    {
        if (value is bool boolValue)
        {
            return boolValue;
        }
        if (value is int intValue)
        {
            return intValue != 0;
        }
        if (value is float floatValue)
        {
            return floatValue != 0;
        }
        if (value is string stringValue)
        {
            return stringValue != "";
        }
        if (value is null)
        {
            return false;
        }

        throw new Exception($"Cannot convert value of type {value?.GetType()} to boolean.");
    }
    
    public bool IsFalse(object? value)
    {
        return !IsTrue(value);
    }
}