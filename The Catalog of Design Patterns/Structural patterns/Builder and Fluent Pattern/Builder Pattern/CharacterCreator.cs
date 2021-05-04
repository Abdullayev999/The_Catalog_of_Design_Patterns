namespace Builder_Pattern
{
    // FIRST OPTION
    class CharacterCreator
    {
        public Player Create(PlayerBuilder playerBuilder)
        {
            playerBuilder.EquipRightHand();
            playerBuilder.EquipLeftHand();
            playerBuilder.EquipHead();
            playerBuilder.EquipChest();
            playerBuilder.EquipLegs();
            return playerBuilder.Build();
        }
    }
}