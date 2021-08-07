using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DemonersClientSimulator.Shared.DataStorage {

  public class ProjectType {
    public string Name { get; set; }
    public int Id { get; set; }
    public List<string> Options { get; set; }
  }

  public class Difficulty {
    public string Name { get; set; }
    public int Id { get; set; }
    public int ElementCount { get; set; }
    public int Priority { get; set; }
    public List<string> Elements { get; set; }
  }

  public class Language {
    public string Name { get; set; }
    public int Id { get; set; }
  }

  public class DataStorageJsonObject {
    public List<ProjectType> ProjectTypes { get; set; }
    public List<Difficulty> Difficulties { get; set; }
    public List<Language> Languages { get; set; }
  }

  public static class DataStorage {
    public static string fileName = "C:\\Users\\schindlei\\source\\repos\\DemonersClientSimulator\\ClientSimulatorData.json";
    public static DataStorageJsonObject ReadSavedData() {
      var data = JsonConvert.DeserializeObject<DataStorageJsonObject>(System.IO.File.ReadAllText(fileName));
      return data;
    }
    public static void WriteSavedData(DataStorageJsonObject data) {
      var dataString = JsonConvert.SerializeObject(data);
      Console.WriteLine(dataString);
      System.IO.File.WriteAllText(fileName, dataString);
    }
  }
  
}
