using System.Text.Json;
namespace PBL;

public static class LoadData
{
     public static async Task<FlowData> LoadFlowData(string fileName)
     {
          await using FileStream openStream = File.OpenRead(fileName);
          FlowData? data = await JsonSerializer.DeserializeAsync<FlowData>(openStream);
          if (data is null) throw new FileFormatException($"File {fileName} has wrong format");
          return data;
     }
}