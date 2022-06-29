using System.Collections.Generic;
using System.Threading.Tasks;
using HowManyAnimalsDoYouWeighApp.Data.AnimalFunFacts;
using HowManyAnimalsDoYouWeighApp.Data.Animals;
using HowManyAnimalsDoYouWeighApp.Data.ItemFunFacts;
using HowManyAnimalsDoYouWeighApp.Data.Items;
using HowManyAnimalsDoYouWeighApp.Data.Substances;
using HowManyAnimalsDoYouWeighApp.Data.Visualizations;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace HowManyAnimalsDoYouWeighApp.Services
{
    public class Client
    {
        private readonly RestClient _client;

        public Client()
        {
            _client = new RestClient("https://localhost:5001/api");
            _client.UseNewtonsoftJson();
        }

        public async Task<List<AnimalFunFactDto>> GetAnimalFunFactAsync()
        {
            var request = new RestRequest("/AnimalFunFacts");
            return await _client.GetAsync<List<AnimalFunFactDto>>(request);
        }

        public async Task<List<AnimalDto>> GetAnimalsAsync()
        {
            var request = new RestRequest("/Animals");
            return await _client.GetAsync<List<AnimalDto>>(request);
        }
        public async Task<List<AnimalResultDto>> GetAnimalResultAsync()
        {
            var request = new RestRequest("/Animals/result");
            return await _client.GetAsync<List<AnimalResultDto>>(request);
        }
        
        public async Task<List<ItemFunFactDto>> GetItemFunFactAsync()
        {
            var request = new RestRequest("/ItemFunFacts");
            return await _client.GetAsync<List<ItemFunFactDto>>(request);
        }
        
        public async Task<List<ItemDto>> GetItemsAsync()
        {
            var request = new RestRequest("/Items");
            return await _client.GetAsync<List<ItemDto>>(request);
        }
        public async Task<List<ItemResultDto>> GetItemResultAsync()
        {
            var request = new RestRequest("/Items/result");
            return await _client.GetAsync<List<ItemResultDto>>(request);
        }
        
        public async Task<List<SubstanceDto>> GetSubstancesAsync()
        {
            var request = new RestRequest("/Substances");
            return await _client.GetAsync<List<SubstanceDto>>(request);
        }
        public async Task<List<SubstanceResultDto>> GetSubstanceResultAsync()
        {
            var request = new RestRequest("/Substances/result");
            return await _client.GetAsync<List<SubstanceResultDto>>(request);
        }
        
       
        public async Task<List<VisualizationDto>> GetVisualizationAsync()
        {
            var request = new RestRequest("/Visualizations");
            return await _client.GetAsync<List<VisualizationDto>>(request);
        }
    }
}