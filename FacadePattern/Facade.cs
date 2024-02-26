namespace FacadePattern;

public class ShopFacade
{
    private static ShopFacade _instance;

    private AccountService accountService;
    private PaymentService paymentService;
    private ShippingService shippingService;
    private EmailService emailService;
    private SmsService smsService;

    private ShopFacade()
    {
        accountService = new AccountService();
        paymentService = new PaymentService();
        shippingService = new ShippingService();
        emailService = new EmailService();
        smsService = new SmsService();
    }

    public static ShopFacade getInstance()
    {
        if (_instance == null)
            _instance = new ShopFacade();
        return _instance;
    }

    public void buyProductByCashWithFreeShipping(string email)
    {
        accountService.GetAccout(email);
        paymentService.PaymentByCash();
        shippingService.FreeShipping();
        emailService.SendMail(email);
        Console.WriteLine("Done\n");
    }

    public void buyProductByPaypalWithStandardShipping(string email, string mobilePhone)
    {
        accountService.GetAccout(email);
        paymentService.PaymentByPaypal();
        shippingService.StandardShipping();
        emailService.SendMail(email);
        smsService.sendSMS(mobilePhone);
        Console.WriteLine("Done\n");
    }
}   