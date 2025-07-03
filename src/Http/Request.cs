using System.Web;

namespace RASharp.Http;


public class Request
{
    // private readonly Request _request;
    public string _host;
    public string _path;
    public HttpMethod _method;
    public Dictionary<string, string> _queryParameters = new Dictionary<string, string>();
    public Dictionary<string, string> _headers = new Dictionary<string, string>();

    public Request()
    {
        this._host = "";
        this._path = "";
        this._method = HttpMethod.Get;
        this._queryParameters = [];
        this._headers = [];
    }

    /// <summary>
    /// Sets the URL hostname of the request.
    /// </summary>
    /// <param name="host">The hostname</param>
    /// <returns>RequestBuilder</returns>
    public Request Host(string host)
    {
        this._host = host;
        return this;
    }

    /// <summary>
    /// Sets the URL path of the request.
    /// </summary>
    /// <param name="path">The URL path</param>
    /// <returns>RequestBuilder</returns>
    public Request Path(string path)
    {
        this._path = path;
        return this;
    }

    /// <summary>
    /// Sets the HTTP method of the request.
    /// </summary>
    /// <param name="method">The HTTP method verb</param>
    /// <returns>RequestBuilder</returns>
    public Request HTTPMethod(HttpMethod method)
    {
        this._method = method;
        return this;
    }

    /// <summary>
    /// Adds a query parameter key/value pair to the request.
    /// </summary>
    /// <param name="key">The query key</param>
    /// <param name="value">The query value</param>
    /// <returns>RequestBuilder</returns>
    public Request QueryParameter(string key, string value)
    {
        this._queryParameters[key] = value;
        return this;
    }

    /// <summary>
    /// Adds a header key/value pair to the request.
    /// </summary>
    /// <param name="key">The header key</param>
    /// <param name="value">The header value</param>
    /// <returns>RequestBuilder</returns>
    public Request Header(string key, string value)
    {
        this._headers[key] = value;
        return this;
    }

    /// <summary>
    /// Adds a 'a' number to the query parameters.
    /// </summary>
    /// <param name="value">The value of A</param>
    /// <returns>RequestBuilder</returns>
    public Request A(int value)
    {
        return this.QueryParameter("a", value.ToString());
    }

    /// <summary>
    /// Adds a 'c' number to the query parameters.
    /// </summary>
    /// <param name="value">The value of C</param>
    /// <returns>RequestBuilder</returns>
    public Request C(int value)
    {
        return this.QueryParameter("c", value.ToString());
    }

    /// <summary>
    /// Adds a 'd' string to the query parameters.
    /// </summary>
    /// <param name="value">The value of D</param>
    /// <returns>RequestBuilder</returns>
    public Request D(string value)
    {
        return this.QueryParameter("d", value);
    }

    /// <summary>
    /// Adds a 'f' number to the query parameters.
    /// </summary>
    /// <param name="value">The value of F</param>
    /// <returns>RequestBuilder</returns>
    public Request F(long value)
    {
        return this.QueryParameter("f", value.ToString());
    }

    /// <summary>
    /// Adds a 'g' number to the query parameters.
    /// </summary>
    /// <param name="value">The value of G</param>
    /// <returns>RequestBuilder</returns>
    public Request G(int value)
    {
        return this.QueryParameter("g", value.ToString());
    }

    /// <summary>
    /// Adds a 'h' number to the query parameters.
    /// </summary>
    /// <param name="value">The value of H</param>
    /// <returns>RequestBuilder</returns>
    public Request H(int value)
    {
        return this.QueryParameter("h", value.ToString());
    }

    /// <summary>
    /// Adds a list of 'i' strings to the query parameters.
    /// </summary>
    /// <param name="values">The values of I</param>
    /// <returns>RequestBuilder</returns>
    public Request I(string[] values)
    {
        return this.QueryParameter("i", String.Join(",", values));
    }

    /// <summary>
    /// Adds a list of 'k' strings to the query parameters.
    /// </summary>
    /// <param name="values">The values of K</param>
    /// <returns>RequestBuilder</returns>
    public Request K(string[] values)
    {
        return this.QueryParameter("k", String.Join(",", values));
    }

    /// <summary>
    /// Adds a 'm' number to the query parameters.
    /// </summary>
    /// <param name="value">The value of M</param>
    /// <returns>RequestBuilder</returns>
    public Request M(int value)
    {
        return this.QueryParameter("m", value.ToString());
    }

    /// <summary>
    /// Adds a 'o' number to the query parameters.
    /// </summary>
    /// <param name="value">The value of O</param>
    /// <returns>RequestBuilder</returns>
    public Request O(int value)
    {
        return this.QueryParameter("o", value.ToString());
    }

    /// <summary>
    /// Adds a 'r' string to the query parameters.
    /// </summary>
    /// <param name="value">The value of R</param>
    /// <returns>RequestBuilder</returns>
    public Request R(string value)
    {
        return this.QueryParameter("r", value.ToString());
    }

    /// <summary>
    /// Adds a 't' string to the query parameters.
    /// </summary>
    /// <param name="value">The value of T</param>
    /// <returns>RequestBuilder</returns>
    public Request T(string value)
    {
        return this.QueryParameter("t", value.ToString());
    }

    /// <summary>
    /// Adds a 'u' string to the query parameters.
    /// </summary>
    /// <param name="value">The value of U</param>
    /// <returns>RequestBuilder</returns>
    public Request U(string value)
    {
        return this.QueryParameter("u", value.ToString());
    }

    /// <summary>
    /// Adds a 'y' string to the query parameters.
    /// </summary>
    /// <param name="value">The value of Y</param>
    /// <returns>RequestBuilder</returns>
    public Request Y(string value)
    {
        return this.QueryParameter("y", value.ToString());
    }

    /// <summary>
    /// Sets a Bearer Token Authorization header.
    /// </summary>
    /// <param name="value">The Bearer Token</param>
    /// <returns>RequestBuilder</returns>
    public Request BearerToken(string token)
    {
        return this.Header("Authorization", string.Format("Bearer {0}", token));
    }

    /// <summary>
    /// Sets a User-Agent header.
    /// </summary>
    /// <param name="value">The Bearer Token</param>
    /// <returns>RequestBuilder</returns>
    public Request UserAgent(string userAgent)
    {
        return this.Header("User-Agent", userAgent);
    }

    /// <summary>
    /// Builds the HTTP request object.
    /// </summary>
    /// <returns>Request</returns>
    public HttpRequestMessage Build()
    {
        UriBuilder uri = new UriBuilder(this._host);
        uri.Path = this._path;
        var query = HttpUtility.ParseQueryString(uri.Query);
        foreach (var queryParam in this._queryParameters)
        {
            query[queryParam.Key] = queryParam.Value;
        }
        uri.Query = query.ToString();
        HttpRequestMessage r = new ( this._method, uri.ToString() );
        foreach (var header in this._headers)
        {
            r.Headers.Add(header.Key, header.Value);
        }
        return r;
    }
}