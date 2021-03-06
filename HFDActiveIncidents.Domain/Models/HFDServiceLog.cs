// HFD Active Incidents
// Copyright � 2014 David M. Wilson
// https://twitter.com/dmwilson_dev
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;

namespace HFDActiveIncidents.Domain.Models
{
    public partial class HFDServiceLog
    {
        public long Id { get; set; }
        public System.DateTime LoggedDT { get; set; }
        public int Level { get; set; }
        public string Source { get; set; }
        public string Message { get; set; }
        public string ExceptionText { get; set; }
    }
}
