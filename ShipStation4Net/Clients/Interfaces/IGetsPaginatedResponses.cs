﻿#region License
/*
 * Copyright 2017 Brandon James
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */
#endregion

using ShipStation4Net.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShipStation4Net.Clients.Interfaces
{
    internal interface IGetsPaginatedResponses<T, FilterType>
        where FilterType: class, IFilter
    {
        Task<IList<T>> GetPageRangeAsync(int start, int end, int pageSize = 100, FilterType filter = null);
        Task<IList<T>> GetPageAsync(int page, int pageSize = 100, FilterType filter = null);
        Task<IList<T>> GetAllPagesAsync(FilterType filter);
    }
}
