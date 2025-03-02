using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Types;
using Twilio;
using Twilio.Rest.Api.V2010.Account; // Contient MessageResource



namespace Gestion_Etudiant.Services
{
    internal class OtpService
    {
        private readonly string _accountSid = "votre_account_sid"; // Remplace par ton SID Twilio
        private readonly string _authToken = "votre_auth_token";   // Remplace par ton token d'authentification Twilio
        private readonly string _twilioPhoneNumber = "+votre_numero_twilio"; // Remplace par ton numéro Twilio

        public string GenerateOtp()
        {
            Random random = new Random();
            string otp = random.Next(100000, 999999).ToString();
            return otp;
        }

        public void SendOtp(string userPhoneNumber, string otp)
        {
            TwilioClient.Init(_accountSid, _authToken);

            var message = MessageResource.Create(
                body: $"Votre code OTP est : {otp}",
                from: new PhoneNumber(_twilioPhoneNumber),
                to: new PhoneNumber(userPhoneNumber)
            );
        }
    }
}

