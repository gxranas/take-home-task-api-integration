using TakeHomeTask.Classes;

Console.Write("Enter city name: ");
string city = Console.ReadLine();

Console.Write("Enter mode: ");
string mode = Console.ReadLine();

Console.Write("Enter latitude: ");
string latitude = Console.ReadLine();

Console.Write("Enter longitude: ");
string longitude = Console.ReadLine();

APIResponse response = new APIResponse();
APIResult result = new APIResult();
HttpResponse httpResponse = APIUtils.HttpWebResponse($"{APIConfiguration.APIURL}lat={latitude}&lon={longitude}&appid={APIConfiguration.APIKey}&q={city}&mode={mode}");
response = APIResponse.ParseResponse(httpResponse);
result.DisplayResult(response,mode);



