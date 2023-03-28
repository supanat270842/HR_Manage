using HR_Management.Models;
using Newtonsoft.Json;

namespace HR_Management.Services;

public class NetworkService
{
    public static async Task<APIPlantModel> getPlant()
    {
        using (var client = new HttpClient())
        {
            try
            {
                const string baseUrl = "https://ccpnext.com";
                string function = "/APIiOT/Get/api/GetPlant";

                client.BaseAddress = new Uri(baseUrl);
                var response = await client.GetAsync(function);
                response.EnsureSuccessStatusCode();

                var strResponse = await response.Content.ReadAsStringAsync();
                APIPlantModel result = JsonConvert.DeserializeObject<APIPlantModel>(strResponse);

                return result;
            }
            catch (HttpRequestException e)
            {
                throw new InvalidOperationException("getPlant " + e.Message);
            }
        }

        return null;
    }
    public static async Task<APIPlantModel> getPlantCPS()
    {
        using (var client = new HttpClient())
        {
            try
            {
                const string baseUrl = "https://ccpnext.com";
                string function = "/APIiOTCPS/Get/api/GetPlant";

                client.BaseAddress = new Uri(baseUrl);
                var response = await client.GetAsync(function);
                response.EnsureSuccessStatusCode();

                var strResponse = await response.Content.ReadAsStringAsync();
                APIPlantModel result = JsonConvert.DeserializeObject<APIPlantModel>(strResponse);

                return result;
            }
            catch (HttpRequestException e)
            {
                throw new InvalidOperationException("getPlantCPS " + e.Message);
            }
        }

        return null;
    }

    public static async Task<APIFacDepModel> getFac_Dep()
    {
        using (var client = new HttpClient())
        {
            try
            {
                const string baseUrl = "https://ccpnext.com";
                string function = "/APIiOT/Get/api/GetFactoryDepartments";

                client.BaseAddress = new Uri(baseUrl);
                var response = await client.GetAsync(function);
                response.EnsureSuccessStatusCode();

                var strResponse = await response.Content.ReadAsStringAsync();
                APIFacDepModel result = JsonConvert.DeserializeObject<APIFacDepModel>(strResponse);

                return result;
            }
            catch (HttpRequestException e)
            {
                throw new InvalidOperationException("getFac_Dep " + e.Message);
            }
        }

        return null;
    }
    public static async Task<APIFacDepModel> getFac_DepCPS()
    {
        using (var client = new HttpClient())
        {
            try
            {
                const string baseUrl = "https://ccpnext.com";
                string function = "/APIiOTCPS/Get/api/GetFactoryDepartments";

                client.BaseAddress = new Uri(baseUrl);
                var response = await client.GetAsync(function);
                response.EnsureSuccessStatusCode();

                var strResponse = await response.Content.ReadAsStringAsync();
                APIFacDepModel result = JsonConvert.DeserializeObject<APIFacDepModel>(strResponse);

                return result;
            }
            catch (HttpRequestException e)
            {
                throw new InvalidOperationException("getFac_DepCPS " + e.Message);
            }
        }

        return null;
    }

    public static async Task<APIListOTModel> getListOT(string factory, string department, string dateStart, string dateEnd)
    {
        using (var client = new HttpClient())
        {
            try
            {
                const string baseUrl = "https://ccpnext.com";
                string function = "/APIiOT/Get/api/GetListOT" +
                $"?Factory={factory}&Department={department}&dateStart={dateStart}&dateEnd={dateEnd}";

                client.BaseAddress = new Uri(baseUrl);
                var response = await client.GetAsync(function);
                response.EnsureSuccessStatusCode();

                var strResponse = await response.Content.ReadAsStringAsync();
                APIListOTModel result = JsonConvert.DeserializeObject<APIListOTModel>(strResponse);

                return result;
            }
            catch (HttpRequestException e)
            {
                throw new InvalidOperationException("getListOT " + e.Message);
            }
        }

        return null;
    }
    public static async Task<APIListOTModel> getListOTCPS(string factory, string department, string dateStart, string dateEnd)
    {
        using (var client = new HttpClient())
        {
            try
            {
                const string baseUrl = "https://ccpnext.com";
                string function = "/APIiOTCPS/Get/api/GetListOT" +
                $"?Factory={factory}&Department={department}&dateStart={dateStart}&dateEnd={dateEnd}";

                client.BaseAddress = new Uri(baseUrl);
                var response = await client.GetAsync(function);
                response.EnsureSuccessStatusCode();

                var strResponse = await response.Content.ReadAsStringAsync();
                APIListOTModel result = JsonConvert.DeserializeObject<APIListOTModel>(strResponse);

                return result;
            }
            catch (HttpRequestException e)
            {
                throw new InvalidOperationException("getListOTCPS " + e.Message);
            }
        }

        return null;
    }

