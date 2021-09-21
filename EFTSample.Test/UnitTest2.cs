using Microsoft.VisualStudio.TestTools.UnitTesting;
using static EFTSample.Program;

namespace EFTSample.Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TransferMoney_WithEmptySenderIBANThenTransferFailedTest()
        {
            var transferResponse = new TransferResponse
            {
                IsSuccess = false,
                Message = "Sender Account IBAN must be null or empty."
            };

            var transfer = new Transfer();

            var transferRequest = new TransferRequest
            {
                Amount = 1400,
                SenderIBAN = string.Empty,
                ReceiverIBAN = "TR13216498468499980"
            };

            var actual = transfer.MoneyTransfer(transferRequest);

            Assert.AreEqual(transferResponse.IsSuccess, actual.IsSuccess);
            Assert.AreEqual(transferResponse.Message, actual.Message);
        }
    }
}