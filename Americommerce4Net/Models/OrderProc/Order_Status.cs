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

using System;

namespace Americommerce4Net.Models
{
    public class Order_Status : BaseAudit, IResource
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool is_open { get; set; }
        public bool is_declined { get; set; }
        public bool is_cancelled { get; set; }
        public bool is_shipped { get; set; }
        public string color { get; set; }
        public int? email_template_id { get; set; }
        public bool is_fully_refunded { get; set; }
        public bool is_partially_refunded { get; set; }
        public bool is_quote_status { get; set; }
    }
}
