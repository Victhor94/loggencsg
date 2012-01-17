//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5420
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Webfonts.v1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class Webfont {
        
        private string family;
        
        private string kind;
        
        private string subsets;
        
        private string variants;
        
        /// <summary>The name of the font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("family")]
        public virtual string Family {
            get {
                return this.family;
            }
            set {
                this.family = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        /// <summary>The scripts supported by the font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subsets")]
        public virtual string Subsets {
            get {
                return this.subsets;
            }
            set {
                this.subsets = value;
            }
        }
        
        /// <summary>The available variants for the font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variants")]
        public virtual string Variants {
            get {
                return this.variants;
            }
            set {
                this.variants = value;
            }
        }
    }
    
    public class WebfontList : Google.Apis.Requests.IDirectResponseSchema {
        
        private IList<Webfont> items;
        
        private string kind;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        /// <summary>The list of fonts currently served by the Google Fonts API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual IList<Webfont> Items {
            get {
                return this.items;
            }
            set {
                this.items = value;
            }
        }
        
        /// <summary>The object kind.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this.error;
            }
            set {
                this.error = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this.eTag;
            }
            set {
                this.eTag = value;
            }
        }
    }
}
namespace Google.Apis.Webfonts.v1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public partial class WebfontsService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string DiscoveryDocument = "{\"kind\":\"discovery#restDescription\",\"id\":\"webfonts:v1\",\"name\":\"webfonts\",\"version" +
            "\":\"v1\",\"title\":\"Google Web Fonts Developer API\",\"description\":\"The Google Web Fo" +
            "nts Developer API.\",\"icons\":{\"x16\":\"http://www.google.com/images/icons/feature/f" +
            "ont_api-16.png\",\"x32\":\"http://www.google.com/images/icons/feature/font_api-32.gi" +
            "f\"},\"documentationLink\":\"http://code.google.com/apis/webfonts/docs/developer_api" +
            ".html\",\"labels\":[\"labs\"],\"protocol\":\"rest\",\"basePath\":\"/webfonts/v1/\",\"parameter" +
            "s\":{\"alt\":{\"type\":\"string\",\"description\":\"Data format for the response.\",\"defaul" +
            "t\":\"json\",\"enum\":[\"json\"],\"enumDescriptions\":[\"Responses with Content-Type of ap" +
            "plication/json\"],\"location\":\"query\"},\"fields\":{\"type\":\"string\",\"description\":\"Se" +
            "lector specifying which fields to include in a partial response.\",\"location\":\"qu" +
            "ery\"},\"key\":{\"type\":\"string\",\"description\":\"API key. Your API key identifies you" +
            "r project and provides you with API access, quota, and reports. Required unless " +
            "you provide an OAuth 2.0 token.\",\"location\":\"query\"},\"oauth_token\":{\"type\":\"stri" +
            "ng\",\"description\":\"OAuth 2.0 token for the current user.\",\"location\":\"query\"},\"p" +
            "rettyPrint\":{\"type\":\"boolean\",\"description\":\"Returns response with indentations " +
            "and line breaks.\",\"default\":\"true\",\"location\":\"query\"},\"quotaUser\":{\"type\":\"stri" +
            "ng\",\"description\":\"Available to use for quota purposes for server-side applicati" +
            "ons. Can be any arbitrary string assigned to a user, but should not exceed 40 ch" +
            "aracters. Overrides userIp if both are provided.\",\"location\":\"query\"},\"userIp\":{" +
            "\"type\":\"string\",\"description\":\"IP address of the site where the request originat" +
            "es. Use this if you want to enforce per-user limits.\",\"location\":\"query\"}},\"sche" +
            "mas\":{\"Webfont\":{\"id\":\"Webfont\",\"type\":\"object\",\"properties\":{\"family\":{\"type\":\"" +
            "any\",\"description\":\"The name of the font.\"},\"kind\":{\"type\":\"string\",\"default\":\"w" +
            "ebfonts#webfont\"},\"subsets\":{\"type\":\"any\",\"description\":\"The scripts supported b" +
            "y the font.\"},\"variants\":{\"type\":\"any\",\"description\":\"The available variants for" +
            " the font.\"}}},\"WebfontList\":{\"id\":\"WebfontList\",\"type\":\"object\",\"properties\":{\"" +
            "items\":{\"type\":\"array\",\"description\":\"The list of fonts currently served by the " +
            "Google Fonts API.\",\"items\":{\"$ref\":\"Webfont\"}},\"kind\":{\"type\":\"string\",\"descript" +
            "ion\":\"The object kind.\",\"default\":\"webfonts#webfontList\"}}}},\"resources\":{\"webfo" +
            "nts\":{\"methods\":{\"list\":{\"id\":\"webfonts.webfonts.list\",\"path\":\"webfonts\",\"httpMe" +
            "thod\":\"GET\",\"description\":\"Retrieves the list of fonts currently served by the G" +
            "oogle Web Fonts Developer API\",\"parameters\":{\"sort\":{\"type\":\"string\",\"descriptio" +
            "n\":\"Enables sorting of the list\",\"enum\":[\"alpha\",\"date\",\"popularity\",\"style\",\"tr" +
            "ending\"],\"enumDescriptions\":[\"Sort alphabetically\",\"Sort by date added\",\"Sort by" +
            " popularity\",\"Sort by number of styles\",\"Sort by trending\"],\"location\":\"query\"}}" +
            ",\"response\":{\"$ref\":\"WebfontList\"}}}}}}";
        
        private const string Version = "v1";
        
        private const string Name = "webfonts";
        
        private const string BaseUri = "https://www.googleapis.com/webfonts/v1/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string key;
        
        protected WebfontsService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this.webfonts = new WebfontsResource(this);
        }
        
        public WebfontsService() : 
                this(Google.Apis.Authentication.NullAuthenticator.Instance) {
        }
        
        public WebfontsService(Google.Apis.Authentication.IAuthenticator authenticator) : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.StringDiscoveryDevice(DiscoveryDocument)).GetService(WebfontsService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameterV1_0(new System.Uri(WebfontsService.BaseUri))), authenticator) {
        }
        
        /// <summary>Sets the API-Key (or DeveloperKey) which this service uses for all requests</summary>
        public virtual string Key {
            get {
                return this.key;
            }
            set {
                this.key = value;
            }
        }
        
        public virtual Google.Apis.Requests.IRequest CreateRequest(string resource, string method) {
            Google.Apis.Requests.IRequest request = this.genericService.CreateRequest(resource, method);
            if (!string.IsNullOrEmpty(Key)) {
                request = request.WithKey(this.Key);
            }
            return request.WithAuthentication(authenticator);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            genericService.Serializer = serializer;
        }
        
        public virtual string SerializeObject(object obj) {
            return genericService.SerializeRequest(obj);
        }
        
        public virtual T DeserializeResponse<T>(Google.Apis.Requests.IResponse response)
         {
            return genericService.DeserializeResponse<T>(response);
        }
    }
    
    public class WebfontsResource {
        
        private Google.Apis.Discovery.IRequestProvider service;
        
        private const string Resource = "webfonts";
        
        public WebfontsResource(WebfontsService service) {
            this.service = service;
        }
        
        /// <summary>Retrieves the list of fonts currently served by the Google Web Fonts Developer API</summary>
        public virtual ListRequest List() {
            return new ListRequest(service);
        }
        
        /// <summary>Enables sorting of the list</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Sort {
            
            /// <summary>Sort alphabetically</summary>
            [Google.Apis.Util.StringValueAttribute("alpha")]
            Alpha,
            
            /// <summary>Sort by date added</summary>
            [Google.Apis.Util.StringValueAttribute("date")]
            Date,
            
            /// <summary>Sort by popularity</summary>
            [Google.Apis.Util.StringValueAttribute("popularity")]
            Popularity,
            
            /// <summary>Sort by number of styles</summary>
            [Google.Apis.Util.StringValueAttribute("style")]
            Style,
            
            /// <summary>Sort by trending</summary>
            [Google.Apis.Util.StringValueAttribute("trending")]
            Trending,
        }
        
        public class ListRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Webfonts.v1.Data.WebfontList> {
            
            private string oauth_token;
            
            private System.Boolean? prettyPrint;
            
            private string quotaUser;
            
            private Sort? sort;
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service) : 
                    base(service) {
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token")]
            public virtual string Oauth_token {
                get {
                    return this.oauth_token;
                }
                set {
                    this.oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint")]
            public virtual System.Boolean? PrettyPrint {
                get {
                    return this.prettyPrint;
                }
                set {
                    this.prettyPrint = value;
                }
            }
            
            /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser")]
            public virtual string QuotaUser {
                get {
                    return this.quotaUser;
                }
                set {
                    this.quotaUser = value;
                }
            }
            
            /// <summary>Enables sorting of the list</summary>
            [Google.Apis.Util.RequestParameterAttribute("sort")]
            public virtual Sort? Sort {
                get {
                    return this.sort;
                }
                set {
                    this.sort = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "webfonts";
                }
            }
            
            protected override string MethodName {
                get {
                    return "list";
                }
            }
        }
    }
    
    public partial class WebfontsService {
        
        private const string Resource = "";
        
        private WebfontsResource webfonts;
        
        private Google.Apis.Discovery.IRequestProvider service {
            get {
                return this;
            }
        }
        
        public virtual WebfontsResource Webfonts {
            get {
                return this.webfonts;
            }
        }
    }
}
