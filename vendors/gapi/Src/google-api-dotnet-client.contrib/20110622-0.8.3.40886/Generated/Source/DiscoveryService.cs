//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Discovery.V1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class DirectoryList : Google.Apis.Requests.IResponse {
        
        private IList<ItemsData> items;
        
        private string kind;
        
        private Google.Apis.Requests.RequestError error;
        
        /// <summary>The individual directory entries.  One entry per api/version pair.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual IList<ItemsData> Items {
            get {
                return this.items;
            }
            set {
                this.items = value;
            }
        }
        
        /// <summary>The kind for this response.</summary>
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
        
        public class ItemsData {
            
            private string description;
            
            private string discoveryLink;
            
            private string documentationLink;
            
            private IconsData icons;
            
            private string id;
            
            private string kind;
            
            private IList<System.String> labels;
            
            private string name;
            
            private bool preferred;
            
            private string title;
            
            private string version;
            
            /// <summary>The description of this API.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("description")]
            public virtual string Description {
                get {
                    return this.description;
                }
                set {
                    this.description = value;
                }
            }
            
            /// <summary>A link to the discovery document.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("discoveryLink")]
            public virtual string DiscoveryLink {
                get {
                    return this.discoveryLink;
                }
                set {
                    this.discoveryLink = value;
                }
            }
            
            /// <summary>A link to human readable documentation for the API.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("documentationLink")]
            public virtual string DocumentationLink {
                get {
                    return this.documentationLink;
                }
                set {
                    this.documentationLink = value;
                }
            }
            
            /// <summary>Links to 16x16 and 32x32 icons representing the API.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("icons")]
            public virtual IconsData Icons {
                get {
                    return this.icons;
                }
                set {
                    this.icons = value;
                }
            }
            
            /// <summary>The id of this API.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id {
                get {
                    return this.id;
                }
                set {
                    this.id = value;
                }
            }
            
            /// <summary>The kind for this response.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("kind")]
            public virtual string Kind {
                get {
                    return this.kind;
                }
                set {
                    this.kind = value;
                }
            }
            
            /// <summary>Labels for the status of this API, such as labs or deprecated.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("labels")]
            public virtual IList<System.String> Labels {
                get {
                    return this.labels;
                }
                set {
                    this.labels = value;
                }
            }
            
            /// <summary>The name of the API.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name {
                get {
                    return this.name;
                }
                set {
                    this.name = value;
                }
            }
            
            /// <summary>True if this version is the preferred version to use.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("preferred")]
            public virtual bool Preferred {
                get {
                    return this.preferred;
                }
                set {
                    this.preferred = value;
                }
            }
            
            /// <summary>The title of this API.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("title")]
            public virtual string Title {
                get {
                    return this.title;
                }
                set {
                    this.title = value;
                }
            }
            
            /// <summary>The version of the API.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("version")]
            public virtual string Version {
                get {
                    return this.version;
                }
                set {
                    this.version = value;
                }
            }
            
            /// <summary>Links to 16x16 and 32x32 icons representing the API.</summary>
            public class IconsData {
                
                private string x16;
                
                private string x32;
                
                /// <summary>The url of the 16x16 icon.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("x16")]
                public virtual string X16 {
                    get {
                        return this.x16;
                    }
                    set {
                        this.x16 = value;
                    }
                }
                
                /// <summary>The url of the 32x32 icon.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("x32")]
                public virtual string X32 {
                    get {
                        return this.x32;
                    }
                    set {
                        this.x32 = value;
                    }
                }
            }
        }
    }
    
    public class Jsonschema {
        
        private string refValue;
        
        private Jsonschema additionalProperties;
        
        private string defaultValue;
        
        private string description;
        
        private IList<System.String> enumValue;
        
        private IList<System.String> enumDescriptions;
        
        private string format;
        
        private string id;
        
        private Jsonschema items;
        
        private string location;
        
        private string maximum;
        
        private string minimum;
        
        private string pattern;
        
        private PropertiesData properties;
        
        private bool repeated;
        
        private bool required;
        
        private string type;
        
        /// <summary>A reference to another schema.  The value of this property is the &quot;id&quot; of another schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("$ref")]
        public virtual string Ref {
            get {
                return this.refValue;
            }
            set {
                this.refValue = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("additionalProperties")]
        public virtual Jsonschema AdditionalProperties {
            get {
                return this.additionalProperties;
            }
            set {
                this.additionalProperties = value;
            }
        }
        
        /// <summary>The default value of this property (if one exists).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("default")]
        public virtual string Default {
            get {
                return this.defaultValue;
            }
            set {
                this.defaultValue = value;
            }
        }
        
        /// <summary>A description of this object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description {
            get {
                return this.description;
            }
            set {
                this.description = value;
            }
        }
        
        /// <summary>Values this parameter may take (if it is an enum).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enum")]
        public virtual IList<System.String> Enum {
            get {
                return this.enumValue;
            }
            set {
                this.enumValue = value;
            }
        }
        
        /// <summary>The descriptions for the enums.  Each position maps to the corresponding value in the &quot;enum&quot; array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumDescriptions")]
        public virtual IList<System.String> EnumDescriptions {
            get {
                return this.enumDescriptions;
            }
            set {
                this.enumDescriptions = value;
            }
        }
        
        /// <summary>An additional regular expression or key that helps constrain the value. For more details see: http://tools.ietf.org/html/draft-zyp-json-schema-03#section-5.23</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format {
            get {
                return this.format;
            }
            set {
                this.format = value;
            }
        }
        
        /// <summary>Unique identifier for this schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual Jsonschema Items {
            get {
                return this.items;
            }
            set {
                this.items = value;
            }
        }
        
        /// <summary>Whether this parameter goes in the query or the path for REST requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location {
            get {
                return this.location;
            }
            set {
                this.location = value;
            }
        }
        
        /// <summary>The maximum value of this parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximum")]
        public virtual string Maximum {
            get {
                return this.maximum;
            }
            set {
                this.maximum = value;
            }
        }
        
        /// <summary>The minimum value of this parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimum")]
        public virtual string Minimum {
            get {
                return this.minimum;
            }
            set {
                this.minimum = value;
            }
        }
        
        /// <summary>The regular expression this parameter must conform to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pattern")]
        public virtual string Pattern {
            get {
                return this.pattern;
            }
            set {
                this.pattern = value;
            }
        }
        
        /// <summary>If this is a schema for an object, list the schema for each property of this object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual PropertiesData Properties {
            get {
                return this.properties;
            }
            set {
                this.properties = value;
            }
        }
        
        /// <summary>Whether this parameter may appear multiple times.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repeated")]
        public virtual bool Repeated {
            get {
                return this.repeated;
            }
            set {
                this.repeated = value;
            }
        }
        
        /// <summary>Whether the parameter is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("required")]
        public virtual bool Required {
            get {
                return this.required;
            }
            set {
                this.required = value;
            }
        }
        
        /// <summary>The value type for this schema.  A list of values can be found here: http://tools.ietf.org/html/draft-zyp-json-schema-03#section-5.1</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type {
            get {
                return this.type;
            }
            set {
                this.type = value;
            }
        }
        
        /// <summary>If this is a schema for an object, list the schema for each property of this object.</summary>
        public class PropertiesData {
        }
    }
    
    public class RestDescription : Google.Apis.Requests.IResponse {
        
        private AuthData auth;
        
        private string basePath;
        
        private string description;
        
        private string documentationLink;
        
        private IList<System.String> features;
        
        private IconsData icons;
        
        private string id;
        
        private string kind;
        
        private IList<System.String> labels;
        
        private MethodsData methods;
        
        private string name;
        
        private ParametersData parameters;
        
        private string protocol;
        
        private ResourcesData resources;
        
        private SchemasData schemas;
        
        private string title;
        
        private string version;
        
        private Google.Apis.Requests.RequestError error;
        
        /// <summary>Authentication information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auth")]
        public virtual AuthData Auth {
            get {
                return this.auth;
            }
            set {
                this.auth = value;
            }
        }
        
        /// <summary>The base URI path for REST requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basePath")]
        public virtual string BasePath {
            get {
                return this.basePath;
            }
            set {
                this.basePath = value;
            }
        }
        
        /// <summary>The description of this API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description {
            get {
                return this.description;
            }
            set {
                this.description = value;
            }
        }
        
        /// <summary>A link to human readable documentation for the API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentationLink")]
        public virtual string DocumentationLink {
            get {
                return this.documentationLink;
            }
            set {
                this.documentationLink = value;
            }
        }
        
        /// <summary>A list of supported features for this API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("features")]
        public virtual IList<System.String> Features {
            get {
                return this.features;
            }
            set {
                this.features = value;
            }
        }
        
        /// <summary>Links to 16x16 and 32x32 icons representing the API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icons")]
        public virtual IconsData Icons {
            get {
                return this.icons;
            }
            set {
                this.icons = value;
            }
        }
        
        /// <summary>The id of this API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
        
        /// <summary>The kind for this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        /// <summary>Labels for the status of this API, such as labs or deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual IList<System.String> Labels {
            get {
                return this.labels;
            }
            set {
                this.labels = value;
            }
        }
        
        /// <summary>API-level methods for this API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methods")]
        public virtual MethodsData Methods {
            get {
                return this.methods;
            }
            set {
                this.methods = value;
            }
        }
        
        /// <summary>The name of this API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name {
            get {
                return this.name;
            }
            set {
                this.name = value;
            }
        }
        
        /// <summary>Common parameters that apply across all apis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual ParametersData Parameters {
            get {
                return this.parameters;
            }
            set {
                this.parameters = value;
            }
        }
        
        /// <summary>The protocol described by this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol {
            get {
                return this.protocol;
            }
            set {
                this.protocol = value;
            }
        }
        
        /// <summary>The resources in this API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual ResourcesData Resources {
            get {
                return this.resources;
            }
            set {
                this.resources = value;
            }
        }
        
        /// <summary>The schemas for this API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemas")]
        public virtual SchemasData Schemas {
            get {
                return this.schemas;
            }
            set {
                this.schemas = value;
            }
        }
        
        /// <summary>The title of this API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title {
            get {
                return this.title;
            }
            set {
                this.title = value;
            }
        }
        
        /// <summary>The version of this API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version {
            get {
                return this.version;
            }
            set {
                this.version = value;
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
        
        /// <summary>Authentication information.</summary>
        public class AuthData {
            
            private Oauth2Data oauth2;
            
            /// <summary>OAuth 2.0 authentication information.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("oauth2")]
            public virtual Oauth2Data Oauth2 {
                get {
                    return this.oauth2;
                }
                set {
                    this.oauth2 = value;
                }
            }
            
            /// <summary>OAuth 2.0 authentication information.</summary>
            public class Oauth2Data {
                
                private ScopesData scopes;
                
                /// <summary>Available OAuth 2.0 scopes.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
                public virtual ScopesData Scopes {
                    get {
                        return this.scopes;
                    }
                    set {
                        this.scopes = value;
                    }
                }
                
                /// <summary>Available OAuth 2.0 scopes.</summary>
                public class ScopesData {
                }
            }
        }
        
        /// <summary>Links to 16x16 and 32x32 icons representing the API.</summary>
        public class IconsData {
            
            private string x16;
            
            private string x32;
            
            /// <summary>The url of the 16x16 icon.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("x16")]
            public virtual string X16 {
                get {
                    return this.x16;
                }
                set {
                    this.x16 = value;
                }
            }
            
            /// <summary>The url of the 32x32 icon.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("x32")]
            public virtual string X32 {
                get {
                    return this.x32;
                }
                set {
                    this.x32 = value;
                }
            }
        }
        
        /// <summary>API-level methods for this API.</summary>
        public class MethodsData {
        }
        
        /// <summary>Common parameters that apply across all apis.</summary>
        public class ParametersData {
        }
        
        /// <summary>The resources in this API.</summary>
        public class ResourcesData {
        }
        
        /// <summary>The schemas for this API.</summary>
        public class SchemasData {
        }
    }
    
    public class Restmethod {
        
        private string description;
        
        private string httpMethod;
        
        private string id;
        
        private IList<System.String> parameterOrder;
        
        private ParametersData parameters;
        
        private string path;
        
        private RequestData request;
        
        private ResponseData response;
        
        private IList<System.String> scopes;
        
        /// <summary>Description of this method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description {
            get {
                return this.description;
            }
            set {
                this.description = value;
            }
        }
        
        /// <summary>HTTP method used by this method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpMethod")]
        public virtual string HttpMethod {
            get {
                return this.httpMethod;
            }
            set {
                this.httpMethod = value;
            }
        }
        
        /// <summary>A unique ID for this method.  This property can be used to match methods between different versions of Discovery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
        
        /// <summary>Ordered list of required parameters, serves as a hint to clients on how to structure their method signatures.  The array is ordered such that the &quot;most-significant&quot; parameter appears first.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterOrder")]
        public virtual IList<System.String> ParameterOrder {
            get {
                return this.parameterOrder;
            }
            set {
                this.parameterOrder = value;
            }
        }
        
        /// <summary>Details for all parameters in this method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual ParametersData Parameters {
            get {
                return this.parameters;
            }
            set {
                this.parameters = value;
            }
        }
        
        /// <summary>The URI path of this REST method.  Should be used in conjunction with the restBasePath property at the api-level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path {
            get {
                return this.path;
            }
            set {
                this.path = value;
            }
        }
        
        /// <summary>The schema for the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual RequestData Request {
            get {
                return this.request;
            }
            set {
                this.request = value;
            }
        }
        
        /// <summary>The schema for the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual ResponseData Response {
            get {
                return this.response;
            }
            set {
                this.response = value;
            }
        }
        
        /// <summary>OAuth 2.0 scopes applicable to this method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual IList<System.String> Scopes {
            get {
                return this.scopes;
            }
            set {
                this.scopes = value;
            }
        }
        
        /// <summary>Details for all parameters in this method.</summary>
        public class ParametersData {
        }
        
        /// <summary>The schema for the request.</summary>
        public class RequestData {
            
            private string refValue;
            
            /// <summary>Schema ID for the request schema.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("$ref")]
            public virtual string Ref {
                get {
                    return this.refValue;
                }
                set {
                    this.refValue = value;
                }
            }
        }
        
        /// <summary>The schema for the response.</summary>
        public class ResponseData {
            
            private string refValue;
            
            /// <summary>Schema ID for the response schema.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("$ref")]
            public virtual string Ref {
                get {
                    return this.refValue;
                }
                set {
                    this.refValue = value;
                }
            }
        }
    }
    
    public class Restresource {
        
        private MethodsData methods;
        
        private ResourcesData resources;
        
        /// <summary>Methods on this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methods")]
        public virtual MethodsData Methods {
            get {
                return this.methods;
            }
            set {
                this.methods = value;
            }
        }
        
        /// <summary>Sub-resources on this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual ResourcesData Resources {
            get {
                return this.resources;
            }
            set {
                this.resources = value;
            }
        }
        
        /// <summary>Methods on this resource.</summary>
        public class MethodsData {
        }
        
        /// <summary>Sub-resources on this resource.</summary>
        public class ResourcesData {
        }
    }
}
namespace Google.Apis.Discovery.V1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public class DiscoveryService : Google.Apis.Discovery.IRequestExecutor, Google.Apis.Discovery.ISchemaAwareRequestExecutor {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string Version = "v1";
        
