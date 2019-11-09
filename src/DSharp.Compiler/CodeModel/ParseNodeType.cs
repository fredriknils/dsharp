﻿// ParseNodeType.cs
// Script#/Core/Compiler
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

namespace DSharp.Compiler.CodeModel
{
    /// <summary>
    ///     List of parse node types.
    /// </summary>
    internal enum ParseNodeType
    {
        CompilationUnit,
        Namespace,
        UsingNamespace,
        UsingAlias,
        Name,
        PredefinedType,
        Type,
        Delegate,
        PointerType,
        ArrayType,
        FormalParameter,
        EnumerationFieldDeclaration,
        VariableDeclarator,
        FieldDeclaration,
        ConstFieldDeclaration,
        VariableDeclaration,
        ConstDeclaration,
        PropertyDeclaration,
        AccessorDeclaration,
        IndexerDeclaration,
        EventDeclaration,
        MethodDeclaration,
        OperatorDeclaration,
        ConstructorDeclaration,
        DestructorDeclaration,
        Block,
        EmptyStatement,
        IfElse,
        Switch,
        CaseLabel,
        DefaultLabel,
        SwitchSection,
        For,
        While,
        DoWhile,
        Foreach,
        Break,
        Continue,
        Goto,
        Return,
        Throw,
        Try,
        Catch,
        Checked,
        Unchecked,
        Using,
        Lock,
        ExpressionStatement,
        LabeledStatement,
        Conditional,
        BinaryExpression,
        UnaryExpression,
        Typeof,
        Cast,
        New,
        ArrayNew,
        This,
        Base,
        Sizeof,
        Literal,
        AttributeBlock,
        Attribute,
        Fixed,
        StackAlloc,
        ArrayInitializer,
        MultiPartName,
        ExpressionList,
        UnsafeStatement,
        YieldReturn,
        YieldBreak,
        ExternAlias,
        AnonymousMethod,
        AliasQualifiedName,
        TypeParameter,
        ConstraintClause,
        DefaultValueExpression,
        GenericName,
        Await,
    }
}
