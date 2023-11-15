using System.Net;
using System.Net.Mail;

public class Program
{
    public static void Main(string[] args)
    {
        string mail = "";
        string pword = "jmsbkdvjylorffuh";

        string Email;
        Console.WriteLine("Enter your mail id");
        Email = Console.ReadLine();



        MailMessage message = new MailMessage();
        message.From = new MailAddress(mail);
        Console.WriteLine("Enter a subject");
        string ipname = Console.ReadLine();
        message.Subject = ipname;
       // message.Subject = "Message";
        message.To.Add(new MailAddress(Email));
        message.Body = "<html><body> " + "<p> Hey Haley, </p>" +
                                         "<p> Just checking in! Wanted to say thank you once again for your purchase and ask if you had a feed back for us. </p>" +
                                         "<p> Let us know how you're feeling by clicking one of these little faces: </p>" +
                                         "<a href=\"https://www.google.com/url?sa=i&url=https%3A%2F%2Fadnan-tech.com%2Femoji-ratings-feedback-javascript%2F&psig=AOvVaw1cnSpbRmV_Yciuo5CTdLWZ&ust=1700135322151000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCLDuzeb3xYIDFQAAAAAdAAAAABAk\"><img src=\"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRaF8nckxclQ1q5L_F2bBxakTBQtrvxGmQa5A&usqp=CAU\" hspace=5 vspace=5 width=\"70\"height=\"43\" \"></a></p>" +
                                         "<img src= \" https://www.creativefabrica.com/wp-content/uploads/2021/03/23/Emoji-Feedback-Icon-Graphics-9897778-1-580x386.jpg\" hspace=5 vspace=5 width=\"70\" height=\"43\">" +
                                         "<img src= \"https://thumbs.dreamstime.com/b/image-emoticons-feedback-icon-vector-stock-154317223.jpg\" hspace=5 vspace=5 width=\"70\" height=\"43\">" +
                                         "<img src=\"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRaF8nckxclQ1q5L_F2bBxakTBQtrvxGmQa5A&usqp=CAU\" hspace=5 vspace=5 width=\"70\" height=\"43\">" +


                                         /* "<a href=\"https://opiniator.com/wp-content/uploads/2023/02/ThinkAgainEmoji.jpg\">Give your Feedback</a>" + */
                                         "<p> Your input is vital in ensuring that our products are meeting your needs <br> A mission we take very seriously</p>" + 
                                         "<p> Thanks a million <br> Paul Foote </p>"+" </html></body> ";
        message.IsBodyHtml = true;

        var smtpclient = new SmtpClient("smtp.gmail.com")
        {
            Port = 587,
            Credentials = new NetworkCredential(mail, pword),
            EnableSsl = true,

        };

        smtpclient.Send(message);

        Console.WriteLine("Message Send Successfully");


    }
}