    public static async Task<APIHistoryByDocModel> getHistory(string document)
    {
        using (var client = new HttpClient())
        {
            try
            {
                const string baseUrl = "https://ccpnext.com";
                string function = "/APIiOT/Get/api/GetHistoryByDocument" +
                $"?Document={document}";

                client.BaseAddress = new Uri(baseUrl);
                var response = await client.GetAsync(function);
                response.EnsureSuccessStatusCode();

                var strResponse = await response.Content.ReadAsStringAsync();
                APIHistoryByDocModel result = JsonConvert.DeserializeObject<APIHistoryByDocModel>(strResponse);

                return result;
            }
            catch (HttpRequestException e)
            {
                throw new InvalidOperationException("getHistory " + e.Message);
            }
        }

        return null;
    }
    public static async Task<APIHistoryByDocModel> getHistoryCPS(string document)
    {
        using (var client = new HttpClient())
        {
            try
            {
                const string baseUrl = "https://ccpnext.com";
                string function = "/APIiOTCPS/Get/api/GetHistoryByDocument" +
                $"?Document={document}";

                client.BaseAddress = new Uri(baseUrl);
                var response = await client.GetAsync(function);
                response.EnsureSuccessStatusCode();

                var strResponse = await response.Content.ReadAsStringAsync();
                APIHistoryByDocModel result = JsonConvert.DeserializeObject<APIHistoryByDocModel>(strResponse);

                return result;
            }
            catch (HttpRequestException e)
            {
                throw new InvalidOperationException("getHistoryCPS " + e.Message);
            }
        }

        return null;
    }

    public static async Task<APILeaderOTModel> getOtLeader(string employeeId, string dateStart, string dateEnd)
    {
        using (var client = new HttpClient())
        {
            try
            {
                const string baseUrl = "https://ccpnext.com";
                string function = "/APIiOT/Get/api/GetListOTByLeader" +
                $"?EmployeeId={employeeId}&dateStart={dateStart}&dateEnd={dateEnd}";

                client.BaseAddress = new Uri(baseUrl);
                var response = await client.GetAsync(function);
                response.EnsureSuccessStatusCode();

                var strResponse = await response.Content.ReadAsStringAsync();
                APILeaderOTModel result = JsonConvert.DeserializeObject<APILeaderOTModel>(strResponse);

                return result;
            }
            catch (HttpRequestException e)
            {
                throw new InvalidOperationException("getOtLeader " + e.Message);
            }
        }

        return null;
    }
    public static async Task<APILeaderOTModel> getOtLeaderCPS(string employeeId, string dateStart, string dateEnd)
    {
        using (var client = new HttpClient())
        {
            try
            {
                const string baseUrl = "https://ccpnext.com";
                string function = "/APIiOTCPS/Get/api/GetListOTByLeader" +
                $"?EmployeeId={employeeId}&dateStart={dateStart}&dateEnd={dateEnd}";

                client.BaseAddress = new Uri(baseUrl);
                var response = await client.GetAsync(function);
                response.EnsureSuccessStatusCode();

                var strResponse = await response.Content.ReadAsStringAsync();
                APILeaderOTModel result = JsonConvert.DeserializeObject<APILeaderOTModel>(strResponse);

                return result;
            }
            catch (HttpRequestException e)
            {
                throw new InvalidOperationException("getOtLeaderCPS " + e.Message);
            }
        }

        return null;
    }

