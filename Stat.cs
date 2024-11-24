namespace CreatureRoller
{
    public struct Stat
    {
        private static Random random = new Random();
        public readonly int NumDice { get; } // Nombre de dés
        public readonly int DiceType { get; } // Type de dé (ex. 4 pour d4, 6 pour d6)
        public readonly int Modifier { get; } // Modificateur

        /// <summary>
        /// Constructeur qui prend les valeurs sous forme de chaînes
        /// </summary>
        /// <param name="numDice">le nombre de dés à lancer</param>
        /// <param name="diceType">la valeur d'un dé (ex "d4", "d6")</param>
        /// <param name="modifier">le modificateur du dé (peut être négatif)</param>
        public Stat(string numDice, string diceType, string modifier)
        {
            // Conversion des strings en int
            NumDice = int.TryParse(numDice, out int n) ? n : 0;
            DiceType = int.TryParse(diceType.TrimStart('d', 'D'), out int d) ? d : 0;
            Modifier = int.TryParse(modifier, out int m) ? m : 0;
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
            return total;
        }

        // Méthode pour afficher la stat
        public override string ToString()
        {
            return $"{NumDice}d{DiceType} + {Modifier}";
        }
    }
}
