
namespace CashFlow.Communication.Responses
{
    public class ResponseErrorJson 
    {
        public List<string> ErrorMessages { get; set; }

        public ResponseErrorJson(string erroMessage)
        {
            ErrorMessages = [erroMessage];
        }

        public ResponseErrorJson(List<string> erroMessage)
        {
            ErrorMessages = erroMessage;
        }
    }
}
