using DemonersClientSimulator.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemonersClientSimulator.Shared.DataStorage;

namespace DemonersClientSimulator.Server.Controllers {
  [ApiController]
  [Route("[controller]")]
  public class Backend : ControllerBase {
    private string fileName = "ClientSimulatorData.json";
    [HttpGet]
    public DataStorageJsonObject Get() {
      if(!System.IO.File.Exists(fileName)) {
        return new DataStorageJsonObject() { Difficulties = new List<Difficulty>(), Languages = new List<Language>(), ProjectTypes = new List<ProjectType>() };
      }
      var dataString = System.IO.File.ReadAllText(fileName);
      return Newtonsoft.Json.JsonConvert.DeserializeObject<DataStorageJsonObject>(dataString);
    }

    [HttpGet("randseed")]
    public int GetRandSeed() {
      return (int)DateTime.UtcNow.Ticks;
    }

    [HttpPost]
    public bool Post(DataStorageJsonObject data) {
      var dataString = Newtonsoft.Json.JsonConvert.SerializeObject(data);
      System.IO.File.WriteAllText(fileName, dataString);
      return true;
    }
  }
}
