namespace UnstableRestApi.Dto
{
    public class LoremIpsumResponse
    {
        public string Words { get; }

        public LoremIpsumResponse(string words)
        {
            Words = words;
        }
    }
}
