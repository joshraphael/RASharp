namespace RASharp.Http;

public class Request
{
    public string Host { get; set; }
    public string Path { get; set; }
    public HttpMethod Method { get; set; }
    public Dictionary<string, string> QueryParameters { get; set; }
    public Dictionary<string, string> Headers { get; set; }
    public Request()
    {
        this.Host = "";
        this.Path = "";
        this.Method = HttpMethod.Get;
        this.QueryParameters = new Dictionary<string, string>();
        this.Headers = new Dictionary<string, string>();
    }
}

public class RequestBuilder
{
    private readonly Request _request;

    public RequestBuilder()
    {
        this._request = new Request();
    }

    /// <summary>
    /// Sets the URL hostname of the request.
    /// </summary>
    /// <param name="host">The hostname</param>
    /// <returns>RequestBuilder</returns>
    public RequestBuilder Host(string host)
    {
        _request.Host = host;
        return this;
    }

    /// <summary>
    /// Sets the URL path of the request.
    /// </summary>
    /// <param name="path">The URL path</param>
    /// <returns>RequestBuilder</returns>
    public RequestBuilder Path(string path)
    {
        _request.Path = path;
        return this;
    }

    /// <summary>
    /// Sets the HTTP method of the request.
    /// </summary>
    /// <param name="method">The HTTP method verb</param>
    /// <returns>RequestBuilder</returns>
    public RequestBuilder Method(HttpMethod method)
    {
        _request.Method = method;
        return this;
    }

    /// <summary>
    /// Adds a query parameter key/value pair to the request.
    /// </summary>
    /// <param name="key">The query key</param>
    /// <param name="value">The query value</param>
    /// <returns>RequestBuilder</returns>
    public RequestBuilder QueryParameter(string key, string value)
    {
        _request.QueryParameters[key] = value;
        return this;
    }

    /// <summary>
    /// Adds a header key/value pair to the request.
    /// </summary>
    /// <param name="key">The header key</param>
    /// <param name="value">The header value</param>
    /// <returns>RequestBuilder</returns>
    public RequestBuilder Header(string key, string value)
    {
        _request.Headers[key] = value;
        return this;
    }

    /// <summary>
    /// Adds a 'a' number to the query parameters.
    /// </summary>
    /// <param name="value">The value of A</param>
    /// <returns>RequestBuilder</returns>
    public RequestBuilder A(int value)
    {
        return this.QueryParameter("a", value.ToString());
    }

    /// <summary>
    /// Adds a 'c' number to the query parameters.
    /// </summary>
    /// <param name="value">The value of C</param>
    /// <returns>RequestBuilder</returns>
    public RequestBuilder C(int value)
    {
        return this.QueryParameter("c", value.ToString());
    }

    /// <summary>
    /// Adds a 'd' string to the query parameters.
    /// </summary>
    /// <param name="value">The value of D</param>
    /// <returns>RequestBuilder</returns>
    public RequestBuilder D(string value)
    {
        return this.QueryParameter("d", value);
    }

    /// <summary>
    /// Adds a 'f' number to the query parameters.
    /// </summary>
    /// <param name="value">The value of F</param>
    /// <returns>RequestBuilder</returns>
    public RequestBuilder F(long value)
    {
        return this.QueryParameter("f", value.ToString());
    }

    /// <summary>
    /// Adds a 'g' number to the query parameters.
    /// </summary>
    /// <param name="value">The value of G</param>
    /// <returns>RequestBuilder</returns>
    public RequestBuilder G(int value)
    {
        return this.QueryParameter("g", value.ToString());
    }

    /// <summary>
    /// Adds a 'h' number to the query parameters.
    /// </summary>
    /// <param name="value">The value of H</param>
    /// <returns>RequestBuilder</returns>
    public RequestBuilder H(int value)
    {
        return this.QueryParameter("h", value.ToString());
    }

    /// <summary>
    /// Adds a list of 'i' strings to the query parameters.
    /// </summary>
    /// <param name="values">The values of I</param>
    /// <returns>RequestBuilder</returns>
    public RequestBuilder I(string[] values)
    {
        return this.QueryParameter("i", String.Join(",", values));
    }

    /// <summary>
    /// Adds a list of 'k' strings to the query parameters.
    /// </summary>
    /// <param name="values">The values of K</param>
    /// <returns>RequestBuilder</returns>
    public RequestBuilder K(string[] values)
    {
        return this.QueryParameter("k", String.Join(",", values));
    }

    /// <summary>
    /// Adds a 'm' number to the query parameters.
    /// </summary>
    /// <param name="value">The value of M</param>
    /// <returns>RequestBuilder</returns>
    public RequestBuilder M(int value)
    {
        return this.QueryParameter("m", value.ToString());
    }

    /// <summary>
    /// Adds a 'o' number to the query parameters.
    /// </summary>
    /// <param name="value">The value of O</param>
    /// <returns>RequestBuilder</returns>
    public RequestBuilder O(int value)
    {
        return this.QueryParameter("o", value.ToString());
    }

    /// <summary>
    /// Adds a 'r' string to the query parameters.
    /// </summary>
    /// <param name="value">The value of R</param>
    /// <returns>RequestBuilder</returns>
    public RequestBuilder R(string value)
    {
        return this.QueryParameter("r", value.ToString());
    }

    /// <summary>
    /// Adds a 't' string to the query parameters.
    /// </summary>
    /// <param name="value">The value of T</param>
    /// <returns>RequestBuilder</returns>
    public RequestBuilder T(string value)
    {
        return this.QueryParameter("t", value.ToString());
    }

    /// <summary>
    /// Adds a 'u' string to the query parameters.
    /// </summary>
    /// <param name="value">The value of U</param>
    /// <returns>RequestBuilder</returns>
    public RequestBuilder U(string value)
    {
        return this.QueryParameter("u", value.ToString());
    }

    /// <summary>
    /// Adds a 'y' string to the query parameters.
    /// </summary>
    /// <param name="value">The value of Y</param>
    /// <returns>RequestBuilder</returns>
    public RequestBuilder Y(string value)
    {
        return this.QueryParameter("y", value.ToString());
    }

    /// <summary>
    /// Sets a Bearer Token Authorization header.
    /// </summary>
    /// <param name="value">The Bearer Token</param>
    /// <returns>RequestBuilder</returns>
    public RequestBuilder BearerToken(string token)
    {
        return this.Header("Authorization", string.Format("Bearer {0}", token));
    }

    /// <summary>
    /// Sets a User-Agent header.
    /// </summary>
    /// <param name="value">The Bearer Token</param>
    /// <returns>RequestBuilder</returns>
    public RequestBuilder UserAgent(string userAgent)
    {
        return this.Header("User-Agent", userAgent);
    }

    /// <summary>
    /// Builds the HTTP request object.
    /// </summary>
    /// <returns>Request</returns>
    public Request Build()
    {
        return this._request;
    }
}