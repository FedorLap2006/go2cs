﻿//******************************************************************************************************
//  Signature.cs - Gbtc
//
//  Copyright © 2018, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the MIT License (MIT), the "License"; you may not use this
//  file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://opensource.org/licenses/MIT
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  06/21/2018 - J. Ritchie Carroll
//       Generated original version of source code.
//
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;

namespace go2cs.Metadata
{
    [Serializable]
    public class Signature
    {
        public ParameterInfo[] Parameters;
        public ParameterInfo[] Result;

        public string GenerateParameterTypeList() => string.Join(", ", Parameters.Select(parameter => parameter.Type.PrimitiveName));

        public string GenerateParametersSignature(bool prefixByRef)
        {
            return string.Join(", ", GetParameters(prefixByRef));
        }

        public IEnumerable<String> GetParameters(bool prefixByRef)
        {
            return Parameters.Select(parameter => $"{parameter.Type.PrimitiveName} {(prefixByRef && parameter.Type.IsByRefPointer ? "_" : "")}{parameter.Name}");
        }

        public IEnumerable<String> GetByRefParameters(bool includeType)
        {
            return Parameters.Where(parameter => parameter.Type.IsByRefPointer).Select(parameter => $"{(includeType ? $"{parameter.Type.PrimitiveName} " : "_")}{parameter.Name}");
        }

        public string GenerateResultSignature()
        {
            if (Result.Length == 0)
                return "void";

            if (Result.Length > 1)
                return $"({string.Join(", ", Result.Select(parameter => parameter.Type.PrimitiveName))})";

            return Result[0].Type.PrimitiveName;
        }
    }
}
