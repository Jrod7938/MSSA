﻿namespace FinalTest.Models {
    public class AccountsResponse {
        public bool error { get; set; }
        public string message { get; set; }
        public List<Account> accounts { get; set; }
    }
}
