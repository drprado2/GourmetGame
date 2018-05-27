namespace JogoGourmet.Core
{
    public class NewGameNodeDto
    {
        public NewGameNodeDto(string elementCharacteristic, string elementLabel)
        {
            ElementCharacteristic = elementCharacteristic;
            ElementLabel = elementLabel;
        }
        
        public string ElementCharacteristic { get; }
        public string ElementLabel { get; }
    }
}