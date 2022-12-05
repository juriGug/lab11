namespace Properties
{
    using System;

    /// <summary>
    /// The class models a card.
    /// </summary>
    public class Card
    {
        public string Seed{get;}
        public string Name{get;}
        public int Ordinal{get;}

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param _name="_name">the _name of the card.</param>
        /// <param _name="_seed">the _seed of the card.</param>
        /// <param _name="_ordinal">the _ordinal number of the card.</param>
        public Card(string _name, string _seed, int _ordinal)
        {
            this.Name = _name;
            this.Ordinal = _ordinal;
            this.Seed = _seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param _name="tuple">the informations about the card as a tuple.</param>
        internal Card(Tuple<string, string, int> tuple) : this(tuple.Item1, tuple.Item2, tuple.Item3)
        {
        }

        /// <inheritdoc cref="object.ToString"/>
        public override string ToString()
        {
            // TODO understand string interpolation
            return $"{this.GetType().Name}(Name={this.Name}, Seed={this.Seed}, Ordinal={this.Ordinal})";
        }

        // TODO generate Equals(object obj)
        public override bool Equals(object obj)
        {
            Card c = obj as Card;
            return (string.Equals(Seed, c.Seed) && string.Equals(Name, c.Name) && Ordinal == c.Ordinal);
        }
        // TODO generate GetHashCode()
        public override int GetHashCode() {
            return  HashCode.Combine(Name, Seed, Ordinal);
        }    
    }
}
