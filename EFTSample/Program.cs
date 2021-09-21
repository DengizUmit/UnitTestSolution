using System;

namespace EFTSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Unit Test!");
        }

        public class TransferRequest
        {
            public decimal Amount { get; set; }
            public string SenderIBAN { get; set; }
            public string ReceiverIBAN { get; set; }
        }

        public class TransferResponse
        {
            public bool IsSuccess { get; set; }
            public string Message { get; set; }
        }
    }
}
