using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class MailingListController : ControllerBase
{
    private readonly ILogger<MailingListController> _logger;

    public MailingListController(ILogger<MailingListController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// REST Endpoint to get all emails currently in the mailing list. 
    /// </summary>
    /// <param name="optionalParams">It accepts the following JSON keys: LastName: string, Descending: bool.</param>
    /// <returns>Returns a list of all emails in the mailing list</returns>
    [HttpGet(Name = "GetMailingList")]
    public List<Subscriber> Get ( [FromBody] GetOptionalParams? optionalParams)
    {
        if(optionalParams == null)
        {
            //No parameters at all
            return MailingListSubscribers.Instance.GetAllEmailsAscending();
        }

        if(optionalParams.LastName == null)
        { 
            if(optionalParams.Descending != null && optionalParams.Descending == true)
            {
                //Last name not specified, descending is specified
                return MailingListSubscribers.Instance.GetAllEmailsDescending();
            }
            else
            {
                //Last name not specified, decending not specified
                return MailingListSubscribers.Instance.GetAllEmailsAscending();
            }
        }
        else
        {
            if(optionalParams.Descending != null && optionalParams.Descending == true)
            {
                //Last name specified and descending specified
                return MailingListSubscribers.Instance.GetEmailsByLastNameDescending(optionalParams.LastName);
            }
            else
            {
                //Last name specified, descending not specified
                return MailingListSubscribers.Instance.GetEmailsByLastNameAscending(optionalParams.LastName);
            }
        }
    }

    [HttpPost]
    public int Post ([FromBody] Subscriber data)
    {
        return MailingListSubscribers.Instance.AddEmail(data);
    }
}
