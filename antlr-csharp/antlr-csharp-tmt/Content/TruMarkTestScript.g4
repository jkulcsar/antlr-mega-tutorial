grammar TruMarkTestScript;

program: line* EOF;

line: statement | ifBlock | whileBlock;

statement: (declaration | assignment | functionCall | subProgramCall );

ifBlock: 'if' expression block ('else' elseIfBlock)?;

elseIfBlock: block | ifBlock;

block: '{' line* '}';

whileBlock: WHILE expression block ('else' elseIfBlock)?;

WHILE: 'while' | 'until';
IN : 'in';
OUT : 'out';
CALL : 'call';

assignment: IDENTIFIER '=' expression;

functionCall: FUNCTIONIDENTIFIER '(' (expression (',' expression)*)? ')';

subProgramCall: CALL FUNCTIONIDENTIFIER '(' (expression (',' expression)*)? ')';

hardwareModuleCall: HARDWAREMODULEIDENTIFIER '(' (expression (',' expression)*)? ')';

commandCall: FUNCTIONIDENTIFIER '[' STRING STRING STRING ']';

expression
    : constant                          #constantExpression
    | IDENTIFIER                        #identifierExpression
    | functionCall                      #functionCallExpression
    | subProgramCall                    #subProgramCallExpression
    | hardwareModuleCall                #hardwareModuleCallExpression
    | commandCall                       #commandCallExpression
    |'(' expression ')'                 #parenthesizedExpression
    | '!' expression                    #notExpression
    | expression multOp expression      #multiplicativeExpression
    | expression addOp expression       #additiveExpression
    | expression compareOp expression   #comparisonExpression
    | expression boolOp expression      #booleanExpression
    ;
    
multOp: '*' | '/' | '%';
addOp: '+' | '-';
compareOp: '<' | '>' | '<=' | '>=' | '==' | '!=' | '<>';
boolOp: BOOL_OPERATOR;

BOOL_OPERATOR: 'and' | 'or' | 'xor';

constant: INTEGER | FLOAT | STRING | BOOL | NULL;

INTEGER: [0-9]+;
FLOAT: [0-9]+ '.' [0-9]+;
STRING: ('"' ~'"'* '"') | ('\'' ~'\''* '\'');
BOOL: 'true' | 'false';
NULL: 'null';

WS
   : [ \r\n\t] -> skip
   ;
   
IDENTIFIER: [$a-zA-Z_][$a-zA-Z0-9_]*;
FUNCTIONIDENTIFIER: [a-zA-Z_][a-zA-Z0-9_]*;
HARDWAREMODULEIDENTIFIER: [a-zA-Z^:.][a-zA-Z0-9^:.]*;

variant_type_parameter
	: variance_annotation? IDENTIFIER
	;
	
variance_annotation
	: IN | OUT
	;

typeSpecifier
    :   ('void'
    |   'int'
    |   'float'
    |   'string'
    |   'bool')
    ;
    
declaration
    :   declarationSpecifiers initDeclaratorList?
    ;
    
initDeclaratorList
    :   initDeclarator (',' initDeclarator)*
    ;

declarationSpecifiers
    :   declarationSpecifier+
    ;
    
declarationSpecifier
    :   typeSpecifier
    ;

initDeclarator
    :   declarator ('=' initializer)?
    ;
    
initializer
    :   assignment
//    |   '{' initializerList ','? '}'
    ;
    
declarator
    :   directDeclarator 
    ;

directDeclarator
    :   IDENTIFIER
    |   '(' declarator ')'
    ;
        
BlockComment
    :   '/*' .*? '*/'
        -> skip
    ;

LineComment
    :   '//' ~[\r\n]*
        -> skip
    ;
