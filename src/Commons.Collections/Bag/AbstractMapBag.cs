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

namespace Commons.Collections.Bag
{
    [CLSCompliant(true)]
    public abstract class AbstractMapBag<TItem> : IBag<TItem>
    {
        public int GetCount(TItem item)
        {
            throw new NotImplementedException();
        }

        public void Add(TItem item, int copies = 1)
        {
            throw new NotImplementedException();
        }

        public bool Remove(TItem item, int copies = 1)
        {
            throw new NotImplementedException();
        }

        public ISet<TItem> UniqueSet()
        {
            throw new NotImplementedException();
        }

        public bool ContainsAll(ICollection<TItem> collection)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAll(ICollection<TItem> collection)
        {
            throw new NotImplementedException();
        }

        public bool RetainAll(ICollection<TItem> collection)
        {
            throw new NotImplementedException();
        }

        public void Add(TItem item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(TItem item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(TItem[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(TItem item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<TItem> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
