using System.Net.Http.Headers;
 HttpClient client = new HttpClient(new HttpClientHandler() { AutomaticDecompression =  System.Net.DecompressionMethods.All});
// // HttpClient client = new HttpClient(handler);

// HttpClientHandler handler = new HttpClientHandler();
// handler.AutomaticDecompression =  System.Net.DecompressionMethods.All;
// HttpClient client = new HttpClient();
 HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://alpha.payuterus.biz/index-a.php");

request.Headers.Add("authority", "alpha.payuterus.biz");
request.Headers.Add("cookie", "_ga=GA1.2.1350919872.1671866712; _gid=GA1.2.681296448.1671866712; __gads=ID=448fe963f2c67c48-22bf191507d9002c:T=1671866714:RT=1671866714:S=ALNI_MZgureWINDStZRucRD7xBcvlgfGCQ; __gpi=UID=00000b968f79a886:T=1671866714:RT=1671927571:S=ALNI_MZShK7nw6KSqxEsBz1l9Cwta02BLQ; PHPSESSID=2c9ribl9i3r00ritq45nb4na94; _gat=1");
request.Headers.Add("origin", "https://alpha.payuterus.biz");
request.Headers.Add("referer", "https://alpha.payuterus.biz/index.php");
request.Headers.Add("upgrade-insecure-requests", "1");
request.Headers.Add("user-agent", "Mozilla/5.0 (iPhone; CPU iPhone OS 13_2_3 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/13.0.3 Mobile/15E148 Safari/604.1 Edg/108.0.0.0");
request.Content = new StringContent("name=eeee&nomorhp=0847857382&key=408444");
request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

HttpResponseMessage response = await client.SendAsync(request);
 Console.WriteLine(await response.Content.ReadAsStringAsync());
