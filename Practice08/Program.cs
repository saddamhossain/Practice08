Console.WriteLine("=== Movie Rating System ===\n");

Movie movie = new("Inception", "Christopher Nolan");

try
{
    movie.Watch();
    movie.Rate(4.5);
    movie.Rate(5.0);
    movie.Rate(4.0);

    Console.WriteLine($"Movie: {movie.Title}");
    Console.WriteLine($"Director: {movie.Director}");
    Console.WriteLine($"Watched: {movie.IsWatched}");
    Console.WriteLine($"Average Rating: {movie.GetAverageRating():F1}");
}
catch (Exception ex)
{
    Console.WriteLine($"\nError: {ex.Message}");
}