using System.Net.Http.Headers;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

{

    string accountSid = Environment.GetEnvironmentVariable("TwilioSID");
    string authToken = Environment.GetEnvironmentVariable("TwilioAuth");
    string text = "Aco Random Code Generator:";
    TwilioClient.Init(accountSid, authToken);
    Random randomNumber = new Random();
    var message = MessageResource.Create(
        body: text + " " + randomNumber.Next().ToString(),
        from: new Twilio.Types.PhoneNumber("+16067157328"),
        to: new Twilio.Types.PhoneNumber("+38970367241")

    );

    Console.WriteLine(message.Body);
}

