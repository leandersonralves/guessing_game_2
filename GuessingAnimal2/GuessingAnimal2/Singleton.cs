namespace GuessingAnimal2
{
    public static class Singleton
    {
        private static GameMechanics gameMechanics;

        public static GameMechanics GameMechanics
        {
            get {
                if (gameMechanics == null)
                    gameMechanics = new GameMechanics();
                return gameMechanics;
            }
        }
    }
}
