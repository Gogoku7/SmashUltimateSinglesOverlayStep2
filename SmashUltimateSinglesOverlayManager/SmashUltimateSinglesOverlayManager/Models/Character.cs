using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmashUltimateSinglesOverlayManager.Models
{
    public class Character : INotifyPropertyChanged
    {
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private string _path;
        public string Path
        {
            get
            {
                return _path;
            }
            set
            {
                _path = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public Character(int id, string name, string path)
        {
            Id = id;
            Name = name;
            Path = path;
        }

        public static ObservableCollection<Character> InitiateSmashUltimateCharacterList()
        {
            return new ObservableCollection<Character>
            {
                new Character(0, "Bayonetta", @"..\\characterIcons\\bayonetta.png"),
                new Character(1, "Bowser", @"..\\characterIcons\\Bowser.png"),
                new Character(2, "Bowser. Jr", @"..\\characterIcons\\bowserjr.png"),
                new Character(3, "Captain Falcon", @"..\\characterIcons\\captainfalcon.png"),
                new Character(5, "Chrom", @"..\\characterIcons\\chrom.png"),
                new Character(6, "Cloud", @"..\\characterIcons\\cloud.png"),
                new Character(7, "Corrin", @"..\\characterIcons\\corrin.png"),
                new Character(8, "Daisy", @"..\\characterIcons\\daisy.png"),
                new Character(9, "Dark Pit", @"..\\characterIcons\\darkpit.png"),
                new Character(10, "Dark Samus", @"..\\characterIcons\\darksamus.png"),
                new Character(11, "Diddy Kong", @"..\\characterIcons\\diddykong.png"),
                new Character(12, "Donkey Kong", @"..\\characterIcons\\donkeykong.png"),
                new Character(13, "Dr. Mario", @"..\\characterIcons\\drmario.png"),
                new Character(14, "Duck Hunt", @"..\\characterIcons\\duckhunt.png"),
                new Character(15, "Falco", @"..\\characterIcons\\falco.png"),
                new Character(16, "Fox", @"..\\characterIcons\\fox.png"),
                new Character(17, "Ganondorf", @"..\\characterIcons\\ganondorf.png"),
                new Character(18, "Greninja", @"..\\characterIcons\\greninja.png"),
                new Character(19, "Ice Climbers", @"..\\characterIcons\\iceclimbers.png"),
                new Character(20, "Ike", @"..\\characterIcons\\ike.png"),
                new Character(21, "Incineroar", @"..\\characterIcons\\incineroar.png"),
                new Character(22, "Inkling", @"..\\characterIcons\\inkling.png"),
                new Character(23, "Isabelle", @"..\\characterIcons\\isabelle.png"),
                new Character(24, "Jigglypuff", @"..\\characterIcons\\jigglypuff.png"),
                new Character(25, "Ken", @"..\\characterIcons\\ken.png"),
                new Character(26, "King Dedede", @"..\\characterIcons\\kingdedede.png"),
                new Character(27, "King K. Rool", @"..\\characterIcons\\kingkrool.png"),
                new Character(28, "Kirby", @"..\\characterIcons\\kirby.png"),
                new Character(29, "Link", @"..\\characterIcons\\link.png"),
                new Character(20, "Little Mac", @"..\\characterIcons\\littlemac.png"),
                new Character(30, "Lucario", @"..\\characterIcons\\lucario.png"),
                new Character(31, "Lucas", @"..\\characterIcons\\lucas.png"),
                new Character(32, "Lucina", @"..\\characterIcons\\lucina.png"),
                new Character(33, "Luigi", @"..\\characterIcons\\luigi.png"),
                new Character(34, "Mario", @"..\\characterIcons\\mario.png"),
                new Character(35, "Marth", @"..\\characterIcons\\marth.png"),
                new Character(36, "Mega Man", @"..\\characterIcons\\megaman.png"),
                new Character(37, "Meta Knight", @"..\\characterIcons\\metaknight.png"),
                new Character(38, "Mewtwo", @"..\\characterIcons\\mewtwo.png"),
                new Character(39, "Mii Brawler", @"..\\characterIcons\\miifighter.png"),
                new Character(40, "Mii Gunner", @"..\\characterIcons\\miifighter.png"),
                new Character(41, "Mii Swordfighter", @"..\\characterIcons\\miifighter.png"),
                new Character(42, "Mr. Game & Watch", @"..\\characterIcons\\mrgamewatch.png"),
                new Character(43, "Ness", @"..\\characterIcons\\ness.png"),
                new Character(44, "Olimar", @"..\\characterIcons\\olimar.png"),
                new Character(45, "Pac-Man", @"..\\characterIcons\\pacman.png"),
                new Character(46, "Palutena", @"..\\characterIcons\\palutena.png"),
                new Character(47, "Peach", @"..\\characterIcons\\peach.png"),
                new Character(48, "Pichu", @"..\\characterIcons\\pichu.png"),
                new Character(49, "Pikachu", @"..\\characterIcons\\pikachu.png"),
                new Character(50, "Piranha Plant", @"..\\characterIcons\\piranhaplant.png"),
                new Character(51, "Pit", @"..\\characterIcons\\pit.png"),
                new Character(52, "Pokémon Trainer", @"..\\characterIcons\\pokemontrainer.png"),
                new Character(53, "Random", @"..\\characterIcons\\random.png"),
                new Character(54, "Richter", @"..\\characterIcons\\richter.png"),
                new Character(55, "Ridley", @"..\\characterIcons\\ridley.png"),
                new Character(56, "R.O.B", @"..\\characterIcons\\rob.png"),
                new Character(57, "Robin", @"..\\characterIcons\\robin.png"),
                new Character(58, "Rosalina & Luma", @"..\\characterIcons\\rosalina.png"),
                new Character(59, "Roy", @"..\\characterIcons\\roy.png"),
                new Character(60, "Ryu", @"..\\characterIcons\\ryu.png"),
                new Character(60, "Samus", @"..\\characterIcons\\samus.png"),
                new Character(61, "Sheik", @"..\\characterIcons\\sheik.png"),
                new Character(62, "Shulk", @"..\\characterIcons\\shulk.png"),
                new Character(63, "Simon", @"..\\characterIcons\\simon.png"),
                new Character(64, "Snake", @"..\\characterIcons\\snake.png"),
                new Character(65, "Sonic", @"..\\characterIcons\\sonic.png"),
                new Character(66, "Toon Link", @"..\\characterIcons\\toonlink.png"),
                new Character(67, "Villager", @"..\\characterIcons\\villager.png"),
                new Character(68, "Wario", @"..\\characterIcons\\wario.png"),
                new Character(69, "Wii Fit Trainer", @"..\\characterIcons\\wiifittrainer.png"),
                new Character(70, "Wolf", @"..\\characterIcons\\wolf.png"),
                new Character(71, "Yoshi", @"..\\characterIcons\\yoshi.png"),
                new Character(72, "Young Link", @"..\\characterIcons\\younglink.png"),
                new Character(73, "Zelda", @"..\\characterIcons\\zelda.png"),
                new Character(74, "Zero Suit Samus", @"..\\characterIcons\\zerosuitsamus.png"),
                new Character(75, "DLC Character 1", @"..\\characterIcons\\random.png"),
                new Character(76, "DLC Character 2", @"..\\characterIcons\\random.png"),
                new Character(77, "DLC Character 3", @"..\\characterIcons\\random.png"),
                new Character(78, "DLC Character 4", @"..\\characterIcons\\random.png"),
                new Character(79, "DLC Character 5", @"..\\characterIcons\\random.png"),
            };
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
