namespace Practice08;

public class Movie
{
    public string Title { get; }
    public string Director { get; }
    public bool IsWatched { get; private set; }
    public List<double> Ratings { get; private set; }

    public Movie(string title, string director)
    {
        ValidateString(title, nameof(title), "Title cannot be null or empty.");

        ValidateString(director, nameof(director), "Director cannot be null or empty.");

        Title = title;
        Director = director;
        IsWatched = false;
        Ratings = new List<double>();
    }

    public void Watch()
    {
        EnsureNotWatched();

        IsWatched = true;
    }

    public void Rate(double rating)
    {
        EnsureWatched();

        ValidateRating(rating);

        Ratings.Add(rating);
    }

    public double GetAverageRating()
    {
        return Ratings.Count == 0 ? 0 : Ratings.Average();
    }

    private void ValidateString(string value, string paramName, string message)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException(message, paramName);
    }

    private void ValidateRating(double rating)
    {
        if (rating < 0 || rating > 5)
            throw new ArgumentException("Rating must be between 0 and 5.", nameof(rating));
    }

    private void EnsureWatched()
    {
        if (!IsWatched)
            throw new InvalidOperationException($"{Title} must be watched before rating.");
    }

    private void EnsureNotWatched()
    {
        if (IsWatched)
            throw new InvalidOperationException($"{Title} has already been watched.");
    }

}