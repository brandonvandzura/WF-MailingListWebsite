namespace webapi.Test
{
    public class Tests
    {
        [OneTimeSetUp]
        public void Setup ()
        {
            var sub1 = new Subscriber();
            sub1.lastName = "Doe";
            sub1.firstName = "Jane";
            sub1.email = "jdoe@jdoe.net";

            var sub2 = new Subscriber();
            sub1.lastName = "Doe";
            sub1.firstName = "John";
            sub1.email = "jdoe@jdoe.net";

            var sub3 = new Subscriber();
            sub1.lastName = "Doe";
            sub1.firstName = "Joe";
            sub1.email = "jdoe@jdoe.net";

            int currentCount;

            currentCount = MailingListSubscribers.Instance.AddEmail(sub1);
            currentCount = MailingListSubscribers.Instance.AddEmail(sub2);
            currentCount = MailingListSubscribers.Instance.AddEmail(sub3);
        }

        [Test]
        public void SubscribersGetAllEmailsCount ()
        {
            List<Subscriber> list = MailingListSubscribers.Instance.GetAllEmailsAscending();
            Assert.IsTrue(list.Count == 3); //Make sure all 3 names were added successfully
        }

        //Ideally, additional tests could be added to check the whether values are sorted properly. Not spending much time here as I'm running out.
    }
}