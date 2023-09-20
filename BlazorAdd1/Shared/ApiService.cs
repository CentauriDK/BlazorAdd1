namespace BlazorAdd1.Shared;
using System.Net.Http;
using System.Threading.Tasks;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> ValidateNameAsync(string name)
    {
        try
        {
            // Replace "api/validation/name" with the actual API endpoint for name validation
            var response = await _httpClient.GetAsync($"api/validation/name?name={name}");

            if (response.IsSuccessStatusCode)
            {
                return "Name is valid.";
            }
            else
            {
              
                return "Name must be at least 3 characters long."; // You can customize this message based on the API response.
            }
        }
        catch (Exception ex)
        {
            return $"Error: {ex.Message}";
        }
    }

    public async Task<string> ValidatePhoneNumberAsync(string phoneNumber)
    {
        try
        {
            // Replace "api/validation/phone" with the actual API endpoint for phone number validation
            var response = await _httpClient.GetAsync($"api/validation/phone?phoneNumber={phoneNumber}");

            if (response.IsSuccessStatusCode)
            {
                return "Phone number is valid.";
            }
            else
            {
                return "Phone number is invalid. Please enter a 8-digit numeric phone number."; // You can customize this message based on the API response.
            }
        }
        catch (Exception ex)
        {
            return $"Error: {ex.Message}";
        }
    }
}

