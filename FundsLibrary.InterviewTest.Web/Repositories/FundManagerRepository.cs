using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FundsLibrary.InterviewTest.Common;
using System.Configuration;
using System.Web.Configuration;

namespace FundsLibrary.InterviewTest.Web.Repositories
{
    public interface IFundManagerRepository
    {
        Task Delete(Guid id);
        Task<IEnumerable<FundManager>> GetAll();
        Task<FundManager> Get(Guid id);
        Task<Funds> GetFunds(Guid id);
        Task<Guid> Put(FundManager content);
        Task<Guid> Post(FundManager content);
    }

    public class FundManagerRepository : IFundManagerRepository
    {
        private readonly IHttpClientWrapper _client;

        public FundManagerRepository(IHttpClientWrapper client)
        {
            _client = client;
        }

        public async Task<IEnumerable<FundManager>> GetAll()
        {
            return await _client.GetAndReadFromContentGetAsync<IEnumerable<FundManager>>("api/FundManager/");
        }

        public async Task<FundManager> Get(Guid id)
        {
            return await _client.GetAndReadFromContentGetAsync<FundManager>("api/FundManager/" + id);
        }

        public async Task<Funds> GetFunds(Guid id)
        {
            
            var uri = WebConfigurationManager.AppSettings["FundsLibraryUri"].ToString() + "?$search=" + id.ToString();
            var key = WebConfigurationManager.AppSettings["FundsLibraryApiKey"].ToString();

            return await _client.GetAndReadFromContentGetAsync<Funds>(uri, key);
        }

        public async Task<Guid> Put(FundManager content)
        {
            return await _client.PutContentAndGetAsync<Guid, FundManager>("api/FundManager/", content);
        }

        public async Task<Guid> Post(FundManager content)
        {
            return await _client.PostContentAndGetAsync<Guid, FundManager>("api/FundManager/", content);
        }

        public Task Delete(Guid id)
        {
            return _client.DeleteContentAsync($"api/FundManager/{id}");
        }
    }
}
