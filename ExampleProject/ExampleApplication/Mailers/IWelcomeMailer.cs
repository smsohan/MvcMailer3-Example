using Mvc.Mailer;

namespace ExampleApplication.Mailers
{ 
    public interface IWelcomeMailer
    {
			MvcMailMessage Welcome();
	}
}