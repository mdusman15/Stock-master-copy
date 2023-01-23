using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using Stock.Models;

namespace Stock.Controllers
{
    public class StockController : Controller
    {
        public async Task<IActionResult> Index(string symbol)
        {
            if (string.IsNullOrEmpty(symbol))
            {
                return View();
            }
            using (var client = new HttpClient())
            {
                var apiKey = "HPN07DX7MCQ8NXNV";
                var url = $"https://www.alphavantage.co/query?function=TIME_SERIES_MONTHLY_ADJUSTED&symbol={symbol}&interval=5min&apikey={apiKey}";

                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var stockModel = JsonConvert.DeserializeObject<StockModel>(json);
                    return View(stockModel);
                }
                else
                {
                    return View("Error");

                }
            }
        } }}