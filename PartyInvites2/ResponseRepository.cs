using System.Collections.Generic;
using System;
using System.Linq;
using System.Web;

namespace PartyInvites2
{
    public class ResponseRepository
    {
        private static ResponseRepository repository = new ResponseRepository();
        private List<GuessResponse> responses = new List<GuessResponse>();

        public static ResponseRepository GetRepository()
        {
            return repository;
        }

        public IEnumerable<GuessResponse> GetAllResponses()
        {
            return responses;
        }

        public void AddResponse(GuessResponse response)
        {
            responses.Add(response);
        }
    }
}