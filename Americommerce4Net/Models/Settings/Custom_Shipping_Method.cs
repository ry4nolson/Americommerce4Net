#region License
//   Copyright 2014 Ken Worst - R.C. Worst & Company Inc.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 
#endregion

namespace Americommerce4Net.Models
{
    public class Custom_Shipping_Method : BaseAudit, IResource
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool is_enabled { get; set; }
        public bool is_default { get; set; }
        public string markup_type { get; set; }
        public string markup_amount { get; set; }
        public string description { get; set; }
        public bool use_base_rate { get; set; }
        public bool is_calculated_method { get; set; }
    }
}