        private const string Name = "discovery";
        
        private const string BaseUri = "https://www.googleapis.com/discovery/v1/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string developerKey;
        
        private ApisResource apis;
        
        public DiscoveryService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this.apis = new ApisResource(this);
        }
        
        public DiscoveryService() : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.WebDiscoveryDevice(new System.Uri(string.Format("https://www.googleapis.com/discovery/v1/apis/{0}/{1}/rest", DiscoveryService.Name, DiscoveryService.Version)))).GetService(DiscoveryService.Version, DiscoveryService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameterV1_0(new System.Uri(DiscoveryService.BaseUri))), Google.Apis.Authentication.AuthenticatorFactory.GetInstance().GetRegisteredAuthenticator()) {
        }
        
        /// <summary>Sets the DeveloperKey which this service uses for all requests</summary>
        public virtual string DeveloperKey {
            get {
                return this.developerKey;
            }
            set {
                this.developerKey = value;
            }
        }
        
        public virtual ApisResource Apis {
            get {
                return this.apis;
            }
        }
        
        public virtual System.IO.Stream ExecuteRequest(string resource, string method, string body, System.Collections.Generic.IDictionary<string, object> parameters) {
            Google.Apis.Requests.IRequest request = this.genericService.CreateRequest(resource, method);
            if (string.IsNullOrEmpty(DeveloperKey) == false) {
                request = request.WithDeveloperKey(this.DeveloperKey);
            }
            return request.WithParameters(parameters).WithAuthentication(authenticator).WithBody(body).ExecuteRequest();
        }
        
        public virtual System.IO.Stream ExecuteRequest(string resource, string method, object body, System.Collections.Generic.IDictionary<string, object> parameters) {
            return this.ExecuteRequest(resource, method, this.ObjectToJson(body), parameters);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            genericService.Serializer = serializer;
        }
        
        public virtual string ObjectToJson(object obj) {
            return genericService.SerializeRequest(obj);
        }
        
        public virtual T JsonToObject<T>(System.IO.Stream stream)
         {
            return genericService.DeserializeResponse<T>(stream);
        }
    }
    
    public class ApisResource {
        
        private Google.Apis.Discovery.ISchemaAwareRequestExecutor service;
        
        private const string Resource = "apis";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(ApisResource));
        
        public ApisResource(DiscoveryService service) {
            this.service = service;
        }
        
        /// <summary>Retrieve the description of a particular version of an api.</summary>
        /// <param name="api">Required - The name of the API.</param>
        /// <param name="version">Required - The version of the API.</param>
        public virtual System.IO.Stream GetRestAsStream(string api, string version) {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["api"] = api;
            parameters["version"] = version;
            logger.Debug("Executing apis.getRest");
            System.IO.Stream ret = this.service.ExecuteRequest(ApisResource.Resource, "getRest", body, parameters);
            logger.Debug("Done Executing apis.getRest");
            return ret;
        }
        
        /// <summary>Retrieve the list of APIs supported at this endpoint.</summary>
        /// <param name="label">Optional - Must be one of the following values [deprecated, graduated, labs] - Only include APIs with a matching label, such as &apos;graduated&apos; or &apos;labs&apos;.</param>
        /// <param name="name">Optional - Only include APIs with the given name.</param>
        /// <param name="preferred">Optional - Return only the preferred version of an API.</param>
        public virtual System.IO.Stream ListAsStream(Label? label, string name, System.Boolean? preferred) {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["label"] = label;
            parameters["name"] = name;
            parameters["preferred"] = preferred;
            logger.Debug("Executing apis.list");
            System.IO.Stream ret = this.service.ExecuteRequest(ApisResource.Resource, "list", body, parameters);
            logger.Debug("Done Executing apis.list");
            return ret;
        }
        
        /// <summary>Retrieve the description of a particular version of an api.</summary>
        /// <param name="api">Required - The name of the API.</param>
        /// <param name="version">Required - The version of the API.</param>
        public virtual Google.Apis.Discovery.V1.Data.RestDescription GetRest(string api, string version) {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["api"] = api;
            parameters["version"] = version;
            logger.Debug("Executing apis.getRest");
            Google.Apis.Discovery.V1.Data.RestDescription ret = this.service.JsonToObject<Google.Apis.Discovery.V1.Data.RestDescription>(this.service.ExecuteRequest(ApisResource.Resource, "getRest", body, parameters));
            logger.Debug("Done Executing apis.getRest");
            return ret;
        }
        
        /// <summary>Retrieve the list of APIs supported at this endpoint.</summary>
        /// <param name="label">Optional - Must be one of the following values [deprecated, graduated, labs] - Only include APIs with a matching label, such as &apos;graduated&apos; or &apos;labs&apos;.</param>
        /// <param name="name">Optional - Only include APIs with the given name.</param>
        /// <param name="preferred">Optional - Return only the preferred version of an API.</param>
        public virtual Google.Apis.Discovery.V1.Data.DirectoryList List(Label? label, string name, System.Boolean? preferred) {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["label"] = label;
            parameters["name"] = name;
            parameters["preferred"] = preferred;
            logger.Debug("Executing apis.list");
            Google.Apis.Discovery.V1.Data.DirectoryList ret = this.service.JsonToObject<Google.Apis.Discovery.V1.Data.DirectoryList>(this.service.ExecuteRequest(ApisResource.Resource, "list", body, parameters));
            logger.Debug("Done Executing apis.list");
            return ret;
        }
        
        /// <summary>Only include APIs with a matching label, such as &apos;graduated&apos; or &apos;labs&apos;.</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Label {
            
            /// <summary>APIs that have been deprecated.</summary>
            [Google.Apis.Util.StringValueAttribute("deprecated")]
            Deprecated,
            
            /// <summary>Supported APIs that have graduated from labs.</summary>
            [Google.Apis.Util.StringValueAttribute("graduated")]
            Graduated,
            
            /// <summary>APIs that are experimental</summary>
            [Google.Apis.Util.StringValueAttribute("labs")]
            Labs,
        }
    }
}
