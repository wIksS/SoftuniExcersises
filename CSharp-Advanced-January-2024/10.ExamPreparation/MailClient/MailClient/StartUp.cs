namespace MailClient
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Initialize new repository (MailBox) 
            MailBox mailbox = new(5);

            //Initialize entities (Mail)
            Mail mail1 = new("John", "Alice", "Hello Alice, How are you?");
            Mail mail2 = new("Alice", "Bob", "Hi Bob, Here's the document you requested.");
            Mail mail3 = new("Bob", "Charlie", "Hey Charlie, Let's meet for lunch.");
            Mail mail4 = new("Charlie", "David", "Hi David, Can you help me with the project?");
            Mail mail5 = new("David", "Eva", "Hello Eva, Don't forget our meeting tomorrow.");
            Mail mail6 = new("Eva", "Frank", "Hi Frank, I found an interesting article for you.");
            Mail mail7 = new("Frank", "Grace", "Hey Grace, How's your day going?");
            Mail mail8 = new("Grace", "Henry", "Hi Henry, Please review the proposal.");
            Mail mail9 = new("Henry", "Isabella", "Hello Isabella, Let's schedule a call.");
            Mail mail10 = new("Isabella", "John", "Hi John, I received your message. Thanks!");

            //Send mails to Inbox 
            mailbox.IncomingMail(mail1);
            mailbox.IncomingMail(mail2);
            mailbox.IncomingMail(mail3);
            mailbox.IncomingMail(mail4);
            mailbox.IncomingMail(mail5);

            //Send when Capacity is full
            mailbox.IncomingMail(mail6);

            //Delete existing Mail
            Console.WriteLine(mailbox.DeleteMail("David")); //True

            //Try to delete not existing Mail
            Console.WriteLine(mailbox.DeleteMail("Eva")); //False

            //Try to send once again, if there is enough Capacity
            mailbox.IncomingMail(mail6);

            //mail6 should exist and be available to delete
            Console.WriteLine(mailbox.DeleteMail("Eva")); //True

            //Archive mails and print count
            Console.WriteLine(mailbox.ArchiveInboxMessages()); //4

            //Send the rest of the mails
            mailbox.IncomingMail(mail7);
            mailbox.IncomingMail(mail8);
            mailbox.IncomingMail(mail9);
            mailbox.IncomingMail(mail10);

            //Print the mail with the longest message
            Console.WriteLine(mailbox.GetLongestMessage());
            //From: Isabella / To: John
            //Message: Hi John, I received your message.Thanks!

            //Display all mails currently in Inbox
            Console.WriteLine(mailbox.InboxView());
            //Inbox:
            //From: Frank / To: Grace
            //Message: Hey Grace, How's your day going?
            //From: Grace / To: Henry
            //Message: Hi Henry, Please review the proposal.
            //From: Henry / To: Isabella
            //Message: Hello Isabella, Let's schedule a call.
            //From: Isabella / To: John
            //Message: Hi John, I received your message.Thanks!

        }
    }
}