    public static async Task<APIOtByDocModel> getOtByDoc(string document)
    {
        using (var client = new HttpClient())
        {
            try
            {
                const string baseUrl = "https://ccpnext.com";
                string function = "/APIiOT/Get/api/GetListOTByDocument" +
                $"?DocumentOt={document}";

                client.BaseAddress = new Uri(baseUrl);
                var response = await client.GetAsync(function);
                response.EnsureSuccessStatusCode();

                var strResponse = await response.Content.ReadAsStringAsync();
                APIOtByDocModel result = JsonConvert.DeserializeObject<APIOtByDocModel>(strResponse);

                return result;
            }
            catch (HttpRequestException e)
            {
                throw new InvalidOperationException("getOtByDoc " + e.Message);
            }
        }

        return null;
    }
    public static async Task<APIOtByDocModel> getOtByDocCPS(string document)
    {
        using (var client = new HttpClient())
        {
            try
            {
                const string baseUrl = "https://ccpnext.com";
                string function = "/APIiOTCPS/Get/api/GetListOTByDocument" +
                $"?DocumentOt={document}";

                client.BaseAddress = new Uri(baseUrl);
                var response = await client.GetAsync(function);
                response.EnsureSuccessStatusCode();

                var strResponse = await response.Content.ReadAsStringAsync();
                APIOtByDocModel result = JsonConvert.DeserializeObject<APIOtByDocModel>(strResponse);

                return result;
            }
            catch (HttpRequestException e)
            {
                throw new InvalidOperationException("getOtByDocCPS " + e.Message);
            }
        }

        return null;
    }

    public static async Task<APIImageModel> getImage(string docImage)
    {
        using (var client = new HttpClient())
        {
            try
            {
                const string baseUrl = "https://ccpnext.com";
                string function = "/APIiOT/Get/api/GetImage" +
                $"?DocNumber={docImage}";

                client.BaseAddress = new Uri(baseUrl);
                var response = await client.GetAsync(function);
                response.EnsureSuccessStatusCode();

                var strResponse = await response.Content.ReadAsStringAsync();
                APIImageModel result = JsonConvert.DeserializeObject<APIImageModel>(strResponse);

                return result;
            }
            catch (HttpRequestException e)
            {
                throw new InvalidOperationException("getImage " + e.Message);
            }
        }

        return null;
    }
    public static async Task<APIImageModel> getImageCPS(string docImage)
    {
        using (var client = new HttpClient())
        {
            try
            {
                const string baseUrl = "https://ccpnext.com";
                string function = "/APIiOTCPS/Get/api/GetImage" +
                $"?DocNumber={docImage}";

                client.BaseAddress = new Uri(baseUrl);
                var response = await client.GetAsync(function);
                response.EnsureSuccessStatusCode();

                var strResponse = await response.Content.ReadAsStringAsync();
                APIImageModel result = JsonConvert.DeserializeObject<APIImageModel>(strResponse);

                return result;
            }
            catch (HttpRequestException e)
            {
                throw new InvalidOperationException("getImageCPS " + e.Message);
            }
        }

        return null;
    }
    public static async Task<APIOTByDateModel> getListOTByDate(string dateStart, string dateEnd)
    {
        using (var client = new HttpClient())
        {
            try
            {
                const string baseUrl = "https://ccpnext.com";
                string function = "/APIiOT/Get/api/GetListOTByDate" +
                $"?dateStart={dateStart}&dateEnd={dateEnd}";

                client.BaseAddress = new Uri(baseUrl);
                var response = await client.GetAsync(function);
                response.EnsureSuccessStatusCode();

                var strResponse = await response.Content.ReadAsStringAsync();
                APIOTByDateModel result = JsonConvert.DeserializeObject<APIOTByDateModel>(strResponse);

                return result;
            }
            catch (HttpRequestException e)
            {
                throw new InvalidOperationException("getListOTByDate " + e.Message);
            }
        }

        return null;
    }
    public static async Task<APIOTByDateModel> getListOTByDateCPS(string dateStart, string dateEnd)
    {
        using (var client = new HttpClient())
        {
            try
            {
                const string baseUrl = "https://ccpnext.com";
                string function = "/APIiOTCPS/Get/api/GetListOTByDate" +
                $"?dateStart={dateStart}&dateEnd={dateEnd}";

                client.BaseAddress = new Uri(baseUrl);
                var response = await client.GetAsync(function);
                response.EnsureSuccessStatusCode();

                var strResponse = await response.Content.ReadAsStringAsync();
                APIOTByDateModel result = JsonConvert.DeserializeObject<APIOTByDateModel>(strResponse);

                return result;
            }
            catch (HttpRequestException e)
            {
                throw new InvalidOperationException("getListOTByDateCPS " + e.Message);
            }
        }

        return null;
    }

}