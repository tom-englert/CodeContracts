// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

#if NETFRAMEWORK_4_0
// File System.Runtime.CompilerServices.DebugInfoGenerator.cs
// Automatically generated contract file.
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;
using System.IO;
using System.Text;

// Disable the "this variable is not used" warning as every field would imply it.
#pragma warning disable 0414
// Disable the "this variable is never assigned to".
#pragma warning disable 0067
// Disable the "this event is never assigned to".
#pragma warning disable 0649
// Disable the "this variable is never used".
#pragma warning disable 0169
// Disable the "new keyword not required" warning.
#pragma warning disable 0109
// Disable the "extern without DllImport" warning.
#pragma warning disable 0626
// Disable the "could hide other member" warning, can happen on certain properties.
#pragma warning disable 0108


namespace System.Runtime.CompilerServices
{
  [ContractClass(typeof(ContractForDebugInfoGenerator))]
  public abstract class DebugInfoGenerator
  {
    #region Methods and constructors

    //
    // Summary:
    //     Initializes a new instance of the System.Runtime.CompilerServices.DebugInfoGenerator
    //     class.
    protected DebugInfoGenerator()
    { }

    //
    // Summary:
    //     Creates a program database (PDB) symbol generator.
    //
    // Returns:
    //     A PDB symbol generator.
    public static DebugInfoGenerator CreatePdbGenerator()
    {
      Contract.Ensures(Contract.Result<DebugInfoGenerator>() != null);
      return default(DebugInfoGenerator);
    }

    //
    // Summary:
    //     Marks a sequence point in Microsoft intermediate language (MSIL) code.
    //
    // Parameters:
    //   method:
    //     The lambda expression that is generated.
    //
    //   ilOffset:
    //     The offset within MSIL code at which to mark the sequence point.
    //
    //   sequencePoint:
    //     Debug information that corresponds to the sequence point.
    public abstract void MarkSequencePoint(LambdaExpression method, int ilOffset, DebugInfoExpression sequencePoint);

    #endregion
  }

  [ContractClassFor(typeof(DebugInfoGenerator))]
  abstract class ContractForDebugInfoGenerator : DebugInfoGenerator
  {
    // Summary:
    //     Marks a sequence point in Microsoft intermediate language (MSIL) code.
    //
    // Parameters:
    //   method:
    //     The lambda expression that is generated.
    //
    //   ilOffset:
    //     The offset within MSIL code at which to mark the sequence point.
    //
    //   sequencePoint:
    //     Debug information that corresponds to the sequence point.
    public override void MarkSequencePoint(LambdaExpression method, int ilOffset, DebugInfoExpression sequencePoint)
    {
      Contract.Requires(method != null);
      Contract.Requires(sequencePoint != null);
    }
  }

}
#endif