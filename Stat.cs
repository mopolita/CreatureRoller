namespace CreatureRoller
{
    public class Stat
    {
        private static Random random = new Random();
        public int NumDice { get; set; } // Nombre de dés
        public int DiceType { get; set; } // Type de dé (ex. 4 pour d4, 6 pour d6)
        public int Modifier { get; set; } // Modificateur

        /// <summary>
        /// Constructeur qui prend les valeurs sous forme de chaînes
        /// </summary>
        /// <param name="numDice">le nombre de dés à lancer</param>
        /// <param name="diceType">la valeur d'un dé (ex "d4", "d6")</param>
        /// <param name="modifier">le modificateur du dé (peut être négatif)</param>
        public Stat(int numDice, int diceType, int modifier)
        {
            NumDice = numDice;
            DiceType = diceType;
            Modifier = modifier;
        }

        public Stat()
        {
            NumDice = 1;
            DiceType = 4;
            Modifier = 1;
        }

        /// <summary>
        /// Calcule le résultat d'un lancer de dé sous la forme NumDice * dDiceType + Modifier (ex 3d6+5)
        /// </summary>
        /// <returns>le résultat calculé</returns>
        public int Roll()
        {
            int total = Modifier;
            for (int i = 0; i < NumDice; i++)
            {
                total += random.Next(1, DiceType + 1);
            }
            return total * 5;
        }

        // Méthode pour afficher la stat
        public override string ToString()
        {
            return $"{NumDice}d{DiceType} + {Modifier}";
        }
    }
}
