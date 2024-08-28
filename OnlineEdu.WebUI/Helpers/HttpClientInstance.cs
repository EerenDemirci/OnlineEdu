using System;

namespace OnlineEdu.WebUI.Helpers;

public static class HttpClientIstance
{
    public static HttpClient CreateClint()
    {
        HttpClient client = new HttpClient();
        client.BaseAddress= new Uri("https://localhost:7019/api");
        return client;

    }




}
