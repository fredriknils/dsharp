﻿using System.Diagnostics;
using DSharp.Compiler.CodeModel;
using DSharp.Compiler.CodeModel.Expressions;
using DSharp.Compiler.Errors;

namespace DSharp.Compiler.Validator
{
    internal sealed class ArrayNewNodeValidator : IParseNodeValidator
    {
        bool IParseNodeValidator.Validate(ParseNode node, CompilerOptions options, IErrorHandler errorHandler)
        {
            ArrayNewNode newNode = (ArrayNewNode) node;

            if (newNode.ExpressionList != null)
            {
                Debug.Assert(newNode.ExpressionList.NodeType == ParseNodeType.ExpressionList);
                ExpressionListNode argsList = (ExpressionListNode) newNode.ExpressionList;

                if (argsList.Expressions.Count != 1)
                {
                    errorHandler.ReportError(new NodeValidationError("Only single dimensional arrays are supported.", newNode.ExpressionList));
                }
            }

            return true;
        }
    }
}
