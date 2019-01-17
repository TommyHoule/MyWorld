namespace MyWorld.Models{
    public class LivingObject
    {
        private string _name;
        private int _age;
        private Race _race;
        private Profession _profession;

        public LivingObject(){
        }
        public LivingObject(string name){
            _name = name;
        }
        public LivingObject(string name, int age){
            _name = name;
            _age = age;
        }
        public LivingObject(string name, int age, Race race){
            _name = name;
            _age = age;
            _race = race;
        }

        public string getName(){
            return _name;
        }
        public int getAge(){
            return _age;
        }
        public Race getRace(){
            return _race;
        }
        public Profession getProfession(){
            return _profession;
        }
        public void setName(string name){
            _name = name;
        }
        public void setAge(int age){
            _age = age;
        }
        public void setRace(Race race){
            _race = race;
        }
        public void setProfession(Profession profession){
            _profession = profession;
        }
    }
}