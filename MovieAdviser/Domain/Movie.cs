namespace MovieAdviser
{
    public class Movie
    {
        public Movie(string name, string director, string genre)
        {
            Name = name;
            Director = director;
            Genre = genre;
        }

        public string Name { get; private set; } 

        public string Director { get; private set; }

        public string Genre { get; private set; }

        protected bool Equals(Movie other)
        {
            return string.Equals(Name, other.Name) 
                && string.Equals(Director, other.Director)
                && string.Equals(Genre, other.Genre);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Movie) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Director != null ? Director.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Genre != null ? Genre.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator ==(Movie left, Movie right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Movie left, Movie right)
        {
            return !Equals(left, right);
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Director: {1}, Genre: {2}", Name, Director, Genre);
        }
    }
}