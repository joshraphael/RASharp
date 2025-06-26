namespace RASharp.Tests.Http;

using System.Globalization;
using NUnit.Framework;
using RASharp.Http;

public class RequestTests
{
    [Test]
    public void TestRequestBuilder()
    {
        var dateStr = @"2024-03-02 17:27:03Z";
        var dateTime = DateTime.ParseExact(dateStr, "yyyy-MM-dd HH:mm:ssZ", CultureInfo.InvariantCulture);
        var later = dateTime.AddMinutes(10);
        DateTimeOffset dto = new DateTimeOffset(dateTime);
        var seconds = dto.ToUnixTimeSeconds();
        DateTimeOffset laterDto = new DateTimeOffset(later);
        var laterSeconds = laterDto.ToUnixTimeSeconds();
        Request request = new RequestBuilder()
            .Host("http://localhost")
            .Path("/api/v1/some_resource")
            .Method(HttpMethod.Post)
            .UserAgent("RASharp/v0.0.0")
            .BearerToken("secret_bearer")
            .A(1)
            .C(20)
            .D(dateTime.ToUniversalTime().ToString("yyyy-MM-dd"))
            .F(seconds)
            .G(345)
            .H(1)
            .I([2837.ToString(), 4535.ToString()])
            .K(["test1", "test2"])
            .M(10)
            .O(34)
            .R("codenotes2")
            .T(laterSeconds.ToString())
            .U("myUsername")
		    .Y("secret_token")
            .Build();
        Assert.Multiple(() =>
        {
            Assert.That(request.Host, Is.EqualTo("http://localhost"));
            Assert.That(request.Path, Is.EqualTo("/api/v1/some_resource"));
            Assert.That(request.Method, Is.EqualTo(HttpMethod.Post));
            Assert.That(request.Headers, Has.Count.EqualTo(2));
            Assert.That(request.Headers["User-Agent"], Is.EqualTo("RASharp/v0.0.0"));
            Assert.That(request.Headers["Authorization"], Is.EqualTo("Bearer secret_bearer"));
            Assert.That(request.QueryParameters, Has.Count.EqualTo(14));
            Assert.That(request.QueryParameters["a"], Is.EqualTo("1"));
            Assert.That(request.QueryParameters["c"], Is.EqualTo("20"));
            Assert.That(request.QueryParameters["d"], Is.EqualTo("2024-03-02"));
            Assert.That(request.QueryParameters["f"], Is.EqualTo("1709400423"));
            Assert.That(request.QueryParameters["g"], Is.EqualTo("345"));
            Assert.That(request.QueryParameters["h"], Is.EqualTo("1"));
            Assert.That(request.QueryParameters["i"], Is.EqualTo("2837,4535"));
            Assert.That(request.QueryParameters["k"], Is.EqualTo("test1,test2"));
            Assert.That(request.QueryParameters["m"], Is.EqualTo("10"));
            Assert.That(request.QueryParameters["o"], Is.EqualTo("34"));
            Assert.That(request.QueryParameters["r"], Is.EqualTo("codenotes2"));
            Assert.That(request.QueryParameters["t"], Is.EqualTo("1709401023"));
            Assert.That(request.QueryParameters["u"], Is.EqualTo("myUsername"));
            Assert.That(request.QueryParameters["y"], Is.EqualTo("secret_token"));
        });
    }
}