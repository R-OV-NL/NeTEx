namespace NetexParser.Contracts;

public interface IXmlParserService
{
    Task<T> ParseXmlAsync<T>(string xml) where T : class;
}