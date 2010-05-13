﻿using System;
// Copyright 2004-2009 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System.Collections;

namespace Castle.Components.DictionaryAdapter.Tests
{
	public class CreateHashtableStrategy : DictionaryBehaviorAttribute, IDictionaryMetaInitializer,
										   IDictionaryCreateStrategy
	{
		public void Initialize(IDictionaryAdapterFactory factory, DictionaryAdapterMeta dictionaryMeta)
		{
			dictionaryMeta.CreateStrategy = this;
		}

		object IDictionaryCreateStrategy.Create(IDictionaryAdapter adapter, Type type, IDictionary dictionary)
		{
			dictionary = dictionary ?? new Hashtable();
			return adapter.This.Factory.GetAdapter(type, dictionary, adapter.This.Descriptor); ;
		}
	}
}