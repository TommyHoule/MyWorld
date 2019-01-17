namespace MyWorld.Models{
    public class Profession
    {
        private string _name;

        public Profession(string name){
            _name = name;
        }

        public string getProfessionName(){
            return _name;
        }
    }
}