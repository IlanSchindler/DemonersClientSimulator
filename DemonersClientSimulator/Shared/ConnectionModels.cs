using System;
using System.Collections.Generic;
using System.Text;

namespace DemonersClientSimulator.Shared {
  public class LanguagesComboModel {
    public string LanguageName { get; set; }
    public int LanguageId { get; set; }
  }

  public class ProjectTypeComboModel {
    public string ProjectTypeName { get; set; }
    public int ProjectTypeId { get; set; }
  }

  public class DifficultyComboModel {
    public string DifficultyName { get; set; }
    public int DifficultyId { get; set; }
  }
}
