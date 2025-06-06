﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using W12D3C1.Model;

namespace W12D3C1.Services {
    public class MonkeyService {
        HttpClient httpClient;
        List<Monkey> monkeyList;

        public MonkeyService() {
            httpClient = new HttpClient();
            monkeyList = new();
        }

        public async Task<List<Monkey>> GetMonkeys() {
            if (monkeyList.Count > 0) return monkeyList;
            var url = "https://montemagno.com/monkeys.json";
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode) monkeyList = await response.Content.ReadFromJsonAsync<List<Monkey>>();

            return monkeyList;
        }
    }
}
