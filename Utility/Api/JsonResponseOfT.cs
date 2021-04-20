namespace Utility.Api
{
    public class JsonResponse<T> : JsonResponse
    {
        public T data { get; set; }
    }
}