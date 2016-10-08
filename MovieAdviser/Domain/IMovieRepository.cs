namespace MovieAdviser.Domain
{
    public interface IMovieRepository
    {
        Movie[] GetAllMovies();

        Movie GetMovie(int userId);

        void SaveMovie(Movie Movie);
    }
}
