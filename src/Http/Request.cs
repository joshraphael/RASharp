namespace RASharp.Http
{
    public class Request
    {
        public string Host { get; set; }
        public string Path { get; set; }
        public string Method { get; set; }
        public Dictionary<string, string> QueryParameters { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public Request()
        {
            this.Host = "";
            this.Path = "";
            this.Method = "";
            this.QueryParameters = new Dictionary<string, string>();
            this.Headers = new Dictionary<string, string>();
        }
    }
    public class RequestBuilder
    {
        private readonly Request _request = new Request();
        public RequestBuilder Host(string host)
        {
            _request.Host = host;
            return this;
        }
        public RequestBuilder Path(string path)
        {
            _request.Path = path;
            return this;
        }
        public RequestBuilder Method(string method)
        {
            _request.Method = method;
            return this;
        }
        public RequestBuilder QueryParameter(string key, string value)
        {
            _request.QueryParameters[key] = value;
            return this;
        }
        public RequestBuilder Header(string key, string value)
        {
            _request.Headers[key] = value;
            return this;
        }
        public Request Build()
        {
            return this._request;
        }
    }
}