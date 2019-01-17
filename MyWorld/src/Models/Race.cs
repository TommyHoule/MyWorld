using System.Drawing;
namespace MyWorld.Models{
    public class Race
    {
        private string _language;
        private Color _skinFurColor;
        private string _crySound;
        
        public Race(string language, Color skinFurColor, string crySound){
            _language = language;
            _skinFurColor = skinFurColor;
            _crySound = crySound;
        }
    }
}