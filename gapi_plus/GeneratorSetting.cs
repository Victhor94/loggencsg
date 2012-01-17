﻿using System.Collections.Generic;
using Core;

namespace gapi_plus {
	internal class GeneratorSetting : Core.GeneratorSetting {
		public Visualizers.Types VisLogs {
			get;
			set;
		}

		public Dictionary<Visualizers.Types, string> LogFiles {
			get;
			set;
		}

		public Dictionary<Visualizers.Types, GeneratorLogsMeth> Methods {
			get;
			set;
		}

		public Dictionary<Visualizers.Types, Dictionary<Rules, string>> Rules {
			get;
			set;
		}

		public string ProfileID {
			get;
			set;
		}

		public Google.Apis.Plus.v1.ActivitiesResource.Collection Collection {
			get;
			set;
		}

		public int MaxResults {
			get;
			set;
		}

		public GeneratorSetting() {
			Collection = Google.Apis.Plus.v1.ActivitiesResource.Collection.Public;
		}

		public GeneratorSetting Clone() {
			return new GeneratorSetting() {
				VisLogs = this.VisLogs,
				LogFiles = this.LogFiles,
				Methods = this.Methods,
				Rules = this.Rules,
				ProfileID = this.ProfileID,
				Collection = this.Collection,
				MaxResults = this.MaxResults
			};
		}
	}
}
