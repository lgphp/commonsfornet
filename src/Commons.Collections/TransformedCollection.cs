﻿// Copyright CommonsForNET. Author: Gujun Yang. email: gujun.yang@gmail.com
// Licensed to the Apache Software Foundation (ASF) under one or more
// contributor license agreements. See the NOTICE file distributed with
// this work for additional information regarding copyright ownership.
// The ASF licenses this file to You under the Apache License, Version 2.0
// (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Collections
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    [CLSCompliant(true)]
    public class TransformedCollection<TItem> : AbstractCollectionDecorator<TItem>
    {
        private readonly Func<TItem, TItem> transform;
        public TransformedCollection(ICollection<TItem> collection, Func<TItem, TItem> transform) : base(collection)
        {
            this.transform = transform;
        }

        public override void Add(TItem item)
        {
            Decorated.Add(transform(item));
        }

        public virtual void AddAll(ICollection<TItem> items)
        {
            foreach (var i in items)
            {
                Decorated.Add(transform(i));
            }
        }
    }
}
