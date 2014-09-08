﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using Extensions;

namespace BungieNetPlatform.Responses {
	public class FollowersResponse : QueryableResponse {

		public ICollection<User> Followers;


		public FollowersResponse(JObject j) : base(j) {

			Followers = new List<User>();

			if(j["results"] != null) {
				j["results"].Cast<JObject>().ForEach(u => Followers.Add(new User(u)));
			}

		}

	}
}