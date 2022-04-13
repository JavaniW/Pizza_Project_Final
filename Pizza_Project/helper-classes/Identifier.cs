using System;

namespace Pizza_Project {
 public static class Identifier {

  /**
  <summary>
   Creates and returns unique string identifier.
  </summary>
 
  <returns>
   Unique string.
  </returns>
  */
  public static string CreateIdentifier() {
    Guid g = Guid.NewGuid();
    var guidString = Convert.ToBase64String(g.ToByteArray());
    guidString = guidString.Replace("=", "");
    guidString = guidString.Replace("+", "");
    return guidString;
   }
 }
}