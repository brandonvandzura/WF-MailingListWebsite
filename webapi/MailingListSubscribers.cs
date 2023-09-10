using System.Linq;

namespace webapi;

public sealed class MailingListSubscribers
{
    private static MailingListSubscribers instance = null;
    private List<Subscriber> subscribers;

    private MailingListSubscribers() 
    {
        subscribers = new List<Subscriber>();
    }

    public static MailingListSubscribers Instance
    {
        get 
        { 
            if (instance == null)
            {
                instance = new MailingListSubscribers();
            } 

            return instance;
        }
    }

    /// <summary>
    /// Adds an email to the mailing list and returns the new total count of email subscribers.
    /// </summary>
    /// <param name="firstName">First name of new subscriber.</param>
    /// <param name="lastName">Last name of new subscriber.</param>
    /// <param name="email">Email of new subscriber.</param>
    /// <returns>int total count of subscribers</returns>
    public int AddEmail(Subscriber subscriber)
    {
        subscribers.Add(subscriber);

        return subscribers.Count;
    }

    public List<Subscriber> GetAllEmailsAscending ()
    {
        return subscribers.OrderBy(e => e.lastName).ThenBy(e => e.firstName).ToList();
    }

    public List<Subscriber> GetAllEmailsDescending ()
    {
        return subscribers.OrderByDescending(e => e.lastName).ThenByDescending(e => e.firstName).ToList();
    }

    public List<Subscriber> GetEmailsByLastNameAscending (string lastName)
    {

        return subscribers.Where(e=> e.lastName == lastName).OrderBy(e => e.lastName).ThenBy(e => e.firstName).ToList();
    }

    public List<Subscriber> GetEmailsByLastNameDescending (string lastName)
    {
        return subscribers.Where(e => e.lastName == lastName).OrderByDescending(e => e.lastName).ThenByDescending(e => e.firstName).ToList();
    }
}
