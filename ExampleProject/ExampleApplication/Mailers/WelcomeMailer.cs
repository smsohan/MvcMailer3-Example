using Mvc.Mailer;

namespace ExampleApplication.Mailers
{ 
    public class WelcomeMailer : MailerBase, IWelcomeMailer 	
	{
		public WelcomeMailer()
		{
			MasterName="_Layout";
		}
		
		public virtual MvcMailMessage Welcome()
		{
			//ViewBag.Data = someObject;
			return Populate(x =>
			{
				x.Subject = "Welcome";
				x.ViewName = "Welcome";
				x.To.Add("some-email@example.com");
			});
		}
 	}
}