namespace TelerikExamSystem.Web.Infrastructure.Providers
{
    public interface IUserInfoProvider
    {
        string GetUserId();

        string GetUsername();
    }
}