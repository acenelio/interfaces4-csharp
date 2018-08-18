namespace Course.Services {
    class PaypalService : IOnlinePaymentService {

        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int months) {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amount) {
            return amount * FeePercentage;
        }
    }
}
