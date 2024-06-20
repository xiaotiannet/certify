/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Dnspod.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDomainAnalyticsResponse : AbstractModel
    {
        
        /// <summary>
        /// 当前统计维度解析量小计
        /// </summary>
        [JsonProperty("Data")]
        public DomainAnalyticsDetail[] Data{ get; set; }

        /// <summary>
        /// 域名解析量统计查询信息
        /// </summary>
        [JsonProperty("Info")]
        public DomainAnalyticsInfo Info{ get; set; }

        /// <summary>
        /// 域名别名解析量统计信息
        /// </summary>
        [JsonProperty("AliasData")]
        public DomainAliasAnalyticsItem[] AliasData{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamObj(map, prefix + "Info.", this.Info);
            this.SetParamArrayObj(map, prefix + "AliasData.", this.AliasData);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

