namespace Builder_Pattern
{
    // SECOND OPTION
    class GamePlayerBuilder2
    {
        private Player Player { get; set; }

        public GamePlayerBuilder2()
        {
            Player =  new Player();         
        }

        public void EquipRightHand(Weapon weapon)
        {
            Player.RightHand = weapon;
        }

        public void EquipLeftHand(Weapon weapon)
        {
            Player.LeftHand = weapon;
        }

        public void EquipHead(Armor armor)
        {
            Player.Head = armor;
        }

        public void EquipChest(Armor armor)
        {
            Player.Chest = armor;
        }

        public void EquipLegs(Armor armor)
        {
            Player.Legs = armor;
        }

        public Player Build()
        {
            return Player;
        }
    }


    // THIRD OPTION  FLUENT BUILDER
    class GamePlayerBuilder3
    {
        private Player Player { get; set; }

        public GamePlayerBuilder3(string name)
        {
            Player = new Player();
            Player.Name = name;
        }

        public GamePlayerBuilder3 EquipRightHand(Weapon weapon)
        {
            Player.RightHand = weapon;
            return this;
        }

        public GamePlayerBuilder3 EquipLeftHand(Weapon weapon)
        {
            Player.LeftHand = weapon;
            return this;
        }

        public GamePlayerBuilder3 EquipHead(Armor armor)
        {
            Player.Head = armor;
            return this;
        }

        public GamePlayerBuilder3 EquipChest(Armor armor)
        {
            Player.Chest = armor;
            return this;
        }

        public GamePlayerBuilder3 EquipLegs(Armor armor)
        {
            Player.Legs = armor;
            return this;
        }

        public Player Build()
        {
            return Player;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //// THE BEST CODE  THIRD OPTION
            
            Player player = new GamePlayerBuilder3("Farid")
                .EquipRightHand(new Sword())  // return this
                .EquipLegs(new LeatherArmor())// return this
                .EquipHead(new ClothArmor())  // return this
                .Build();                     // return player;


            player.Info();




            //--------------------------------------------------------------------------------------------------



            //// BEST CODE  SECOND OPTION

            //   GamePlayerBuilder2 builder = new GamePlayerBuilder2();
            //  builder.EquipRightHand(new Sword());
            //  builder.EquipLegs(new LeatherArmor());   
            //  builder.EquipHead(new ClothArmor());
            //
            //  var player = builder.Build();
            //  player.Name = "Farid";
            //  player.Info();


            //--------------------------------------------------------------------------------------------------


            //// GOOD CODE  FIRST OPTION

            //  WarriorBuilder warriorBuilder = new WarriorBuilder();
            //  ArcherBuilder archerBuilder = new ArcherBuilder();
            //  BerserkerBuilder berserkerBuilder = new BerserkerBuilder();
            //  HomelessBuilder homelessBuilder = new HomelessBuilder();
            //
            //  CharacterCreator characterCreator = new CharacterCreator();
            //
            //  Player player1 = characterCreator.Create(warriorBuilder);
            //  player1.Name = "Warrior";
            //  player1.Info();
            //
            //  Player player2 = characterCreator.Create(archerBuilder);
            //  player2.Name = "Archer";
            //  player2.Info();
            //
            //  Player player3 = characterCreator.Create(berserkerBuilder);
            //  player3.Name = "Berserker";
            //  player3.Info();
            //
            //  Player player4 = characterCreator.Create(homelessBuilder);
            //  player4.Name = "Homeless";
            //  player4.Info();



            //--------------------------------------------------------------------------------------------------



            //// BAD CODE
            //var player = new Player("Farid", new Sword(), null, null, new PlateArmor(), new LeatherArmor());
            //player.Info();
        }
    }

    

}
