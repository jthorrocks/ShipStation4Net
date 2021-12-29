﻿#region License
/*
 * Copyright 2021 MarketVision Consulting Group
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

using Newtonsoft.Json;
using ShipStation4Net.Domain.Enumerations;
using System.Collections.Generic;

namespace ShipStation4Net.Domain.Entities
{
    public class Webhook
    {
        [JsonProperty("IsLabelAPIHook")]
        public bool? IsLabelApiHook { get; set; }

        [JsonProperty("WebHookID")]
        public int? WebhookId { get; set; }

        [JsonProperty("SellerID")]
        public int? SellerId { get; set; }

        [JsonProperty("StoreId")]
        public int? StoreId { get; set; }

        [JsonProperty("HookType")]
        public WebhookEvents? HookType { get; set; }

        [JsonProperty("MessageFormat")]
        public string MessageFormat { get; set; }

        [JsonProperty("Url")]
        public string Url { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Active")]
        public bool? IsActive { get; set; }
    }
}
