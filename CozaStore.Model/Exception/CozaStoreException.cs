// <copyright file="CozaStoreException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.Exception
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CozaStoreException : Exception
    {
        public CozaStoreException()
        {
        }

        public CozaStoreException(string message)
            : base(message)
        {
        }

        public CozaStoreException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
