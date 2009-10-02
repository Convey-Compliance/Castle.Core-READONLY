﻿// Copyright 2004-2009 Castle Project - http://www.castleproject.org/
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

namespace Castle.Components.DictionaryAdapter
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public interface IDictionaryAdapter
	{
		Type Type { get; }

		bool IsEditing { get; }

		bool WantsPropertyChangeNotification { get; }

		IDictionary State { get; }

		IDictionary Dictionary { get; }

		PropertyDescriptor Descriptor { get; }

		IDictionary<String, PropertyDescriptor> Properties { get; }

		IDictionaryAdapterFactory Factory { get; }

		IDictionaryValidator Validator { get; set; }

		object GetProperty(string propertyName);

		T GetPropertyOfType<T>(string propertyName);

		bool SetProperty(string propertyName, ref object value);

		void FetchProperties();
	}
}
