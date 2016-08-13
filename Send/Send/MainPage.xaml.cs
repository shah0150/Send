using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Messaging;
using Xamarin.Forms;

namespace Send
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        

        private void SendSMS(object sender, EventArgs e)
        {
            var smsMessenger = CrossMessaging.Current.SmsMessenger;
            if (smsMessenger.CanSendSms)
                smsMessenger.SendSms("+16476674651", "Well, Hello there from Shah0150");
        }

        private void MakePhone(object sender, EventArgs e)
        {
           var phone =  CrossMessaging.Current.PhoneDialer;
            if(phone.CanMakePhoneCall)
            {
                phone.MakePhoneCall("+16476674651", "Adesh Shah");
            }

         
        }

        private void SendEMAIL(object sender, EventArgs e)
        {
           var emailMessenger =  CrossMessaging.Current.EmailMessenger;
            if(emailMessenger.CanSendEmail)
            {
                emailMessenger.SendEmail("to.plugins@xamarin.com", "Xamarin Messaging Plugin", "Well hello there from Xam.Messaging.Plugin");

                // Alternatively use EmailBuilder fluent interface to construct more complex e-mail with multiple recipients, bcc, attachments etc. 
                var email = new EmailMessageBuilder()
                  .To("to.plugins@xamarin.com")
                  .Cc("cc.plugins@xamarin.com")
                  .Bcc(new[] { "bcc1.plugins@xamarin.com", "bcc2.plugins@xamarin.com" })
                  .Subject("Xamarin Messaging Plugin")
                  
                  .Body("Well hello there from Xam.Messaging.Plugin")
                  .Build();

                emailMessenger.SendEmail(email);
            }
        }
    }
}
