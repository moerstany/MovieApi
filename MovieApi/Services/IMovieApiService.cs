using MovieApi.Models;

namespace MovieApi.Services
{
	public interface IMovieApiService
	{
		string ApiKey { get; set; }
		string BaseUrl { get; set; }

		Task<MovieApiResponse> SearchByTitle(string title);
		Task<Movie> SearchById(string id);
	}
}