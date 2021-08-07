using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using DemonersClientSimulator.Shared.DataStorage;

namespace DemonersClientSimulator.Client.Shared {
  public class BackendService {

    public BackendService() { }

    public async Task<DataStorageJsonObject> LoadData(HttpClient client) {
      var result = await client.GetFromJsonAsync<DataStorageJsonObject>("Backend");
      return result;

    }

    public async Task SaveData(DataStorageJsonObject data, HttpClient client) {
      var result = await client.PostAsJsonAsync<DataStorageJsonObject>("Backend", data);
    }

    public async Task<int> GetRandSeed(HttpClient client) {
      var result = await client.GetFromJsonAsync<int>("Backend/randseed");
      return result;              
    }
  }
}
