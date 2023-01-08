using System.Xml.Serialization;
using NetexParser.Contracts;

namespace NetexParser.Services;

public class XmlParserService : IXmlParserService
{
    public async Task<T> ParseXmlAsync<T>(string xmlPath) where T : class
    {
        if(string.IsNullOrEmpty(xmlPath))
            throw new ArgumentException("Value cannot be null or empty.", nameof(xmlPath));
        
        if(!File.Exists(xmlPath))
            throw new FileNotFoundException("File not found.", xmlPath);

        var serializer = new XmlSerializer(typeof(T));

        using var stream = new StreamReader(xmlPath);

        var result = await Task.Run(() => serializer.Deserialize(stream) as T);
        
        if(result == null)
            throw new Exception("Failed to parse xml file as type " + typeof(T).Name);

        return result;
    }
}