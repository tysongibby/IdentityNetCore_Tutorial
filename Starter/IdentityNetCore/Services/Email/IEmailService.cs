namespace IdentityNetCore.Email
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}
