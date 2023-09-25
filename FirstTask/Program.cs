
using System.Text.Json;

namespace FirstTask
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
           ReplacementService service = new ReplacementService(new HttpClient());
           await service.RunService();
        }        
    }

}